namespace Sat.Recruitment.Model
{
    public class PremiumUser : User
    {
        private decimal money;
        public override decimal Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value > 100)
                {
                    var gif = value * 2;
                    money = value + gif;
                }
            }
        }
    }
}
