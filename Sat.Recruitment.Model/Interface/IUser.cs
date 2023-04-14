using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Model
{
    public interface IUser
    {
        long UserId { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        decimal Money { get; set; }
    }
}
