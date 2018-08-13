using System.Collections.Generic;

namespace IMMDB.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Shows = new List<GenreShow>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<GenreShow> Shows { get; set; }
    }
}
