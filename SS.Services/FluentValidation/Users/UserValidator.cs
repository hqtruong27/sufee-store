using FluentValidation;
using SS.Services.ViewModels.User;

namespace SS.Services.FluentValidation.Users
{
    public class LoginValidator : AbstractValidator<LoginViewModel>
    {
        public LoginValidator()
        {
            //.Matches(@"^[a-zA-Z0-9_.-]*$").WithMessage("User name contains no special characters")
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is required");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters")
                .MaximumLength(18).WithMessage("Password maximum of 18 characters");
        }
    }
    public class RegisterValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Full name is required");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$")
                .WithMessage("Email is not the correct format");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters")
                .MaximumLength(18).WithMessage("Password maximum of 18 characters");

            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password)
                .WithMessage("password incorrect");
        }
    }
}
