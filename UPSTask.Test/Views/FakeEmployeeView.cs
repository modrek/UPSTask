using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPSTask.Views;

namespace UPSTask.Test.Views
{
    public class FakeEmployeeView : IEmployee
    {
        #region Private prop
        private string txtId { get; set; }
        private string txtName { get; set; }
        private string txtEmail { get; set; }
        private string drpGender { get; set; }
        private string drpStatus { get; set; }
        private string txtCreatedAt { get; set; }
        private string txtUpdatedAt { get; set; }
        private string txtSearch { get; set; }
        private object GrdEmployees { get; set; } 
        #endregion

        public string IdText { get => txtId; set => txtId = value; }
        public string NameText { get => txtName; set => txtName = value; }
        public string EmailText { get => txtEmail; set => txtEmail = value; }
        public string GenderText { get => drpGender; set => drpGender = value; }
        public string StatusText { get => drpStatus; set => drpStatus = value; }
        public string CreatedAtText { get => txtCreatedAt; set => txtCreatedAt = value; }
        public string UpdatedAtText { get => txtUpdatedAt; set => txtUpdatedAt = value; }        
        public object DataGridViewItems { get => GrdEmployees; set => GrdEmployees = value; }
        public string SearchText { get => txtSearch; set => txtSearch=value; }
        
    }
}
