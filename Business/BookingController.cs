﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PhumlaKamnandi.Business
{
    class BookingController
    {
        #region Data Members

        BookingDB bookingDB;
        Collection<Booking> bookings;

        #endregion

        #region Properties

        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public PersonController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            bookingDB = new BookingDB();
            bookings = bookingBD.AllPeople;
        }

        #endregion

        #region Database Communication

        public void DataMaintenance(Booking aBook, DB.DBOperation operation)
        {
            int index = 0;
            BookingDB.DataSetChange(aBook, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    bookings.Add(aBook);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(aBook);
                    bookings[index] = aBook;
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(aBook);
                    bookings.RemoveAt(index);
                    break;

            }
        }

        public bool FinalizeChanges(Booking aBook)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return BookingDB.UpdateDataSource(aBook);
        }
        #endregion

        #region Searching through a collection

        public Collection<Booking> FindByRole(Collection<Booking> Bookings, Role.RoleType roleVal)
        {
            Collection<Booking> matches = new Collection<Booking>();
            foreach (Booking book in bookings)
            {
                if (book.role.getRoleValue == roleVal)
                {
                    matches.Add(book);
                }
            }
            return matches;
        }

        public Person Find(string ID)
        {
            int index = 0;
            bool found = (bookings[index].ID == ID);
            int count = bookings.Count;
            while (!(found) && (index < bookings.Count - 1))
            {
                index = index + 1;
                found = (bookings[index].ID == ID);
            }
            return bookings[index];
        }

        public int FindIndex(Booking abook)
        {
            int counter = 0;
            bool found = false;
            found = (abook.ID == bookings[counter].ID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < bookings.Count - 1)
            {
                counter += 1;
                found = (abook.ID == abook[counter].ID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }

        }

        #endregion
    }
}