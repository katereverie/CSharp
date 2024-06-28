using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingProperties
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                if (value > DateTime.Today)
                {
                    _birthdate = DateTime.Today;
                }
                else
                {
                    _birthdate = value;
                }
            }
        }

        public string NameLastFirst
        {
            get { return $"{LastName}, {FirstName}"; }
        }

        public int AgeYears
        {
            get
            {
                int age = DateTime.Today.Year - Birthdate.Year;

                // account for whether the birthdate happened this year yet
                if (Birthdate.AddYears(age) > DateTime.Today)
                {
                    age--;
                }

                return age;
            }
        }
    }
}
