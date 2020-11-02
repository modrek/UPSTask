using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPSTask.Models;
using UPSTask.Presenters;
using UPSTask.Services;
using UPSTask.Test.Views;


namespace UPSTask.Test.Presenters
{
    [TestClass]
    public class EmployeePresenterTest
    {
        [TestMethod]
        public async Task TestEmployeePrensenterGetListAsync()
        {
            FakeEmployeeView fakeEmployeeView = new FakeEmployeeView();
            EmployeePresenter employeePresenter = new EmployeePresenter(fakeEmployeeView);

            await employeePresenter.GetEmployeeListAsync(null);
            var Items = fakeEmployeeView.DataGridViewItems ;
            Assert.IsNotNull(Items);
        }

        [TestMethod]
        public async Task TestEmployeePrensenterGetEmployeeAsync()
        {
            FakeEmployeeView fakeEmployeeView = new FakeEmployeeView();
            EmployeePresenter employeePresenter = new EmployeePresenter(fakeEmployeeView);

            await employeePresenter.GetEmployeeListAsync(null);
            var Items = (fakeEmployeeView.DataGridViewItems as IEnumerable<EmployeeModel>);
         
            fakeEmployeeView.IdText = Items.FirstOrDefault().id.ToString();
            await employeePresenter.GetEmployeeAsync();

            Assert.AreEqual(fakeEmployeeView.EmailText, Items.FirstOrDefault().email);
        }

    }
}
