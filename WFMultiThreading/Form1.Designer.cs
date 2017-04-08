namespace WFMultiThreading
{
    partial class Form1
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
            this.btn_start = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btn_second = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(442, 39);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(131, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Main Button";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(27, 28);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(381, 240);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // btn_second
            // 
            this.btn_second.Location = new System.Drawing.Point(442, 80);
            this.btn_second.Name = "btn_second";
            this.btn_second.Size = new System.Drawing.Size(131, 23);
            this.btn_second.TabIndex = 2;
            this.btn_second.Text = "Button Second";
            this.btn_second.UseVisualStyleBackColor = true;
            this.btn_second.Click += new System.EventHandler(this.btn_second_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(27, 287);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(381, 56);
            this.txtBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 396);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btn_second);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btn_second;
        private System.Windows.Forms.TextBox txtBox;
    }
}

