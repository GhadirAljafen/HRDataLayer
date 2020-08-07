using HRDataLayer.Enums;
using System;

namespace HR
{
    public class VacationData
    {

        public int VacationID { set; get; }
        public int EmployeeID { set; get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Types Type { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public Statuses Status { set; get; }
        public string Description { set; get; }
        public string Attatchment { set; get; }

    }
}
