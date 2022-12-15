using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class Bll_Deposit
    {
        Dal_Deposit dal = new Dal_Deposit();

        public void create(Deposit d)
        {
            dal.create(d);
        }
        public Deposit SearchById(int id) 
        {
            return dal.SearchById(id);
        }
        public List<Deposit> ReadAll()
        {
            return dal.ReadAll();
        }
        public void Update(int id , Deposit d)
        {
            dal.Update(id, d);
        }
        public void Delete(int id)
        {
            dal.Delete(id);
        }
        public List<Deposit> SearchByName(string text)
        {
            return dal.SearchByName(text);
        }
        public Deposit[] SearchByNumber (string text)
        {
            return dal.SearchByNumber(text);
        }
        public List<Deposit> SearchId(int id)
        {
            return dal.SearchId(id);
        }
        public List<Deposit> Search(string KDeposit, string KUser, string UserName, string Address)
        {
            return dal.Search(KDeposit,  KUser,  UserName,  Address);
        }
        public List<Deposit> Search(string KDeposit, string KUser, string UserName, string Address, long FullA, long MeterA, int Meter)
        {
            return dal.Search(KDeposit, KUser, UserName, Address, FullA, MeterA, Meter);
        }
        public List<Deposit> Search(string KDeposit, string KUser, string UserName, string Address, long FullA, long MeterA, int Meter, int F, int Room)
        {
            return dal.Search(KDeposit, KUser, UserName, Address, FullA, MeterA, Meter , F , Room);
        }
        public List<Deposit> Search2(string KDeposit, string KUser, string UserName, string Address, long Mortgage, long Rent, int Meter)
        {
            return dal.Search2(KDeposit, KUser, UserName, Address, Mortgage, Rent, Meter);
        }
        public List<Deposit> Search2(string KDeposit, string KUser, string UserName, string Address, long Mortgage, long Rent, int Meter, int F, int Room)
        {
            return dal.Search2(KDeposit, KUser, UserName, Address, Mortgage, Rent, Meter ,F , Room);
        }
        public List<Deposit> dg()
        {
            return dal.dg();
        }
        public List<Deposit> NeedSms()
        {
            return dal.NeedSms();
        }
    }
}
