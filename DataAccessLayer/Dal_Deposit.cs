using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Dal_Deposit
    {
        DAL_Db db = new DAL_Db();
        public void create(Deposit d)
        {
            db.Deposits.Add(d);
            db.SaveChanges();
        }
        public Deposit SearchById(int id)
        {
            return (from i in db.Deposits where i.id == id select i).Single();
        }
        public List<Deposit> ReadAll()
        {
            return db.Deposits.ToList();
        }
        public void Update(int id , Deposit d)
        {
            Deposit h = new Deposit();
            h = SearchById(id);
            h.FullName = d.FullName;
            h.Number = d.Number;
            h.KindDeposit = d.KindDeposit;
            h.KindUser = d.KindUser;
            h.UserName = d.UserName;
            h.Grade = d.Grade;
            h.Foundation = d.Foundation;
            h.Room = d.Room;
            h.Meter = d.Meter;
            h.Address = d.Address;
            h.FullAmount = d.FullAmount;
            h.MeterAmount = d.MeterAmount;
            h.MortgageAmount = d.MortgageAmount;
            h.RentAmount = d.RentAmount;
            h.Explain = d.Explain;
            h.Parking = d.Parking;
            h.Elavator = d.Elavator;
            h.Store = d.Store;
            h.RemoteDoor = d.RemoteDoor;
            h.Change = d.Change;
            h.PictureAddress1 = d.PictureAddress1;
            h.PictureAddress2 = d.PictureAddress2;
            h.PictureAddress3 = d.PictureAddress3;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            Deposit d = new Deposit();
            d = SearchById(id);
            db.Deposits.Remove(d);
            db.SaveChanges();
        }
        public List<Deposit> SearchByName(string text)
        {
            return (from i in db.Deposits where i.FullName.Contains(text) select i).ToList();
        }
        public Deposit[] SearchByNumber(string text)
        {
            return (from i in db.Deposits where i.Number.Contains(text) select i).ToArray();
        }
        public List<Deposit> SearchId(int id)
        {
            return (from i in db.Deposits where i.id == id select i).ToList();
        }
        public List<Deposit> Search(string KDeposit , string KUser , string UserName , string Address)
        {
            return (from i in db.Deposits
                    where i.KindDeposit.Contains(KDeposit) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) && i.Address.Contains(Address)
                    select i).ToList();
        }
        public List<Deposit> Search(string KDeposit, string KUser, string UserName, string Address , long FullA , long MeterA , int Meter)
        {
            return (from i in db.Deposits
                    where i.KindDeposit.Contains(KDeposit) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) && i.Address.Contains(Address)
                    && (i.FullAmount <= FullA+300000000 || i.FullAmount >=FullA-300000000) && (i.MeterAmount <= MeterA+1500000 || i.MeterAmount >= MeterA-1500000)
                    && (i.Meter<= Meter+50 || i.Meter>=Meter-50)
                    select i).ToList();
        }
        public List<Deposit> Search(string KDeposit, string KUser, string UserName, string Address, long FullA, long MeterA, int Meter , int F , int Room)
        {
            return (from i in db.Deposits
                    where i.KindDeposit.Contains(KDeposit) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) && i.Address.Contains(Address)
                    && (i.FullAmount <= FullA + 300000000 || i.FullAmount >= FullA - 300000000) && (i.MeterAmount <= MeterA + 1500000 || i.MeterAmount >= MeterA - 1500000)
                    && (i.Meter <= Meter + 50 || i.Meter >= Meter - 50) && i.Room==Room && (i.Foundation<=F+50 || i.Foundation>=F-50)
                    select i).ToList();
        }
        public List<Deposit> Search2(string KDeposit, string KUser, string UserName, string Address, long Mortgage, long Rent, int Meter)
        {
            return (from i in db.Deposits
                    where i.KindDeposit.Contains(KDeposit) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) &&
                    i.Address.Contains(Address) && (i.MortgageAmount <= Mortgage + 50000000 || i.MortgageAmount >= Mortgage - 50000000) && (i.RentAmount >= Rent + 1000000 || i.RentAmount > Rent - 1000000) &&
                    (i.Meter <= Meter + 50 || i.Meter >= Meter - 50)
                    select i).ToList();
        }
        public List<Deposit> Search2(string KDeposit, string KUser, string UserName, string Address, long Mortgage, long Rent, int Meter, int F, int Room)
        {
            return (from i in db.Deposits
                    where i.KindDeposit.Contains(KDeposit) && i.KindUser.Contains(KUser) && i.UserName.Contains(UserName) &&
                    i.Address.Contains(Address) && (i.MortgageAmount <= Mortgage + 50000000 || i.MortgageAmount >= Mortgage - 50000000) && (i.RentAmount >= Rent + 1000000 || i.RentAmount > Rent - 1000000) &&
                    (i.Meter <= Meter + 50 || i.Meter >= Meter - 50) && i.Room == Room && (i.Foundation <= F + 50 || i.Foundation >= F - 50)
                    select i).ToList();
        }
        public List<Deposit> dg()
        {
            return (db.Deposits.OrderByDescending(i=>i.id).Take(10)).ToList();
        }
        public List<Deposit> NeedSms()
        {
            List<Deposit> Find = new List<Deposit>();
            DateTime today = DateTime.Now.Date;
            foreach (var item in db.Deposits)
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
