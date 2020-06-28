using AidImpactTraining.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AidImpactTraining.Controllers
{
    public class AccountController : Controller
    {
        // Add the authenticate manager for the user
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Render the Login View
        /// </summary>
        /// <returns>the view</returns>
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        /// <summary>
        /// Take the user connexion informations and redirect him
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(
                    login.EmailAddress, login.Password,
                    login.RememberMe, false
                );

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Erreur de connexion");
                return View();
            }

            // If the user is null
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }

            return Redirect(returnUrl);
        }

        /// <summary>
        /// Simply logout the user 
        /// </summary>
        /// <param name="returnUrl">where the user is redirected</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();

            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }

            // Follow the same redirection as the login method
            return Redirect(returnUrl);
        }

            public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        /// <summary>
        /// Take the user connexion informations and redirect him
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registration)
        {
            if (!ModelState.IsValid)
                return View(registration);

            var newUser = new IdentityUser
            {
                Email = registration.EmailAddress,
                UserName = registration.EmailAddress,
            };

            // Here we finish the user registration

            // Create method of the user
            var result = await _userManager.CreateAsync(newUser, registration.Password);

            // Displays an error if it don't succeed
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors.Select(x => x.Description))
                {
                    ModelState.AddModelError("", error);
                }

                return View();
            } 

            return RedirectToAction("Login");
        }
    }
}
