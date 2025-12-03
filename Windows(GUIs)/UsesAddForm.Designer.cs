namespace INF1_EX1_Group02.Windows_GUIs_
{
    partial class UsesAddForm
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
            labelUseName = new Label();
            labelUseQK = new Label();
            textBoxUseName = new TextBox();
            textBoxUseQK = new TextBox();
            buttonUseAddOK = new Button();
            labelUseQKUnit = new Label();
            SuspendLayout();
            // 
            // labelUseName
            // 
            labelUseName.AutoSize = true;
            labelUseName.Location = new Point(12, 22);
            labelUseName.Name = "labelUseName";
            labelUseName.Size = new Size(52, 20);
            labelUseName.TabIndex = 0;
            labelUseName.Text = "Name:";
            // 
            // labelUseQK
            // 
            labelUseQK.AutoSize = true;
            labelUseQK.Location = new Point(12, 56);
            labelUseQK.Name = "labelUseQK";
            labelUseQK.Size = new Size(97, 20);
            labelUseQK.TabIndex = 1;
            labelUseQK.Text = "Live Load qK:";
            // 
            // textBoxUseName
            // 
            textBoxUseName.Location = new Point(128, 15);
            textBoxUseName.Name = "textBoxUseName";
            textBoxUseName.Size = new Size(125, 27);
            textBoxUseName.TabIndex = 2;
            // 
            // textBoxUseQK
            // 
            textBoxUseQK.Location = new Point(128, 53);
            textBoxUseQK.Name = "textBoxUseQK";
            textBoxUseQK.Size = new Size(125, 27);
            textBoxUseQK.TabIndex = 3;
            // 
            // buttonUseAddOK
            // 
            buttonUseAddOK.Location = new Point(207, 97);
            buttonUseAddOK.Name = "buttonUseAddOK";
            buttonUseAddOK.Size = new Size(94, 29);
            buttonUseAddOK.TabIndex = 4;
            buttonUseAddOK.Text = "OK";
            buttonUseAddOK.UseVisualStyleBackColor = true;
            buttonUseAddOK.Click += buttonUseAddOK_Click;
            // 
            // labelUseQKUnit
            // 
            labelUseQKUnit.AutoSize = true;
            labelUseQKUnit.Location = new Point(259, 56);
            labelUseQKUnit.Name = "labelUseQKUnit";
            labelUseQKUnit.Size = new Size(52, 20);
            labelUseQKUnit.TabIndex = 5;
            labelUseQKUnit.Text = "kN/m²";
            // 
            // UsesAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 138);
            Controls.Add(labelUseQKUnit);
            Controls.Add(buttonUseAddOK);
            Controls.Add(textBoxUseQK);
            Controls.Add(textBoxUseName);
            Controls.Add(labelUseQK);
            Controls.Add(labelUseName);
            Name = "UsesAddForm";
            Text = "Use Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUseName;
        private Label labelUseQK;
        private TextBox textBoxUseName;
        private TextBox textBoxUseQK;
        private Button buttonUseAddOK;
        private Label labelUseQKUnit;
    }
}