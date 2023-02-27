
namespace Agenda
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Contactos");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView = new System.Windows.Forms.TreeView();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode2.Name = "Nodo0";
            treeNode2.Text = "Contactos";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView.Size = new System.Drawing.Size(200, 369);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(3, 375);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(191, 41);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(3, 469);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(191, 41);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bLimpiar);
            this.panel2.Controls.Add(this.bActualizar);
            this.panel2.Controls.Add(this.treeView);
            this.panel2.Controls.Add(this.bAgregar);
            this.panel2.Controls.Add(this.bEliminar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 523);
            this.panel2.TabIndex = 6;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(106, 422);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(88, 41);
            this.bLimpiar.TabIndex = 6;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(3, 422);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(88, 41);
            this.bActualizar.TabIndex = 5;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bGuardar);
            this.panel1.Controls.Add(this.tAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 305);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(274, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(84, 240);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 37);
            this.bGuardar.TabIndex = 5;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(31, 214);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(185, 20);
            this.tAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Domicilio:";
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(31, 156);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(185, 20);
            this.tEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo:";
            // 
            // tNumber
            // 
            this.tNumber.Location = new System.Drawing.Point(31, 95);
            this.tNumber.Name = "tNumber";
            this.tNumber.Size = new System.Drawing.Size(185, 20);
            this.tNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero:";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(29, 36);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(185, 20);
            this.tName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.column3,
            this.Column4});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 305);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.Size = new System.Drawing.Size(600, 218);
            this.dataGridView.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            // 
            // column3
            // 
            this.column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.column3.DefaultCellStyle = dataGridViewCellStyle10;
            this.column3.HeaderText = "Correo";
            this.column3.Name = "column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column4.HeaderText = "Domicilio";
            this.Column4.Name = "Column4";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 523);
            this.panel3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

