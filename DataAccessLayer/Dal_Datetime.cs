using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace DataAccessLayer
{
    public class Dal_Datetime
    {
        DAL_Db db = new DAL_Db();
        public void create(Datetime date)
        {
            db.datetimes.Add(date);
            db.SaveChanges();
        }
        public Datetime SearchByid(int id)
        {
            return (from i in db.datetimes where i.id == id select i).Single();
        }
        public void update (int id , Datetime date)
        {
            Datetime newdate = new Datetime();
            newdate = SearchByid(id);
            newdate.title = date.title;
            newdate.explain = date.explain;
            newdate.Date = date.Date;
            newdate.Hour = date.Hour;
            db.SaveChanges();
        }
        public void delete(int id)
        {
            Datetime date = new Datetime();
            date = SearchByid(id);
            db.datetimes.Remove(date);
            db.SaveChanges();
        }
        public List<Datetime> ReadAll()
        {
            return db.datetimes.ToList();
        }
        public List<Datetime> searchBydate(string text)
        {
            return (from i in db.datetimes where i.Date == text select i).ToList();
        }
        public List<Datetime> serachBytitle(string text)
        {
            return (from i in db.datetimes where i.title.Contains(text) select i).ToList();
        }
        public bool Alarm(Datetime d)
        {
            foreach (var item in db.datetimes)
            {
                if (item.Date==d.Date && item.Hour==d.Hour)
                {                    
                    return true;
                }
            }
            return false;
        }
        public string ReturnAlarm(Datetime d)
        {
            foreach (var item in db.datetimes)
            {
                if (item.Date == d.Date && item.Hour == d.Hour)
                {
                    return item.title;
                }
            }
            return "";
            
        }
        public Datetime Return(Datetime d)
        {
            return (from i in db.datetimes where i.Date == d.Date && i.Hour == d.Hour select i).Single();
        }
    }
}
