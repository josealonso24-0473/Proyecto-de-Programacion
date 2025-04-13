namespace Proyecto_de_Programacion
{
    partial class Form2
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
            Insertar_al_SQL = new Button();
            textBoxNombre_libro = new TextBox();
            textBoxAutor = new TextBox();
            textBoxGenero = new TextBox();
            textBoxFecha_guardado = new TextBox();
            Nombre__libro = new Label();
            label1Autor = new Label();
            label2Genero = new Label();
            label3Fecha_Hoy = new Label();
            label1como_se_pone_la_fecha = new Label();
            SuspendLayout();
            // 
            // Insertar_al_SQL
            // 
            Insertar_al_SQL.Location = new Point(638, 354);
            Insertar_al_SQL.Name = "Insertar_al_SQL";
            Insertar_al_SQL.Size = new Size(94, 29);
            Insertar_al_SQL.TabIndex = 0;
            Insertar_al_SQL.Text = "Aceptar";
            Insertar_al_SQL.UseVisualStyleBackColor = true;
            Insertar_al_SQL.Click += Insertar_al_SQL_Click;
            // 
            // textBoxNombre_libro
            // 
            textBoxNombre_libro.Location = new Point(227, 59);
            textBoxNombre_libro.Name = "textBoxNombre_libro";
            textBoxNombre_libro.Size = new Size(125, 27);
            textBoxNombre_libro.TabIndex = 1;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(227, 114);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(125, 27);
            textBoxAutor.TabIndex = 2;
            // 
            // textBoxGenero
            // 
            textBoxGenero.Location = new Point(227, 166);
            textBoxGenero.Name = "textBoxGenero";
            textBoxGenero.Size = new Size(125, 27);
            textBoxGenero.TabIndex = 3;
            // 
            // textBoxFecha_guardado
            // 
            textBoxFecha_guardado.Location = new Point(227, 231);
            textBoxFecha_guardado.Name = "textBoxFecha_guardado";
            textBoxFecha_guardado.Size = new Size(125, 27);
            textBoxFecha_guardado.TabIndex = 4;
            // 
            // Nombre__libro
            // 
            Nombre__libro.AutoSize = true;
            Nombre__libro.Location = new Point(54, 62);
            Nombre__libro.Name = "Nombre__libro";
            Nombre__libro.Size = new Size(110, 20);
            Nombre__libro.TabIndex = 5;
            Nombre__libro.Text = "Titulo del Libro";
            // 
            // label1Autor
            // 
            label1Autor.AutoSize = true;
            label1Autor.Location = new Point(54, 121);
            label1Autor.Name = "label1Autor";
            label1Autor.Size = new Size(46, 20);
            label1Autor.TabIndex = 6;
            label1Autor.Text = "Autor";
            label1Autor.Click += label1_Click;
            // 
            // label2Genero
            // 
            label2Genero.AutoSize = true;
            label2Genero.Location = new Point(54, 173);
            label2Genero.Name = "label2Genero";
            label2Genero.Size = new Size(57, 20);
            label2Genero.TabIndex = 7;
            label2Genero.Text = "Genero";
            // 
            // label3Fecha_Hoy
            // 
            label3Fecha_Hoy.AutoSize = true;
            label3Fecha_Hoy.Location = new Point(54, 234);
            label3Fecha_Hoy.Name = "label3Fecha_Hoy";
            label3Fecha_Hoy.Size = new Size(99, 20);
            label3Fecha_Hoy.TabIndex = 8;
            label3Fecha_Hoy.Text = "Fecha de Hoy";
            // 
            // label1como_se_pone_la_fecha
            // 
            label1como_se_pone_la_fecha.AutoSize = true;
            label1como_se_pone_la_fecha.Location = new Point(241, 261);
            label1como_se_pone_la_fecha.Name = "label1como_se_pone_la_fecha";
            label1como_se_pone_la_fecha.Size = new Size(93, 20);
            label1como_se_pone_la_fecha.TabIndex = 9;
            label1como_se_pone_la_fecha.Text = "dd-mm-yyyy";
            label1como_se_pone_la_fecha.Click += label1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1como_se_pone_la_fecha);
            Controls.Add(label3Fecha_Hoy);
            Controls.Add(label2Genero);
            Controls.Add(label1Autor);
            Controls.Add(Nombre__libro);
            Controls.Add(textBoxFecha_guardado);
            Controls.Add(textBoxGenero);
            Controls.Add(textBoxAutor);
            Controls.Add(textBoxNombre_libro);
            Controls.Add(Insertar_al_SQL);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Insertar_al_SQL;
        private TextBox textBoxNombre_libro;
        private TextBox textBoxAutor;
        private TextBox textBoxGenero;
        private TextBox textBoxFecha_guardado;
        private Label Nombre__libro;
        private Label label1Autor;
        private Label label2Genero;
        private Label label3Fecha_Hoy;
        private Label label1como_se_pone_la_fecha;
    }
}