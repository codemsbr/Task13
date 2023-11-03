using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task13.Model
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string PassWord { get; set; }

        public User(string name, int age, string phoneNumber, string passWord)
        {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            PassWord = passWord;
        }

        public User()
        {
            
        }
    }
}
