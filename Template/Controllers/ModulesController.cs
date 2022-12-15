using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Application.Interfaces;
using Template.CrossCutting.Auth.Interfaces;
using Template.CrossCutting.Auth.ViewModels;

namespace Template.Controllers
{
	[Route("api/[controller]"), ApiController]
	public class ModulesController : ControllerBase
	{
        private readonly IModuleService moduleService;
        private readonly IMenuService menuService;

        private readonly IAuthService authService;

        public ModulesController(IModuleService moduleService, IMenuService menuService, IAuthService authService)
        {
            this.moduleService = moduleService;
            this.menuService = menuService;
            this.authService = authService;
        }

        [HttpGet]
        public IActionResult GetUserLogged()
        {
            try
            {
                ContextUserViewModel _user = authService.GetLoggedUser();
                if (_user == null)
                    return Unauthorized();

                return Ok(menuService.GetMenuByProfile(int.Parse(_user.Profile)));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
