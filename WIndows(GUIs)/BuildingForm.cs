using INF1_EX1_Group02.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF1_EX1_Group02.Windows_GUIs_
{
    public partial class BuildingForm : Form
    {
        public BuildingForm()
        {
            InitializeComponent();
        }

        private void buttonBuildingAddOK_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string areaText = textBoxArea.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a building name.");
                return;
            }

            double area;
            if (!double.TryParse(areaText, out area) || area <= 0)
            {
                MessageBox.Show("Please enter a valid area (> 0).");
                return;
            }

            Building newBuilding = new Building(name, area);
            AppData.Buildings.Add(newBuilding);

            this.Close();
        }
    }
    }
}
