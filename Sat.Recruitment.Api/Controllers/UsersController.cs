using Microsoft.AspNetCore.Mvc;
using Sat.Recruitment.Business;
using Sat.Recruitment.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class UsersController : ControllerBase
    {
        private IUserBusiness _userBusiness;
        public UsersController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }


        [HttpPost]
        [Route("/create")]
        public async Task CreateAsync([FromBody] UserInputDTO request)
        {
            await _userBusiness.CreateAsync(request);
        }

    }
}
