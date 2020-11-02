using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPSTask.Views;
using UPSTask.Presenters;
using UPSTask.Helper;

namespace UPSTask.UserControls
{
    public partial class ucDataView : UserControl, IEmployee
    {
        private static ucDataView _instance;
        private EmployeePresenter _employeePresenter;

        public static ucDataView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDataView();
                return _instance;
            }
        }
        public ucDataView()
        {
            InitializeComponent();
            _employeePresenter= new EmployeePresenter(this);
        }

        #region interface impelentation
        public string IdText { get => txtId.Text; set => txtId.Text = value; }
        public string NameText { get => txtName.Text; set => txtName.Text = value; }
        public string EmailText { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string GenderText { get => drpGender.Text; set => drpGender.Text = value; }
        public string StatusText { get => drpStatus.Text; set => drpStatus.Text = value; }
        public string CreatedAtText { get => txtCreatedAt.Text; set => txtCreatedAt.Text = value; }
        public string UpdatedAtText { get => txtUpdatedAt.Text; set => txtUpdatedAt.Text = value; }
        public string SearchText { get => txtSearch.Text; set => txtSearch.Text = value; }
        public object DataGridViewItems { get => GrdEmployees.DataSource; set => GrdEmployees.DataSource = value; }

        #endregion interface impelentation

        private void ShowButtons(FormType formType)
        {
            switch (formType)
            {
                case FormType.View:
                    tbnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    break;
                case FormType.Insert:
                    tbnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    #region clear texts
                    txtId.Clear();
                    txtName.Clear();
                    txtEmail.Clear();
                    drpGender.SelectedIndex = 0;
                    drpStatus.SelectedIndex = 0;
                    txtCreatedAt.Clear();
                    txtUpdatedAt.Clear();
                    txtName.Focus();
                    #endregion
                    break;
                case FormType.Edit:
                    tbnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    txtName.Focus();
                    break;
                default:
                    break;
            }
        }

        private void ucDataView_Load(object sender, EventArgs e)
        {
            ShowButtons(FormType.View);          
            _employeePresenter.GetEmployeeListAsync(null);
        }

        private void GrdEmployees_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtId.Text = GrdEmployees.CurrentRow.Cells[0].Value.ToString();
                _employeePresenter.GetEmployeeAsync();
            }
            catch (Exception)
            {
                ShowButtons(FormType.View);
            }
        }
       
        private void tbnNew_Click(object sender, EventArgs e)
        {
            ShowButtons(FormType.Insert);            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            _employeePresenter.DeleteEmployee();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowButtons(FormType.Edit);            
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty( txtId.Text))
               _employeePresenter.AddEmployee();
            else
               _employeePresenter.UpdateEmployee();

            ShowButtons(FormType.View);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowButtons(FormType.View);
            GrdEmployees_SelectionChanged(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _employeePresenter.SearchEmployee();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (numPage.Value > 1) // _employeePresenter.GetEmployeeListAsync autocatically call when numPage changed
                numPage.Value = 1;
            else
                _employeePresenter.GetEmployeeListAsync(1);
            
        }

        private void numPage_ValueChanged(object sender, EventArgs e)
        {            
            _employeePresenter.GetEmployeeListAsync(Convert.ToInt32(numPage.Value));
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in GrdEmployees.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in GrdEmployees.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value;
                }
            }


            Helper.ExportHelper.GenerateExcel(dt, "D:\\tes.xls");
        }
    }
}
