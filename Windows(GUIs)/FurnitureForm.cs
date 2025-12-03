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
    public partial class FurnitureForm : Form
    {
        private Room room;

        public FurnitureForm(Room room)
        {
            InitializeComponent();
            this.room = room;
        }

        private void buttonFurnitureAddOK_Click(object sender, EventArgs e)
        {
            //read GUI input
            string type = textBoxFurnitureType.Text.Trim();
            string amountText = textBoxFurnitureAmount.Text.Trim();
            int amount;
            Furniture newFurniture;

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Please enter a furniture type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(amountText, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.\namount must be positve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newFurniture = new Furniture(type, amount);

            //add furniture to room
            room.Furnitures.Add(newFurniture);

        }
    }
}
