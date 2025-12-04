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
            string FloorCountText = textBoxBuildingFloors.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a building name.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double area;
            if (!double.TryParse(areaText, out area) || area <= 0)
            {
                MessageBox.Show("Please enter a valid area. \narea must be positve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int floorCount;
            if (!int.TryParse(FloorCountText, out floorCount) || floorCount <= 0)
            {
                MessageBox.Show("Please enter a valid number of floors. \nnumber of floors must be positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Building newBuilding = new Building(name, area);
            AppData.Buildings.Add(newBuilding);

            this.Close();

            // Open FloorForm to add floors to the new building
            new FloorForm(newBuilding, floorCount).ShowDialog();
            
        }
    }
}
