using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MovieApplication.MovieDB.Forms
{
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(MovieRow), CheckNames = true)]
    public class MovieForm
    {
        public string Title { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string Description { get; set; }

        [TextAreaEditor(Rows = 8)]
        public string Storyline { get; set; }
        public int Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
    }
}