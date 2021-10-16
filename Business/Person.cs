using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi
{
    class Person
    {
            //Create an abstract Person base class with an ID, Name and Phone. 
            //Include a default and a parametrised constructor. 
            //Add a ToString method to this class to allow you to display the details of a person.
            //This base class will enable you to easily expand the system to include customer bookings at a later stage.   

        #region data members
        private string id,personId, name, phone, email;
        #endregion

        #region Properties
        public int ID
            {
                get { return id; }
                set { id = value; }
            }
        public string Name
            {
                get { return name; }
                set { name = value; }
            }
        public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        public string PersonalId
        {
            set { personId = value; }
            get { return personId; }
        }

        

        public Role role;
            #endregion

        #region Construtor
        public Person()
        {
                Id = "";
                name = "";
                Phone = "";
        }

        public Person(Role.RoleType roleValue)
        {

            switch (roleValue)
            {
                case Role.RoleType.NoRole:
                    role = new Role();
                    break;
                case Role.RoleType.Guest:
                    role = new Guest();
                    break;
                case Role.RoleType.Clerk:
                    role = new Clerk();
                    break;
            }
        }
            
                
            #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + Phone;
        }
        #endregion
    }
}


