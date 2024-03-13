using HelloWebApi.Services.Interfaces;

namespace HelloWebApi.Services;

public class GreetingService() : IGreetingService
{
    public string Hello() => "Hello World!";

    public string Hello(string name) => $"Hello, {name}!";
}