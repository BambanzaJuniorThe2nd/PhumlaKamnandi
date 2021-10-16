using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PhumlaKamnandi.Business
{
    public class Reserve
    {
        #region Data Members
        int BoookingId;
        int periodOfStay;
        decimal Total_Fee;
        static Collection<Room> bookedRooms;
        static Collection<Booking> bookings;
        private Collection<Person> people;
        PersonController controller = new PersonController();
        #endregion


        public Reserve()
        {
            people = controller.AllPeople;
        }

        #region Utility Method

       /* public int makeBooking(Guest guest, DateTime checkIn, DateTime checkout)
        {

        }*/

       public Person FindGuest(string id)
        {
            Person guest=null;//=new Person();
            foreach (Person person in people)
            {
                if (person.role.getRoleValue == Role.RoleType.Guest)
                {
                    if (person.ID.Equals(id))
                    {
                        guest = person;
                    }
                }
            }

            return guest;
        }


      public void AddGuest(Person person)
        {   
            controller.DataMaintenance(person, Data.DB.DBOperation.Add);
            controller.FinalizeChanges(person, Data.DB.DBOperation.Add);

        }


    public String GetId(Person person)
    {
        String id = "";
        foreach(Person person1 in people)
            {
                if (person.PersonalId.Equals(person1.PersonalId))
                {
                    id = id + person1.ID;
                }
            }

                return id;
    }

           
        #endregion

    }
}
