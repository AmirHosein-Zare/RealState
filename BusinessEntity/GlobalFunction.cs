using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class GlobalFunction
    {
        public static string SeparateHundred(string TextPrice)
        {
            try
            {
                if (TextPrice.Length > 0)
                {
                    //lblPriceFactor.TextChanged -= lblPriceFactor_TextChanged;
                    TextPrice = TextPrice.Replace(",", "");
                    TextPrice = String.Format("{0:N0}", long.Parse(TextPrice));
                    //lblPriceFactor.TextChanged += lblPriceFactor_TextChanged;
                    //lblSumDiscount.SelectionStart = lblSumDiscount.Text.Length;
                    return TextPrice;
                }
                return "0";
            }
            catch
            {
                return "0";
            }
        }
    }
}
