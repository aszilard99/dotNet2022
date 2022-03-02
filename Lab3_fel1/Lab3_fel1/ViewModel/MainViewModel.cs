using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_fel1.Model;

namespace Lab3_fel1.ViewModel
{
    class MainViewModel
    {
        public User User { get; set; }
        public MainViewModel()
        {
            User = new User() { Name = "Cortana" };
        }
        public void ChangeName(string newName)
        {
            User.Name = newName;
        }
    }
}
