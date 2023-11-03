using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task13.Exceptions;
using Task13.Model;

namespace Task13
{
    internal class Controller
    {
        public void AddUser()
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            if (name.Length < 2 || name.Length > 30 || string.IsNullOrWhiteSpace(name)) throw new InvalidNameException(ExceptionMessages.InvalidNameMessages);

            Console.Write("Enter Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 0) throw new InvalidAgeException(ExceptionMessages.InvalidAgeMessages);

            Console.Write("Enter PhoneNumber +994 Seklinde Yaz: ");
            string phoneNumber = Console.ReadLine();
            if (!PhoneNumberController(phoneNumber)) throw new InvalidPhoneFormat(ExceptionMessages.InvalidPhoneMessages);

            Console.Write("Enter PassWord : ");
            string passWord = Console.ReadLine();

            #region Yol 1
            //if (passWord.Length < 8 || !PassWordUpperController(passWord) || !PassWordNumberController(passWord)) throw new PasswordException(ExceptionMessages.PasswordMessages);
            #endregion
            
            if (!PassWordController(passWord)) throw new PasswordException(ExceptionMessages.PasswordMessages);

            User user = new User(name, age, phoneNumber, passWord);
            
        }

        bool PhoneNumberController(string phoneNumber)
        {
            //string pattern = @"^\(\+994\)\s[0-9]{2}\s[0-9]{3}\s[0-9]{2}\s[0-9]{2}$";
            string pattern = @"^(\+994|0)(50|51|55|70|77)(\d{7})$";

            return Regex.IsMatch(phoneNumber, pattern); ;
        }

        #region passWord yol 1
        //bool PassWordUpperController(string password)
        //{
        //    //Password (daxilinde min 1 uppercase,1 reqem, uzunluq 8den kicik olmamalidir)
        //    bool controller = false;
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if (password[i] == char.ToUpper(password[i]))
        //            return true;
        //    }
        //    return false;
        //}

        //bool PassWordNumberController(string password)
        //{
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if (char.IsNumber(password[i]))
        //            return true;
        //    }
        //    return false;
        //}
        #endregion

        bool PassWordController(string passWord)
        {
            return Regex.IsMatch(passWord, @"^(?=.*[A-Z])(?=.*\d).{8,}$");
        }
    }
}
