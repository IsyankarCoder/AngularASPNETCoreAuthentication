using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication10.ViewModel;
using WebApplication10.Data;
using Microsoft.AspNetCore.Identity;
using WebApplication10.Models;
using WebApplication10.Models.Entities;
using WebApplication10.Helpers;

namespace WebApplication10.Controllers
{

    [Route("api/account")]
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<AppUser> _userManager;


        public AccountsController(UserManager<AppUser> UserManager, ApplicationDbContext applicationDbContext)
        {
            _userManager = UserManager;
            _applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            AppUser ap = new AppUser();
            ap.Email = model.Email;
            ap.FirstName = model.FirstName;
            ap.LastName = model.LastName;
            ap.UserName = model.Email;

            var result = await _userManager.CreateAsync(ap, model.Password);

            if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

            await _applicationDbContext.JobSeekers.AddAsync(new JobSeeker { IdentityId = ap.Id, Location = model.Location });
            await _applicationDbContext.SaveChangesAsync();

            return new OkObjectResult("Account Created");

        }
    }
} 