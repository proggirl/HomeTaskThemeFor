using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskAll
{
    class Car
    {
        string name = "Range Rover";
        int carnumber = 8888;
        string carcolor = "White";
        int ride = 0;

        public Car(string carName, int cNumber, string carColor )
        {
            this.name = carName;
            this.carnumber = cNumber;
            this.carcolor = carColor;
        }

        public void Dreive()
        {
            ride++;
        }

    }
   
    


}
