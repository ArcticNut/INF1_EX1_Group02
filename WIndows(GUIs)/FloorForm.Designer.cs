namespace INF1_EX1_Group02.Windows_GUIs_
{
    partial class FloorForm
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
            buttonFloorAdd = new Button();
            labelFloorLevel = new Label();
            labelFloorHeight = new Label();
            comboBoxFloorLevel = new ComboBox();
            textBoxFloorHeight = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonFloorAdd
            // 
            buttonFloorAdd.Location = new Point(269, 167);
            buttonFloorAdd.Name = "buttonFloorAdd";
            buttonFloorAdd.Size = new Size(75, 23);
            buttonFloorAdd.TabIndex = 0;
            buttonFloorAdd.Text = "add";
            buttonFloorAdd.UseVisualStyleBackColor = true;
            buttonFloorAdd.Click += buttonOK_Click;
            // 
            // labelFloorLevel
            // 
            labelFloorLevel.AutoSize = true;
            labelFloorLevel.Location = new Point(54, 62);
            labelFloorLevel.Name = "labelFloorLevel";
            labelFloorLevel.Size = new Size(70, 15);
            labelFloorLevel.TabIndex = 1;
            labelFloorLevel.Text = "Floor Level: ";
            // 
            // labelFloorHeight
            // 
            labelFloorHeight.AutoSize = true;
            labelFloorHeight.Location = new Point(54, 108);
            labelFloorHeight.Name = "labelFloorHeight";
            labelFloorHeight.Size = new Size(79, 15);
            labelFloorHeight.TabIndex = 2;
            labelFloorHeight.Text = "Floor Height: ";
            // 
            // comboBoxFloorLevel
            // 
            comboBoxFloorLevel.FormattingEnabled = true;
            comboBoxFloorLevel.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBoxFloorLevel.Location = new Point(269, 60);
            comboBoxFloorLevel.Name = "comboBoxFloorLevel";
            comboBoxFloorLevel.Size = new Size(121, 23);
            comboBoxFloorLevel.TabIndex = 3;
            // 
            // textBoxFloorHeight
            // 
            textBoxFloorHeight.Location = new Point(269, 100);
            textBoxFloorHeight.Name = "textBoxFloorHeight";
            textBoxFloorHeight.Size = new Size(121, 23);
            textBoxFloorHeight.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 103);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 5;
            label3.Text = "(m)";
            // 
            // FloorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 268);
            Controls.Add(label3);
            Controls.Add(textBoxFloorHeight);
            Controls.Add(comboBoxFloorLevel);
            Controls.Add(labelFloorHeight);
            Controls.Add(labelFloorLevel);
            Controls.Add(buttonFloorAdd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FloorForm";
            Text = "FloorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFloorAdd;
        private Label labelFloorLevel;
        private Label labelFloorHeight;
        private ComboBox comboBoxFloorLevel;
        private TextBox textBoxFloorHeight;
        private Label label3;
    }
}