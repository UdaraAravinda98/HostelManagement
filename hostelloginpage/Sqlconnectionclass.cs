using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hostelloginpage
{
    class Sqlconnectionclass
    {

        public static string conReturn()
        {

            return (@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename =" + System.IO.Path.GetFullPath("HostelDB.mdf") + "; Integrated Security=True");
            
        }
    }
}
