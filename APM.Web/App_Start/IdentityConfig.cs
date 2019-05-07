using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using APM.Data;
using APM.Entity.Models;

namespace APM.Web.App_Start
{
    //public class UserStore : UserStore<AppUser>
    //{
    //    public UserStore(APMDBContext context)
    //        : base(context)
    //    {
    //    }
    //}
    //// Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.
    //public class UserManager : UserManager<AppUser>
    //{
    //    public UserManager(IUserStore<AppUser> store)
    //        : base(store)
    //    {
    //    }

    //    public static UserManager Create(IdentityFactoryOptions<UserManager> options, IOwinContext context)
    //    {
    //        var manager = new UserManager(new UserStore<AppUser>(context.Get<APMDBContext>()));
    //        // Configure validation logic for usernames
    //        manager.UserValidator = new UserValidator<AppUser>(manager)
    //        {
    //            AllowOnlyAlphanumericUserNames = false,
    //            RequireUniqueEmail = true
    //        };

    //        // Configure validation logic for passwords
    //        manager.PasswordValidator = new PasswordValidator
    //        {
    //            RequiredLength = 6,
    //            RequireNonLetterOrDigit = true,
    //            RequireDigit = true,
    //            RequireLowercase = true,
    //            RequireUppercase = true,
    //        };

    //        // Configure user lockout defaults
    //        manager.UserLockoutEnabledByDefault = true;
    //        manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);

    //        manager.MaxFailedAccessAttemptsBeforeLockout = 5;

    //        var dataProtectionProvider = options.DataProtectionProvider;
    //        if (dataProtectionProvider != null)
    //        {
    //            manager.UserTokenProvider =
    //                new DataProtectorTokenProvider<AppUser>(dataProtectionProvider.Create("ASP.NET Identity"));
    //        }
    //        return manager;
    //    }
    //}

    //// Configure the application sign-in manager which is used in this application.
    //public class ApplicationSignInManager : SignInManager<AppUser, string>
    //{
    //    public ApplicationSignInManager(UserManager userManager, IAuthenticationManager authenticationManager)
    //        : base(userManager, authenticationManager)
    //    {
    //    }

    //    public override Task<ClaimsIdentity> CreateUserIdentityAsync(AppUser user)
    //    {
    //        return user.GenerateUserIdentityAsync((UserManager)UserManager,DefaultAuthenticationTypes.ApplicationCookie);
    //    }

    //    public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
    //    {
    //        return new ApplicationSignInManager(context.GetUserManager<UserManager>(), context.Authentication);
    //    }
    //}
}