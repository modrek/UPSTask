using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPSTask.Models;
using UPSTask.Services;
using UPSTask.Views;

namespace UPSTask.Presenters
{
    public class EmployeePresenter
    {
        IEmployee _employeeView;
        EmployeeModel _employee;
        EmployeeSearchModel _employeeSearch;
        List<string> _errorList = new List<string>();

        /// <summary>
        /// I can also inject EmployeeService here, It's better for Unit Test and also independent Prensenter layer
        /// form any services, but it makes more complex the project and I perefer not to inject Employee Service 
        /// for this assessment.
        /// </summary>
        /// <param name="EmployeeService"></param>
        public EmployeePresenter(IEmployee view)
        {
            _employeeView = view;
            _employee = new EmployeeModel();
            _employeeSearch = new EmployeeSearchModel();
        }

        private void MapFieldsToProps()
        {
            _employee.id = _employeeView.IdText == string.Empty ? 0 : int.Parse(_employeeView.IdText);
            _employee.name = _employeeView.NameText;
            _employee.email = _employeeView.EmailText;
            _employee.gender = _employeeView.GenderText;
            _employee.status = _employeeView.StatusText;
            _employeeSearch.seach = _employeeView.SearchText;
        }

        private bool IsValidModel()
        {
            _errorList.Clear();
            if (string.IsNullOrEmpty(_employee.name))
                _errorList.Add("Name is Required.");

            if (string.IsNullOrEmpty(_employee.email))
                _errorList.Add("Email is Required.");
            else
                if (!(_employee.email.Contains("@") && _employee.email.Contains(".")))
                _errorList.Add("Email format is Incorrect.");

            if (string.IsNullOrEmpty(_employee.status))
                _errorList.Add("Status is Required.");
            else
               if (!(_employee.status == "Active" || _employee.status == "Inactive"))
                _errorList.Add("Status value must be Active or Inactive.");

            if (string.IsNullOrEmpty(_employee.gender))
                _errorList.Add("Gender is Required.");
            else
               if (!(_employee.gender == "Male" || _employee.gender == "Female"))
                _errorList.Add("Gender value must be Male or Female.");

            return _errorList.Count == 0 ? true : false;
        }

        public async Task GetEmployeeListAsync(int? page)
        {
            _employeeSearch.Page = page;
            EmployeeService service = new EmployeeService(_employee);
            await service.GetEmployeeListAsync(page);
            _employeeView.DataGridViewItems = service.DataGridViewItems;
        }

        public async Task GetEmployeeAsync()
        {
            MapFieldsToProps();
            EmployeeService service = new EmployeeService(_employee);
            var s = await service.GetEmployeeAsync();
            _employeeView.NameText = s.name;
            _employeeView.EmailText = s.email;
            _employeeView.GenderText = s.gender;
            _employeeView.StatusText = s.status;
            _employeeView.CreatedAtText = s.created_at.ToString();
            _employeeView.UpdatedAtText = s.updated_at.ToString();
        }

        public async Task AddEmployee()
        {
            MapFieldsToProps();
            if (!IsValidModel())
            {
                MessageBox.Show(string.Join("\n", _errorList.ToArray()), "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EmployeeService service = new EmployeeService(_employee);
            await service.AddEmployeeAsync();
        }

        public async Task UpdateEmployee()
        {
            MapFieldsToProps();
            if (!IsValidModel())
            {
                MessageBox.Show(string.Join("\n", _errorList.ToArray()), "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EmployeeService service = new EmployeeService(_employee);
            await service.UpdateEmployeeAsync();
        }

        public async Task DeleteEmployee()
        {
            MapFieldsToProps();
            EmployeeService service = new EmployeeService(_employee);
            await service.DeleteEmployeeAsync();

        }

        public async Task SearchEmployee()
        {
            MapFieldsToProps();
            EmployeeService service = new EmployeeService(_employeeSearch);
            await service.SearchEmployeeAsync();
            _employeeView.DataGridViewItems = service.DataGridViewItems;
        }
    }
}
