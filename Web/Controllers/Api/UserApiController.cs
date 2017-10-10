using System.Collections.Generic;
using AppCore.Models;
using AppCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserApiController : Controller
    {
        private readonly IUserService _userService;

        public UserApiController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<UserDto> Get()
        {
            return _userService.GetAll();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
