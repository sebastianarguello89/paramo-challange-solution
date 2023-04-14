namespace Sat.Recruitment.Model
{
    public class SuperUser : User
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
                    var gif = value *0.20M;
                    money = value + gif;
                }
            }
        }
    }
}
