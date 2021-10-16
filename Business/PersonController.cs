﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Business
{
    class PersonController
    {

        #region Data Members

        PersonDB personDB;
        Collection<Person> people;

        #endregion

        #region Properties

        public Collection<Person> AllPeople
        {
            get
            {
                return people;
            }
        }
        #endregion

        #region Constructor
        public PersonController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            personDB = new PersonDB();
             people=personDB.AllPeople;
        }

        #endregion

        #region Database Communication

        public void DataMaintenance(Person aPerson, DB.DBOperation operation)
        {
            int index = 0;
            PersonDB.DataSetChange(aPerson, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    people.Add(aPerson);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(aPerson);
                    people[index] = aPerson;
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(aPerson);
                    people.RemoveAt(index);
                    break;

            }
        }

        public bool FinalizeChanges(Person aperson)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return personDB.UpdateDataSource(aperson);
        }
        #endregion

        #region Searching through a collection

        public Collection<Person> FindByRole(Collection<Person> people, Role.RoleType roleVal)
        {
            Collection<Person> matches = new Collection<Person>();
            foreach (Person person in people)
            {
                if (person.role.getRoleValue == roleVal)
                {
                    matches.Add(person);
                }
            }
            return matches;
        }

        public Person Find(string ID)
        {
            int index = 0;
            bool found = (people[index].ID == ID);
            int count = people.Count;
            while (!(found) && (index < people.Count - 1))
            {
                index = index + 1;
                found = (people[index].ID == ID);
            }
            return people[index];
        }

        public int FindIndex(Person aPerson)
        {
            int counter = 0;
            bool found = false;
            found = (aPerson.ID == people[counter].ID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < people.Count - 1)
            {
                counter += 1;
                found = (aPerson.ID == people[counter].ID);
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
