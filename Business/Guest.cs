using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhumlaKamnandi.Business
{
    public class Guest : Role
    {
        #region data members
        String address;
        String creditCardNu;
        int cccId;
        int expirationMonth;
        int expirationYear;
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

        public String CreditCardNu
        {
            set { creditCardNu = value; }
            get { return creditCardNu; }
        }

        public int CCCID
        {
            set { cccId = value; }
            get { return cccId; }
        }

        public int ExpirationMonth
        {
            set { expirationMonth = value; }
            get { return expirationMonth; }
        }

        public int ExpirationYear
        {
            set { expirationYear = value; }
            get { return expirationYear; }
        }
        #endregion

    }
}
