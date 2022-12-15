using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Dal_Sms
    {
        DAL_Db db = new DAL_Db();
        public void create(UserSms h)
        {
            db.PersonSms.Add(h);
            db.SaveChanges();
        }
        public UserSms SearchById(int id)
        {
            return (from i in db.PersonSms where i.id == id select i).Single();
        }
        public void Update(int id , UserSms u)
        {
            UserSms h = new UserSms();
            h = SearchById(id);
            h.UserName = u.UserName;
            h.Password = u.Password;
            h.Number = u.Number;
            h.Name = u.Name;
            db.SaveChanges();
        }
        public bool NumberOfUser()
        {
            var q = from i in db.PersonSms select i;
            if (q.Count()==0)
            {
                return false;
            }
            return true;
        }
        public UserSms ReturnUser()
        {
            return (from i in db.PersonSms where i.id == 1 select i).Single();
        }
    }
}
