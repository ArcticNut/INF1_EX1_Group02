using System;
using System.Windows.Forms;
using INF1_EX1_Group02.Classes;

namespace INF1_EX1_Group02.Windows_GUIs_
{
    public partial class FloorForm : Form
    {
        private Building _building;

        public FloorForm()
        {
            InitializeComponent();
        }

        public FloorForm(Building building) : this()
        {
            _building = building;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            int level;
            string heightText = textBoxFloorHeight.Text.Trim();

            if (comboBoxFloorLevel.SelectedItem==null)
            {
                MessageBox.Show("Please enter a valid floor level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                level = (int)comboBoxFloorLevel.SelectedItem;
            }

            if (!double.TryParse(heightText, out double height) || height <= 0)
            {
                MessageBox.Show("Please enter a valid floor height \nfloor height must be positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Floor newFloor = new Floor(level, height);
            _building.Floors.Add(newFloor);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
