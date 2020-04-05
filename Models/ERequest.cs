using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task5_sol.Models
{
    public class ERequest
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Studies { get; set; }

        public bool NullEmptyCheck()
        {
            if (string.IsNullOrEmpty(IndexNumber) || string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Studies))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool WhiteSpaceCheck()
        {
            if (string.IsNullOrWhiteSpace(IndexNumber) || string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Studies))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}