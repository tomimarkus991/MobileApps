﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SignIn.Data
{
    public class RegUserTable
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
