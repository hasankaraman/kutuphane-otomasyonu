using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kulturhane
{
    class OrtakNokta
    {
        static OleDbHelper dbHelper;

        internal static OleDbHelper DbHelper
        {
            get { return OrtakNokta.dbHelper; }
            set { OrtakNokta.dbHelper = value; }
        }
    }
}
