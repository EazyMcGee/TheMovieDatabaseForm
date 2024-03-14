# TheMovieDatabaseForm
The goal of this application is to create a REST service that:

- Will show information about a movie by its title
- Will show a list of similar movies

This was created consuming the [The Movie Database](https://developers.themoviedb.org/3/getting-started/introduction) (TMD) API (registration is required):

The information to be returned is the following

- Title
- Original Titles
- Average Score
- Release Date
- Popularity
- Movie Description
- List (5 max) of films with similar themes. NOTE: You will need to search that movie to get information returned

* When searching by title the TMD API may return more than one result, it will return the first of the results
