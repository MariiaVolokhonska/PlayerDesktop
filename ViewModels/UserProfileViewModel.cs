﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDesktop.ViewModels
{
    class UserProfileViewModel
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password{ get; set; }
        public string Email{ get; set; }
        public string PhoneNumber{ get; set; }
    }
}
