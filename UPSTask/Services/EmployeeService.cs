using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPSTask.Models;

namespace UPSTask.Services
{
    public class EmployeeService : IEmployeeService
    {
        const string BaseUrl = "https://gorest.co.in/public-api/";
        static HttpClient client = new HttpClient();

        EmployeeModel _employee;
        EmployeeSearchModel _employeeSearch;

        public object DataGridViewItems { get; set; }

        public EmployeeService(EmployeeModel employee)
        {
            _employee = employee;
        }

        public EmployeeService(EmployeeSearchModel employeeSearch)
        {
            _employeeSearch = employeeSearch;
        }

        private void PharsReponse(string apiResult)
        {
            var obj = JsonConvert.DeserializeObject<dynamic>(apiResult);
            var newobj = JsonConvert.DeserializeObject<dynamic>(apiResult)["data"];
            string errorlist = string.Empty;
            string erCode = obj.code;
            switch (erCode)
            {
                case "200": // no error 
                    MessageBox.Show($"Operation compelete successfullly ");
                    return;
                case "201": // post successfully     
                    MessageBox.Show($"Operation compelete successfullly ");
                    return;
                case "422": // validation error                                       
                    foreach (var item in newobj)
                        errorlist += $"{item.field} : {item.message} \n";
                    break;
                case "401": // authentication failed
                    errorlist = newobj;
                    break;
                default:
                    errorlist = "Unexcpected error!";
                    break;
            }

            //throw new ArgumentException(errorlist);

            MessageBox.Show($"{errorlist}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public async Task GetEmployeeListAsync(int? page)
        {
            string url = "users" + (page != null ? $"?page={page.ToString()}" : "");

            string apiResult = await CallAPIAsync(url, HttpMethod.Get, "");
            var modelResult = JsonConvert.DeserializeObject<DtoGetEmployeeModel>(apiResult);
            DataGridViewItems = modelResult.data;
        }

        public async Task<EmployeeModel> GetEmployeeAsync()
        {
            string apiResult = await CallAPIAsync($"users/{_employee.id.ToString()}", HttpMethod.Get, "");
            dynamic modelResult = JsonConvert.DeserializeObject<dynamic>(apiResult);
            _employee.name = modelResult["data"].name;
            _employee.email = modelResult["data"].email;
            _employee.gender = modelResult["data"].gender;
            _employee.status = modelResult["data"].status;
            _employee.created_at = modelResult["data"].created_at;
            _employee.updated_at = modelResult["data"].updated_at;
            return _employee;
        }

        public async Task AddEmployeeAsync()
        {
            string serializedEntity = JsonConvert.SerializeObject(_employee);
            string apiResult = await CallAPIAsync("users", HttpMethod.Post, serializedEntity);
            PharsReponse(apiResult);
        }

        public async Task UpdateEmployeeAsync()
        {
            string serializedEntity = JsonConvert.SerializeObject(_employee);
            string apiResult = await CallAPIAsync($"users/{_employee.id.ToString()}", HttpMethod.Put, serializedEntity);
            PharsReponse(apiResult);
        }

        public async Task DeleteEmployeeAsync()
        {
            string apiResult = await CallAPIAsync($"users/{_employee.id.ToString()}", HttpMethod.Delete, "");
            PharsReponse(apiResult);
        }

        public async Task SearchEmployeeAsync()
        {
            string apiResult = await CallAPIAsync($"users?name={_employeeSearch.seach}", HttpMethod.Get, "");
            var modelResult = JsonConvert.DeserializeObject<DtoGetEmployeeModel>(apiResult);
            DataGridViewItems = modelResult.data;
        }        

        private async Task<string> CallAPIAsync(string action, HttpMethod type, string data)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response;

            switch (type)
            {
                case HttpMethod m when m == HttpMethod.Post:
                    response = await client.PostAsync($"{BaseUrl}{action}", content);
                    break;
                case HttpMethod m when m == HttpMethod.Put:
                    response = await client.PutAsync($"{BaseUrl}{action}", content);
                    break;
                case HttpMethod m when m == HttpMethod.Delete:
                    response = await client.DeleteAsync($"{BaseUrl}{action}{data}");
                    break;
                default:
                    response = await client.GetAsync($"{BaseUrl}{action}{data}");
                    break;
            }

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();
            else
            {
                MessageBox.Show($"Error on calling API : {response.StatusCode.ToString()}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
