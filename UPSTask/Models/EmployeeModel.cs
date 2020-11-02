using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSTask.Models
{
    public class DtoGetEmployeeModel
    {
        public string code { get; set; }
        public EmployeeModel[] data { get; set; }
    }
    public class EmployeeModel 
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }      
    }
    public class EmployeeSearchModel
    {
        public string seach { get; set; }
        public int? Page { get; set; }
    }


}
