using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PhumlaKamnandi.Business
{
    public class Reserve
    {
        #region Data Members
        int BoookingId;
        int periodOfStay;
        decimal Total_Fee;
   
        Collection<Booking> bookings;
        Collection<Person> people;
        Collection<int> rooms;
        Collection<CreditCardCompany> companies;
        PersonController personController;
        BookingController bookingController;
        CreditCardCompanyController cccController;

        #endregion


        public Reserve()
        {
            rooms = new Collection<int>();
            personController = new PersonController();
            bookingController = new BookingController();
            cccController = new CreditCardCompanyController();
            people = personController.AllPeople;
            bookings = bookingController.AllBookings;
            companies = cccController.AllCompanies;
            UpdateRooms();
        }

        #region Utility Method

        public void UpdateRooms()
        {
            //for (int num = 1; num < 6; num++)
            //{
            //    rooms.Add(num);
            //}
            rooms.Add(1);
            rooms.Add(2);
            rooms.Add(3);
            rooms.Add(4);
            rooms.Add(5);
        }
        public Collection<int> makeBooking(DateTime checkIn, DateTime checkout)
       {
            Collection<int> AvailableRooms = new Collection<int>() ;
            foreach(Booking book in bookings)
            {
                if((checkIn.Day >= int.Parse(book.Checkin)) && (checkIn.Day < int.Parse(book.CheckOut)))
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

        public int AddBooking (int guestId, int roomId, String checkIn, String checkout, decimal Total_Fee)
       {
            Booking booking = new Booking(guestId, roomId, checkIn, checkout, Total_Fee);
            bookingController.DataMaintenance(booking, Data.DB.DBOperation.Add);
            bookingController.FinalizeChanges(Data.DB.DBOperation.Add);
            return booking.BookingID;
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
            Debug.WriteLine("Inside AddGuest");
            personController.DataMaintenance(person, Data.DB.DBOperation.Add);
            personController.FinalizeChanges(person, Data.DB.DBOperation.Add);
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

        public Collection<CreditCardCompany> AllCreditCardCompanies()
        {
            return companies;
        }
        #endregion

    }
}
