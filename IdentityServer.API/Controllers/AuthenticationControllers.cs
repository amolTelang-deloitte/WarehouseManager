﻿
using IdentityServer.Applcation.Interfaces;
using IdentityServer.Contracts.Authentication;

using Microsoft.AspNetCore.Mvc;
using AuthenticationResponse = IdentityServer.Applcation.Response.AuthenticationResponse;

namespace IdentityServer.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);

            var response = new AuthenticationResponse(
                authResult.Id, authResult.FirstName, authResult.LastName, authResult.Email, authResult.Token);
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(request.Email, request.Password);
            var response = new AuthenticationResponse(
               authResult.Id, authResult.FirstName, authResult.LastName, authResult.Email, authResult.Token);

            return Ok(response);
        }
    }
}
