﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegGen
{
    struct DSNObject
    {
        private String dsnName; /* The name of the DSN */
        private String dsnDatabase; /* The database for the DSN */
        private String dsnConnection;   /* The connection string of the DSN */
        private String dsnDesc; /* The description for the DSN */
        private Boolean whichBit;   /* The determines whether the DSN is 64 bit or 32 bit (default 32) */
        private String dsnLogin;    /* The login name used by the DSN */                         
    } /* end of struct DSNObject */

} /* end of the RegGen namespace */
