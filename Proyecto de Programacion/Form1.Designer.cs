namespace Proyecto_de_Programacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Boton_agregar = new Button();
            label1 = new Label();
            button2Mostrar_Biblioteca = new Button();
            SuspendLayout();
            // 
            // Boton_agregar
            // 
            Boton_agregar.Location = new Point(199, 129);
            Boton_agregar.Name = "Boton_agregar";
            Boton_agregar.Size = new Size(152, 74);
            Boton_agregar.TabIndex = 0;
            Boton_agregar.Text = "Argegar Libro";
            Boton_agregar.UseVisualStyleBackColor = true;
            Boton_agregar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 30);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu de tu biblioteca";
            label1.Click += label1_Click;
            // 
            // button2Mostrar_Biblioteca
            // 
            button2Mostrar_Biblioteca.Location = new Point(199, 251);
            button2Mostrar_Biblioteca.Name = "button2Mostrar_Biblioteca";
            button2Mostrar_Biblioteca.Size = new Size(152, 74);
            button2Mostrar_Biblioteca.TabIndex = 2;
            button2Mostrar_Biblioteca.Text = "Mostrar biblioteca";
            button2Mostrar_Biblioteca.UseVisualStyleBackColor = true;
            button2Mostrar_Biblioteca.Click += button2Mostrar_Biblioteca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 480);
            Controls.Add(button2Mostrar_Biblioteca);
            Controls.Add(label1);
            Controls.Add(Boton_agregar);
            HelpButton = true;
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Boton_agregar;
        private Label label1;
        private Button button2Mostrar_Biblioteca;
    }
}
