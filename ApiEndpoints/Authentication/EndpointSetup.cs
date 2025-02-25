namespace NookpostBackend.ApiEndpoints.Authentication;

/// <summary>
/// Sets up the Authentication Endpoints
/// </summary>
public static class EndpointSetup
{
    /// <summary>
    /// Initialize the Authentication Endpoints on the WebApp object.
    /// <param name="parentGroup">The parent group which contains the endpoints.</param>
    /// </summary>
    public static void Setup(RouteGroupBuilder parentGroup)
    {
        parentGroup.MapPost("/authentication/login", Login.PostLogin).WithTags("Authentication").WithOpenApi();
        parentGroup.MapPut("/authentication/changePassword", ChangePassword.HandleRequest).WithTags("Authentication").WithOpenApi().RequireAuthorization("user");
    }
}
