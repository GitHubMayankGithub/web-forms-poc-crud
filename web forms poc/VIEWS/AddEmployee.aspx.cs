using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_forms_poc.VIEWS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void OnSubmit1(object sender, EventArgs e)
        {
            EmpId.Text+=" =Emp9";
            Designation.Text+=(" = Software Engineer");
        }
    }
}