using System;

namespace Sat.Recruitment.Business
{
    public class EmailBusiness : IEmailBusiness
    {

        #region Method
        public string Normalize(string email)
        {
            var aux = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            var plusIndex = aux[0].IndexOf("+", StringComparison.Ordinal);

            if (plusIndex > 0)
                aux[0] = aux[0].Replace("+", "");

            var dotIndex = aux[0].IndexOf(".", StringComparison.Ordinal);

            if (dotIndex > 0)
                aux[0] = aux[0].Replace(".", "");

            return string.Join("@", new string[] { aux[0], aux[1] });
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
