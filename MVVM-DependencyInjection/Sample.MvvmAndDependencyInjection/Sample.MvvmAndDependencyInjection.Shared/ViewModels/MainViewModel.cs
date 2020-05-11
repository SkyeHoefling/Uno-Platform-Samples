using Sample.MvvmAndDependencyInjection.Services;

namespace Sample.MvvmAndDependencyInjection.ViewModels
{
    public class MainViewModel
    {
        protected IMessageService MessageService { get; }

        public MainViewModel(IMessageService messageService)
        {
            MessageService = messageService;
        }

        public string Message { get => MessageService.GetMessage(); }
    }
}
