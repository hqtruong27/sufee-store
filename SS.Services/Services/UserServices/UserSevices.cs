using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SS.DataAccess.Entities;
using SS.Services.Interface.IUserServices;
using SS.Services.ViewModels.User;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SS.Services.Services.UserServices
{
    public class UserSevices : IUserServices
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _config;
        public UserSevices(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }
        public async Task<string> Authencation(LoginViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.UserName);
            if (user == null) return null;
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
            if (!result.Succeeded) return null;
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.FullName),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.Name, model.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> Register(RegisterViewModel model)
        {
            if (await _userManager.FindByEmailAsync(model.Email) != null)
            {
                return false;
            }
            var user = new AppUser()
            {
                FullName = model.FullName,
                Email = model.Email,
                UserName = model.Email,
                Birthday = model.Birthday,
                PasswordHash = model.Password
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded) return true;
            return false;
        }
    }
}
