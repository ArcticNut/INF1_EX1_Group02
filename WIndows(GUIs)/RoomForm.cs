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
        public RoomForm(Room room = null)
        {
            InitializeComponent();
            FillComboBoxRoomUse();
            roomToEdit = room;

            if (roomToEdit != null)
            {
                // Editing: pre-fill fields
                textBoxRoomNr.Text = roomToEdit.RoomNr.ToString();
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

        }
    }
}
