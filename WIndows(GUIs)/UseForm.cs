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
                
                // Confirm Deletion
                string message = "Are you sure you want to delete the selected Use: " + selectedUse.Name + "?";
                MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                // Delete the Use
                AppData.Uses.Remove(selectedUse);
                FillUseListBox();
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
            try { UpdateUseSum(listBoxUses.SelectedItem as Use); }
            catch { }
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
                                    "\nLive Load qK: " + use.Qk.ToString() + "kN/m²";
            }
                
        }
    }
}
