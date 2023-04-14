using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Business
{
    public interface IEmailBusiness : IBusiness
    {
        string Normalize(string email);
    }
}
