using System;
using System.Collections.Generic;
using System.Text;

namespace IMMDB.Models
{
    public class DirectorShow
    {
        public int DirectorId { get; set; }

        public Director Director { get; set; }

        public int ShowId { get; set; }

        public Show Show { get; set; }
    }
}
