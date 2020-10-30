using System;
using System.Collections.Generic;
using System.Text;

namespace SS.Services.ViewModels.User
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
    public class RegisterViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
