namespace Radio_button_ejercicio_13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Asignatura = new System.Windows.Forms.TextBox();
            this.txt_Profesor = new System.Windows.Forms.TextBox();
            this.rb_Virtual = new System.Windows.Forms.RadioButton();
            this.rb_Presencial = new System.Windows.Forms.RadioButton();
            this.btn_Procesar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modalidad";
            // 
            // txt_Asignatura
            // 
            this.txt_Asignatura.Location = new System.Drawing.Point(192, 47);
            this.txt_Asignatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Asignatura.Name = "txt_Asignatura";
            this.txt_Asignatura.Size = new System.Drawing.Size(229, 21);
            this.txt_Asignatura.TabIndex = 3;
            // 
            // txt_Profesor
            // 
            this.txt_Profesor.Location = new System.Drawing.Point(192, 95);
            this.txt_Profesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Profesor.Name = "txt_Profesor";
            this.txt_Profesor.Size = new System.Drawing.Size(229, 21);
            this.txt_Profesor.TabIndex = 4;
            // 
            // rb_Virtual
            // 
            this.rb_Virtual.AutoSize = true;
            this.rb_Virtual.Location = new System.Drawing.Point(192, 197);
            this.rb_Virtual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_Virtual.Name = "rb_Virtual";
            this.rb_Virtual.Size = new System.Drawing.Size(150, 19);
            this.rb_Virtual.TabIndex = 6;
            this.rb_Virtual.TabStop = true;
            this.rb_Virtual.Text = "Virtual                     ";
            this.rb_Virtual.UseVisualStyleBackColor = true;
            // 
            // rb_Presencial
            // 
            this.rb_Presencial.AutoSize = true;
            this.rb_Presencial.Location = new System.Drawing.Point(192, 243);
            this.rb_Presencial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_Presencial.Name = "rb_Presencial";
            this.rb_Presencial.Size = new System.Drawing.Size(93, 19);
            this.rb_Presencial.TabIndex = 7;
            this.rb_Presencial.TabStop = true;
            this.rb_Presencial.Text = "Presencial";
            this.rb_Presencial.UseVisualStyleBackColor = true;
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.Location = new System.Drawing.Point(496, 43);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(75, 23);
            this.btn_Procesar.TabIndex = 8;
            this.btn_Procesar.Text = "Procesar";
            this.btn_Procesar.UseVisualStyleBackColor = true;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(496, 98);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(496, 158);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Procesar);
            this.Controls.Add(this.rb_Presencial);
            this.Controls.Add(this.rb_Virtual);
            this.Controls.Add(this.txt_Profesor);
            this.Controls.Add(this.txt_Asignatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Modalidad de clases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Asignatura;
        private System.Windows.Forms.TextBox txt_Profesor;
        private System.Windows.Forms.RadioButton rb_Virtual;
        private System.Windows.Forms.RadioButton rb_Presencial;
        private System.Windows.Forms.Button btn_Procesar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
    }
}

