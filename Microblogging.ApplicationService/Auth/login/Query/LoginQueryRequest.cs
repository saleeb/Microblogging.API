
namespace Microblogging.ApplicationService.Auth.login.Query;

public record LoginQuery(LoginModelRequest request) : IRequest<string>;
public class LoginQueryHandler : IRequestHandler<LoginQuery, string>
{
    public const string ApiRoute = "api/V1/LoginAuth";
    private const string _secretKey = "123"; // Use a strong secret key

    public async Task<string> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        //Make database operation here to check user 

        if (request.request.LoginName == "test" && request.request.Password == "password") // Example check
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, request.request.LoginName)}),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_secretKey)),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        return string.Empty;
    }
}
