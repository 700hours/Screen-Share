namespace ScreenRecieve
{
    partial class ConnectInfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.Text_Auth = new System.Windows.Forms.TextBox();
            this.Text_Group = new System.Windows.Forms.TextBox();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.Button_CreateKey = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // Text_Auth
            // 
            this.Text_Auth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Auth.Location = new System.Drawing.Point(88, 12);
            this.Text_Auth.Name = "Text_Auth";
            this.Text_Auth.Size = new System.Drawing.Size(150, 20);
            this.Text_Auth.TabIndex = 3;
            // 
            // Text_Group
            // 
            this.Text_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Group.Location = new System.Drawing.Point(88, 38);
            this.Text_Group.Name = "Text_Group";
            this.Text_Group.Size = new System.Drawing.Size(150, 20);
            this.Text_Group.TabIndex = 4;
            // 
            // Text_Password
            // 
            this.Text_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Password.Location = new System.Drawing.Point(88, 64);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.Size = new System.Drawing.Size(150, 20);
            this.Text_Password.TabIndex = 5;
            // 
            // Button_CreateKey
            // 
            this.Button_CreateKey.Location = new System.Drawing.Point(163, 90);
            this.Button_CreateKey.Name = "Button_CreateKey";
            this.Button_CreateKey.Size = new System.Drawing.Size(75, 23);
            this.Button_CreateKey.TabIndex = 6;
            this.Button_CreateKey.Text = "Create Key";
            this.Button_CreateKey.UseVisualStyleBackColor = true;
            this.Button_CreateKey.Click += new System.EventHandler(this.Button_CreateKey_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.ForeColor = System.Drawing.Color.IndianRed;
            this.Label_Status.Location = new System.Drawing.Point(88, 95);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(19, 13);
            this.Label_Status.TabIndex = 8;
            this.Label_Status.Text = "??";
            // 
            // ConnectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 123);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_CreateKey);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.Text_Group);
            this.Controls.Add(this.Text_Auth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConnectInfo";
            this.ShowIcon = false;
            this.Text = "Connection Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Info_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_Auth;
        private System.Windows.Forms.TextBox Text_Group;
        private System.Windows.Forms.TextBox Text_Password;
        private System.Windows.Forms.Button Button_CreateKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Status;
    }
}