namespace Sat.Recruitment.Model
{
    public class NormalUser : User
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
                decimal gif;
                if (value > 100)
                {
                    gif = value * 0.12M;
                    money = value + gif;
                }
                else if (value < 100 && value > 10)
                {
                    gif = value * 0.8M;
                    money = value + gif;
                }
            }
        }
    }
}
