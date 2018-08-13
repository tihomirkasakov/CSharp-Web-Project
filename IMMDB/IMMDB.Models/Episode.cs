using System;

namespace IMMDB.Models
{
    public class Episode
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Season { get; set; }

        public int EpisodeNumber { get; set; }

        public string Description { get; set; }

        public DateTime AirDate { get; set; }
    }
}
