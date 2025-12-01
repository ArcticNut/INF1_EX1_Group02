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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(128, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonUseAddOK;
        private Label labelUseQKUnit;
    }
}