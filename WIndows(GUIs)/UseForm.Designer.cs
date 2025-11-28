namespace INF1_EX1_Group02.Windows_GUIs_
{
    partial class UseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxUses = new ListBox();
            buttonUsesEdit = new Button();
            buttonUsesDelete = new Button();
            buttonUsesAdd = new Button();
            SuspendLayout();
            // 
            // listBoxUses
            // 
            listBoxUses.FormattingEnabled = true;
            listBoxUses.Location = new Point(12, 12);
            listBoxUses.Name = "listBoxUses";
            listBoxUses.Size = new Size(177, 204);
            listBoxUses.TabIndex = 0;
            // 
            // buttonUsesEdit
            // 
            buttonUsesEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUsesEdit.Location = new Point(134, 222);
            buttonUsesEdit.Name = "buttonUsesEdit";
            buttonUsesEdit.Size = new Size(55, 29);
            buttonUsesEdit.TabIndex = 12;
            buttonUsesEdit.Text = "Edit";
            buttonUsesEdit.UseVisualStyleBackColor = true;
            // 
            // buttonUsesDelete
            // 
            buttonUsesDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUsesDelete.Location = new Point(73, 222);
            buttonUsesDelete.Name = "buttonUsesDelete";
            buttonUsesDelete.Size = new Size(55, 29);
            buttonUsesDelete.TabIndex = 11;
            buttonUsesDelete.Text = "-";
            buttonUsesDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUsesAdd
            // 
            buttonUsesAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUsesAdd.Location = new Point(12, 222);
            buttonUsesAdd.Name = "buttonUsesAdd";
            buttonUsesAdd.Size = new Size(55, 29);
            buttonUsesAdd.TabIndex = 10;
            buttonUsesAdd.Text = "+";
            buttonUsesAdd.UseVisualStyleBackColor = true;
            // 
            // UseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 279);
            Controls.Add(buttonUsesEdit);
            Controls.Add(buttonUsesDelete);
            Controls.Add(buttonUsesAdd);
            Controls.Add(listBoxUses);
            Name = "UseForm";
            Text = "UseForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUses;
        private Button buttonUsesEdit;
        private Button buttonUsesDelete;
        private Button buttonUsesAdd;
    }
}