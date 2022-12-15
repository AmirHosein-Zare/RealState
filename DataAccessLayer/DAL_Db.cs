using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class DAL_Db : DbContext
    {
        public DAL_Db() : base("constr") { }

        public DbSet<User_Login> USers { get; set; }
        public DbSet<contact> contacts { get; set; }
        public DbSet<Datetime> datetimes { get; set; }
        public DbSet<Need> Needs { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<UserSms> PersonSms { get; set; }
        public DbSet<SmsText> Texts { get; set; }
    }
}
