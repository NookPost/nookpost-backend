namespace NookpostBackend.ApiEndpoints.Authentication;

/// <summary>
/// Sets up the Authentication Endpoints
/// </summary>
public static class EndpointSetup
{
        /// <summary>
        /// Initialize the Authentication Endpoints on the WebApp object.
        /// <param name="app">The app to initialize the endpoint on.</param>
        /// </summary>
    public static void Setup(WebApplication app)
    {
        app.MapPost("/authentication/login", Login.PostLogin).WithTags("Authentication");
    }
}
