using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_1_hur_manga_versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountUppercase_Click(object sender, EventArgs e)
        {
            var nrOfCapitals = Model.TextAnalyzer.GetNumberOfCapitals(WriteHere.Text);
            WriteHere.Enabled = false;
            Result.Text = String.Format("Texten innehåller {0} versaler",nrOfCapitals);

            CountUppercase.Text = "Rensa";
        }
    }
}