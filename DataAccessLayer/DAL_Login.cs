using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class DAL_Login
    {
        DAL_Db db = new DAL_Db();
        public byte Login (string username , string password)
        {
            if (db.USers.Count()==0)
            {
                return 0;
            }
            else
            {
                if (db.USers.Any(i=>i.Username==username && i.Password==password))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        public void register(User_Login human)
        {
            db.USers.Add(human);
            db.SaveChanges();
        }
        public string ReturnName(DAL_Db db)
        {
            foreach (var item in db.USers)
            {
                if (item.id==1)
                {
                    return item.Name;
                }
            }
            return "";
        }
        public string ReturnUsername(DAL_Db db)
        {
            foreach (var item in db.USers)
            {
                if (item.id==1)
                {
                    return item.Username;
                }
            }
            return "";
        }
        public string ReturnPass(DAL_Db db)
        {
            foreach (var item in db.USers)
            {
                if (item.id == 1)
                {
                    return item.Password;
                }
            }
            return "";
        }
        public string Returnpic(DAL_Db db)
        {
            foreach (var item in db.USers)
            {
                if (item.id == 1)
                {
                    return item.PictureAddress;
                }
            }
            return "";
        }
        public User_Login Read()
        {
            return (from i in db.USers where i.id == 1 select i).Single();
        }
        public void UpdatePic(User_Login u)
        {
            User_Login h = new User_Login();
            h = Read();
            h.PictureAddress = u.PictureAddress;
            db.SaveChanges();
        }
        public void updateName(User_Login u)
        {
            User_Login h = new User_Login();
            h = Read();
            h.Name = u.Name;
            db.SaveChanges();
        }
        public void updateUserName(User_Login u)
        {
            User_Login h = new User_Login();
            h = Read();
            h.Username = u.Username;
            db.SaveChanges();
        }
        public void updatepass(User_Login u)
        {
            User_Login h = new User_Login();
            h = Read();
            h.Password = u.Password;
            db.SaveChanges();
        }
        public bool nullPic()
        {
            foreach (var item in db.USers)
            {
                if (item.PictureAddress=="NULL" || item.PictureAddress.Trim()=="" || item.PictureAddress==null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
