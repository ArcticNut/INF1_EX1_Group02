using System;
using System.Windows.Forms;
using INF1_EX1_Group02.Classes;

namespace INF1_EX1_Group02.Windows_GUIs_
{
    public partial class FloorForm : Form
    {
        private Building _building;
        private List<TextBox> _floorHeightTextBoxes = new List<TextBox>();
        

        public FloorForm()
        {
            InitializeComponent();
        }

        public FloorForm(Building building, int floorCount) : this()
        {
            _building = building;
            GenerateDynamicHeightInput(floorCount);
        }

        private void buttonFloorAdd_Click(object sender, EventArgs e)
        {
            
            foreach (TextBox tb in _floorHeightTextBoxes)
            {
                string heightText = tb.Text.Trim();

                // Determine floor number based on current count
                int floorNumber = _building.Floors.Count() + 1; 
                
                if (!double.TryParse(heightText, out double height) || height <= 0)
                {
                    MessageBox.Show($"Please enter a valid height for Floor {floorNumber}.\nHeight must be positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Floor newFloor = new Floor(floorNumber, height);
                _building.Floors.Add(newFloor);
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GenerateDynamicHeightInput(int FloorCount)
        {
            int y = 20;

            //make input fields for each floor height
            for (int i = 1; i <= FloorCount; i++)
            {
                Label floorLabel = new Label();
                floorLabel.Text = $"Floor {i} Height (m):";
                floorLabel.Location = new Point(20, y);
                floorLabel.AutoSize = true;
                this.Controls.Add(floorLabel);

                TextBox textBoxHeight = new TextBox();
                textBoxHeight.Location = new Point(150, y);
                textBoxHeight.Width = 100;
                this.Controls.Add(textBoxHeight);

                _floorHeightTextBoxes.Add(textBoxHeight);
                y += 30;
            }

            //adjust OK button position
            buttonFloorAdd.Location = new Point(150, y);

            //resize the form
            this.Height = y + 80;
        }
    }
}
