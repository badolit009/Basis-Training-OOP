using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataHidingPersonApp
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public void SetFirstName( string firstName)
        {
            if (firstName.Length>=3)
            {
                this.firstName = firstName;
            }
            else
            {
                MessageBox.Show("Enter Full Data");
            }
        }

        public string SetFirstName()
        {
            return firstName;
        }

        public void SetMiddleName(string middleName)
        {
            this.middleName = middleName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }


        public string GetFullName()
        {
            return lastName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
