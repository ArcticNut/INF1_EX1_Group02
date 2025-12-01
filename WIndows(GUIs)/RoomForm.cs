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
    public partial class RoomForm : Form
    {
        // Make it possible to distinguish between Add and Edit
        private Room roomToEdit; // null = Add, not null = Edit

        private Floor floor;
        public RoomForm(Floor floor, Room room = null)
        {
            InitializeComponent();
            FillComboBoxRoomUse();
            roomToEdit = room;
            this.floor = floor;

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
        }

        private void buttonRoomAddOK_Click(object sender, EventArgs e)
        {
            //read GUI input
            string roomNr = textBoxRoomNr.Text;
            double area;
            Use use;
            double slabThickness;

            try { area = int.Parse(textBoxRoomArea.Text); }
            catch { MessageBox.Show("Area must be a number."); return; }

            if (comboBoxRoomUse.SelectedItem == null)
            {
                MessageBox.Show("Please select a Use for the Room.");
                return;
            }
            else
            {
                use = (Use)comboBoxRoomUse.SelectedItem;
            }

            try { slabThickness = double.Parse(textBoxRoomSlabThick.Text); }
            catch { MessageBox.Show("Slab Thickness must be a number."); return; }

            if (roomToEdit != null)
            {
                // Edit existing Room
                roomToEdit.RoomNr = roomNr;
                roomToEdit.Area = area;
                roomToEdit.Use = use;
                roomToEdit.SlabThickness = slabThickness;
            }
            else
            {
                // Add new Room
                Room newRoom = new Room(roomNr, area, use, slabThickness);
                floor.AddRoom(newRoom);
            }

        }
    }
}
