namespace SGV_P.View
{
    partial class FrmEditFuncs
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            this.txtTelm = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(20, 132);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 18);
            label7.TabIndex = 36;
            label7.Text = "Telemóvel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(20, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 18);
            label4.TabIndex = 34;
            label4.Text = "Morada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(20, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 18);
            label3.TabIndex = 33;
            label3.Text = "NIF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(20, 57);
            label5.Name = "label5";
            label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label5.Size = new System.Drawing.Size(49, 18);
            label5.TabIndex = 32;
            label5.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(20, 158);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 18);
            label1.TabIndex = 41;
            label1.Text = "Administrador";
            // 
            // txtTelm
            // 
            this.txtTelm.Location = new System.Drawing.Point(125, 134);
            this.txtTelm.MaxLength = 9;
            this.txtTelm.Name = "txtTelm";
            this.txtTelm.Size = new System.Drawing.Size(224, 20);
            this.txtTelm.TabIndex = 39;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(125, 81);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(224, 20);
            this.txtNIF.TabIndex = 38;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(125, 107);
            this.txtMorada.MaxLength = 50;
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(224, 20);
            this.txtMorada.TabIndex = 27;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(17, 182);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(332, 44);
            this.btnApply.TabIndex = 31;
            this.btnApply.Text = "Placeholder";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 55);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 20);
            this.txtNome.TabIndex = 26;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(126, 25);
            this.labelNome.TabIndex = 30;
            this.labelNome.Text = "Placeholder";
            // 
            // cbAdmin
            // 
            this.cbAdmin.Location = new System.Drawing.Point(125, 159);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(73, 20);
            this.cbAdmin.TabIndex = 40;
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // FrmEditFuncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(363, 237);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.txtTelm);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(label7);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(label3);
            this.Controls.Add(label5);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNome);
            this.Name = "FrmEditFuncs";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.Funcionários_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelm;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.CheckBox cbAdmin;
    }
}