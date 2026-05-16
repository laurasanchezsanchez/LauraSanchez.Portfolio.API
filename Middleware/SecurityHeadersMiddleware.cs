namespace LauraSanchez.Portfolio.API.Middleware
{
    /// <summary>
    /// Adds security headers to every HTTP response to protect against
    /// common web vulnerabilities like XSS, clickjacking and MIME sniffing.
    /// </summary>
    public class SecurityHeadersMiddleware
    {
        private readonly RequestDelegate _next;

        public SecurityHeadersMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Prevent browsers from MIME-sniffing the content type
            context.Response.Headers.Append("X-Content-Type-Options", "nosniff");

            // Prevent the response from being embedded in an iframe (clickjacking)
            context.Response.Headers.Append("X-Frame-Options", "DENY");

            // Block detected XSS attacks in older browsers
            context.Response.Headers.Append("X-XSS-Protection", "1; mode=block");

            // Only allow HTTPS connections for the next 6 months
            context.Response.Headers.Append("Strict-Transport-Security", "max-age=15552000; includeSubDomains");

            // Hide the server technology from response headers
            context.Response.Headers.Remove("Server");
            context.Response.Headers.Remove("X-Powered-By");

            await _next(context);
        }
    }
}