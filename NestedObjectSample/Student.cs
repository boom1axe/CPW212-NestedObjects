using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectSample
{
    class Student
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }

        /// <summary>
        /// The Students Home Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
