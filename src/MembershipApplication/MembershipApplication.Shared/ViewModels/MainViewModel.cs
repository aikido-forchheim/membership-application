using System;
using System.Threading.Tasks;
using MembershipApplication.Interfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

public class MainViewModel : ObservableRecipient
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

    // Toolkit.Mvvm
    public IAsyncRelayCommand FirstCommand { get; }
    

    private Task OnCommandAsync(string arg)
    {
        RememberMe = true;
        return Task.FromResult(RememberMe);
    }

    public MainViewModel(IMessageService messageService)
    {
        MessageService = messageService;

        FirstCommand = new AsyncRelayCommand<string>(OnCommandAsync);
    }
}