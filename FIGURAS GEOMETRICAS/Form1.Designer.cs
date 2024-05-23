namespace FIGURAS_GEOMETRICAS
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
            groupBox1 = new GroupBox();
            CALC = new Button();
            LIMPIAR = new Button();
            label2 = new Label();
            ESFERA = new RadioButton();
            PRISMA = new RadioButton();
            CUBO = new RadioButton();
            CIRCULO = new RadioButton();
            DATOS = new TextBox();
            POLIIRREC = new RadioButton();
            POLIREG = new RadioButton();
            RECTANGULO = new RadioButton();
            TRIANGULO = new RadioButton();
            CUADRADO = new RadioButton();
            label1 = new Label();
            EXPORT = new Button();
            DUBUJAR = new Button();
            INFO = new Button();
            GUARDAR = new Button();
            IMAGEN = new PictureBox();
            INFORMACION = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IMAGEN).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CALC);
            groupBox1.Controls.Add(LIMPIAR);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ESFERA);
            groupBox1.Controls.Add(PRISMA);
            groupBox1.Controls.Add(CUBO);
            groupBox1.Controls.Add(CIRCULO);
            groupBox1.Controls.Add(DATOS);
            groupBox1.Controls.Add(POLIIRREC);
            groupBox1.Controls.Add(POLIREG);
            groupBox1.Controls.Add(RECTANGULO);
            groupBox1.Controls.Add(TRIANGULO);
            groupBox1.Controls.Add(CUADRADO);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(EXPORT);
            groupBox1.Controls.Add(DUBUJAR);
            groupBox1.Controls.Add(INFO);
            groupBox1.Controls.Add(GUARDAR);
            groupBox1.Location = new Point(22, 23);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(777, 323);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // CALC
            // 
            CALC.Location = new Point(595, 246);
            CALC.Margin = new Padding(5, 6, 5, 6);
            CALC.Name = "CALC";
            CALC.Size = new Size(125, 44);
            CALC.TabIndex = 16;
            CALC.Text = "CALCULAR";
            CALC.UseVisualStyleBackColor = true;
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(462, 246);
            LIMPIAR.Margin = new Padding(5, 6, 5, 6);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(125, 44);
            LIMPIAR.TabIndex = 15;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 202);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(409, 25);
            label2.TabIndex = 14;
            label2.Text = "INGRESA MEDIDA DEL LADO, ARISTA, RADIO ETC";
            // 
            // ESFERA
            // 
            ESFERA.AutoSize = true;
            ESFERA.Location = new Point(613, 135);
            ESFERA.Margin = new Padding(5, 6, 5, 6);
            ESFERA.Name = "ESFERA";
            ESFERA.Size = new Size(97, 29);
            ESFERA.TabIndex = 13;
            ESFERA.TabStop = true;
            ESFERA.Text = "ESFERA";
            ESFERA.UseVisualStyleBackColor = true;
            // 
            // PRISMA
            // 
            PRISMA.AutoSize = true;
            PRISMA.Location = new Point(493, 135);
            PRISMA.Margin = new Padding(5, 6, 5, 6);
            PRISMA.Name = "PRISMA";
            PRISMA.Size = new Size(101, 29);
            PRISMA.TabIndex = 12;
            PRISMA.TabStop = true;
            PRISMA.Text = "PRISMA";
            PRISMA.UseVisualStyleBackColor = true;
            // 
            // CUBO
            // 
            CUBO.AutoSize = true;
            CUBO.Location = new Point(400, 135);
            CUBO.Margin = new Padding(5, 6, 5, 6);
            CUBO.Name = "CUBO";
            CUBO.Size = new Size(84, 29);
            CUBO.TabIndex = 12;
            CUBO.TabStop = true;
            CUBO.Text = "CUBO";
            CUBO.UseVisualStyleBackColor = true;
            // 
            // CIRCULO
            // 
            CIRCULO.AutoSize = true;
            CIRCULO.Location = new Point(270, 135);
            CIRCULO.Margin = new Padding(5, 6, 5, 6);
            CIRCULO.Name = "CIRCULO";
            CIRCULO.Size = new Size(108, 29);
            CIRCULO.TabIndex = 11;
            CIRCULO.TabStop = true;
            CIRCULO.Text = "CÍRCULO";
            CIRCULO.UseVisualStyleBackColor = true;
            // 
            // DATOS
            // 
            DATOS.Location = new Point(462, 196);
            DATOS.Margin = new Padding(5, 6, 5, 6);
            DATOS.Name = "DATOS";
            DATOS.Size = new Size(121, 31);
            DATOS.TabIndex = 10;
            // 
            // POLIIRREC
            // 
            POLIIRREC.AutoSize = true;
            POLIIRREC.Location = new Point(15, 135);
            POLIIRREC.Margin = new Padding(5, 6, 5, 6);
            POLIIRREC.Name = "POLIIRREC";
            POLIIRREC.Size = new Size(224, 29);
            POLIIRREC.TabIndex = 9;
            POLIIRREC.TabStop = true;
            POLIIRREC.Text = "POLÍGONO IRREGULAR";
            POLIIRREC.UseVisualStyleBackColor = true;
            // 
            // POLIREG
            // 
            POLIREG.AutoSize = true;
            POLIREG.Location = new Point(493, 90);
            POLIREG.Margin = new Padding(5, 6, 5, 6);
            POLIREG.Name = "POLIREG";
            POLIREG.Size = new Size(208, 29);
            POLIREG.TabIndex = 8;
            POLIREG.TabStop = true;
            POLIREG.Text = "POLÍGONO REGULAR";
            POLIREG.UseVisualStyleBackColor = true;
            // 
            // RECTANGULO
            // 
            RECTANGULO.AutoSize = true;
            RECTANGULO.Location = new Point(318, 90);
            RECTANGULO.Margin = new Padding(5, 6, 5, 6);
            RECTANGULO.Name = "RECTANGULO";
            RECTANGULO.Size = new Size(146, 29);
            RECTANGULO.TabIndex = 7;
            RECTANGULO.TabStop = true;
            RECTANGULO.Text = "RECTÁNGULO";
            RECTANGULO.UseVisualStyleBackColor = true;
            // 
            // TRIANGULO
            // 
            TRIANGULO.AutoSize = true;
            TRIANGULO.Location = new Point(167, 90);
            TRIANGULO.Margin = new Padding(5, 6, 5, 6);
            TRIANGULO.Name = "TRIANGULO";
            TRIANGULO.Size = new Size(132, 29);
            TRIANGULO.TabIndex = 6;
            TRIANGULO.TabStop = true;
            TRIANGULO.Text = "TRIÁNGULO";
            TRIANGULO.UseVisualStyleBackColor = true;
            // 
            // CUADRADO
            // 
            CUADRADO.AutoSize = true;
            CUADRADO.Location = new Point(15, 90);
            CUADRADO.Margin = new Padding(5, 6, 5, 6);
            CUADRADO.Name = "CUADRADO";
            CUADRADO.Size = new Size(135, 29);
            CUADRADO.TabIndex = 5;
            CUADRADO.TabStop = true;
            CUADRADO.Text = "CUADRADO";
            CUADRADO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 31);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(567, 29);
            label1.TabIndex = 4;
            label1.Text = "CONSTRUCTOR DE FIGURAS GEOMÉTRICAS";
            // 
            // EXPORT
            // 
            EXPORT.Location = new Point(318, 246);
            EXPORT.Margin = new Padding(5, 6, 5, 6);
            EXPORT.Name = "EXPORT";
            EXPORT.Size = new Size(125, 44);
            EXPORT.TabIndex = 3;
            EXPORT.Text = "EXPORTAR";
            EXPORT.UseVisualStyleBackColor = true;
            // 
            // DUBUJAR
            // 
            DUBUJAR.Location = new Point(183, 246);
            DUBUJAR.Margin = new Padding(5, 6, 5, 6);
            DUBUJAR.Name = "DUBUJAR";
            DUBUJAR.Size = new Size(125, 44);
            DUBUJAR.TabIndex = 2;
            DUBUJAR.Text = "DIBUJAR";
            DUBUJAR.UseVisualStyleBackColor = true;
            // 
            // INFO
            // 
            INFO.Location = new Point(18, 246);
            INFO.Margin = new Padding(5, 6, 5, 6);
            INFO.Name = "INFO";
            INFO.Size = new Size(155, 44);
            INFO.TabIndex = 1;
            INFO.Text = "INFORMACIÓN";
            INFO.UseVisualStyleBackColor = true;
            // 
            // GUARDAR
            // 
            GUARDAR.Location = new Point(595, 190);
            GUARDAR.Margin = new Padding(5, 6, 5, 6);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(125, 44);
            GUARDAR.TabIndex = 0;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = true;
            // 
            // IMAGEN
            // 
            IMAGEN.Location = new Point(22, 358);
            IMAGEN.Margin = new Padding(5, 6, 5, 6);
            IMAGEN.Name = "IMAGEN";
            IMAGEN.Size = new Size(430, 485);
            IMAGEN.TabIndex = 1;
            IMAGEN.TabStop = false;
            // 
            // INFORMACION
            // 
            INFORMACION.Location = new Point(462, 358);
            INFORMACION.Margin = new Padding(5, 6, 5, 6);
            INFORMACION.Name = "INFORMACION";
            INFORMACION.Size = new Size(334, 481);
            INFORMACION.TabIndex = 2;
            INFORMACION.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 957);
            Controls.Add(INFORMACION);
            Controls.Add(IMAGEN);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "BIENVENID@";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IMAGEN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CALC;
        private Button LIMPIAR;
        private Label label2;
        private RadioButton ESFERA;
        private RadioButton PRISMA;
        private RadioButton CUBO;
        private RadioButton CIRCULO;
        private TextBox DATOS;
        private RadioButton POLIIRREC;
        private RadioButton POLIREG;
        private RadioButton RECTANGULO;
        private RadioButton TRIANGULO;
        private RadioButton CUADRADO;
        private Label label1;
        private Button EXPORT;
        private Button DUBUJAR;
        private Button INFO;
        private Button GUARDAR;
        private PictureBox IMAGEN;
        private RichTextBox INFORMACION;
    }
}