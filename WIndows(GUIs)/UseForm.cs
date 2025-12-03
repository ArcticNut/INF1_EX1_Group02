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
    public partial class UseForm : Form
    {
        public UseForm()
        {
            InitializeComponent();
            // Populate the Use list box
            FillUseListBox();

        }

        private void buttonUsesAdd_Click(object sender, EventArgs e)
        {
            new UsesAddForm().ShowDialog();
            FillUseListBox();
        }

        private void buttonUsesDelete_Click(object sender, EventArgs e)
        {
            if(listBoxUses.SelectedItem != null)
            {
                Use selectedUse = listBoxUses.SelectedItem as Use;

                // Check if any Room references this Use
                bool isUsed = AppData.Buildings
                    .SelectMany(b => b.Floors)  // Get all Floors from all Buildings
                    .SelectMany(f => f.Rooms)   // Get all Rooms from all Floors
                    .Any(r => r.Use == selectedUse);

                if (isUsed)
                {
                    MessageBox.Show("Cannot delete this use because it is referenced by one or more rooms.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm Deletion
                string message = $"Are you sure you want to delete the selected use: {selectedUse} ?";
                DialogResult result = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    // Delete the Use
                    AppData.Uses.Remove(selectedUse);
                    FillUseListBox();
                }
                               
            }
        }

        private void buttonUsesEdit_Click(object sender, EventArgs e)
        {
            Use selectedUse = listBoxUses.SelectedItem as Use; 
            if (selectedUse != null)
            {
                new UsesAddForm(selectedUse).ShowDialog();
                FillUseListBox();
            }
        }

        private void listBoxUses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUses.SelectedItem != null){ UpdateUseSum(listBoxUses.SelectedItem as Use); }
            
        }

        private void FillUseListBox()
        {
            listBoxUses.Items.Clear();
            // Add all predefined Uses saved in the AppData class
            foreach (Use use in AppData.Uses)
            {
                listBoxUses.Items.Add(use);
            }
            
        }

        private void UpdateUseSum(Use use)
        {
            // Display the selected Use information (check for null)
            if (use == null)
            {
                labelUseSum.Text = "Use Information: \nName: -\nLive Load qK: - kN/m²";
            }
            else
            {
                labelUseSum.Text = "Use Information:" +
                                    "\nName: " + use.Name +
                                    "\nLive Load qK: " + use.Qk.ToString() + " kN/m²";
            }
                
        }
    }
}
