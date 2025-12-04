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
            buttonFloorAdd.Location = new Point(307, 223);
            buttonFloorAdd.Margin = new Padding(3, 4, 3, 4);
            buttonFloorAdd.Name = "buttonFloorAdd";
            buttonFloorAdd.Size = new Size(86, 31);
            buttonFloorAdd.TabIndex = 0;
            buttonFloorAdd.Text = "OK";
            buttonFloorAdd.UseVisualStyleBackColor = true;
            buttonFloorAdd.Click += buttonFloorAdd_Click;
            // 
            // labelFloorLevel
            // 
            labelFloorLevel.AutoSize = true;
            labelFloorLevel.Location = new Point(62, 83);
            labelFloorLevel.Name = "labelFloorLevel";
            labelFloorLevel.Size = new Size(88, 20);
            labelFloorLevel.TabIndex = 1;
            labelFloorLevel.Text = "Floor Level: ";
            // 
            // labelFloorHeight
            // 
            labelFloorHeight.AutoSize = true;
            labelFloorHeight.Location = new Point(62, 144);
            labelFloorHeight.Name = "labelFloorHeight";
            labelFloorHeight.Size = new Size(99, 20);
            labelFloorHeight.TabIndex = 2;
            labelFloorHeight.Text = "Floor Height: ";
            // 
            // comboBoxFloorLevel
            // 
            comboBoxFloorLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFloorLevel.FormattingEnabled = true;
            comboBoxFloorLevel.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBoxFloorLevel.Location = new Point(307, 80);
            comboBoxFloorLevel.Margin = new Padding(3, 4, 3, 4);
            comboBoxFloorLevel.Name = "comboBoxFloorLevel";
            comboBoxFloorLevel.Size = new Size(138, 28);
            comboBoxFloorLevel.TabIndex = 3;
            // 
            // textBoxFloorHeight
            // 
            textBoxFloorHeight.Location = new Point(307, 133);
            textBoxFloorHeight.Margin = new Padding(3, 4, 3, 4);
            textBoxFloorHeight.Name = "textBoxFloorHeight";
            textBoxFloorHeight.Size = new Size(138, 27);
            textBoxFloorHeight.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 137);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 5;
            label3.Text = "(m)";
            // 
            // FloorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 357);
            Controls.Add(label3);
            Controls.Add(textBoxFloorHeight);
            Controls.Add(comboBoxFloorLevel);
            Controls.Add(labelFloorHeight);
            Controls.Add(labelFloorLevel);
            Controls.Add(buttonFloorAdd);
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