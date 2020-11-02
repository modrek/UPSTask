using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSTask.Views
{
    public interface IEmployee
    {
        string IdText { get; set; }
        string NameText { get; set; }
        string EmailText { get; set; }
        string GenderText { get; set; }
        string StatusText { get; set; }
        string CreatedAtText { get; set; }
        string UpdatedAtText { get; set; }
        string SearchText { get; set; }
        object DataGridViewItems { get; set; }

    }    

}
