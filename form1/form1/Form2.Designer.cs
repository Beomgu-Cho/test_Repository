namespace form1
{
    partial class Form_Input
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
            this.TB_input1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_input1
            // 
            this.TB_input1.Location = new System.Drawing.Point(12, 12);
            this.TB_input1.Name = "TB_input1";
            this.TB_input1.Size = new System.Drawing.Size(352, 22);
            this.TB_input1.TabIndex = 0;
            this.TB_input1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_input1_KeyPress);
            // 
            // Form_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 47);
            this.Controls.Add(this.TB_input1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Input";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_input1;
    }
}