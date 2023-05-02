
namespace RentaDeAutos
{
    partial class Main
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDateStart = new System.Windows.Forms.TextBox();
            this.btnDateStart = new System.Windows.Forms.Button();
            this.tbDateFinal = new System.Windows.Forms.TextBox();
            this.btnDateEnd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.panelClock = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.tbFolio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAasignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de renta";
            // 
            // btnCar
            // 
            this.btnCar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.Location = new System.Drawing.Point(26, 60);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(257, 45);
            this.btnCar.TabIndex = 1;
            this.btnCar.Tag = "-1";
            this.btnCar.Text = "Elegir auto";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.BtnCar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de salida";
            // 
            // tbDateStart
            // 
            this.tbDateStart.Location = new System.Drawing.Point(26, 189);
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.ReadOnly = true;
            this.tbDateStart.Size = new System.Drawing.Size(168, 20);
            this.tbDateStart.TabIndex = 3;
            // 
            // btnDateStart
            // 
            this.btnDateStart.Location = new System.Drawing.Point(200, 187);
            this.btnDateStart.Name = "btnDateStart";
            this.btnDateStart.Size = new System.Drawing.Size(36, 23);
            this.btnDateStart.TabIndex = 4;
            this.btnDateStart.Text = "X";
            this.btnDateStart.UseVisualStyleBackColor = true;
            this.btnDateStart.Click += new System.EventHandler(this.DateStart_Click);
            // 
            // tbDateFinal
            // 
            this.tbDateFinal.Location = new System.Drawing.Point(26, 236);
            this.tbDateFinal.Name = "tbDateFinal";
            this.tbDateFinal.ReadOnly = true;
            this.tbDateFinal.Size = new System.Drawing.Size(168, 20);
            this.tbDateFinal.TabIndex = 5;
            // 
            // btnDateEnd
            // 
            this.btnDateEnd.Location = new System.Drawing.Point(201, 232);
            this.btnDateEnd.Name = "btnDateEnd";
            this.btnDateEnd.Size = new System.Drawing.Size(35, 23);
            this.btnDateEnd.TabIndex = 6;
            this.btnDateEnd.Text = "X";
            this.btnDateEnd.UseVisualStyleBackColor = true;
            this.btnDateEnd.Click += new System.EventHandler(this.btnDateEnd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de devolucion del auto";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(103, 286);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.ReadOnly = true;
            this.tbAmount.Size = new System.Drawing.Size(133, 20);
            this.tbAmount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto total   $";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(103, 322);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(133, 20);
            this.tbCustomer.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono";
            // 
            // tbCel
            // 
            this.tbCel.Location = new System.Drawing.Point(103, 394);
            this.tbCel.Name = "tbCel";
            this.tbCel.Size = new System.Drawing.Size(133, 20);
            this.tbCel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Domicilio";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(103, 435);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(133, 20);
            this.tbAddress.TabIndex = 15;
            // 
            // panelClock
            // 
            this.panelClock.Location = new System.Drawing.Point(367, 27);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(204, 204);
            this.panelClock.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Apellido";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(103, 357);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(133, 20);
            this.tbLastName.TabIndex = 20;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(27, 259);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 21;
            // 
            // tbFolio
            // 
            this.tbFolio.Location = new System.Drawing.Point(26, 143);
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.Size = new System.Drawing.Size(210, 20);
            this.tbFolio.TabIndex = 22;
            this.tbFolio.TextChanged += new System.EventHandler(this.tbFolio_TextChanged);
            this.tbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFolio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Folio";
            // 
            // btnAasignar
            // 
            this.btnAasignar.Location = new System.Drawing.Point(153, 122);
            this.btnAasignar.Name = "btnAasignar";
            this.btnAasignar.Size = new System.Drawing.Size(83, 20);
            this.btnAasignar.TabIndex = 24;
            this.btnAasignar.Text = "Auto asignar";
            this.btnAasignar.UseVisualStyleBackColor = true;
            this.btnAasignar.Click += new System.EventHandler(this.btnAasignar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 517);
            this.Controls.Add(this.btnAasignar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbFolio);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelClock);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDateEnd);
            this.Controls.Add(this.tbDateFinal);
            this.Controls.Add(this.btnDateStart);
            this.Controls.Add(this.tbDateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(600, 120);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Renta de automoviles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDateStart;
        private System.Windows.Forms.Button btnDateStart;
        private System.Windows.Forms.TextBox tbDateFinal;
        private System.Windows.Forms.Button btnDateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox tbFolio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAasignar;
    }
}

