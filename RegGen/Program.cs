using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegGen
{
    class DSNGenerator
    {

        /*
         * Constructor:
         */
        public DSNGenerator() 
        {

        }

        /*
         * createDSN: creates a DSN file for 
         *  the user to input into the registry
         */
        private void createDSN()
        {
            Console.WriteLine("Enter a name");
            Console.ReadLine();
        } /* end of method createDSN */

        static void Main(string[] args)
        {

                /* Set up a DSN based on user input */
            DSNGenerator newDSN;

            newDSN = new DSNGenerator();
            newDSN.createDSN();

            Console.ReadLine();
        }
    }
}
