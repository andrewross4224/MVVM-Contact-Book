using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Contact_Book.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUser = new ObservableCollection<User>() { new User { Name = "Andrew", Email = "andrew.ross4224@gmail.com", Phone ="7203945304" } };
        
        public static ObservableCollection<User> GetUsers() { return _DatabaseUser; }

        public static void AddUser(User user) { _DatabaseUser.Add(user); }
    }
}
