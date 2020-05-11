using MvvmAndDependenyInjectionSample.Services;

namespace MvvmAndDependenyInjectionSample.ViewModels
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
