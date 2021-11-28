using System;
using System.Collections.Generic;

namespace Admission
{
    public class Register
    {
        public string RegNo;
        public string FirstName;
        public string LastName;
        public string Middlename;
        public int YearOfBirth;
        public string Gender;
        public string Institution;
        public string Course;
        public int Age;
        bool IsAdmitted;

        public Register(string firstName, string lastName, string middlename, string institution, string course,
            string gender, int age, string regNo)
        {
            FirstName = firstName;
            LastName = lastName;
            Institution = institution;
            Gender = gender;
            Course = course;
            IsAdmitted = false;
            RegNo = regNo;

        }

        public void SetIsAdmitted(bool check)
        {
            IsAdmitted = check;
        }
        
        public bool GetIsAdmitted()
        {
            return IsAdmitted;
        }

       
        
    }
}
                    
                    