using MembershipApplication.Interfaces;
using MvvmCross.ViewModels;
public class MainViewModel : MvxViewModel
{
    public string Message { get => MessageService.GetMessage(); }

    private bool _rememberMe;
    public bool RememberMe
    {
        get => _rememberMe;
        set => SetProperty(ref _rememberMe, value);
    }

    private bool _rememberMe2;
    public bool RememberMe2
    {
        get => _rememberMe2;
        set {
            SetProperty(ref _rememberMe2, value);
            RememberMe = value;
        } 
    }

    protected IMessageService MessageService { get; }
     
    public MainViewModel(IMessageService messageService)
    {
        MessageService = messageService;
    }
}