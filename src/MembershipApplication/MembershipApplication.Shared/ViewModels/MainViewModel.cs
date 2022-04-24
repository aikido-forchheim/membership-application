using MembershipApplication.Interfaces;
using MvvmCross.ViewModels;
public class MainViewModel : MvxViewModel
{
    public string Message { get => MessageService.GetMessage(); }

    protected IMessageService MessageService { get; }
     
    public MainViewModel(IMessageService messageService)
    {
        MessageService = messageService;
    }
}