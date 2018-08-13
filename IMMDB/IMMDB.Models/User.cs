﻿using System;

namespace IMMDB.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        //ToDo Make it Hash
        public string Password { get; set; }

        public string Email { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}
