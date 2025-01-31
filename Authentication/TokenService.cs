using NookpostBackend.Models;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace NookpostBackend.Authentication;

/// <summary>
/// The service provider for token generation.
/// Initialized as singleton by the application builder.
/// </summary>
public class TokenService
{
    /// <summary>
    /// The time set for access token expiry after it has been issued.
    /// </summary>
    public const int AccessTokenExpiryTimeInSeconds = 1209600;
    /// <summary>
    /// Generate a new token for a user.
    /// </summary>
    /// <param name="user">The user to generate the token for.</param>
    public string GenerateNewToken(User user)
    {
        ArgumentNullException.ThrowIfNull(user.Uuid);
        ArgumentNullException.ThrowIfNull(user);
        ArgumentNullException.ThrowIfNull(user.Username);

        JwtSecurityTokenHandler tokenHandler = new();
        byte[] jwtIssuerSigningKey = Configuration.Settings.JwtIssuerSigningKey;
        long tokenExpiryTimestamp = (long)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds + AccessTokenExpiryTimeInSeconds;
        SecurityTokenDescriptor tokenDescriptor = new()
        {
            Subject = new ClaimsIdentity(new Claim[]
                    {
                        new (ClaimTypes.Name, user.Username),
                        new (ClaimTypes.Role, "user"),
                        new (ClaimTypes.Expiration, System.Convert.ToString(tokenExpiryTimestamp, CultureInfo.InvariantCulture))
                    }),
            Expires = DateTime.UtcNow.AddSeconds(AccessTokenExpiryTimeInSeconds),
            SigningCredentials = new(
                        new SymmetricSecurityKey(jwtIssuerSigningKey),
                        SecurityAlgorithms.HmacSha256Signature
                    )
        };
        SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

        string tokenString = tokenHandler.WriteToken(token);
        return tokenString;
    }

}

