namespace Traffic_Light_Project
{
    partial class ctrlTrafficLight
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
            this.components = new System.ComponentModel.Container();
            this.lblTraffic = new System.Windows.Forms.Label();
            this.pbTraffic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraffic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTraffic
            // 
            this.lblTraffic.AutoSize = true;
            this.lblTraffic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTraffic.Location = new System.Drawing.Point(51, 166);
            this.lblTraffic.Name = "lblTraffic";
            this.lblTraffic.Size = new System.Drawing.Size(36, 20);
            this.lblTraffic.TabIndex = 1;
            this.lblTraffic.Text = "???";
            // 
            // pbTraffic
            // 
            this.pbTraffic.Image = global::Traffic_Light_Project.Properties.Resources.Red;
            this.pbTraffic.Location = new System.Drawing.Point(18, 13);
            this.pbTraffic.Name = "pbTraffic";
            this.pbTraffic.Size = new System.Drawing.Size(100, 132);
            this.pbTraffic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTraffic.TabIndex = 0;
            this.pbTraffic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTraffic);
            this.Controls.Add(this.pbTraffic);
            this.Name = "ctrlTrafficLight";
            this.Size = new System.Drawing.Size(147, 221);
            this.Load += new System.EventHandler(this.ctrlTrafficLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraffic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTraffic;
        private System.Windows.Forms.Label lblTraffic;
        private System.Windows.Forms.Timer timer1;
    }
}
