namespace SGV_P
{
    partial class FrmCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarCliente = new System.Windows.Forms.Button();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnDelCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // btnCriarCliente
            // 
            this.btnCriarCliente.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCriarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnCriarCliente.Location = new System.Drawing.Point(12, 37);
            this.btnCriarCliente.Name = "btnCriarCliente";
            this.btnCriarCliente.Size = new System.Drawing.Size(75, 40);
            this.btnCriarCliente.TabIndex = 2;
            this.btnCriarCliente.Text = "Criar Cliente";
            this.btnCriarCliente.UseVisualStyleBackColor = false;
            this.btnCriarCliente.Click += new System.EventHandler(this.btnCriarCliente_Click);
            // 
            // btnModCliente
            // 
            this.btnModCliente.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnModCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnModCliente.Location = new System.Drawing.Point(93, 37);
            this.btnModCliente.Name = "btnModCliente";
            this.btnModCliente.Size = new System.Drawing.Size(75, 40);
            this.btnModCliente.TabIndex = 3;
            this.btnModCliente.Text = "Modificar";
            this.btnModCliente.UseVisualStyleBackColor = false;
            this.btnModCliente.Click += new System.EventHandler(this.btnModCliente_Click);
            // 
            // btnDelCliente
            // 
            this.btnDelCliente.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnDelCliente.Location = new System.Drawing.Point(174, 37);
            this.btnDelCliente.Name = "btnDelCliente";
            this.btnDelCliente.Size = new System.Drawing.Size(75, 40);
            this.btnDelCliente.TabIndex = 4;
            this.btnDelCliente.Text = "Apagar";
            this.btnDelCliente.UseVisualStyleBackColor = false;
            this.btnDelCliente.Click += new System.EventHandler(this.btnDelCliente_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelCliente);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.btnCriarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCliente";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FrmCliente_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriarCliente;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnDelCliente;
    }
}

