using System;

namespace santander.teste._03.Model
{
    public class Person
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public int? Age {
            get
            {
                var age = DateTime.Now.Year - BirthDate.Year;
                return age;
            }
        }

    }
}
