namespace Sample.MvvmAndDependencyInjection.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from Message Service & Dependency Injection";
        }
    }
}
