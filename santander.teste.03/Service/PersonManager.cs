using santander.teste._03.Model;
using System;
using System.Collections.Generic;

namespace santander.teste._03.Service
{
    public class PersonManager
    {
        public List<Person> DB { get; set; }

        public PersonManager()
        {
            DB = new List<Person>();
        }

        public void AddPerson(string name, string birthDate)
        {
            try
            {
                Person p = new Person()
                {
                    Name = name,
                    BirthDate = parseBirthDate(birthDate)
                };

                DB.Add(p);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private DateTime parseBirthDate(string birthDate)
        {
            DateTime dDate;

            if (DateTime.TryParse(birthDate, out dDate))
            {
                String.Format("{0:d/MM/yyyy}", dDate);
            }
            else
            {
                throw new Exception("Invalid date!");
            }

            return dDate;
        }


        public void DeletePerson(int id)
        {
            try
            {
                DB.RemoveAt(id);
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error deleting the item: " + ex.Message);

            }
        }

    }
}
