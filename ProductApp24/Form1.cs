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
            string name = txtName.Text;

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Моля, въведете коректна цена", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtQuantity.Text, out double quantity))
            {
                MessageBox.Show("Моля, въведете коректна количество", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = new Product(name, price, quantity);
            products.Add(product);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var product = dataGridView1.SelectedRows[0].DataBoundItem
                as Product;
            DialogResult dialog = MessageBox.Show("Сигурни ли сте, че искате да изтриете този запис?", "Сигурни ли сте?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                products.Remove(product);
            }
        }
    }
}
