using System.Collections.Generic;

namespace IMMDB.Models
{
    public class Show
    {
        public Show()
        {
            this.Directors = new List<DirectorShow>();
            this.Genres = new List<GenreShow>();
            this.Popularity = 0;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public int Popularity { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<DirectorShow> Directors { get; set; }

        public ICollection<GenreShow> Genres { get; set; }
    }
}