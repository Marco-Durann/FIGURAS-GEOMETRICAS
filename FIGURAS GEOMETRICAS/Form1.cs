using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace FIGURAS_GEOMETRICAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CUADRADO_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C://TRABAJOS DE POO I 3er SEMESTRE\\IMAGENES DE FIGURAS GEOMETRICAS//CUADRADO.png";
            IMAGEN.BackgroundImage = Image.FromFile(rutaImagen);
            RECTANGULO.Visible = false;
            TRIANGULO.Visible = false;
            POLIREG.Visible = false;
            POLIIRREC.Visible = false;
            CIRCULO.Visible = false;
            CUADRADO.Visible = true;
            CUBO.Visible = false;
            PRISMA.Visible = false;
            ESFERA.Visible = false;
            DATOS.Visible = true;

        }

        private void TRIANGULO_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES DE FIGURAS GEOMETRICAS//TRIANGULO.png";
            IMAGEN.BackgroundImage = Image.FromFile(rutaImagen);
            RECTANGULO.Visible = false;
            TRIANGULO.Visible = true;
            POLIREG.Visible = false;
            POLIIRREC.Visible = false;
            CIRCULO.Visible = false;
            CUADRADO.Visible = false;
            CUBO.Visible = false;
            PRISMA.Visible = false;
            ESFERA.Visible = false;
            DATOS.Visible = true;
        }

        private void IMAGEN_Click(object sender, EventArgs e)
        {

        }

        private void RECTANGULO_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES DE FIGURAS GEOMETRICAS//RECTANGULO.png";
            IMAGEN.BackgroundImage = Image.FromFile("C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES DE FIGURAS GEOMETRICAS//RECTANGULO.png");
            RECTANGULO.Visible = true;
            TRIANGULO.Visible = false;
            POLIREG.Visible = false;
            POLIIRREC.Visible = false;
            CIRCULO.Visible = false;
            CUADRADO.Visible = false;
            CUBO.Visible = false;
            PRISMA.Visible = false;
            ESFERA.Visible = false;
            DATOS.Visible = true;

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {

        }
    }
}