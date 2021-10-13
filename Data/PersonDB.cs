using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Data
{
    class PersonDB: DB
    {
        private string table1 = "Guest";
        private string table2 = "Clerk";
        private string sqlLocal1 = "SELECT * FROM Guest";
        private string sqlLocal2 = "SELECT * FROM Clerk";
        private Collection<Person> guestsAndClerks;

        #region Property Method: Collection
        public Collection<Person> AllGuestsAndClerks
        {
            get
            {
                return guestsAndClerks;
            }
        }
        #endregion

        #region Constructor
        public PersonDB() : base()
        {
            guestsAndClerks = new Collection<Person>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);
        }
        #endregion

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Person aPerson;
            Guest aGuest;
            Clerk aClerk;
            Role.RoleType roleValue = Role.RoleType.NoRole;

            switch (table)
            {
                case "Guest":
                    roleValue = Role.RoleType.Guest;
                    break;
                case "Clerk":
                    roleValue = Role.RoleType.Clerk;
                    break;
            }

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Person object
                    aPerson = new Person(roleValue);
                    aPerson.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    aPerson.PersonID = Convert.ToString(myRow["PersonalID"]).TrimEnd();
                    aPerson.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    aPerson.Email = Convert.ToString(myRow["Email"]).TrimEnd();

                    switch (table)
                    {
                        case "Guest":
                            aGuest = (Guest)aPerson.role;
                            aGuest.GuestID = Convert.ToInt32(myRow["GuestID"]);
                            break;
                        case "Clerk":
                            aClerk = (Clerk)aPerson.role;
                            aClerk.Username = Convert.ToString(myRow["Username"]).TrimEnd();
                            break;
                    }

                    guestsAndClerks.Add(aPerson);
                }
            }
        }

        private void FillRow(DataRow aRow, Person aPerson, DB.DBOperation operation)
        {
            Guest aGuest;
            Clerk aClerk;

            aRow["Name"] = aPerson.Name;
            aRow["PersonalID"] = aPerson.PersonalID;
            aRow["Phone"] = aPerson.Phone;
            aRow["Email"] = aPerson.Email;
            //*** For each role add the specific data variables
            switch (aPerson.role.getRoleValue)
            {
                case Role.RoleType.Clerk:
                    aClerk = (Clerk)aPerson.role;
                    aRow["Username"] = aClerk.Username;
                    aRow["Password"] = aClerk.Password;
                    break;
            }
        }


    }
}
