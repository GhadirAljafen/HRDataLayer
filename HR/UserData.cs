using HRDataLayer.Enums;

namespace HR
{
   public class UserData
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Username { set; get; }
        public string Password { set; get; }
        // How to access enums????
        public Roles Role { set; get; }
        public int ManagerID { set; get; }

      //  public ICollection<VacationData> Vacations { set; get; }
    }
}
