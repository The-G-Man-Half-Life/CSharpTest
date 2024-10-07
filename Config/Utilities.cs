using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using CSharpTest.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.ComponentModel;

namespace CSharpTest.Config;
public class Utilities
{
    public string EncryptSHA256(string input)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for(int i=0;i<bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
    public string GenerateJWtToken(Employee employee)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier,employee.Employee_id.ToString()),
            new Claim(ClaimTypes.Email,employee.Employee_email),
        };

        var JWT_KEY = Environment.GetEnvironmentVariable("JWT_KEY");
        var JWT_ISSUER = Environment.GetEnvironmentVariable("JWT_ISSUER");
        var JWT_AUDIENCE = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
        var JWT_EXPIRES_IN = Environment.GetEnvironmentVariable("JWT_EXPIRES_IN");

        if(string.IsNullOrWhiteSpace(JWT_KEY) || string.IsNullOrWhiteSpace(JWT_ISSUER) || string.IsNullOrWhiteSpace(JWT_AUDIENCE))
        {
            throw new InvalidOperationException("Any JWT configurations are missing");
        }
        var Entry = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWT_KEY));

        var credentials = new SigningCredentials(Entry, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer: JWT_ISSUER,
            audience: JWT_AUDIENCE,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(JWT_EXPIRES_IN))
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

}