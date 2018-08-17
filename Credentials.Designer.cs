namespace ScreenRecieve
{
    partial class Credentials
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_User = new System.Windows.Forms.TextBox();
            this.Text_Pass = new System.Windows.Forms.TextBox();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // Text_User
            // 
            this.Text_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_User.Location = new System.Drawing.Point(81, 12);
            this.Text_User.Name = "Text_User";
            this.Text_User.Size = new System.Drawing.Size(121, 20);
            this.Text_User.TabIndex = 2;
            // 
            // Text_Pass
            // 
            this.Text_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Pass.Location = new System.Drawing.Point(81, 38);
            this.Text_Pass.Name = "Text_Pass";
            this.Text_Pass.Size = new System.Drawing.Size(121, 20);
            this.Text_Pass.TabIndex = 3;
            // 
            // Button_Submit
            // 
            this.Button_Submit.Location = new System.Drawing.Point(127, 64);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(75, 23);
            this.Button_Submit.TabIndex = 4;
            this.Button_Submit.Text = "Submit";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // Credentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 95);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.Text_Pass);
            this.Controls.Add(this.Text_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Credentials";
            this.Text = "Credentials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Info_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_User;
        private System.Windows.Forms.TextBox Text_Pass;
        private System.Windows.Forms.Button Button_Submit;
    }
}