namespace INF1_EX1_Group02.Windows_GUIs_
{
    partial class BuildingForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonAddBuildingOK = new Button();
            labelBuildingName = new Label();
            labelBuildingArea = new Label();
            labelBuildingAreaUnit = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 1;
            // 
            // buttonAddBuildingOK
            // 
            buttonAddBuildingOK.Location = new Point(165, 101);
            buttonAddBuildingOK.Name = "buttonAddBuildingOK";
            buttonAddBuildingOK.Size = new Size(94, 29);
            buttonAddBuildingOK.TabIndex = 2;
            buttonAddBuildingOK.Text = "OK";
            buttonAddBuildingOK.UseVisualStyleBackColor = true;
            buttonAddBuildingOK.Click += buttonBuildingAddOK_Click;
            // 
            // labelBuildingName
            // 
            labelBuildingName.AutoSize = true;
            labelBuildingName.Location = new Point(13, 15);
            labelBuildingName.Name = "labelBuildingName";
            labelBuildingName.Size = new Size(52, 20);
            labelBuildingName.TabIndex = 3;
            labelBuildingName.Text = "Name:";
            // 
            // labelBuildingArea
            // 
            labelBuildingArea.AutoSize = true;
            labelBuildingArea.Location = new Point(13, 61);
            labelBuildingArea.Name = "labelBuildingArea";
            labelBuildingArea.Size = new Size(43, 20);
            labelBuildingArea.TabIndex = 4;
            labelBuildingArea.Text = "Area:";
            // 
            // labelBuildingAreaUnit
            // 
            labelBuildingAreaUnit.AutoSize = true;
            labelBuildingAreaUnit.Location = new Point(231, 61);
            labelBuildingAreaUnit.Name = "labelBuildingAreaUnit";
            labelBuildingAreaUnit.Size = new Size(28, 20);
            labelBuildingAreaUnit.TabIndex = 5;
            labelBuildingAreaUnit.Text = "m²";
            // 
            // BuildingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 143);
            Controls.Add(labelBuildingAreaUnit);
            Controls.Add(labelBuildingArea);
            Controls.Add(labelBuildingName);
            Controls.Add(buttonAddBuildingOK);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "BuildingForm";
            Text = "Add a Building";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAddBuildingOK;
        private Label labelBuildingName;
        private Label labelBuildingArea;
        private Label labelBuildingAreaUnit;
    }
}