namespace HelloWebApi.Services.Interfaces;

public interface IGreetingService
{
    public string Hello();
    public string Hello(string name);
}
