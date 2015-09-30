using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Statistics
{
    public partial class NewData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void buttonImport_Click(object sender, EventArgs e)
        {
            Data toAdd = new Data();
            toAdd.Country = countryTxt.Text;
            toAdd.Capital = capitalTxt.Text;
            toAdd.Population = long.Parse(populationTxt.Text);

            using (StreamWriter data = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                using (StreamReader info = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
                {
                    info.ReadToEnd();
                }
                
                try
                {
                    if (toAdd.Country == countryTxt.Text)
                    {
                        data.Write(toAdd + " | ");
                        data.WriteLine();
                    }
                }
                catch (Exception)
                {
                    exeption.Text = "This country already exists!";
                }

            }

        }
    }
}