//using DeliveryProject.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.IdentityModel.Tokens;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;

//namespace DeliveryProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AuthController : ControllerBase
//    {
//        private readonly IConfiguration _configuration;

//        public AuthController(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }

//        [HttpPost]
//        public IActionResult Login([FromBody] LoginModel loginModel)
//        {

//            var deliver = _deliverService.ge
//            new Claim(ClaimTypes.Name, "yael"),
//            new Claim(ClaimTypes.Role, "student")


//                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWT:Key")));
//                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
//                var tokeOptions = new JwtSecurityToken(
//                    issuer: _configuration.GetValue<string>("JWT:Issuer"),
//                    audience: _configuration.GetValue<string>("JWT:Audience"),
//                    claims: claims,
//                    expires: DateTime.Now.AddMinutes(6),
//                    signingCredentials: signinCredentials
//                );
//                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
//                return Ok(new { Token = tokenString });
//        }
//            return Unauthorized();

//     };
//}
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Delivery.Core.Models;
using Delivery.Core.Services;

namespace DeliveryProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IDeliverService _deliverService;
        private readonly IRecipientService _recipientService;
        private readonly IConfiguration _configuration;

        public AuthController(IDeliverService deliverService, IRecipientService recipientService, IConfiguration configuration)
        {
            _deliverService = deliverService;
            _recipientService = recipientService;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            // 1️⃣ חיפוש משתמש בטבלת המשלוחנים
            var deliver = (await _deliverService.GetDeliversAsync())
                          .FirstOrDefault(d => d.Email == loginModel.Email);

            if (deliver != null)
            {
                // כאן אפשר להוסיף בדיקת סיסמה אם יש
                var token = CreateToken(deliver.Email, "Deliver");
                return Ok(new { Token = token });
            }

            // 2️⃣ חיפוש משתמש בטבלת הנמענים
            var recipient = (await _recipientService.GetRecipientsAsync())
                            .FirstOrDefault(r => r.Email == loginModel.Email);

            if (recipient != null)
            {
                // כאן גם אפשר להוסיף בדיקת סיסמה אם יש
                var token = CreateToken(recipient.Email, "Recipient");
                return Ok(new { Token = token });
            }

            // 3️⃣ אם לא נמצא משתמש
            return Unauthorized("Email or password is incorrect.");
        }

        private string CreateToken(string email, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

    // DTO קטן בשביל קבלת נתוני הלוגין
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; } // אם אין סיסמה, אפשר להשאיר אבל צריך להתאים בדיקה
    }
}
