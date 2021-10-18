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
   
        static Collection<Booking> bookings;
        private Collection<Person> people;
        private Collection<int> rooms;
        PersonController controller = new PersonController();
        BookingController Bcontroller = new BookingController();

        #endregion


        public Reserve()
        {
            rooms = new Collection<int>();
            people = controller.AllPeople;
            bookings = Bcontroller.AllBookings;
            UpdateRooms();
            
        }

        #region Utility Method

        public void UpdateRooms()
        {
            for (int num = 1; num < 6; num++)
            {
                rooms.Add(num);
            }
        }
        public Collection<int> makeBooking(String checkIn, String checkout)
       {
            Collection<int> AvailableRooms = new Collection<int>() ;
            foreach(Booking book in bookings)
            {
                if((int.Parse(checkIn) >= int.Parse(book.Checkin)) && (int.Parse(checkIn) < int.Parse(book.CheckOut)))
                {
                    rooms.Remove(book.RoomId);
                }
            }
            
            foreach(int i in rooms)
            {
                AvailableRooms.Add(i);
            }
            UpdateRooms();
            return AvailableRooms;
       }

        public void AddBooking(int bookingId, int guestId, int roomId, String checkIn, String checkout, decimal Total_Fee)
       {
            Booking booking = new Booking( bookingId,guestId, roomId, checkIn, checkout, Total_Fee);
            Bcontroller.DataMaintenance(booking, Data.DB.DBOperation.Add);
            Bcontroller.FinalizeChanges(Data.DB.DBOperation.Add);
       }
       
        public decimal getFee(String checkIn, String checkOut)
        {
           return RoomFee.getTotalFee(checkIn, checkOut);
        }

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
