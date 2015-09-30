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
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonSearch_Click(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = file.ReadLine();
                string[] data = line.Split('|');

                if (dropDown.SelectedIndex == 1)
                {
                    data = line.Split('|');
                    do
                    {
                        if (result.Text == data[0])
                        {
                            line = file.ReadLine();
                        }

                    } while (line != null);
                    labelResult.Text = data[0] + " " + data[1] + " " + data[2].ToString();
                }

                else if (dropDown.SelectedIndex == 2)
                {
                    data = line.Split('|');
                    do
                    {
                        if (result.Text == file.ReadLine())
                        {
                            line = file.ReadLine();
                        }
                        line = file.ReadLine();

                    } while (line != null);
                    labelResult.Text = data[0] + " " + data[1] + " " + data[2].ToString();
                }

                else if (dropDown.SelectedIndex == 3)
                {
                    data = line.Split('|');
                    do
                    {
                        if (1 <= 2000000000)
                        {
                            line = file.ReadLine();
                        }
                        line = file.ReadLine();

                    } while (line != null);
                    labelResult.Text = data[0] + " " + data[1] + " " + data[2].ToString();
                }
            }
        }
    }
}