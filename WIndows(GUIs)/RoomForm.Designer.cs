namespace INF1_EX1_Group02.Windows_GUIs_
{
    partial class RoomForm
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
            labelRoomNr = new Label();
            labelRoomArea = new Label();
            labelRoomUse = new Label();
            labelRoomSlabThick = new Label();
            textBoxRoomNr = new TextBox();
            textBoxRoomArea = new TextBox();
            textBoxRoomSlabThick = new TextBox();
            labelRoomAreaUnit = new Label();
            labelRoomSlabThickUnit = new Label();
            comboBoxRoomUse = new ComboBox();
            buttonRoomAddOK = new Button();
            SuspendLayout();
            // 
            // labelRoomNr
            // 
            labelRoomNr.AutoSize = true;
            labelRoomNr.Location = new Point(26, 25);
            labelRoomNr.Name = "labelRoomNr";
            labelRoomNr.Size = new Size(75, 20);
            labelRoomNr.TabIndex = 0;
            labelRoomNr.Text = "Room Nr.:";
            // 
            // labelRoomArea
            // 
            labelRoomArea.AutoSize = true;
            labelRoomArea.Location = new Point(26, 66);
            labelRoomArea.Name = "labelRoomArea";
            labelRoomArea.Size = new Size(43, 20);
            labelRoomArea.TabIndex = 1;
            labelRoomArea.Text = "Area:";
            // 
            // labelRoomUse
            // 
            labelRoomUse.AutoSize = true;
            labelRoomUse.Location = new Point(26, 109);
            labelRoomUse.Name = "labelRoomUse";
            labelRoomUse.Size = new Size(36, 20);
            labelRoomUse.TabIndex = 2;
            labelRoomUse.Text = "Use:";
            // 
            // labelRoomSlabThick
            // 
            labelRoomSlabThick.AutoSize = true;
            labelRoomSlabThick.Location = new Point(26, 140);
            labelRoomSlabThick.Name = "labelRoomSlabThick";
            labelRoomSlabThick.Size = new Size(74, 40);
            labelRoomSlabThick.TabIndex = 3;
            labelRoomSlabThick.Text = "Slab \nThickness:";
            // 
            // textBoxRoomNr
            // 
            textBoxRoomNr.Location = new Point(115, 22);
            textBoxRoomNr.Name = "textBoxRoomNr";
            textBoxRoomNr.Size = new Size(125, 27);
            textBoxRoomNr.TabIndex = 4;
            // 
            // textBoxRoomArea
            // 
            textBoxRoomArea.Location = new Point(115, 63);
            textBoxRoomArea.Name = "textBoxRoomArea";
            textBoxRoomArea.Size = new Size(125, 27);
            textBoxRoomArea.TabIndex = 5;
            // 
            // textBoxRoomSlabThick
            // 
            textBoxRoomSlabThick.Location = new Point(115, 149);
            textBoxRoomSlabThick.Name = "textBoxRoomSlabThick";
            textBoxRoomSlabThick.Size = new Size(125, 27);
            textBoxRoomSlabThick.TabIndex = 7;
            // 
            // labelRoomAreaUnit
            // 
            labelRoomAreaUnit.AutoSize = true;
            labelRoomAreaUnit.Location = new Point(256, 66);
            labelRoomAreaUnit.Name = "labelRoomAreaUnit";
            labelRoomAreaUnit.Size = new Size(28, 20);
            labelRoomAreaUnit.TabIndex = 8;
            labelRoomAreaUnit.Text = "m²";
            // 
            // labelRoomSlabThickUnit
            // 
            labelRoomSlabThickUnit.AutoSize = true;
            labelRoomSlabThickUnit.Location = new Point(256, 152);
            labelRoomSlabThickUnit.Name = "labelRoomSlabThickUnit";
            labelRoomSlabThickUnit.Size = new Size(22, 20);
            labelRoomSlabThickUnit.TabIndex = 9;
            labelRoomSlabThickUnit.Text = "m";
            // 
            // comboBoxRoomUse
            // 
            comboBoxRoomUse.FormattingEnabled = true;
            comboBoxRoomUse.Location = new Point(115, 109);
            comboBoxRoomUse.Name = "comboBoxRoomUse";
            comboBoxRoomUse.Size = new Size(125, 28);
            comboBoxRoomUse.TabIndex = 10;
            // 
            // buttonRoomAddOK
            // 
            buttonRoomAddOK.Location = new Point(190, 198);
            buttonRoomAddOK.Name = "buttonRoomAddOK";
            buttonRoomAddOK.Size = new Size(94, 29);
            buttonRoomAddOK.TabIndex = 11;
            buttonRoomAddOK.Text = "OK";
            buttonRoomAddOK.UseVisualStyleBackColor = true;
            buttonRoomAddOK.Click += buttonRoomAddOK_Click;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 242);
            Controls.Add(buttonRoomAddOK);
            Controls.Add(comboBoxRoomUse);
            Controls.Add(labelRoomSlabThickUnit);
            Controls.Add(labelRoomAreaUnit);
            Controls.Add(textBoxRoomSlabThick);
            Controls.Add(textBoxRoomArea);
            Controls.Add(textBoxRoomNr);
            Controls.Add(labelRoomSlabThick);
            Controls.Add(labelRoomUse);
            Controls.Add(labelRoomArea);
            Controls.Add(labelRoomNr);
            Name = "RoomForm";
            Text = "Room Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRoomNr;
        private Label labelRoomArea;
        private Label labelRoomUse;
        private Label labelRoomSlabThick;
        private TextBox textBoxRoomNr;
        private TextBox textBoxRoomArea;
        private TextBox textBoxRoomSlabThick;
        private Label labelRoomAreaUnit;
        private Label labelRoomSlabThickUnit;
        private ComboBox comboBoxRoomUse;
        private Button buttonRoomAddOK;
    }
}