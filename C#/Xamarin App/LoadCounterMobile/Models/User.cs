using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool IsLC { get; set; }

        public bool IsPm { get; set; }

        public bool IsAdmin { get; set; }

        public string Role { get; set; }
    }
}
