using System.Collections.Generic;

namespace IMMDB.Models
{
    public class Role
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
