﻿using GripOpGras.Models;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

namespace GripOpGras.Data
{
    public class UserDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public UserDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
        }

        public User GetUser()
        {
            lock (locker)
            {
                if (database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<User>().First();
                }
            }

        }

        public int SaveUser(User user)
        {

            lock(locker)
            {
                if(user.Id !=0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                {
                    return database.InsertOrReplace(user);
                }
            }
    
        }
        
        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }          
    }
}
