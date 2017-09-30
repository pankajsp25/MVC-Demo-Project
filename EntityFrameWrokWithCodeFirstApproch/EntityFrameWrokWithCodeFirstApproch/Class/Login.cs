﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameWrokWithCodeFirstApproch
{
    public class Login
    {
        [Key]
        public string UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        public string Phone { get; set; }

        public string Address { get; set; }
    }
}