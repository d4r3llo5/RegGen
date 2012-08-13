using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegGen
{
    struct DSNObject
    {
        public String dsnName; /* The name of the DSN */
        public String dsnDatabase; /* The database for the DSN */
        public String dsnConnection;   /* The connection string of the DSN */
        public String dsnDesc; /* The description for the DSN */
        public Boolean whichBit;   /* The determines whether the DSN is 64 bit or 32 bit (default 32) */
        public String dsnLogin;    /* The login name used by the DSN */                         
    } /* end of struct DSNObject */

} /* end of the RegGen namespace */
