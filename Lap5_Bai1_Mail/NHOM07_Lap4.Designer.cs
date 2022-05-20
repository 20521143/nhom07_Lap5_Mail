
namespace Lap5_Bai1_Mail
{
    partial class NHOM07_Lap4
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBAI1 = new System.Windows.Forms.Button();
            this.btn_Bai2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBAI1
            // 
            this.btnBAI1.Location = new System.Drawing.Point(92, 59);
            this.btnBAI1.Name = "btnBAI1";
            this.btnBAI1.Size = new System.Drawing.Size(94, 29);
            this.btnBAI1.TabIndex = 0;
            this.btnBAI1.Text = "BAI 1";
            this.btnBAI1.UseVisualStyleBackColor = true;
            this.btnBAI1.Click += new System.EventHandler(this.btnBAI1_Click);
            // 
            // btn_Bai2
            // 
            this.btn_Bai2.Location = new System.Drawing.Point(92, 142);
            this.btn_Bai2.Name = "btn_Bai2";
            this.btn_Bai2.Size = new System.Drawing.Size(94, 29);
            this.btn_Bai2.TabIndex = 1;
            this.btn_Bai2.Text = "Bai2";
            this.btn_Bai2.UseVisualStyleBackColor = true;
            this.btn_Bai2.Click += new System.EventHandler(this.btn_Bai2_Click);
            // 
            // NHOM07_Lap4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 555);
            this.Controls.Add(this.btn_Bai2);
            this.Controls.Add(this.btnBAI1);
            this.Name = "NHOM07_Lap4";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBAI1;
        private System.Windows.Forms.Button btn_Bai2;
    }
}

