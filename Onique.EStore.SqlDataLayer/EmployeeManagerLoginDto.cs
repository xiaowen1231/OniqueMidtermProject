﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer
{
    public class EmployeeManagerLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
    }
}
