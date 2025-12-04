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
            SuspendLayout();
            // 
            // buttonFloorAdd
            // 
            buttonFloorAdd.Location = new Point(204, 460);
            buttonFloorAdd.Margin = new Padding(3, 4, 3, 4);
            buttonFloorAdd.Name = "buttonFloorAdd";
            buttonFloorAdd.Size = new Size(100, 31);
            buttonFloorAdd.TabIndex = 0;
            buttonFloorAdd.Text = "OK";
            buttonFloorAdd.UseVisualStyleBackColor = true;
            buttonFloorAdd.Click += buttonFloorAdd_Click;
            // 
            // FloorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 504);
            Controls.Add(buttonFloorAdd);
            Name = "FloorForm";
            Text = "Add Floor";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFloorAdd;
    }
}