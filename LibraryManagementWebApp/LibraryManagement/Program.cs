var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


// Enforce HTTPS
app.UseHttpsRedirection();
// Middleware to log requests
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next();
    Console.WriteLine($"Response: {context.Response.StatusCode}");
});

// Apply Content Security Policy (CSP)
app.Use(async (context, next) =>
{
    context.Response.Headers["Content-Security-Policy"] = "default-src 'self'";
    await next();
});

// Handle errors globally
app.UseExceptionHandler("/error");

// Serve static files from wwwroot
app.UseStaticFiles();

app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
