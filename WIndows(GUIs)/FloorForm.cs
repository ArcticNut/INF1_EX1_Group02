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
            string levelText = comboBoxFloorLevel.Text.Trim();
            string heightText = textBoxFloorHeight.Text.Trim();

            if (!int.TryParse(levelText, out int level))
            {
                MessageBox.Show("Please enter a valid floor level.");
                return;
            }

            if (!double.TryParse(heightText, out double height) || height <= 0)
            {
                MessageBox.Show("Please enter a valid floor height (> 0).");
                return;
            }

            Floor newFloor = new Floor(level, height);
            _building.Floors.Add(newFloor);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
