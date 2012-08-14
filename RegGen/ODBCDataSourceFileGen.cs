using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RegGen
{
    /*
     * ODBCDataSourceFile
     *  type: Class
     *      Creates a Data Source DSN reg file for the user
     */
    class ODBCDataSourceFile
    {
        DSNObject structDSN;    /* the object that holds the data to print */

        /*
         * Constructor: Initialize class variables, 
         *  this must pull from an already created DSNObject
         *      DSNObject
         *          newDSN: the DSN to output to a file.
         */
        public ODBCDataSourceFile(DSNObject newDSN)
        {
            structDSN = newDSN;
        } /* end of constructor */

        /*
         * writeDSNFile: write the DSN values to the .reg file
         */
        public void writeDSNFile()
        {
            TextWriter regFile; // File to write to

            regFile = new StreamWriter("C:\\Users\\Tbell\\Desktop\\datasource_" + structDSN.dsnName + ".reg");

            writeHeader(regFile);
            writeBody(regFile);

            regFile.Close();
        } /* end of method writeDSNFile */

        /*
         * writeHeader: writes the header of the Reg file
         *      TextWriter
         *          regFile: the file to write to
         */
        private void writeHeader(TextWriter regFile)
        {
            regFile.WriteLine("Windows Registry Editor Version 5.00");
            regFile.WriteLine("");

            if (structDSN.whichBit) regFile.WriteLine("[HKEY_LOCAL_MACHINE\\SOFTWARE\\ODBC\\ODBC.INI\\ODBC Data Sources]");
            else regFile.WriteLine("[HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\ODBC\\ODBC.INI\\ODBC Data Sources]");

        } /* end of method writeHeader */

        /*
         * writeBody: writes the body of the .reg file
         *      TextWriter
         *          regFile: the file to write to
         */
        private void writeBody(TextWriter regFile)
        {
            regFile.WriteLine("\"" + structDSN.dsnName + "\"=\"SQL Server\""); 
        } /* end of method writeBody */

    } /* end of class ODBCFileGen */
} /* end of namespace RegGen */
