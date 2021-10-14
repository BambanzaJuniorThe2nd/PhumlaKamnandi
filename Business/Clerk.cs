using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    class Clerk:Role
    {
        #region Data Members

        String username, password;
        #endregion

        #region Constructor
        public Clerk() : base()
        {
            getRoleValue = RoleType.Clerk;

        }

        #endregion

        #region Property Methods

        public String Username
        {
            set { username = value; }
            get { return username; }
        }

        public String Password
        {
            set { password = value; }
            get { return password; }
        }
        #endregion
    }
}
