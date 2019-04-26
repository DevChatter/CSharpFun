using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp8.Web.Pages
{
    public class SwitchExpressionsModel : PageModel
    {
        public void OnGet()
        {
        }

        public static Villains GetVillainByMovieOld(Movies movie)
        {
            switch (movie)
            {
                case Movies.Avengers:
                    return Villains.Loki;
                case Movies.AgeOfUltron:
                    return Villains.Ultron;
                case Movies.InfinityWar:
                    return Villains.Thanos;
                case Movies.EndGame:
                    return Villains.ProbablyThanos;
                default:
                    throw new ArgumentException("Invalid Movie Selection", nameof(movie));
            }
        }


        public static Villains GetVillainByMovie(Movies movie)
        {
            return movie switch
            {
                Movies.Avengers => Villains.Loki,
                Movies.AgeOfUltron => Villains.Ultron,
                Movies.InfinityWar => Villains.Thanos,
                Movies.EndGame => Villains.ProbablyThanos,
                _ => throw new ArgumentException("Invalid Movie Selection", nameof(movie)),
            };
        }

        public enum Movies
        {
            Avengers,
            AgeOfUltron,
            InfinityWar,
            EndGame
        }

        public enum Villains
        {
            Loki,
            Ultron,
            Thanos,
            ProbablyThanos
        }
    }
}