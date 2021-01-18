using System.Collections.ObjectModel;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    class UserViewModel
    {
        public User CurrentUser { get; set; } = new User();
        public static ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
    }
}
