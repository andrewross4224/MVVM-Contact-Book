using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_Contact_Book.Models;

namespace MVVM_Contact_Book.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();        
        }
    }
}
