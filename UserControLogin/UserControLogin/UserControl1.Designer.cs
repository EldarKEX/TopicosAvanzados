namespace UserControLogin
{
    partial class ucLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLogin));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelUser.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(35, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(182, 183);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tbUser
            // 
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUser.Location = new System.Drawing.Point(0, 0);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(180, 19);
            this.tbUser.TabIndex = 1;
            this.tbUser.Text = "Usuario";
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEmail.Location = new System.Drawing.Point(0, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 19);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Text = "Email";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Location = new System.Drawing.Point(0, 1);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(180, 19);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(35, 370);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(142, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // panelUser
            // 
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Controls.Add(this.tbUser);
            this.panelUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelUser.Location = new System.Drawing.Point(35, 225);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(182, 21);
            this.panelUser.TabIndex = 6;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUser.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Black;
            this.labelUser.Location = new System.Drawing.Point(0, 0);
            this.labelUser.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(39, 15);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Usuario";
            this.labelUser.Visible = false;
            // 
            // panelEmail
            // 
            this.panelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmail.Controls.Add(this.labelEmail);
            this.panelEmail.Controls.Add(this.tbEmail);
            this.panelEmail.Location = new System.Drawing.Point(35, 266);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(182, 23);
            this.panelEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmail.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(0, 0);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(30, 15);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email";
            this.labelEmail.Visible = false;
            // 
            // panelPassword
            // 
            this.panelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPassword.Controls.Add(this.labelPassword);
            this.panelPassword.Controls.Add(this.tbPassword);
            this.panelPassword.Location = new System.Drawing.Point(35, 309);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(182, 22);
            this.panelPassword.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPassword.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(0, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(54, 15);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Contraseña";
            this.labelPassword.Visible = false;
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pictureBox);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(257, 443);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label labelPassword;
    }
}
