using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracting
{
    public static class Session
    {
        public static int AdminID { get; private set; } // Holds the Admin ID

        // Method to set AdminID after login
        public static void SetAdminID(int id)
        {
            AdminID = id;
        }

        // Method to clear AdminID (on logout or application close)
        public static void ClearSession()
        {
            AdminID = 0; // Reset the Admin ID
        }
    }
}
