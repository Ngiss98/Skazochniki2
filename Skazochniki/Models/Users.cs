using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skazochniki.Models
{
    public class Users
    {
        public int UserId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string FIO { get; set; }

        public string Email { get; set; }

    }
}