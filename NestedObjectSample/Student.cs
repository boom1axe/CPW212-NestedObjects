using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectSample
{
    class Student
    {
        private string _fullName;
        private string _emailAddress;

        public Student(string fullName)
        {
            FullName = fullName;
        }

        /// <summary>
        /// The legal first and last
        /// ex. J Doe
        /// </summary>
        public string FullName {
            get { return _fullName; }
            set {
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("Full cannot be null or whitespace");
                }
            }
        }

        /// <summary>
        /// The students school provided email address
        /// </summary>
        public string EmailAddress
        {
            get { return _emailAddress; }
            set
            {
                if (value.EndsWith("@student.cptc.edu"))
                {
                    _emailAddress = value;
                }
            }
        }

        /// <summary>
        /// Students mailing address
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// The Students Home Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
