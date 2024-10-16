var builder = WebApplication.CreateBuilder(args);

// Build the application
var app = builder.Build();

// Simple API returning "Hello World!"
app.MapGet("/helloworld", () => "Hello World! \n My Name Is Mohammed Iliyas");

// Log message when the application starts
Console.WriteLine("HelloWorld API is running. Visit /helloworld to see the message.");

// This API endpoint responds with a greeting message
// It's designed to demonstrate a minimal API setup in .NET

app.Run();
