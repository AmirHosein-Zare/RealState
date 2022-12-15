using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Bll_Sms
    {
        Dal_Sms dal = new Dal_Sms();
        public void Create(UserSms h)
        {
            dal.create(h);
        }
        public UserSms SearchById(int id)
        {
            return dal.SearchById(id);
        }
        public void Update(int id , UserSms u)
        {
            dal.Update(id, u);
        }
        public bool NumberOfUser()
        {
            return dal.NumberOfUser();
        }
        public UserSms ReturnUser()
        {
            return dal.ReturnUser();
        }
    }
}
