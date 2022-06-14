using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace CMSWebApplication.Pages.Account
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public string Password { get; set; } = string.Empty;
        private const string _password = "n^@JBF!^Qo!t93tkgLxG%7WBc!iOSqm39!QefHbkUlJzsXmCpf9skZiaJ2fi%7wh";

        public void OnPost()
        {
            if(Password == _password)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, "zdc"));
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
            }
            else
            {
                
            }
        }
    }
}
