using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Data
{
    class CreditCardDB: DB
    {
        #region  Data members        
        private string table = "Credit_Card";
        private string sqlLocal = "SELECT * FROM Credit_Card";
        private Collection<CreditCard> cards;
        #endregion

        #region Property Method: Collection
        public Collection<CreditCard> AllCards
        {
            get
            {
                return cards;
            }
        }
        #endregion

        #region Constructor
        public CreditCardDB() : base()
        {
            cards = new Collection<CreditCard>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            CreditCard aCard;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Booking object
                    aCard = new CreditCard();
                    //Obtain each employee attribute from the specific field in the row in the table
                    aCard.CreditCardNum = Convert.ToString(myRow["CC_Number"]).TrimEnd();
                    aCard.CCCId = Convert.ToInt32(myRow["CCC_ID"]);
                    aCard.ExperationM = Convert.ToInt32(myRow["Expiration_Month"]);
                    aCard.ExperationY = Convert.ToInt32(myRow["Expiration_Year"]);
                    cards.Add(aCard);
                }
            }
        }

        private void FillRow(DataRow aRow, CreditCard aBooking, DB.DBOperation operation)
        {
            aRow["Room_Number"] = aBooking.RoomId;
            aRow["Room_Number"] = aBooking.RoomId;
            aRow["Check_In"] = aBooking.Checkin;
            aRow["Check_Out"] = aBooking.CheckOut;
            aRow["Total_Fee"] = aBooking.TOTALFee;
        }

        private int FindRow(Booking aBooking, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (aBooking.BookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
    }
}
