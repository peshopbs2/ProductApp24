using System.ComponentModel;

namespace ProductApp24
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products
            = new BindingList<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = products;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                double price = double.Parse(txtPrice.Text);
                double quantity = double.Parse(txtQuantity.Text);
                Product product = new Product(name, price, quantity);
                products.Add(product);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("����, �������� �������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var product = dataGridView1.SelectedRows[0].DataBoundItem
                as Product;
            DialogResult dialog = MessageBox.Show("������� �� ���, �� ������ �� �������� ���� �����?", "������� �� ���?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                products.Remove(product);
            }
        }
    }
}
