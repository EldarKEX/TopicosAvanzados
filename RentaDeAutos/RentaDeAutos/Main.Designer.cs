
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
            this.button5 = new System.Windows.Forms.Button();
            this.rentcarDataSet1 = new RentaDeAutos.RENTCARDataSet();
            this.purchaseTableAdapter = new RentaDeAutos.RENTCARDataSetTableAdapters.PurchaseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de inicio";
            // 
            // tbDateStart
            // 
            this.tbDateStart.Location = new System.Drawing.Point(29, 166);
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.Size = new System.Drawing.Size(168, 20);
            this.tbDateStart.TabIndex = 3;
            // 
            // btnDateStart
            // 
            this.btnDateStart.Location = new System.Drawing.Point(203, 164);
            this.btnDateStart.Name = "btnDateStart";
            this.btnDateStart.Size = new System.Drawing.Size(36, 23);
            this.btnDateStart.TabIndex = 4;
            this.btnDateStart.Text = "X";
            this.btnDateStart.UseVisualStyleBackColor = true;
            this.btnDateStart.Click += new System.EventHandler(this.DateStart_Click);
            // 
            // tbDateFinal
            // 
            this.tbDateFinal.Location = new System.Drawing.Point(29, 223);
            this.tbDateFinal.Name = "tbDateFinal";
            this.tbDateFinal.Size = new System.Drawing.Size(168, 20);
            this.tbDateFinal.TabIndex = 5;
            // 
            // btnDateEnd
            // 
            this.btnDateEnd.Location = new System.Drawing.Point(204, 219);
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
            this.label3.Location = new System.Drawing.Point(29, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de entrega";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(97, 267);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto       $";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(97, 303);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(100, 20);
            this.tbCustomer.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono";
            // 
            // tbCel
            // 
            this.tbCel.Location = new System.Drawing.Point(97, 343);
            this.tbCel.Name = "tbCel";
            this.tbCel.Size = new System.Drawing.Size(100, 20);
            this.tbCel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Domicilio";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(97, 387);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 15;
            // 
            // panelClock
            // 
            this.panelClock.Location = new System.Drawing.Point(367, 27);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(200, 200);
            this.panelClock.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(309, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(465, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 36);
            this.button5.TabIndex = 18;
            this.button5.Text = "Historial";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // rentcarDataSet1
            // 
            this.rentcarDataSet1.DataSetName = "RENTCARDataSet";
            this.rentcarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 564);
            this.Controls.Add(this.button5);
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
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet1)).EndInit();
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
        private System.Windows.Forms.Button button5;
        private RENTCARDataSet rentcarDataSet1;
        private RENTCARDataSetTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
    }
}

