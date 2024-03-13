using System.Net;
using TheMovieDatabaseForm.Models;

namespace TMDbFormApp
{
    public partial class Form1 : Form
    {
        private const string TMDbApiKey = "<APIKEY>";
        public Form1()
        {
            InitializeComponent();
        }

        private async Task MovieSearch(string title)
        {
            using var httpClient = new HttpClient();
            var url = $"https://api.themoviedb.org/3/search/movie?api_key={TMDbApiKey}&query={title}";

            try
            {
                var response = await httpClient.GetStringAsync(url);
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<TMDbSearchResult<MovieDetails>>(response);

                if (result.Results.Count > 0)
                {
                    var movie = result.Results[0];

                    string urlImage = $"https://image.tmdb.org/t/p/original{movie.poster_path}";

                    // Show information in form controls
                    lblTitle.Text = $"Title: {movie.title}";
                    lblTitleOriginal.Text = $"Original Title: {movie.original_title}";
                    lblAverageScore.Text = $"Average Score: {movie.vote_average}";
                    lblReleaseDate.Text = $"Release Date: {DateTime.ParseExact(movie.release_date, "yyyy-MM-dd", null).ToString("dd/MM/yyyy")}";
                    lblPopularity.Text = $"Popularity: {movie.popularity}";
                    textBoxSynopsis.Text = $"{movie.overview}";

                    // Download image from URL
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] data = webClient.DownloadData(urlImage);
                        using (MemoryStream ms = new MemoryStream(data))
                        {
                            // Create an image object from the downloaded byte stream
                            Image image = Image.FromStream(ms);

                            // Assign the image to the PictureBox in the form
                            pictureBox1.Image = image;
                        }
                    }

                    // Get and show similar movies
                    var similarMovies = await getSimilarMovies(movie.Id);
                    showSimilarMovies(similarMovies);
                }
                else
                {
                    MessageBox.Show("No results were found for the specified movie.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when searching for the movie: {ex.Message}");
            }
        }

        private async Task<List<MovieDetails>> getSimilarMovies(int movieId)
        {
            using var httpClient = new HttpClient();
            var url = $"https://api.themoviedb.org/3/movie/{movieId}/similar?api_key={TMDbApiKey}";
            var request = await httpClient.GetStringAsync(url);

            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<TMDbSearchResult<MovieDetails>>(request);
            return result.Results;
        }

        private void showSimilarMovies(List<MovieDetails> similarMovies)
        {
            // Clear the ListBox before adding new movies
            listBoxSimilar.Items.Clear();

            if (similarMovies != null && similarMovies.Count > 0)
            {
                foreach (var similar in similarMovies.Take(5))
                {
                    listBoxSimilar.Items.Add($"{similar.title} ({getReleaseDate(similar.release_date)})");
                }
            }
            else
            {
                listBoxSimilar.Items.Add("No similar movies found.");
            }
        }

        private int getReleaseDate(string releaseDate)
        {
            if (DateTime.TryParse(releaseDate, out var date))
            {
                return date.Year;
            }
            return 0;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string movieTitle = txtFilmTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(movieTitle))
            {
                MessageBox.Show("Please enter a valid movie name.");
                return;
            }

            await MovieSearch(movieTitle);
        }
    }
}
