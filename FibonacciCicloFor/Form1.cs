using System.Windows.Forms;

namespace FibonacciCicloFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            int x = 1, y = 0;
            int resultado;
            int n = int.Parse(numberInput.Text);


            Console.Out.WriteLine(1);
            for (int contador = 0; contador < n; contador++)
            {
                resultado = x + y;
                Console.Out.WriteLine(resultado);
                    y = x;
                    x = resultado;
                MessageBox.Show(x.ToString());
            }

        }
    }
}