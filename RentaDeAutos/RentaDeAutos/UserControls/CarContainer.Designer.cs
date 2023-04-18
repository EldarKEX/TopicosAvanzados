
namespace RentaDeAutos.UserControls
{
    partial class CarContainer
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
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.lModel = new System.Windows.Forms.Label();
            this.lBrand = new System.Windows.Forms.Label();
            this.lCost = new System.Windows.Forms.Label();
            this.lColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(12, 8);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(106, 96);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 0;
            this.pbCar.TabStop = false;
            this.pbCar.Click += new System.EventHandler(this.lColor_Click);
            this.pbCar.MouseEnter += new System.EventHandler(this.lColor_MouseEnter);
            this.pbCar.MouseLeave += new System.EventHandler(this.lColor_MouseLeave);
            // 
            // lModel
            // 
            this.lModel.AutoSize = true;
            this.lModel.BackColor = System.Drawing.Color.Transparent;
            this.lModel.Location = new System.Drawing.Point(124, 8);
            this.lModel.Name = "lModel";
            this.lModel.Size = new System.Drawing.Size(45, 13);
            this.lModel.TabIndex = 1;
            this.lModel.Text = "Modelo:";
            this.lModel.Click += new System.EventHandler(this.lColor_Click);
            this.lModel.MouseEnter += new System.EventHandler(this.lColor_MouseEnter);
            this.lModel.MouseLeave += new System.EventHandler(this.lColor_MouseLeave);
            // 
            // lBrand
            // 
            this.lBrand.AutoSize = true;
            this.lBrand.BackColor = System.Drawing.Color.Transparent;
            this.lBrand.Location = new System.Drawing.Point(124, 32);
            this.lBrand.Name = "lBrand";
            this.lBrand.Size = new System.Drawing.Size(40, 13);
            this.lBrand.TabIndex = 2;
            this.lBrand.Text = "Marca:";
            this.lBrand.Click += new System.EventHandler(this.lColor_Click);
            this.lBrand.MouseEnter += new System.EventHandler(this.lColor_MouseEnter);
            this.lBrand.MouseLeave += new System.EventHandler(this.lColor_MouseLeave);
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.BackColor = System.Drawing.Color.Transparent;
            this.lCost.Location = new System.Drawing.Point(124, 82);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(72, 13);
            this.lCost.TabIndex = 3;
            this.lCost.Text = "Costo por dia:";
            this.lCost.Click += new System.EventHandler(this.lColor_Click);
            this.lCost.MouseEnter += new System.EventHandler(this.lColor_MouseEnter);
            this.lCost.MouseLeave += new System.EventHandler(this.lColor_MouseLeave);
            // 
            // lColor
            // 
            this.lColor.AutoSize = true;
            this.lColor.BackColor = System.Drawing.Color.Transparent;
            this.lColor.Location = new System.Drawing.Point(124, 56);
            this.lColor.Name = "lColor";
            this.lColor.Size = new System.Drawing.Size(34, 13);
            this.lColor.TabIndex = 4;
            this.lColor.Text = "Color:";
            this.lColor.Click += new System.EventHandler(this.lColor_Click);
            this.lColor.MouseEnter += new System.EventHandler(this.lColor_MouseEnter);
            this.lColor.MouseLeave += new System.EventHandler(this.lColor_MouseLeave);
            // 
            // CarContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lColor);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.lBrand);
            this.Controls.Add(this.lModel);
            this.Controls.Add(this.pbCar);
            this.Name = "CarContainer";
            this.Size = new System.Drawing.Size(328, 109);
            this.Click += new System.EventHandler(this.CarContainer_Click);
            this.MouseEnter += new System.EventHandler(this.CarContainer_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CarContainer_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Label lModel;
        private System.Windows.Forms.Label lBrand;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.Label lColor;
    }
}
