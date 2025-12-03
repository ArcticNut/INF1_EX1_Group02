namespace INF1_EX1_Group02.Windows_GUIs_
{
    partial class FurnitureForm
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
            labelFurnitureType = new Label();
            labelFurnitureAmount = new Label();
            textBoxFurnitureType = new TextBox();
            textBoxFurnitureAmount = new TextBox();
            buttonFurnitureAddOK = new Button();
            SuspendLayout();
            // 
            // labelFurnitureType
            // 
            labelFurnitureType.AutoSize = true;
            labelFurnitureType.Location = new Point(16, 16);
            labelFurnitureType.Name = "labelFurnitureType";
            labelFurnitureType.Size = new Size(43, 20);
            labelFurnitureType.TabIndex = 0;
            labelFurnitureType.Text = "Type:";
            // 
            // labelFurnitureAmount
            // 
            labelFurnitureAmount.AutoSize = true;
            labelFurnitureAmount.Location = new Point(16, 58);
            labelFurnitureAmount.Name = "labelFurnitureAmount";
            labelFurnitureAmount.Size = new Size(65, 20);
            labelFurnitureAmount.TabIndex = 1;
            labelFurnitureAmount.Text = "Amount:";
            // 
            // textBoxFurnitureType
            // 
            textBoxFurnitureType.Location = new Point(102, 13);
            textBoxFurnitureType.Name = "textBoxFurnitureType";
            textBoxFurnitureType.Size = new Size(187, 27);
            textBoxFurnitureType.TabIndex = 2;
            // 
            // textBoxFurnituteAmount
            // 
            textBoxFurnitureAmount.Location = new Point(102, 55);
            textBoxFurnitureAmount.Name = "textBoxFurnitureAmount";
            textBoxFurnitureAmount.Size = new Size(187, 27);
            textBoxFurnitureAmount.TabIndex = 3;
            // 
            // buttonFurnitureAddOK
            // 
            buttonFurnitureAddOK.Location = new Point(195, 99);
            buttonFurnitureAddOK.Name = "buttonFurnitureAddOK";
            buttonFurnitureAddOK.Size = new Size(94, 29);
            buttonFurnitureAddOK.TabIndex = 4;
            buttonFurnitureAddOK.Text = "OK";
            buttonFurnitureAddOK.UseVisualStyleBackColor = true;
            buttonFurnitureAddOK.Click += buttonFurnitureAddOK_Click;
            // 
            // FurnitureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 140);
            Controls.Add(buttonFurnitureAddOK);
            Controls.Add(textBoxFurnitureAmount);
            Controls.Add(textBoxFurnitureType);
            Controls.Add(labelFurnitureAmount);
            Controls.Add(labelFurnitureType);
            Name = "FurnitureForm";
            Text = "Add Furniture";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFurnitureType;
        private Label labelFurnitureAmount;
        private TextBox textBoxFurnitureType;
        private TextBox textBoxFurnitureAmount;
        private Button buttonFurnitureAddOK;
    }
}