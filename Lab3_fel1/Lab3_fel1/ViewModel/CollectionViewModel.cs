using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Lab3_fel1.Model;

namespace Lab3_fel1.ViewModel
{
    public class CollectionViewModel
    {
        //public List<User> Users { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Name = "Administrator" });
            Users.Add(new User() { Name = "root" });
            Users.Add(new User() { Name = "Blackhawk" });
            Users.Add(new User() { Name = "User001" });
            Users.Add(new User() { Name = "Cortana" });
        }
    }
}
