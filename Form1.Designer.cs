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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnTodosTxtBox = new System.Windows.Forms.Button();
            this.dgAlumnos = new System.Windows.Forms.DataGridView();
            this.btnTodosDG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTodosTxtBox);
            this.groupBox1.Controls.Add(this.txtDatos);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(730, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejemplo LINQ to SQL con TextBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTodosDG);
            this.groupBox2.Controls.Add(this.dgAlumnos);
            this.groupBox2.Location = new System.Drawing.Point(18, 287);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(730, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ejemplo LINQ to SQL con DataGrid";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(12, 37);
            this.txtDatos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(500, 200);
            this.txtDatos.TabIndex = 0;
            // 
            // btnTodosTxtBox
            // 
            this.btnTodosTxtBox.Location = new System.Drawing.Point(524, 37);
            this.btnTodosTxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTodosTxtBox.Name = "btnTodosTxtBox";
            this.btnTodosTxtBox.Size = new System.Drawing.Size(185, 44);
            this.btnTodosTxtBox.TabIndex = 1;
            this.btnTodosTxtBox.Text = "Mostrar todos";
            this.btnTodosTxtBox.UseVisualStyleBackColor = true;
            this.btnTodosTxtBox.Click += new System.EventHandler(this.btnTodosTxtBox_Click);
            // 
            // dgAlumnos
            // 
            this.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnos.Location = new System.Drawing.Point(12, 37);
            this.dgAlumnos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgAlumnos.Name = "dgAlumnos";
            this.dgAlumnos.Size = new System.Drawing.Size(500, 200);
            this.dgAlumnos.TabIndex = 0;
            // 
            // btnTodosDG
            // 
            this.btnTodosDG.Location = new System.Drawing.Point(524, 37);
            this.btnTodosDG.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTodosDG.Name = "btnTodosDG";
            this.btnTodosDG.Size = new System.Drawing.Size(185, 44);
            this.btnTodosDG.TabIndex = 1;
            this.btnTodosDG.Text = "Mostrar todos";
            this.btnTodosDG.UseVisualStyleBackColor = true;
            this.btnTodosDG.Click += new System.EventHandler(this.btnTodosDG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 563);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTodosTxtBox;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTodosDG;
        private System.Windows.Forms.DataGridView dgAlumnos;
    }
}

