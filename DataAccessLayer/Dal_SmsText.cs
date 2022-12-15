using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Dal_SmsText
    {
        DAL_Db db = new DAL_Db();
        public void create(SmsText s)
        {
            db.Texts.Add(s);
            db.SaveChanges();
        }
        public SmsText SearchById(int id)
        {
            return (from i in db.Texts where i.id == id select i).Single();
        }
        public List<SmsText> ReadAll()
        {
            return db.Texts.ToList();
        }
        public void delete(int id)
        {
            SmsText u = new SmsText();
            u = SearchById(id);
            db.Texts.Remove(u);
            db.SaveChanges();
        }
        public void Update(int id , SmsText text)
        {
            SmsText s = new SmsText();
            s = SearchById(id);
            s.Text = text.Text;
            db.SaveChanges();
        }
    }
}
