using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MembershipApplication.ViewModels
{
    public class MainViewModel : ObservableRecipient
    {
        private bool _isChildApplication = true;
        public bool IsChildApplication
        {
            get => _isChildApplication;
            set
            {
                SetProperty(ref _isChildApplication, value);
                if (value || IsAdultApplication == IsChildApplication)
                IsAdultApplication = !value;
            }
        }

        private bool _isAdultApplication;
        public bool IsAdultApplication
        {
            get => _isAdultApplication;
            set
            {
                SetProperty(ref _isAdultApplication, value);
                if (value || IsAdultApplication == IsChildApplication)
                IsChildApplication = !value;
            }
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

        private bool _isBk1Checked;
        public bool IsBk1Checked
        {
            get => _isBk1Checked;
            set => SetProperty(ref _isBk1Checked, value);
        }

        private bool _isBk2Checked;
        public bool IsBk2Checked
        {
            get => _isBk2Checked;
            set => SetProperty(ref _isBk2Checked, value);
        }

        private bool _isBk3Checked;
        public bool IsBk3Checked
        {
            get => _isBk3Checked;
            set => SetProperty(ref _isBk3Checked, value);
        }

        private bool _isBk4Checked;
        public bool IsBk4Checked
        {
            get => _isBk4Checked;
            set => SetProperty(ref _isBk4Checked, value);
        }

        private bool _secondFamilyMembership;
        public bool SecondFamilyMembership
        {
            get => _secondFamilyMembership;
            set
            {
                SetProperty(ref _secondFamilyMembership, value);
                if (value)
                ThirdFamilyMembership = !value;
            }
        }

        private bool _thirdFamilyMembership;
        public bool ThirdFamilyMembership
        {
            get => _thirdFamilyMembership;
            set
            {
                SetProperty(ref _thirdFamilyMembership, value);
                if (value)
                SecondFamilyMembership = !value;
            }
        }
    }
}