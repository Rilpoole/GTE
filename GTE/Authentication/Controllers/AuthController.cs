using Authentication.Data;
using Authentication.Models;
using Authentication.Services;
using Fido2NetLib;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    [ApiController]
    [Route("/auth")]
    public class AuthController : Controller
    {
        public UserStore UserStore { get; set; }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View("RegistrationView"); // Renders the registration page (if using HTML views)
        }
        /*
        [HttpPost("register/options")]
        public IActionResult RegisterOptions([FromBody] RegistrationModel model)
        {
            var user = UserStore.GetUserByUsername(model.Username);
            if (user != null)
            {
                return BadRequest("Username already taken.");
            }

            // Generate WebAuthn registration options (challenge)
            var options = _fido2Service.StartRegistration(model.Username);

            // Save the challenge and user data temporarily (session, database, etc.)
            HttpContext.Session.SetString("fido2.challenge", options.Challenge);
            HttpContext.Session.SetString("fido2.username", model.Username);

            return Ok(options); // Send options (challenge, etc.) to the frontend
        }

        [HttpPost("register/complete")]
        public async Task<IActionResult> CompleteRegistration([FromBody] AuthenticatorAttestationRawResponse attestationResponse)
        {
            // Retrieve the challenge and username from session
            var storedChallenge = HttpContext.Session.GetString("fido2.challenge");
            var username = HttpContext.Session.GetString("fido2.username");

            if (storedChallenge == null || username == null)
            {
                return BadRequest("Challenge expired or missing.");
            }

            // Validate the attestation response (check signature, etc.)
            var result = await _fido2Service.CompleteRegistrationAsync(attestationResponse, storedChallenge, username);

            if (result.IsSuccess)
            {
                return Ok("Registration successful");
            }

            return Unauthorized("Invalid registration response.");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login"); // Renders the login page (if using HTML views)
        }

        [HttpPost("login/options")]
        public IActionResult LoginOptions([FromBody] LoginModel model)
        {
            var user = _userStore.GetUserByUsername(model.Username);
            if (user == null)
            {
                return BadRequest("User not found.");
            }

            // Generate WebAuthn authentication options (assertion challenge)
            var options = _fido2Service.StartAuthentication(user);

            // Save the challenge in the session temporarily
            HttpContext.Session.SetString("fido2.challenge", options.Challenge);

            return Ok(options); // Send challenge options to the frontend
        }

        [HttpPost("login/complete")]
        public async Task<IActionResult> CompleteLogin([FromBody] AuthenticatorAssertionRawResponse assertionResponse)
        {
            // Retrieve the challenge from session
            var storedChallenge = HttpContext.Session.GetString("fido2.challenge");

            if (storedChallenge == null)
            {
                return BadRequest("Challenge expired or missing.");
            }

            var user = _userStore.GetUserByCredentialId(assertionResponse.Id);
            if (user == null)
            {
                return BadRequest("User not found.");
            }

            // Verify the assertion (signature, challenge, etc.)
            var result = await _fido2Service.VerifyAssertionAsync(assertionResponse, user, storedChallenge);

            if (result)
            {
                // Successfully authenticated
                return Ok("Login successful");
            }

            return Unauthorized("Invalid assertion.");
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Clear the session or authentication token
            HttpContext.Session.Clear();

            return Ok("Logged out successfully");
        }*/
    }
}