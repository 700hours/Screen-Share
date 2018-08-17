namespace ScreenRecieve
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.Screen_Capture = new AxRDPCOMAPILib.AxRDPViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Screen_Capture)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen_Capture
            // 
            this.Screen_Capture.Enabled = true;
            this.Screen_Capture.Location = new System.Drawing.Point(0, 0);
            this.Screen_Capture.Name = "Screen_Capture";
            this.Screen_Capture.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Screen_Capture.OcxState")));
            this.Screen_Capture.Size = new System.Drawing.Size(800, 600);
            this.Screen_Capture.TabIndex = 0;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Screen_Capture);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Screen";
            this.ShowIcon = false;
            this.Text = "Screen Capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_Closing);
            this.Resize += new System.EventHandler(this.View_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Screen_Capture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxRDPCOMAPILib.AxRDPViewer Screen_Capture;
    }
}

