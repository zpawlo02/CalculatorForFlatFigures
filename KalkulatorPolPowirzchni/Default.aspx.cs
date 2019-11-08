using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KalkulatorPolPowirzchni
{

    public partial class Default : System.Web.UI.Page
    {
        public void selectChanged(object sender, EventArgs args)
        {
            if (figuresNames.SelectedValue.ToString() == "Kwadrat")
            {
                funcLabel.Text = "adsds";

            }
        }

       
    }
}
