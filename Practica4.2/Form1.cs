using Practica4._2.Entities;

namespace Practica4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tienda SuperAki = new Tienda();
        private void button1_Click(object sender, EventArgs e)
        {
            SuperAki.AgregarProducto();
            int Lastindex = SuperAki.Productos.Count - 1;
            Producto ultimoProducto = SuperAki.Productos[Lastindex];
            listBox1.Items.Add($"Clave:{ultimoProducto.Clave} | {ultimoProducto.Nombre} cuesta ${ultimoProducto.Precio}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            SuperAki.Ordenar();
            foreach (Producto producto in SuperAki.ProductosOrdenados)
            {
                listBox2.Items.Add($"{producto.Nombre} cuesta ${producto.Precio}");
            }
            listBox3.Items.Add($"${SuperAki.CalcularCostoTotal()}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int clave = int.Parse(textBox1.Text);
            SuperAki.EliminarProducto(clave);
            foreach (Producto producto in SuperAki.Productos)
            {
                listBox1.Items.Add($"{producto.Nombre} cuesta ${producto.Precio}");
            }
            textBox1.Clear();
        }
    }
}