//James Fleming
//CS-021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_Skills_Demo_5
{
    class Person
    {
        //Global Variables
        private string Name;
        private int Age;

        //Constructor
        public Person()
        {
            this.Name = "Participant";
            this.Age = 18;
        }

        //Getters and Setters
        public string getName()
        {
            return this.Name;
        }

        public int getAge()
        {
            return this.Age;
        }

        public void setName(string nameIn)
        {
            this.Name = nameIn;
        }

        public void setAge (int ageIn)
        {
            this.Age = ageIn;
        }
    }
}
