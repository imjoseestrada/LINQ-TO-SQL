namespace LINQ_TO_SQL
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTB = new System.Windows.Forms.Button();
            this.txtBuscarTB = new System.Windows.Forms.TextBox();
            this.btnMayoresTB = new System.Windows.Forms.Button();
            this.btnTodosTB = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarDGV = new System.Windows.Forms.Button();
            this.txtBuscarDGV = new System.Windows.Forms.TextBox();
            this.btnMayoresDGV = new System.Windows.Forms.Button();
            this.btnTodosDGV = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarTB);
            this.groupBox1.Controls.Add(this.txtBuscarTB);
            this.groupBox1.Controls.Add(this.btnMayoresTB);
            this.groupBox1.Controls.Add(this.btnTodosTB);
            this.groupBox1.Controls.Add(this.txtDatos);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(730, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejemplo LINQ to SQL con TextBox";
            // 
            // btnBuscarTB
            // 
            this.btnBuscarTB.Location = new System.Drawing.Point(483, 178);
            this.btnBuscarTB.Name = "btnBuscarTB";
            this.btnBuscarTB.Size = new System.Drawing.Size(226, 44);
            this.btnBuscarTB.TabIndex = 4;
            this.btnBuscarTB.Text = "Buscar por nombre";
            this.btnBuscarTB.UseVisualStyleBackColor = true;
            this.btnBuscarTB.Click += new System.EventHandler(this.btnBuscarTB_Click);
            // 
            // txtBuscarTB
            // 
            this.txtBuscarTB.Location = new System.Drawing.Point(483, 140);
            this.txtBuscarTB.Name = "txtBuscarTB";
            this.txtBuscarTB.Size = new System.Drawing.Size(226, 32);
            this.txtBuscarTB.TabIndex = 3;
            // 
            // btnMayoresTB
            // 
            this.btnMayoresTB.Location = new System.Drawing.Point(483, 90);
            this.btnMayoresTB.Name = "btnMayoresTB";
            this.btnMayoresTB.Size = new System.Drawing.Size(226, 44);
            this.btnMayoresTB.TabIndex = 2;
            this.btnMayoresTB.Text = "Mayores de edad";
            this.btnMayoresTB.UseVisualStyleBackColor = true;
            this.btnMayoresTB.Click += new System.EventHandler(this.btnMayoresTB_Click);
            // 
            // btnTodosTB
            // 
            this.btnTodosTB.Location = new System.Drawing.Point(483, 37);
            this.btnTodosTB.Margin = new System.Windows.Forms.Padding(6);
            this.btnTodosTB.Name = "btnTodosTB";
            this.btnTodosTB.Size = new System.Drawing.Size(226, 44);
            this.btnTodosTB.TabIndex = 1;
            this.btnTodosTB.Text = "Mostrar todos";
            this.btnTodosTB.UseVisualStyleBackColor = true;
            this.btnTodosTB.Click += new System.EventHandler(this.btnTodosTB_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(12, 37);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(6);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ReadOnly = true;
            this.txtDatos.Size = new System.Drawing.Size(459, 200);
            this.txtDatos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarDGV);
            this.groupBox2.Controls.Add(this.txtBuscarDGV);
            this.groupBox2.Controls.Add(this.btnMayoresDGV);
            this.groupBox2.Controls.Add(this.btnTodosDGV);
            this.groupBox2.Controls.Add(this.dgvAlumnos);
            this.groupBox2.Location = new System.Drawing.Point(18, 287);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(730, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ejemplo LINQ to SQL con DataGrid";
            // 
            // btnBuscarDGV
            // 
            this.btnBuscarDGV.Location = new System.Drawing.Point(483, 178);
            this.btnBuscarDGV.Name = "btnBuscarDGV";
            this.btnBuscarDGV.Size = new System.Drawing.Size(226, 44);
            this.btnBuscarDGV.TabIndex = 7;
            this.btnBuscarDGV.Text = "Buscar por nombre";
            this.btnBuscarDGV.UseVisualStyleBackColor = true;
            this.btnBuscarDGV.Click += new System.EventHandler(this.btnBuscarDGV_Click);
            // 
            // txtBuscarDGV
            // 
            this.txtBuscarDGV.Location = new System.Drawing.Point(483, 140);
            this.txtBuscarDGV.Name = "txtBuscarDGV";
            this.txtBuscarDGV.Size = new System.Drawing.Size(226, 32);
            this.txtBuscarDGV.TabIndex = 6;
            // 
            // btnMayoresDGV
            // 
            this.btnMayoresDGV.Location = new System.Drawing.Point(483, 90);
            this.btnMayoresDGV.Name = "btnMayoresDGV";
            this.btnMayoresDGV.Size = new System.Drawing.Size(226, 44);
            this.btnMayoresDGV.TabIndex = 5;
            this.btnMayoresDGV.Text = "Mayores de edad";
            this.btnMayoresDGV.UseVisualStyleBackColor = true;
            this.btnMayoresDGV.Click += new System.EventHandler(this.btnMayoresDGV_Click);
            // 
            // btnTodosDGV
            // 
            this.btnTodosDGV.Location = new System.Drawing.Point(483, 37);
            this.btnTodosDGV.Margin = new System.Windows.Forms.Padding(6);
            this.btnTodosDGV.Name = "btnTodosDGV";
            this.btnTodosDGV.Size = new System.Drawing.Size(226, 44);
            this.btnTodosDGV.TabIndex = 1;
            this.btnTodosDGV.Text = "Mostrar todos";
            this.btnTodosDGV.UseVisualStyleBackColor = true;
            this.btnTodosDGV.Click += new System.EventHandler(this.btnTodosDGV_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 37);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(459, 200);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTodosTB;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTodosDGV;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnBuscarTB;
        private System.Windows.Forms.TextBox txtBuscarTB;
        private System.Windows.Forms.Button btnMayoresTB;
        private System.Windows.Forms.Button btnBuscarDGV;
        private System.Windows.Forms.TextBox txtBuscarDGV;
        private System.Windows.Forms.Button btnMayoresDGV;
    }
}

