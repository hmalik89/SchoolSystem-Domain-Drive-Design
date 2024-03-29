﻿using SchoolSystem.WebApi.Authentication;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

namespace SchoolSystem.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IMockAuthenticationService _authenticationService;

        public UserController(IMockAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User request)
        {
            if (_authenticationService.AuthenticateUser(request.Username, request.Password))
            {
                var token = _authenticationService.GenerateToken(request.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized(new { Message = "Invalid credentials" });
        }

    }

    


}
