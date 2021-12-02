using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAll
{
    public class Dog
    {
        private string name;
        private string breed;
        public static int CountGav = 0;

        public Dog()
        {
            name = "Sharik";
            breed = "Bulldog";

        }

        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public void SayGav()
        {
            CountGav++;
        }

        public string GetName()
        {
            return this.name;
        }
        public string GetBreed()
        {
            return this.breed;
        }
            
    }
}
