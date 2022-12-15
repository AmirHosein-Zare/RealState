using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLogicLayer
{

    public class user
    {
        DAL_Db db = new DAL_Db();
        DAL_Login h = new DAL_Login();
        public string ReturnName()
        {
            return h.ReturnName(db);
        }
        public string ReturnUsername()
        {
            return h.ReturnUsername(db);
        }
        public string ReturnPass()
        {
            return h.ReturnPass(db);
        }
        public string Returnpic()
        {
            return h.Returnpic(db);
        }
    }
}
