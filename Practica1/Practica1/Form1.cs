namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                Triangulo triangulito = new Triangulo(a, b, c);
                labelResultado.Text = Convert.ToString(triangulito.perimetro());

                double d = double.Parse(textBox4.Text);
                double g = double.Parse(textBox5.Text);
                Cuadrangulo cuadrito = new Cuadrangulo(d, g);
                labelResultadoC.Text = Convert.ToString(cuadrito.perimetro());

                double f = double.Parse(textBox7.Text);
                Circulo circulito = new Circulo(f);
                labelResultadoCirc.Text = Convert.ToString(circulito.perimetro());
            }
            catch (Exception)
            {
                MessageBox.Show("Favor de insertar valores numéricos en todos los cuadros", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                Triangulo triangulito = new Triangulo(a, b, c);
                labelResultado.Text = Convert.ToString(triangulito.area());

                double d = double.Parse(textBox4.Text);
                double g = double.Parse(textBox5.Text);
                Cuadrangulo cuadrito = new Cuadrangulo(d, g);
                labelResultadoC.Text = Convert.ToString(cuadrito.area());

                double f = double.Parse(textBox7.Text);
                Circulo circulito = new Circulo(f);
                labelResultadoCirc.Text = Convert.ToString(circulito.area());
            }
            catch (Exception)
            {
                MessageBox.Show("Favor de insertar valores numéricos en todos los cuadros", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
    public abstract class Figura
    {
        public abstract double area();
        public abstract double perimetro();
    }
    public class Triangulo : Figura
    {
        double ladoA, ladoB, ladoC;
        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }
        public override double area()
        {
            double areaTri;
            double S = (ladoA + ladoB + ladoC) / 2; // S = semiperimetro
            areaTri = Math.Sqrt(S * (S - ladoA) * (S - ladoB) * (S - ladoC));
            return areaTri;
        }
        public override double perimetro()
        {
            double pTri;
            pTri = ladoA + ladoB + ladoC;
            return pTri;
        }
    }
    public class Cuadrangulo : Figura
    {
        double ancho, alto;
        public Cuadrangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
        public override double area()
        {
            double areaCuad;
            areaCuad = ancho * alto;
            return areaCuad;
        }
        public override double perimetro()
        {
            double pCuad;
            pCuad = (ancho * 2) + (alto * 2);
            return pCuad;
        }
    }

    public class Circulo : Figura
    {
        double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override double area()
        {
            double areaCirc;
            areaCirc = Math.PI * (Math.Pow(radio, 2));
            return areaCirc;
        }
        public override double perimetro()
        {
            double pCirc;
            pCirc = Math.PI * (radio * 2);
            return pCirc;
        }

    }
}