
namespace Lap5_Bai1_Mail
{
    partial class Bai1
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
            this.btn_Send = new System.Windows.Forms.Button();
            this.texb_From = new System.Windows.Forms.TextBox();
            this.texb_Body = new System.Windows.Forms.TextBox();
            this.texb_To = new System.Windows.Forms.TextBox();
            this.texb_Subject = new System.Windows.Forms.TextBox();
            this.teb_PassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(31, 21);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(94, 29);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // texb_From
            // 
            this.texb_From.Location = new System.Drawing.Point(197, 23);
            this.texb_From.Name = "texb_From";
            this.texb_From.Size = new System.Drawing.Size(214, 27);
            this.texb_From.TabIndex = 1;
            // 
            // texb_Body
            // 
            this.texb_Body.Location = new System.Drawing.Point(137, 183);
            this.texb_Body.Multiline = true;
            this.texb_Body.Name = "texb_Body";
            this.texb_Body.Size = new System.Drawing.Size(473, 255);
            this.texb_Body.TabIndex = 2;
            // 
            // texb_To
            // 
            this.texb_To.Location = new System.Drawing.Point(197, 74);
            this.texb_To.Name = "texb_To";
            this.texb_To.Size = new System.Drawing.Size(214, 27);
            this.texb_To.TabIndex = 3;
            // 
            // texb_Subject
            // 
            this.texb_Subject.Location = new System.Drawing.Point(137, 119);
            this.texb_Subject.Name = "texb_Subject";
            this.texb_Subject.Size = new System.Drawing.Size(473, 27);
            this.texb_Subject.TabIndex = 4;
            // 
            // teb_PassWord
            // 
            this.teb_PassWord.Location = new System.Drawing.Point(535, 26);
            this.teb_PassWord.Name = "teb_PassWord";
            this.teb_PassWord.Size = new System.Drawing.Size(229, 27);
            this.teb_PassWord.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "PassWord";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teb_PassWord);
            this.Controls.Add(this.texb_Subject);
            this.Controls.Add(this.texb_To);
            this.Controls.Add(this.texb_Body);
            this.Controls.Add(this.texb_From);
            this.Controls.Add(this.btn_Send);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox texb_From;
        private System.Windows.Forms.TextBox texb_Body;
        private System.Windows.Forms.TextBox texb_To;
        private System.Windows.Forms.TextBox texb_Subject;
        private System.Windows.Forms.TextBox teb_PassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}