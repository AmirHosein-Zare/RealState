using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Bll_contact
    {
        Dal_contact c = new Dal_contact();
        public void create(contact human)
        {
            c.create(human);
        }
        public List<contact> SearchByNumber (string number)
        {
            return c.SearchByNumber(number);
        }
        public List<contact> SearchByName(string Name)
        {
            return c.SearchByName(Name);
        }
        public contact SearchById(int id)
        {
            return c.SearchById(id);
        }
        public void update(contact human, int id)
        {
            c.update(human, id);
        }
        public void delete(int id)
        {
            c.delete(id);
        }
        public List<contact> ReadAll()
        {
            return c.ReadAll();
        }
    }
}
