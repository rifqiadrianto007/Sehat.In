namespace Project_PBO.App
{
    partial class underweight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lbltinggi = new Label();
            lblberat = new Label();
            lblbmi = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil Std", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(6, 130);
            label1.Name = "label1";
            label1.Size = new Size(370, 30);
            label1.TabIndex = 0;
            label1.Text = "BERAT BADAN ANDA KURANG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 89);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "KALKULATOR BMI";
            // 
            // lbltinggi
            // 
            lbltinggi.AutoSize = true;
            lbltinggi.Location = new Point(64, 204);
            lbltinggi.Name = "lbltinggi";
            lbltinggi.Size = new Size(36, 20);
            lbltinggi.TabIndex = 2;
            lbltinggi.Text = "Text";
            // 
            // lblberat
            // 
            lblberat.AutoSize = true;
            lblberat.Location = new Point(252, 204);
            lblberat.Name = "lblberat";
            lblberat.Size = new Size(50, 20);
            lblberat.TabIndex = 3;
            lblberat.Text = "label3";
            // 
            // lblbmi
            // 
            lblbmi.AutoSize = true;
            lblbmi.Location = new Point(155, 283);
            lblbmi.Name = "lblbmi";
            lblbmi.Size = new Size(50, 20);
            lblbmi.TabIndex = 4;
            lblbmi.Text = "label3";
            // 
            // underweight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblbmi);
            Controls.Add(lblberat);
            Controls.Add(lbltinggi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "underweight";
            Size = new Size(384, 354);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbltinggi;
        private Label lblberat;
        private Label lblbmi;
    }
}
