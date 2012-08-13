using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegGen
{


    /*
     * DSN Generator
     *  type: Class
     *      Creates a DSN reg file for the user
     */
    class DSNGenerator
    {
            /* Class definitions */
        DSNObject structDSN;    /* the DSN struct */
        /*
         * Constructor:
         */
        public DSNGenerator() 
        {
            structDSN = new DSNObject();
        } /* end of Constructor */

        /*
         * createDSN: creates a DSN file for 
         *  the user to input into the registry
         */
        private void createDSN;

        /*
         * setDSNName: sets the DSN name
         */
        private void setDSNName;

        static void Main(string[] args)
        {

                /* Set up a DSN based on user input */
            DSNGenerator newDSN;

            newDSN = new DSNGenerator();
            newDSN.createDSN();

            Console.ReadLine();
        }

        private void createDSN()
        {
            String dsnName;

            Console.WriteLine("Enter a name");
            dsnName = Console.ReadLine();
        } /* end of method createDSN */

        private void setDSNName()
        {

        } /* end of method setDSNName */

    } /* end of class DSNGenerator */
} /* end if Namespace RegGen */
