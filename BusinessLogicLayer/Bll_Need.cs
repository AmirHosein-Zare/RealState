using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Bll_Need
    {
        Dal_Need dn = new Dal_Need();
        public void create(Need n)
        {
            dn.Create(n);
        }
        public Need SearchById(int id)
        {
            return dn.SearchById(id);
        }
        public List<Need> Read()
        {
            return dn.Read();
        }
        public void Update(Need n, int id)
        {
            dn.Update(n, id);
        }
        public void Delete(int id)
        {
            dn.delete(id);
        }
        public List<Need> SearchByName(string text)
        {
            return dn.SearchByName(text);
        }
        public Need[] SearchByNumber(string text)
        {
            return dn.SearchByNumber(text);
        }
        public List<Need> SearchId(int id)
        {
            return dn.SeachId(id);
        }
        public List<Need> Search(string KNeed, string KUser, string UserName, string Address)
        {
            return dn.Search(KNeed, KUser, UserName, Address);
        }
        public List<Need> Search(string KNeed, string KUser, string UserName, string Address, long Mortgage, long Rent, int Meter)
        {
            return dn.Search(KNeed, KUser, UserName, Address, Mortgage, Rent, Meter);
        }
        public List<Need> Search(string KNeed, string KUser, string UserName, string Address, long Mortgage, long Rent, int Meter, int F, int Room)
        {
            return dn.Search(KNeed, KUser, UserName, Address, Mortgage, Rent, Meter, F, Room);
        }
        public List<Need> Search2(string KNeed, string KUser, string UserName, string Address, long FullA, long MeterA, int Meter)
        {
            return dn.Search2(KNeed, KUser, UserName, Address, FullA,  MeterA, Meter);
        }
        public List<Need> Search2(string KNeed, string KUser, string UserName, string Address, long FullA, long MeterA, int Meter, int F, int Room)
        {
            return dn.Search2(KNeed, KUser, UserName, Address, FullA, MeterA, Meter, F, Room);
        }
        public List<Need> dg()
        {
            return dn.dg();
        }
        public List<Need> NeedSms()
        {
            return dn.NeedSms();
        }
    }
}
