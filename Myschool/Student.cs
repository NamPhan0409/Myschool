using System;
using System.Collections.Generic;
using System.Text;

namespace Myschool
{
    class Student
    {
        protected string _id;
        protected string _fullname;
        public string ID { get { return _id ; } set { ID = value  ; } }
        public string FullName { get {return _fullname ; } set { FullName=value ; } }

        public Student(string ID, String FullName)
        {
            _id = ID;
            _fullname = FullName;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            return result;
        }
    }
}
