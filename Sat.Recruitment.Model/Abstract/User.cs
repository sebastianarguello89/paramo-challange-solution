using Sat.Recruitment.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sat.Recruitment.Model
{
    public abstract class User : IUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; } 
        public string Phone { get; set; }
        public abstract decimal Money { get; set; }
    }
}
