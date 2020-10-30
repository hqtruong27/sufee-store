using SS.Services.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SS.Services.Interface.IUserServices
{
    public interface IUserServices
    {
        Task<string> Authencation(LoginViewModel model);
        Task<bool> Register(RegisterViewModel model);
    }
}
