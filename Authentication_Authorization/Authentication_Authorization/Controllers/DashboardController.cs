//using Authentication_Authorization.Data;
//using Authentication_Authorization.Models;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace Authentication_Authorization.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly UserManager<ApplicationUser> _userManager;
//        private readonly SignInManager<ApplicationUser> _signInManager;

//        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager) 
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//        }

//        public async Task<IActionResult> Register(UserDTO userData)
//        {
//            var user = new User { UserName = userData.Email, Email = userData.Email };
//            var result = await _userManager.CreateAsync(user, userData.Password);

//            if (result.Succeeded)
//            {
//                await _signInManager.SignInAsync(user, isPersistent: false);
//                return RedirectToAction("Index", "Home");
//            }

//            return RedirectToPage("/Account/Register");
//        }
//    }
//}
