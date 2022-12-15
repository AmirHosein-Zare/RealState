using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessEntity;



namespace DataAccessLayer
{
    public class Dal_Need
    {
        DAL_Db db = new DAL_Db();
        public void Create(Need n)
        {
            db.Needs.Add(n);
            db.SaveChanges();
        }
        public Need SearchById(int id)
        {
            try
            {
                return (from i in db.Needs where i.id == id select i).Single();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Need> Read()
        {
            return (from i in db.Needs select i).ToList();
        }
        public void Update(Need n , int id)
        {
            Need h = new Need();
            h=SearchById(id);
            h.FullName = n.FullName;
            h.Number = n.Number;
            h.KindNeed = n.KindNeed;
            h.KindUser = n.KindUser;
            h.UserName = n.UserName;
            h.Foundation = n.Foundation;
            h.Room = n.Room;
            h.Meter = n.Meter;
            h.Address = n.Address;
            h.FullAmount = n.FullAmount;
            h.MeterAmount = n.MeterAmount;
            h.MortgageAmount = n.MortgageAmount;
            h.RentAmount = n.RentAmount;
            h.Explain = n.Explain;
            h.Parking = n.Parking;
            h.Elavator = n.Elavator;
            h.Store = n.Store;
            h.RemoteDoor = n.RemoteDoor;
            db.SaveChanges();
        }
        public void delete(int id)
        {
            db.Needs.Remove(SearchById(id));
            db.SaveChanges();
        }
        public List<Need> SearchByName(string text)
        {
            return (from i in db.Needs where i.FullName.Contains(text) select i).ToList();
        }
        public Need[] SearchByNumber(string text)
        {
            return (from i in db.Needs where i.Number.Contains(text) select i).ToArray();
        }
        public List<Need> SeachId(int id)
        {
            return (from i in db.Needs where i.id == id select i).ToList();
        }
        public List<Need> Search(string KNeed , string KUser , string UserName , string Address  )
        {
            return (from i in db.Needs where i.KindNeed.Contains(KNeed) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName)&&
                    i.Address.Contains(Address) 
                    select i).ToList();

        }
        public List<Need> Search( string KNeed , string KUser , string UserName , string Address , long Mortgage , long Rent , int Meter)
        {
            return (from i in db.Needs where i.KindNeed.Contains(KNeed) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) &&
            i.Address.Contains(Address) && (i.MortgageAmount<=Mortgage+50000000 || i.MortgageAmount >= Mortgage-50000000) && (i.RentAmount>=Rent+1000000 || i.RentAmount>Rent-1000000) &&
            (i.Meter<=Meter+50 || i.Meter>=Meter-50)
                    select i).ToList();
        }
        public List<Need> Search(string KNeed, string KUser, string UserName, string Address, long Mortgage, long Rent, int Meter , int F , int Room)
        {
            return (from i in db.Needs
                    where i.KindNeed.Contains(KNeed) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) &&
                    i.Address.Contains(Address) && (i.MortgageAmount <= Mortgage + 50000000 || i.MortgageAmount >= Mortgage - 50000000) && (i.RentAmount >= Rent + 1000000 || i.RentAmount > Rent - 1000000) &&
                    (i.Meter <= Meter + 50 || i.Meter >= Meter - 50) && i.Room==Room && (i.Foundation<=F+50 || i.Foundation>=F-50)
                    select i).ToList();
        }
        public List<Need> Search2(string KNeed, string KUser, string UserName, string Address, long FullA, long MeterA, int Meter)
        {
            return (from i in db.Needs
                    where i.KindNeed.Contains(KNeed) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) &&
                    i.Address.Contains(Address) && (i.FullAmount <= FullA + 300000000 || i.FullAmount >= FullA - 300000000) && (i.MeterAmount >= MeterA + 1500000 || i.MeterAmount > MeterA - 1500000) &&
                    (i.Meter <= Meter + 50 || i.Meter >= Meter - 50)
                    select i).ToList();
        }
        public List<Need> Search2(string KNeed, string KUser, string UserName, string Address, long FullA, long MeterA, int Meter , int F , int Room)
        {
            return (from i in db.Needs
                    where i.KindNeed.Contains(KNeed) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) &&
                    i.Address.Contains(Address) && (i.FullAmount <= FullA + 300000000 || i.FullAmount >= FullA - 300000000) && (i.MeterAmount <= MeterA + 1500000 || i.MeterAmount >= MeterA - 1500000) &&
                    (i.Meter <= Meter + 50 || i.Meter >= Meter - 50) && (i.Foundation <= F + 50 || i.Foundation >= F - 50) && i.Room == Room
                    select i).ToList();
        }
        public List<Need> dg()
        {
            return (db.Needs.OrderByDescending(i => i.id).Take(10)).ToList();
        }
        public List<Need> NeedSms()
        {
            List<Need> Find = new List<Need>();
            DateTime today = DateTime.Now.Date;
            foreach (var item in db.Needs)
            {
                TimeSpan value = today.Subtract(item.MDate);
                if (value.Days>=10)
                {
                    Find.Add(item);
                }
            }
            return Find;
        }
    }
}
