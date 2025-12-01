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
            string type = textBoxFurnitureType.Text;
            int amount;
            Furniture newFurniture;

            try 
            { 
                amount = int.Parse(textBoxFurnitureAmount.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a whole number for amount", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            } 
            
            newFurniture = new Furniture(type, amount);

            //add furniture to room
            room.Furnitures.Add(newFurniture);

        }
    }
}
