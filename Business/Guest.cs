using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhumlaKamnandi.Business
{
    class Guest : Role
    {
        #region data members

        String email;
        int creditCardNu;
     //   bool creditcardstatus = false;
        String address;
        #endregion


        #region Costructor

        public Guest() : base()
        {
            getRoleValue = RoleType.Guest;
        }
        #endregion

        #region Property Methods

        public String Address
        {
            set { address = value; }
            get { return address; }
        }

        public int CreditCardNu
        {
            set { creditCardNu = value; }
            get { return creditCardNu; }
        }
        #endregion

    }
}
