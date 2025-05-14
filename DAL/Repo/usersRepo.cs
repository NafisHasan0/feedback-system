using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class usersRepo : Repo, IRepo<users, int, string>
    {
        public string create(users user)
        {
            db.users.Add(user);
            db.SaveChanges();
            return "User created successfully";
        }

        public string update(users user) 
        { 
            var data =db.users.Find(user.userID);
            if(data != null)
            {
                data.username = user.username;
                data.password = user.password;
                db.SaveChanges();
                return "User updated successfully";
            }
            else
            {
                return "User not found";
            }
        }


        public string delete(int id) 
        {
            var data = db.users.Find(id);
            if (data != null)
            {
                db.users.Remove(data);
                db.SaveChanges();
                return "User deleted successfully";
            }
            else
            {
                return "User not found";
            }
        }

        public List<users> getAll()
        {
            return db.users.ToList();
        }

        public users get(int id)
        {
            if(db.users.Find(id) == null)
            {
                return null;
            }
            else
            {
                return db.users.Find(id);
            }
        }



    }
}
