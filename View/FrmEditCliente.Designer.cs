namespace SGV_P.View
{
    partial class FrmEditCliente
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtTelm = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(15, 57);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label5.Size = new System.Drawing.Size(49, 18);
            label5.TabIndex = 11;
            label5.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(15, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 18);
            label3.TabIndex = 15;
            label3.Text = "NIF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(15, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 18);
            label4.TabIndex = 17;
            label4.Text = "Morada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(15, 135);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(50, 18);
            label6.TabIndex = 19;
            label6.Text = "E-Mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(15, 161);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 18);
            label7.TabIndex = 21;
            label7.Text = "Telemóvel";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(15, 187);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(143, 18);
            label8.TabIndex = 23;
            label8.Text = "Data de Nascimento";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(7, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(126, 25);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "Placeholder";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 55);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 225);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(332, 44);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Placeholder";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(106, 107);
            this.txtMorada.MaxLength = 50;
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(238, 20);
            this.txtMorada.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 133);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(161, 187);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(183, 20);
            this.dtpDataNasc.TabIndex = 6;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(106, 81);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(238, 20);
            this.txtNIF.TabIndex = 24;
            // 
            // txtTelm
            // 
            this.txtTelm.Location = new System.Drawing.Point(106, 162);
            this.txtTelm.MaxLength = 9;
            this.txtTelm.Name = "txtTelm";
            this.txtTelm.Size = new System.Drawing.Size(238, 20);
            this.txtTelm.TabIndex = 25;
            // 
            // FrmEditCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(360, 293);
            this.Controls.Add(this.txtTelm);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(label3);
            this.Controls.Add(label5);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNome);
            this.Name = "FrmEditCliente";
            this.Text = "FrmEditCliente";
            this.Load += new System.EventHandler(this.FrmEditCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtTelm;
    }
}