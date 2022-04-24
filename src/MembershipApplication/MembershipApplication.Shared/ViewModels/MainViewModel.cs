using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MembershipApplication.ViewModels
{
    public class MainViewModel : ObservableRecipient
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }
    }
}