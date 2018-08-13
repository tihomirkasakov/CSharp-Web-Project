using System.Collections.Generic;

namespace IMMDB.Models
{
    public class Serie : Show
    {
        public Serie()
        {
            this.Episodes = new List<Episode>();
        }

        public ICollection<Episode> Episodes { get; set; }
    }
}
