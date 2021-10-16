using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PhumlaKamnandi.Business
{
    class Reserve
    {
        #region Data Members
        int BoookingId;
        int periodOfStay;
        decimal Total_Fee;
        static Collection<Room> bookedRooms;
        static Collection<Booking> bookings;
        private Collection<Person> people;
        PersonController person = new PersonController();
        #endregion


        public Reserve()
        {
            people = person.AllPeople;
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


           
        #endregion

    }
}
