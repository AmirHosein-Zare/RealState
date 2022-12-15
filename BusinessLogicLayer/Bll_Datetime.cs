using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntity;

namespace BusinessLogicLayer
{
    public class Bll_Datetime
    {
        Dal_Datetime d = new Dal_Datetime();
        public void create(Datetime date)
        {
            d.create(date);
        }
        public Datetime searchByid(int id)
        {
            return d.SearchByid(id);
        }
        public void update(int id , Datetime date)
        {
            d.update(id, date);
        }
        public void delete(int id)
        {
            d.delete(id);
        }
        public List<Datetime> ReadAll()
        {
            return d.ReadAll();
        }
        public List<Datetime> searchBydate (string text)
        {
            return d.searchBydate(text);
        }
        public List<Datetime> searchBytitle(string text)
        {
            return d.serachBytitle(text);
        }
        public bool Alarm(Datetime date)
        {
            if (d.Alarm(date))
            {
                return true;
            }
            return false;
        }
        public string ReturnAlarm(Datetime date)
        {
            return d.ReturnAlarm(date);
        }
        public Datetime Return(Datetime d)
        {
            Dal_Datetime date = new Dal_Datetime();
            return date.Return(d);
        }
    }
}
