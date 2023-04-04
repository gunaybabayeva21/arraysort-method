using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_class
{
    internal class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Username;

        public Student(int Id, string Name, string Surname,string username)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Username=username;

        }

    }

    


}
