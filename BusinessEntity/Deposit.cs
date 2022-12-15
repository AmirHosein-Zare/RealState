using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Deposit
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Number { get; set; }
        public string KindDeposit { get; set; }
        public string KindUser { get; set; }
        public string UserName { get; set; }
        public string Grade { get; set; }
        public int Foundation { get; set; }
        public byte Room { get; set; }
        public int Meter { get; set; }
        public string Address { get; set; }
        public long FullAmount { get; set; }
        public long MeterAmount { get; set; }
        //قیمت رهن
        public long MortgageAmount { get; set; }
        //قیمت اجاره
        public long RentAmount { get; set; }
        public string Explain { get; set; }
        public string Parking { get; set; }
        public string Elavator { get; set; }
        public string Store { get; set; }
        public string RemoteDoor { get; set; }
        public string Change { get; set; }
        public DateTime MDate { get; set; }
        public string ShDate { get; set; }
        public string PictureAddress1 { get; set; }
        public string PictureAddress2 { get; set; }
        public string PictureAddress3 { get; set; }
        public double XLocation { get; set; }
        public double YLocation { get; set; }
    }
}
