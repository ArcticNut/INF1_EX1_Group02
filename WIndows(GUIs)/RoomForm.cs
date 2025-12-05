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
using System.Xml.Linq;

namespace INF1_EX1_Group02.Windows_GUIs_
{
    public partial class RoomForm : Form
    {
        // Make it possible to distinguish between Add and Edit
        private Room roomToEdit; // null = Add, not null = Edit
        private Building building;
        private Floor floor;
        private double availableArea;

        public RoomForm(Building building, Floor floor, double availableArea, Room room = null)
        {
            InitializeComponent();
            FillComboBoxRoomUse();
            roomToEdit = room;
            this.building = building;
            this.floor = floor;
            this.availableArea = availableArea;

            if (roomToEdit != null)
            {
                // Editing: pre-fill fields
                textBoxRoomNr.Text = roomToEdit.RoomNr;
                textBoxRoomArea.Text = roomToEdit.Area.ToString();
                textBoxRoomSlabThick.Text = roomToEdit.SlabThickness.ToString();
                comboBoxRoomUse.SelectedItem = roomToEdit.Use;
                Text = "Edit Room";
            }
            else
            {
                Text = "Add Room";
            }

        }

        private void FillComboBoxRoomUse()
        {
            comboBoxRoomUse.Items.Clear();
            foreach (Use use in AppData.Uses)
            {
                comboBoxRoomUse.Items.Add(use);
            }
            comboBoxRoomUse.SelectedIndex = 0;
        }

        private void buttonRoomAddOK_Click(object sender, EventArgs e)
        {
            //read GUI input
            string roomNr = textBoxRoomNr.Text.Trim();
            string areaText = textBoxRoomArea.Text.Trim();
            double area;
            Use use;
            string slabThicknessText = textBoxRoomSlabThick.Text.Trim();
            double slabThickness;

            if (string.IsNullOrWhiteSpace(roomNr))
            {
                MessageBox.Show("Please enter a Room Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(areaText, out area) || area <= 0)
            {
                MessageBox.Show("Please enter a valid area. \narea must be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxRoomUse.SelectedItem == null)
            {
                MessageBox.Show("Please select a Use for the Room. \nIf there are no selectable Uses please add them under Manage Use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                use = (Use)comboBoxRoomUse.SelectedItem;
            }

            if (!double.TryParse(slabThicknessText, out slabThickness) || slabThickness <= 0)
            {
                MessageBox.Show("Please enter a valid Slab Thickness. \nSlab Thickness must be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roomToEdit != null)
            {   
                //check Area constraints
                availableArea = availableArea + roomToEdit.Area;
                if (area > availableArea)
                {
                    MessageBox.Show($"The entered area exceeds the available area of {availableArea} m² on this floor. \nPlease enter a smaller area.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Edit existing Room
                roomToEdit.RoomNr = roomNr;
                roomToEdit.Area = area;
                roomToEdit.Use = use;
                roomToEdit.SlabThickness = slabThickness;
                roomToEdit.CalcSlabVol();
                roomToEdit.CalcRoomCost(building);
                roomToEdit.CalcLoad();
            }
            else
            {
                //check Area constraints
                if (area > availableArea)
                {
                    MessageBox.Show($"The entered area exceeds the available area of {availableArea} m² on this floor. \nPlease enter a smaller area.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Add new Room
                Room newRoom = new Room(roomNr, area, use, slabThickness, building);
                floor.Rooms.Add(newRoom);
            }

            // Close the form with OK result
            DialogResult = DialogResult.OK;

        }
    }
}
