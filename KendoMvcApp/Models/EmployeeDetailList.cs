﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoMvcApp.Models
{
    public class EmployeeDetailList
    {
        public EmployeeDetailList(int EmployeeID, string FirstName, string LastName)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}