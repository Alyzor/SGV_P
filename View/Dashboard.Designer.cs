namespace SGV_P.View
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panChildForm = new System.Windows.Forms.Panel();
            this.sideBar1 = new SGV_P.SideBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panChildForm
            // 
            this.panChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.panChildForm.ForeColor = System.Drawing.Color.Transparent;
            this.panChildForm.Location = new System.Drawing.Point(73, 0);
            this.panChildForm.Name = "panChildForm";
            this.panChildForm.Size = new System.Drawing.Size(1207, 720);
            this.panChildForm.TabIndex = 0;
            this.panChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panChildForm_Paint);
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.MaximumSize = new System.Drawing.Size(250, 720);
            this.sideBar1.MinimumSize = new System.Drawing.Size(75, 720);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(75, 720);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.MouseEnter += new System.EventHandler(this.sideBar1_MouseEnter);
            this.sideBar1.MouseLeave += new System.EventHandler(this.sideBar1_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.panChildForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panChildForm;
        private SideBar sideBar1;
        private System.Windows.Forms.Timer timer1;
    }
}