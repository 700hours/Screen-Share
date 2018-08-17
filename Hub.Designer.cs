namespace ScreenRecieve
{
    partial class Hub
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
            this.Button_Quit = new System.Windows.Forms.Button();
            this.Text_Key = new System.Windows.Forms.TextBox();
            this.Button_Begin = new System.Windows.Forms.Button();
            this.Opt_Share = new System.Windows.Forms.RadioButton();
            this.Opt_Connect = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Quit
            // 
            this.Button_Quit.Enabled = false;
            this.Button_Quit.Location = new System.Drawing.Point(273, 41);
            this.Button_Quit.Name = "Button_Quit";
            this.Button_Quit.Size = new System.Drawing.Size(75, 23);
            this.Button_Quit.TabIndex = 5;
            this.Button_Quit.Text = "Terminate";
            this.Button_Quit.UseVisualStyleBackColor = true;
            this.Button_Quit.Click += new System.EventHandler(this.Button_Quit_Click);
            // 
            // Text_Key
            // 
            this.Text_Key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Key.Location = new System.Drawing.Point(12, 75);
            this.Text_Key.Name = "Text_Key";
            this.Text_Key.ReadOnly = true;
            this.Text_Key.Size = new System.Drawing.Size(336, 20);
            this.Text_Key.TabIndex = 4;
            // 
            // Button_Begin
            // 
            this.Button_Begin.Location = new System.Drawing.Point(273, 12);
            this.Button_Begin.Name = "Button_Begin";
            this.Button_Begin.Size = new System.Drawing.Size(75, 23);
            this.Button_Begin.TabIndex = 2;
            this.Button_Begin.Text = "Initiate";
            this.Button_Begin.UseVisualStyleBackColor = true;
            this.Button_Begin.Click += new System.EventHandler(this.Button_Begin_Click);
            // 
            // Opt_Share
            // 
            this.Opt_Share.AutoSize = true;
            this.Opt_Share.Checked = true;
            this.Opt_Share.Location = new System.Drawing.Point(6, 19);
            this.Opt_Share.Name = "Opt_Share";
            this.Opt_Share.Size = new System.Drawing.Size(53, 17);
            this.Opt_Share.TabIndex = 6;
            this.Opt_Share.TabStop = true;
            this.Opt_Share.Text = "Share";
            this.Opt_Share.UseVisualStyleBackColor = true;
            this.Opt_Share.CheckedChanged += new System.EventHandler(this.Opt_ShareCheck);
            // 
            // Opt_Connect
            // 
            this.Opt_Connect.AutoSize = true;
            this.Opt_Connect.Location = new System.Drawing.Point(65, 19);
            this.Opt_Connect.Name = "Opt_Connect";
            this.Opt_Connect.Size = new System.Drawing.Size(65, 17);
            this.Opt_Connect.TabIndex = 7;
            this.Opt_Connect.Text = "Connect";
            this.Opt_Connect.UseVisualStyleBackColor = true;
            this.Opt_Connect.CheckedChanged += new System.EventHandler(this.Opt_ConnectCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection Key:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Opt_Share);
            this.groupBox1.Controls.Add(this.Opt_Connect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 44);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Type";
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 105);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Quit);
            this.Controls.Add(this.Button_Begin);
            this.Controls.Add(this.Text_Key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Hub";
            this.Text = "Hub";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Begin;
        private System.Windows.Forms.TextBox Text_Key;
        private System.Windows.Forms.Button Button_Quit;
        private System.Windows.Forms.RadioButton Opt_Share;
        private System.Windows.Forms.RadioButton Opt_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}