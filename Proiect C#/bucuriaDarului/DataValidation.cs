using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bucuriaDarului
{

    internal class DataValidation
    {
        public
        int CheckName(string Name)
        {

            string NameCheck = @"^[A-Z][a-zA-Z ]*$";// Any Letters / not numbers or special characters 
            bool hasMatch = Regex.IsMatch(Name, NameCheck, RegexOptions.IgnoreCase);

            //check is empty	 
            if (Name.Length == 0)
            {
                return 0;
            }

            //check is valid
            if (!hasMatch)
            {
                return -1;
            };

            return 1;
        }
        public
        int CheckPhone(string Phone)
        {
            string PhoneCheck = @"^[+]{1}[0-9]+$"; // numbers in a phone number
            bool hasMatch = Regex.IsMatch(Phone, PhoneCheck, RegexOptions.IgnoreCase);
            
            //check is empty	 
            if (Phone.Length == 0)
            {
                return 0;
            }
            //check is valid
            if (!hasMatch)
            {
                return -1;
            };

            return 1;
        }

        public
        int CheckEmail(string Email)
        {
            string EmailCheck = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            bool hasMatch = Regex.IsMatch(Email, EmailCheck, RegexOptions.IgnoreCase);

            //check is empty	 
            if (Email.Length == 0)
            {
                return 0;
            }
            //check is valid
            if (!hasMatch)
            {
                return -1;
            };

            return 1;
        }

        int CheckUserName(string UserName)
        {
            string UserNameCheck = @"^([\w\.\-]+)$"; //anyleters,numbers and some characters
            bool hasMatch = Regex.IsMatch(UserName, UserNameCheck, RegexOptions.IgnoreCase);

            //check is empty	 
            if (UserName.Length == 0)
            {
                return 0;
            }
            //check is valid
            if (!hasMatch)
            {
                return -1;
            };

            return 1;
        }

        int CheckPassword(string Password)
        {
            string PasswordCheck = @"^(?=.{6,40}$)[0-9A-Za-z.,-_!]+$"; //any leters,numbers and some characters
            bool hasMatch = Regex.IsMatch(Password, PasswordCheck, RegexOptions.IgnoreCase);

            //check is empty	 
            if (Password.Length == 0)
            {
                return 0;
            }
            //check is valid
            if (!hasMatch)
            {
                return -1;
            };

            return 1;
        }
    }
}
