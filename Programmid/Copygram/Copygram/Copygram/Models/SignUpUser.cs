using System;
using System.Collections.Generic;
using System.Text;

namespace Copygram.Models
{
    class SignUpUser
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
