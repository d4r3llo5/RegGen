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
         * Static method that starts the program 
         */
        static void Main(string[] args)
        {

                /* Set up a DSN based on user input */
            DSNGenerator newDSN;

            newDSN = new DSNGenerator();
            newDSN.createDSN();
            Console.ReadKey();  // pause
        }

        /*
         * createDSN: creates a DSN file for 
         *  the user to input into the registry
         */
        private void createDSN()
        {
            setDSNProperty("dsn name");
            setDSNProperty("dsn description");
            setDSNProperty("server location");
            setDSNProperty("database");
            setDSNProperty("32bit");
            setDSNProperty("login");

            printDSNInfo();
        } /* end of method createDSN */

        /*
         * setDSNProperty: sets the DSN properties, based on the input String
         *  (Program based), the property being modified will change,
         *      without the need for sanity checking
         *      String
         *          property
         */
        private void setDSNProperty(String property)
        {
            String dsnProperty; /* the string the DSN will be set to */
            Boolean isCorrect;  /* Makes sure the user is happy with their choice (default false) */

            isCorrect = false;

                /* loop until  the user is satisfied with their choice */
            while (!isCorrect)
            {
                Console.Write("Enter a " + property + " for your new DSN: ");
                dsnProperty = Console.ReadLine(); /* set the user input to the DSN name */
                isCorrect = typedCorrect(dsnProperty);  // check to see if the user was satisfied with their input

                if (isCorrect) setDSNValue(property, dsnProperty); // if the dsn name is correct save it to the struct

            } /* end of while loop */

        } /* end of method setDSNProperty */


            /* HELPER METHODS */
        /*
         * typedCorrect: check to see if the typed String
         *  is what the user wanted. Returns true/false depending
         *      String
         *      strCheck: the string to check for verification
         *      return: True, user typed in correctly, false try again
         */
        private Boolean typedCorrect(String strCheck)
        {
            char correct;   /* Char to test their input */
            String input;   /* Used for sanitation on input */

            Console.Write("Is this input: " + strCheck + ", correct (y/n)?: ");
            input = Console.ReadLine();    // Read the input

            if (input.Length > 0) correct = (input.ToArray())[0];   // if the input isn't nothing then set it for testing
            else correct = 'a'; // else ask again

            if (correct == 'y' || correct == 'Y') return true;  // If the user is happy with the name, return and save it
            else if (correct == 'n' || correct == 'N') return false;    // If the user isn't happy with the name, ask for another input
            else return typedCorrect(strCheck); // Ask again if the user is happy with the input
        } /* end of method typedCorrect */

        /*
         * setDSNValue: Sets the DSN value based on which input it is
         *      String, String
         *          property: the property that you're changing
         *          strValue: the value that you're setting it to
         */
        private void setDSNValue(String property, String strValue)
        {
                /* Determines which property to set the value to */
            switch (property)
            {
                case "dsn name": structDSN.dsnName = strValue; break;
                case "dsn description": structDSN.dsnDesc = strValue; break;
                case "server location": structDSN.dsnConnection = strValue; break;
                case "database": structDSN.dsnDatabase = strValue; break;
                case "32 bit": setBitType(property); break;
                case "login": structDSN.dsnLogin = strValue; break;
            } /* end of case */
        } /* end of method setDSNValue */

        /*
         * setBitType: sets the DSN type to either 32 bit (true), or 64 bit (false)
         *      String
         *          property: the determining String for which bit to set
         */
        private void setBitType(String property)
        {
            if (property == "32bit") structDSN.whichBit = true;
            else structDSN.whichBit = false; 
        } /* end of method setBitType */

            /* Debugging methods */

        /*
         * printDSNInfo: prints the completed DSN info 
         */
        private void printDSNInfo()
        {
            Console.WriteLine(structDSN.dsnName);
            Console.WriteLine(structDSN.dsnDesc);
            Console.WriteLine(structDSN.dsnConnection);
            Console.WriteLine(structDSN.dsnDatabase);
            Console.WriteLine(structDSN.dsnLogin);
            
            if(structDSN.whichBit) Console.WriteLine("32 Bit machine");
            else Console.WriteLine("64 Bit machine");
        } /* end of method printDSNInfo */

    } /* end of class DSNGenerator */
} /* end if Namespace RegGen */
