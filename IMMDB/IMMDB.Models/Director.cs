using System.Collections.Generic;

namespace IMMDB.Models
{
    public class Director
    {
        public Director()
        {
            this.Shows = new List<DirectorShow>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<DirectorShow> Shows { get; set; }
    }
}
