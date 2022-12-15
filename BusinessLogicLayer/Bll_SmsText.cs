using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class Bll_SmsText
    {
        Dal_SmsText dal = new Dal_SmsText();
        public void create(SmsText s)
        {
            dal.create(s);
        }
        public SmsText SearchById(int id)
        {
            return dal.SearchById(id);
        }
        public List<SmsText> ReadAll()
        {
            return dal.ReadAll();
        }
        public void delete(int id)
        {
            dal.delete(id);
        }
        public void Update(int id, SmsText text)
        {
            dal.Update(id, text);
        }
    }
}
