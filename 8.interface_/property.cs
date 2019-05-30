using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCS._8.interface_
{

    class BirthInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Mainapp
    {
        static void Main(string[] args)
        {
            BirthInfo birth = new BirthInfo();

            birth.Name = "이승호";
            birth.Birthday = new DateTime(2002, 6, 11);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
