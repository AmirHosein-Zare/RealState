using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLL_login
    {
        DAL_Login dl = new DAL_Login();
        public byte login(string username , string password)
        {
            return dl.Login(username, password);
        }
        public void register(User_Login human) {
            dl.register(human);
        }
        public void UpdatePic(User_Login u)
        {
            dl.UpdatePic(u);
        }
        public void updateName(User_Login u)
        {
            dl.updateName(u);
        }
        public void updateUserName(User_Login u)
        {
            dl.updateUserName(u);
        }
        public void updatepass(User_Login u)
        {
            dl.updatepass(u);
        }
        public bool nullPic()
        {
            return dl.nullPic();
        }
    }
    
}
