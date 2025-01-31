namespace NookpostBackend.ApiEndpoints.Authentication;

public static class EndpointSetup
{
    public static void Setup(WebApplication app)
    {
        app.MapPost("/authentication/login", Login.PostLogin).WithTags("Authentication");
    }
}
