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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INF1_EX1_Group02.Windows_GUIs_
{
    public partial class UsesAddForm : Form
    {
        // Make it possible to distinguish between Add and Edit
        private Use useToEdit;  // null = Add, not null = Edit

        public UsesAddForm(Use use = null)
        {
            InitializeComponent();
            useToEdit = use;

            if (useToEdit != null)
            {
                // Editing: pre-fill fields
                textBoxUseName.Text = useToEdit.Name;
                textBoxUseQK.Text = useToEdit.Qk.ToString();
                Text = "Edit Use";   
            }
            else
            {
                Text = "Add Use";    
            }
        }

        private void buttonUseAddOK_Click(object sender, EventArgs e)
        {
            // read the GUI fields
            string name = textBoxUseName.Text.Trim();
            string qkText = textBoxUseQK.Text.Trim();
            double qk;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a use name.");
                return;
            }

            if (!double.TryParse(qkText, out qk) || qk <= 0)
            {
                MessageBox.Show("Please enter a valid live load (> 0).");
                return;
            }

            // Edit the selected Use or add a new one
            if (useToEdit != null)
            {
                // Edit existing Use
                useToEdit.Name = name;
                useToEdit.Qk = qk;
            }
            else
            {
                // Add new Use
                Use newUse = new Use(name, qk);
                AppData.Uses.Add(newUse);
            }

            // Close the form with OK result
            DialogResult = DialogResult.OK;

        }
    }
}
