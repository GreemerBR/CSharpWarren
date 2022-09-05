using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebApi.Model;

namespace WebApi.Utils
{
    public class JwtTokenUser
    {
        private readonly IConfiguration configuration;

        public JwtTokenUser(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string CreateToken(User user)
        {
            // Claims
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName)
            };

            // Key
            string appKey = configuration.GetSection("AppSettings:TokenKey").Value;
            // (necessário instalar dependência)
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(appKey));

            // Expiração
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            // Credenciais 
            var expires = DateTime.Now.AddDays(1);

            // Geração do Token (necessário instalar dependência)
            var token = new JwtSecurityToken(
                claims: claims,
                expires: expires,
                signingCredentials: credential
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            
            return jwt;
        }
    }
}
