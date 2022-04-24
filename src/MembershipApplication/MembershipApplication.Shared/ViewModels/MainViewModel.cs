using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MembershipApplication.ViewModels
{
    public class MainViewModel : ObservableRecipient
    {
        private bool _isChildApplication;
        public bool IsChildApplication
        {
            get => _isChildApplication;
            set
            {
                SetProperty(ref _isChildApplication, value);
                IsAdultApplication = !value;
            }
        }

        private bool _isAdultApplication = true;
        public bool IsAdultApplication
        {
            get => _isAdultApplication;
            set => SetProperty(ref _isAdultApplication, value);
        }

        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _birthday;

        public string Birthday
        {
            get => _birthday;
            set => SetProperty(ref _birthday, value);
        }
    }
}