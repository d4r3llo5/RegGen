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
            setDSNName();   
        } /* end of method createDSN */

        /*
         * setDSNName: sets the DSN name
         */
        private void setDSNName()
        {
            String dsnName; /* the string the DSN will be set to */
            Boolean isCorrect;  /* Makes sure the user is happy with their choice (default false) */

            isCorrect = false;

                /* loop until  the user is satisfied with their choice */
            while (!isCorrect)
            {
                Console.Write("Enter a name for your DSN: ");
                dsnName = Console.ReadLine(); /* set the user input to the DSN name */
                isCorrect = typedCorrect(dsnName);  // check to see if the user was satisfied with their input

                if (isCorrect) structDSN.dsnName = dsnName; // if the dsn name is correct save it to the struct

            } /* end of while loop */

        } /* end of method setDSNName */

        /*
         * setDSNPath: sets the DSN path to the server
         */
        private void setDSNPath()
        {
            String dsnName; /* the string the DSN path will be set to */
            Boolean isCorrect;  /* Makes sure the user is happy with their choice (default false) */

            isCorrect = false;

            /* loop until  the user is satisfied with their choice */
            while (!isCorrect)
            {
                Console.Write("Enter a name for your DSN path: ");
                dsnName = Console.ReadLine(); /* set the user input to the DSN name */
                isCorrect = typedCorrect(dsnName);  // check to see if the user was satisfied with their input

                if (isCorrect) structDSN.dsnConnection = dsnName; // if the dsn name is correct save it to the struct
            } /* end of while loop */
        } /* end of method setDSNPath */

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

    } /* end of class DSNGenerator */
} /* end if Namespace RegGen */
