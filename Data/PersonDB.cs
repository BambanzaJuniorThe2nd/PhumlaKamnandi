using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
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

        #region Utility Methods
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

        private int FindRow(Person aPerson, string table)
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
                    if ((aPerson.role == Role.RoleType.Guest && aPerson.GuestID == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["GuestID"])) ||
                        (aPerson.role == Role.RoleType.Clerk && aPerson.ClerkID == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["ClerkID"])))
                    {
                        returnValue = rowIndex;
                    }
                }

                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Person aPerson, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
            switch (aPerson.role.getRoleValue)
            {
                case Role.RoleType.Guest:
                    dataTable = table1;
                    break;
                case Role.RoleType.Clerk:
                    dataTable = table2;
                    break;
            }

            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aPerson, DBOperation.Add);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aPerson, dataTable)];
                    FillRow(aRow, aPerson, DBOperation.Edit);
                    break;
                case DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aPerson, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Person aPerson)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PersonalID", SqlDbType.NVarChar, 50, "PersonalID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NChar, 10, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            switch (aPerson.role.getRoleValue)
            {
                case Role.RoleType.Clerk:
                    param = new SqlParameter("@Username", SqlDbType.NVarChar, 20, "Username");
                    daMain.InsertCommand.Parameters.Add(param);

                    param = new SqlParameter("@Password", SqlDbType.NChar, 60, "Password");
                    daMain.InsertCommand.Parameters.Add(param);
                    break;
            }
        }

        private void Build_UPDATE_Parameters(Person aPerson)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PersonalID", SqlDbType.NVarChar, 50, "PersonalID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NChar, 10, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            switch (aPerson.role.getRoleValue)
            {
                case Role.RoleType.Guest:
                    param = new SqlParameter("@Original_GuestID", SqlDbType.NVarChar, 15, "GuestID");
                    param.SourceVersion = DataRowVersion.Original;
                    daMain.UpdateCommand.Parameters.Add(param);
                    break;
                case Role.RoleType.Clerk:
                    param = new SqlParameter("@Username", SqlDbType.NVarChar, 20, "Username");
                    param.SourceVersion = DataRowVersion.Current;
                    daMain.UpdateCommand.Parameters.Add(param);

                    param = new SqlParameter("@Password", SqlDbType.NChar, 60, "Password");
                    param.SourceVersion = DataRowVersion.Current;
                    daMain.UpdateCommand.Parameters.Add(param);

                    param = new SqlParameter("@Original_ClerkID", SqlDbType.NVarChar, 15, "ClerkID");
                    param.SourceVersion = DataRowVersion.Original;
                    daMain.UpdateCommand.Parameters.Add(param);

                    break;
            }
        }


        private void Create_INSERT_Command(Person aPerson)
        {
            switch (aPerson.role.getRoleValue)
            {
                case Role.RoleType.Guest:
                    daMain.InsertCommand = new SqlCommand("INSERT into Guest (Name, PersonalID, Phone, Email) VALUES (@Name, @PersonalID, @Phone, @Email)", cnMain);
                    break;
                case Role.RoleType.Clerk:
                    daMain.InsertCommand = new SqlCommand("INSERT into Clerk (Name, Username, Password, PersonalID, Phone, Email) VALUES (@Name, @Username, @Password, @PersonalID, @Phone, @Email)", cnMain);
                    break;
            }

            Build_INSERT_Parameters(aPerson);
        }

        private void Create_UPDATE_Command(Person aPerson)
        {
            switch (aPerson.role.getRoleValue)
            {
                case Role.RoleType.Guest:
                    daMain.UpdateCommand = new SqlCommand("UPDATE Guest SET Name=@Name, PersonalID=@PersonalID, Phone=@Phone, Email=@Email WHERE GuestID=@Original_GuestID", cnMain);
                    break;
                case Role.RoleType.Clerk:
                    daMain.UpdateCommand = new SqlCommand("UPDATE Clerk SET Name=@Name, Username=@Username, Password=@Password, PersonalID=@PersonalID, Phone=@Phone, Email=@Email WHERE ClerkID=@Original_ClerkID", cnMain);
                    break;
            }

            Build_UPDATE_Parameters(aPerson);
        }

        private void Create_DELETE_Command(Person aPerson)
        {
            switch(aPerson.role.getRoleValue)
            {
                case Role.RoleType.Guest:
                    daMain.DeleteCommand = new SqlCommand("DELETE FROM Guest WHERE GuestID=@GuestID", cnMain);
                    break;
                case Role.RoleType.Clerk:
                    daMain.DeleteCommand = new SqlCommand("DELETE FROM Clerk WHERE ClerkID=@ClerkID", cnMain);
                    break;
            }

            Build_DELETE_Parameters(aPerson);
        }

        private void Build_DELETE_Parameters(Person aPerson)
        {
            SqlParameter param = default(SqlParameter);

            switch(aPerson.getRoleValue)
            {
                case Role.RoleType.Guest:
                    param = new SqlParameter("@GuestID", SqlDbType.Int);
                    param.SourceColumn = "ClerkID";
                    param.SourceVersion = DataRowVersion.Current;
                    break;
                case Role.RoleType.Clerk:
                    param = new SqlParameter("@ClerkID", SqlDbType.Int);
                    param.SourceColumn = "ClerkID";
                    param.SourceVersion = DataRowVersion.Current;
                    break;
            }

            daMain.DeleteCommand.Parameters.Add(param);
        }

        public bool UpdateDataSource(Person aPerson, DB.DBOperation operation)
        {
            String sqlLocal = "";
            String table = "";

            switch (operation)
            {
                case DBOperation.Add:
                    Create_INSERT_Command(aPerson);
                    break;
                case DBOperation.Edit:
                    Create_UPDATE_Command(aPerson);
                    break;
                case DBOperation.Delete:
                    Create_DELETE_Command(aPerson);
                    break;
            }

            switch (aPerson.role.getRoleValue)
            {
                case Role.RoleType.Guest:
                    sqlLocal = sqlLocal1;
                    table = table1;
                    break;
                case Role.RoleType.Clerk:
                    sqlLocal = sqlLocal2;
                    table = table2;
                    break;
            }

            return UpdateDataSource(sqlLocal, table);
        }
        #endregion
    }
}