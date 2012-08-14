using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RegGen
{
    /*
     * AddToRegistry
     *  type: Class
     *  Add the files to the registry
     */
    class AddToRegistry
    {
        public void addFilesToRegistry()
        {
            String [] listOfRegistryFiles; /* list of all the files in the directory */
            TextWriter regFile; // File to write to

            regFile = new StreamWriter("C:\\Users\\Tbell\\Desktop\\add_registries.bat");

            listOfRegistryFiles = Directory.GetFiles(@"C:\Users\Tbell\Desktop", "*.reg");

            regFile.WriteLine("@ECHO OFF");
            regFile.WriteLine();

                /* for each file found, add it to the registry */
            foreach (String file in listOfRegistryFiles)
            {
                String addDSNToRegistry;    /* command to add the file to the registry */

                addDSNToRegistry = "REGEDIT /S " + file;

                regFile.WriteLine(addDSNToRegistry);

            } /* end of foreach loop */

            regFile.WriteLine("PAUSE");
            regFile.WriteLine("DEL C:\\Users\\Tbell\\Desktop\\*.reg" );
            regFile.WriteLine("DEL C:\\Users\\Tbell\\Desktop\\add_registries.bat");
            regFile.Close();

        } /* end of method addFilesToRegisrty */
    } /* end of class AddToRegistry */
} /* end of namespace RegGen */
