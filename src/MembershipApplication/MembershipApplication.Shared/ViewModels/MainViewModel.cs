using MembershipApplication.Interfaces;

public class MainViewModel
{
    public string Message { get => MessageService.GetMessage(); }

    protected IMessageService MessageService { get; }
     
    public MainViewModel(IMessageService messageService)
    {
        MessageService = messageService;
    }
}