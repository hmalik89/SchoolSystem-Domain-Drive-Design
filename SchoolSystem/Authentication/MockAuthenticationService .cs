using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SchoolSystem.WebApi.Authentication
{
    public class MockAuthenticationService : IMockAuthenticationService
    {
        private readonly Dictionary<string, string> userCredentials = new Dictionary<string, string>
    {
        { "user1", "password1" },
        { "user2", "password2" },

    };

        public bool AuthenticateUser(string username, string password)
        {
            if (userCredentials.TryGetValue(username, out var expectedPassword))
            {
                return password == expectedPassword;
            }

            return false;
        }

        public string GenerateToken(string username)
        {
            // In a real-world scenario, you might use a JWT library to generate a secure token.
            // Here, we use a simple string concatenation for demonstration purposes.
            //return $"MockToken_{username}_{DateTime.UtcNow.Ticks}";

            var secretKey = new SymmetricSecurityKey
                   (Encoding.UTF8.GetBytes("*G-JaNdRgUkXp2s5v8y/B?E(H+MbPeSh"));
            var signinCredentials = new SigningCredentials
            (secretKey, SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: "ABCXYZ",
                audience: "http://localhost:5025",
                claims: new List<Claim>(),
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: signinCredentials
            );
            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }
    }
}
