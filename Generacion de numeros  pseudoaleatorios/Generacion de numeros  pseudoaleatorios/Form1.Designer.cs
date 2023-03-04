
namespace Generacion_de_numeros__pseudoaleatorios
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbIteracion = new System.Windows.Forms.TextBox();
            this.tbSemilla = new System.Windows.Forms.TextBox();
            this.lSemilla = new System.Windows.Forms.Label();
            this.lE = new System.Windows.Forms.Label();
            this.lIteracion = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(117, 137);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(100, 20);
            this.tbE.TabIndex = 1;
            // 
            // tbIteracion
            // 
            this.tbIteracion.Location = new System.Drawing.Point(117, 185);
            this.tbIteracion.Name = "tbIteracion";
            this.tbIteracion.Size = new System.Drawing.Size(100, 20);
            this.tbIteracion.TabIndex = 2;
            // 
            // tbSemilla
            // 
            this.tbSemilla.Location = new System.Drawing.Point(117, 88);
            this.tbSemilla.Name = "tbSemilla";
            this.tbSemilla.Size = new System.Drawing.Size(100, 20);
            this.tbSemilla.TabIndex = 3;
            // 
            // lSemilla
            // 
            this.lSemilla.AutoSize = true;
            this.lSemilla.Location = new System.Drawing.Point(46, 94);
            this.lSemilla.Name = "lSemilla";
            this.lSemilla.Size = new System.Drawing.Size(40, 13);
            this.lSemilla.TabIndex = 4;
            this.lSemilla.Text = "Semilla";
            // 
            // lE
            // 
            this.lE.AutoSize = true;
            this.lE.Location = new System.Drawing.Point(73, 140);
            this.lE.Name = "lE";
            this.lE.Size = new System.Drawing.Size(13, 13);
            this.lE.TabIndex = 5;
            this.lE.Text = "e";
            // 
            // lIteracion
            // 
            this.lIteracion.AutoSize = true;
            this.lIteracion.Location = new System.Drawing.Point(46, 192);
            this.lIteracion.Name = "lIteracion";
            this.lIteracion.Size = new System.Drawing.Size(48, 13);
            this.lIteracion.TabIndex = 6;
            this.lIteracion.Text = "Iteracion";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(275, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(482, 256);
            this.dataGridView.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 85.95601F;
            this.Column1.HeaderText = "Iteracion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 142.132F;
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 85.95601F;
            this.Column3.HeaderText = "Semilla";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 85.95601F;
            this.Column4.HeaderText = "ri";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lTittle
            // 
            this.lTittle.AutoSize = true;
            this.lTittle.Location = new System.Drawing.Point(26, 46);
            this.lTittle.Name = "lTittle";
            this.lTittle.Size = new System.Drawing.Size(205, 13);
            this.lTittle.TabIndex = 8;
            this.lTittle.Text = "Generacion de numeros PseudoAleatorios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 305);
            this.Controls.Add(this.lTittle);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lIteracion);
            this.Controls.Add(this.lE);
            this.Controls.Add(this.lSemilla);
            this.Controls.Add(this.tbSemilla);
            this.Controls.Add(this.tbIteracion);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbIteracion;
        private System.Windows.Forms.TextBox tbSemilla;
        private System.Windows.Forms.Label lSemilla;
        private System.Windows.Forms.Label lE;
        private System.Windows.Forms.Label lIteracion;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lTittle;
    }
}

