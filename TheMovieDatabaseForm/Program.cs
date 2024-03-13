using System;
using TheMovieDatabaseForm.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TMDbFormApp;

namespace TheMovieDatabaseForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}