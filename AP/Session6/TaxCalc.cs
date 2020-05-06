namespace AP.Session6
{
    public delegate float TaxMoney(float salary);
    public class TaxCalc
    {
        public static float VietNamTax(float salary)
        {
            return 10 * salary / 100;
        }
        public static float UsaTax(float salary)
        {
            return 15 * salary / 100;
        }
        public static float OtherTax(float salary)
        {
            return 5 * salary / 100;
        }

        // Viet ham tra ve 1 ham bang delegate
        public static TaxMoney GetTax(string country)
        {
            if (country == "VN")
            {
                return VietNamTax;
            }else if (country == "US")
            {
                return UsaTax;
            }
            else
            {
                return OtherTax;
            }
        }
        
    }
}