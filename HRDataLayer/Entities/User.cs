
using HRDataLayer.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRDataLayer.Entities
{
    public class User
    {
        [Key]
        public int UserID { set; get; }
        public string Name { set; get; }
        public string LastName { set; get; }

        [DataType(DataType.EmailAddress)]
        [Index(IsUnique = true)]
        public string Email { set; get; }
        [Index (IsUnique = true)]
        public string Username { set; get; }
        [DataType(DataType.Password)]
        public string Password { set; get; }
        [Index(IsUnique = true)]
        public string Mobile { set; get; }
        public string JobTitle { set; get; }
        public Roles Role { set; get; }
        public int ManagerID { set; get; }
        public double AnnualVacationBalance { set; get; }
        public ICollection<Vacation> Vacations { set; get; }
    }
}
