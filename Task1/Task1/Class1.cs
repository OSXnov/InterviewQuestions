using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace Task1
{
    //In order to read data from this file, we first have to create a model class that contains
    //all the attributes that we want to read from the file.

    public class MovieStar
    {
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }


        public int Age()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(DateOfBirth.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            return age;
        }
    }

}