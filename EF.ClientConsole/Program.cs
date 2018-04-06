using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generycznosc<int> generycznoscInt = 
            //    new Generycznosc<int>();

            

        }


    }

    class Generycznosc<Cokolwiek>
    {
        public Cokolwiek GetData(Cokolwiek i)
        {
            return i;
        }
        /*
        public int GetData(int i)
        {
            return i;
        }

        public string GetData(string i)
        {
            return i;
        }
        */
    }
}
