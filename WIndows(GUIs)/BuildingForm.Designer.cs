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
            textBoxName = new TextBox();
            textBoxArea = new TextBox();
            buttonAddBuildingOK = new Button();
            labelBuildingName = new Label();
            labelBuildingArea = new Label();
            labelBuildingAreaUnit = new Label();
            label1 = new Label();
            textBoxBuildingFloors = new TextBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(94, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(153, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(94, 54);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(153, 27);
            textBoxArea.TabIndex = 1;
            // 
            // buttonAddBuildingOK
            // 
            buttonAddBuildingOK.Location = new Point(183, 155);
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
            labelBuildingAreaUnit.Location = new Point(253, 61);
            labelBuildingAreaUnit.Name = "labelBuildingAreaUnit";
            labelBuildingAreaUnit.Size = new Size(28, 20);
            labelBuildingAreaUnit.TabIndex = 5;
            labelBuildingAreaUnit.Text = "m²";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 98);
            label1.Name = "label1";
            label1.Size = new Size(70, 40);
            label1.TabIndex = 6;
            label1.Text = "Number \r\nof Floors:";
            // 
            // textBoxBuildingFloors
            // 
            textBoxBuildingFloors.Location = new Point(94, 103);
            textBoxBuildingFloors.Name = "textBoxBuildingFloors";
            textBoxBuildingFloors.Size = new Size(153, 27);
            textBoxBuildingFloors.TabIndex = 7;
            // 
            // BuildingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 207);
            Controls.Add(textBoxBuildingFloors);
            Controls.Add(label1);
            Controls.Add(labelBuildingAreaUnit);
            Controls.Add(labelBuildingArea);
            Controls.Add(labelBuildingName);
            Controls.Add(buttonAddBuildingOK);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxName);
            Name = "BuildingForm";
            Text = "Add a Building";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxArea;
        private Button buttonAddBuildingOK;
        private Label labelBuildingName;
        private Label labelBuildingArea;
        private Label labelBuildingAreaUnit;
        private Label label1;
        private TextBox textBoxBuildingFloors;
    }
}