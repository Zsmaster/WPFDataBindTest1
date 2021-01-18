using MaterialDesignThemes.Wpf;
using System.ComponentModel;
using System.Windows.Media;

namespace WpfApp1.Model
{
    class User :INotifyPropertyChanged
    {
        private string _name = "";
        private string _email = "";
        private string _phone = "";
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                OnPropertyChanged("Email");
            }
        }
        public Gender Gender { get; set; } = Gender.Male;

        public PackIcon GenderIcon
        {
            get
            {
                if (this.Gender == Gender.Male)
                {
                    return new PackIcon
                    {
                        Kind = PackIconKind.GenderMale,
                        Foreground = Brushes.Blue
                    };
                }
                return new PackIcon
                {
                    Kind = PackIconKind.GenderFemale,
                    Foreground = Brushes.Pink
                };
            }
        }

        public User()
        { 
        
        }

        public User(string name, string email, string phone, Gender gender)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
