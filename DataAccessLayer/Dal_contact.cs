using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessEntity;

namespace DataAccessLayer
{
    public class Dal_contact
    {
        DAL_Db db = new DAL_Db();
        public void  create(contact human)
        {
            if (exist(human) == false)
            {
                db.contacts.Add(human);
                db.SaveChanges();
            }
            
        }
        public bool exist(contact human)
        {
            foreach (var item in db.contacts)
            {
                if (item.Number==human.Number)
                {
                    return true;
                }
            }
            return false;
        }
        public List<contact> SearchByNumber (string number)
        {
            return (from i in db.contacts where i.Number.Contains(number) select i).ToList();
        }
        public List<contact> SearchByName(string Name)
        {
            return (from i in db.contacts where i.FullName.Contains(Name) select i).ToList();
        }
        public contact SearchById(int id)
        {
            return (from i in db.contacts where i.id == id select i).Single();
        }
        public void update(contact human , int id)
        {
            contact h = new contact();
            h = SearchById(id);
            h.FullName = human.FullName;
            h.Number = human.Number;
            h.Address = human.Address;
            db.SaveChanges();

        }
        public void delete(int id)
        {
            contact h = new contact();
            h = SearchById(id);
            db.contacts.Remove(h);
            db.SaveChanges();
        }
        public List<contact> ReadAll()
        {
            return (db.contacts).ToList();
        }

    }
}
