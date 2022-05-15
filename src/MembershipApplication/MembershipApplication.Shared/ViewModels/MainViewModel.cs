using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

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

        private int _id = 600;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }

        private string _birthday;
        public string Birthday
        {
            get => _birthday;
            set => SetProperty(ref _birthday, value);
        }

        private string _phone;
        public string Phone
        {
            get => _phone;
            set => SetProperty(ref _phone, value);
        }

        private string _mail;
        public string Mail
        {
            get => _mail;
            set => SetProperty(ref _mail, value);
        }

        private string _firstNameChild;
        public string FirstNameChild
        {
            get => _firstNameChild;
            set => SetProperty(ref _firstNameChild, value);
        }

        private string _lastNameChild;
        public string LastNameChild
        {
            get => _lastNameChild;
            set => SetProperty(ref _lastNameChild, value);
        }

        private string _birthdayChild;
        public string BirthdayChild
        {
            get => _birthdayChild;
            set => SetProperty(ref _birthdayChild, value);
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

        private string _accountOwner;
        public string AccountOwner
        {
            get => _accountOwner;
            set => SetProperty(ref _accountOwner, value);
        }

        private string _iban;
        public string IBAN
        {
            get => _iban;
            set => SetProperty(ref _iban, value);
        }

        private string _mandateDate;
        public string MandateDate
        {
            get => _mandateDate;
            set => SetProperty(ref _mandateDate, value);
        }

        private bool _hasSignature;
        public bool HasSignature
        {
            get => _hasSignature;
            set => SetProperty(ref _hasSignature, value);
        }

        public IAsyncRelayCommand SaveCommand { get; }

        private string _saveText;
        public string SaveText
        {
            get => _saveText;
            set => SetProperty(ref _saveText, value);
        }

        private string _noteToPayee;
        public string NoteToPayee
        {
            get => _noteToPayee;
            set => SetProperty(ref _noteToPayee, value);
        }

        private Task OnSaveCommandAsync(string arg)
        {
            string result = string.Empty;
            string payeeNote = string.Empty;

            string bk = "Nulla";
            if (IsBk1Checked)
            {
                bk = "I";
            }
            if (IsBk2Checked)
            {
                bk = "II";
            }
            if (IsBk3Checked)
            {
                bk = "III";
            }
            if (IsBk4Checked)
            {
                bk = "IV";
            }

            int familyMemberCount = 1;
            if (SecondFamilyMembership)
            {
                familyMemberCount = 2;
            }
            if (ThirdFamilyMembership)
            {
                familyMemberCount = 3;
            }

            string accountFirstName = string.Empty;
            string accountLastName = string.Empty;

            if (AccountOwner.Contains(" "))
            {
                var splitAccountName = AccountOwner.Split(' ');
                accountFirstName = splitAccountName[0];
                accountLastName = splitAccountName[1];
            }

            if (IsChildApplication)
            {
                //Mitgliedsnummer	Nachname	Vorname	Geburtsdatum	Alter	BK		Familienmitglied	Faktor	Eintritt	Austritt	Faktor	Mandats- Datum	Mandats- Referenz	Nachname	Vorname	BLZ	Kontonummer	 Einzug 	Für	IBAN	Erstlastschrift  In (€)	Telefon	Email 1                               
                result = $"{Id}\t{LastNameChild}\t{FirstNameChild}\t{BirthdayChild}\t\t{bk}\t\t{familyMemberCount}\t\t{MandateDate}\t\t{1}\t\t{MandateDate}\t{Id}\t{accountFirstName}\t{accountLastName}\t\t{IBAN}\t\t{Phone}\t{Mail}";
                payeeNote = $"Halbjahresbeitrag BK{bk}, {FirstNameChild} {LastNameChild}";
                if (SecondFamilyMembership)
                {
                    payeeNote += ", halber Beitrag";
                }
                if (ThirdFamilyMembership)
                {
                    payeeNote = "KEIN EINZUG DA DRITTES FAMILIENMITGLIED";
                }
            }
            else
            {
                result = $"{Id}\t{LastName}\t{FirstName}\t{Birthday}\t\t{bk}\t\t{familyMemberCount}\t\t{MandateDate}\t\t{1}\t\t{MandateDate}\t{Id}\t{accountFirstName}\t{accountLastName}\t\t{IBAN}\t\t{Phone}\t{Mail}";
                payeeNote = $"Halbjahresbeitrag BK{bk}, {FirstName} {LastName}";
                if (SecondFamilyMembership)
                {
                    payeeNote += ", halber Beitrag";
                }
                if (ThirdFamilyMembership)
                {
                    payeeNote = "KEIN EINZUG DA DRITTES FAMILIENMITGLIED";
                }
            }

            SaveText = result;

            return Task.FromResult(result);
        }

        public MainViewModel()
        {
            SaveCommand = new AsyncRelayCommand<string>(OnSaveCommandAsync);
        }
    }
}
