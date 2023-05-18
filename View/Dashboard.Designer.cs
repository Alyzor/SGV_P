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
            this.panSideB = new System.Windows.Forms.Panel();
            this.panExit = new System.Windows.Forms.Panel();
            this.panFornece = new System.Windows.Forms.Panel();
            this.panVendas = new System.Windows.Forms.Panel();
            this.panProds = new System.Windows.Forms.Panel();
            this.panEncom = new System.Windows.Forms.Panel();
            this.panClientes = new System.Windows.Forms.Panel();
            this.btnSideB = new System.Windows.Forms.PictureBox();
            this.panBlur = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panChildForm.SuspendLayout();
            this.panSideB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideB)).BeginInit();
            this.SuspendLayout();
            // 
            // panChildForm
            // 
            this.panChildForm.BackColor = System.Drawing.Color.Salmon;
            this.panChildForm.Controls.Add(this.panSideB);
            this.panChildForm.Controls.Add(this.panBlur);
            this.panChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChildForm.ForeColor = System.Drawing.Color.Transparent;
            this.panChildForm.Location = new System.Drawing.Point(0, 0);
            this.panChildForm.Name = "panChildForm";
            this.panChildForm.Size = new System.Drawing.Size(1280, 720);
            this.panChildForm.TabIndex = 0;
            this.panChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panChildForm_Paint);
            // 
            // panSideB
            // 
            this.panSideB.BackColor = System.Drawing.Color.DarkSalmon;
            this.panSideB.Controls.Add(this.panExit);
            this.panSideB.Controls.Add(this.panFornece);
            this.panSideB.Controls.Add(this.panVendas);
            this.panSideB.Controls.Add(this.panProds);
            this.panSideB.Controls.Add(this.panEncom);
            this.panSideB.Controls.Add(this.panClientes);
            this.panSideB.Controls.Add(this.btnSideB);
            this.panSideB.Location = new System.Drawing.Point(0, 0);
            this.panSideB.MaximumSize = new System.Drawing.Size(250, 720);
            this.panSideB.MinimumSize = new System.Drawing.Size(75, 720);
            this.panSideB.Name = "panSideB";
            this.panSideB.Size = new System.Drawing.Size(75, 720);
            this.panSideB.TabIndex = 1;
            // 
            // panExit
            // 
            this.panExit.BackColor = System.Drawing.Color.Red;
            this.panExit.Location = new System.Drawing.Point(0, 645);
            this.panExit.Name = "panExit";
            this.panExit.Size = new System.Drawing.Size(250, 75);
            this.panExit.TabIndex = 4;
            // 
            // panFornece
            // 
            this.panFornece.Location = new System.Drawing.Point(0, 215);
            this.panFornece.Name = "panFornece";
            this.panFornece.Size = new System.Drawing.Size(250, 75);
            this.panFornece.TabIndex = 3;
            // 
            // panVendas
            // 
            this.panVendas.Location = new System.Drawing.Point(0, 322);
            this.panVendas.Name = "panVendas";
            this.panVendas.Size = new System.Drawing.Size(250, 75);
            this.panVendas.TabIndex = 3;
            // 
            // panProds
            // 
            this.panProds.Location = new System.Drawing.Point(0, 430);
            this.panProds.Name = "panProds";
            this.panProds.Size = new System.Drawing.Size(250, 75);
            this.panProds.TabIndex = 3;
            // 
            // panEncom
            // 
            this.panEncom.Location = new System.Drawing.Point(0, 537);
            this.panEncom.Name = "panEncom";
            this.panEncom.Size = new System.Drawing.Size(250, 75);
            this.panEncom.TabIndex = 3;
            // 
            // panClientes
            // 
            this.panClientes.Location = new System.Drawing.Point(0, 107);
            this.panClientes.Name = "panClientes";
            this.panClientes.Size = new System.Drawing.Size(250, 75);
            this.panClientes.TabIndex = 2;
            // 
            // btnSideB
            // 
            this.btnSideB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSideB.Image = global::SGV_P.Properties.Resources.menu;
            this.btnSideB.Location = new System.Drawing.Point(0, 0);
            this.btnSideB.Name = "btnSideB";
            this.btnSideB.Size = new System.Drawing.Size(75, 75);
            this.btnSideB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSideB.TabIndex = 1;
            this.btnSideB.TabStop = false;
            this.btnSideB.Click += new System.EventHandler(this.btnSideB_Click);
            // 
            // panBlur
            // 
            this.panBlur.BackColor = System.Drawing.Color.Transparent;
            this.panBlur.Location = new System.Drawing.Point(0, 0);
            this.panBlur.Name = "panBlur";
            this.panBlur.Size = new System.Drawing.Size(1280, 720);
            this.panBlur.TabIndex = 2;
            this.panBlur.Visible = false;
            this.panBlur.Click += new System.EventHandler(this.panBlur_Click);
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
            this.Controls.Add(this.panChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panChildForm.ResumeLayout(false);
            this.panSideB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSideB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panChildForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panSideB;
        private System.Windows.Forms.PictureBox btnSideB;
        private System.Windows.Forms.Panel panVendas;
        private System.Windows.Forms.Panel panProds;
        private System.Windows.Forms.Panel panFornece;
        private System.Windows.Forms.Panel panEncom;
        private System.Windows.Forms.Panel panClientes;
        private System.Windows.Forms.Panel panExit;
        private System.Windows.Forms.Panel panBlur;
    }
}