namespace Aula05MaquinaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            


        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

           

        }

        private static double saldo;

        private static double soma;



        private void btnSaldo_Click(object sender, EventArgs e)
        {
            saldo = (double.Parse(txtValor.Text));
            //bl_Saldo.Text = $"{saldo}";
            double valor = double.Parse(lbl_Saldo.Text);

            soma = saldo + valor;
            lbl_Saldo.Text = $"{soma}";
         


        }

        private void btnDoritos_Click(object sender, EventArgs e)
        {
            if (soma < 5)
            {
                MessageBox.Show("Sinto muito, você não tem saldo suficiente para realizar a compra");
            }
            if (soma >= 5)
            {
                soma = soma - 5;
                lbl_Saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }

        private void btnRuffles_Click(object sender, EventArgs e)
        {
            if (soma < 4.50)
            {
                MessageBox.Show("Sinto muito, você não tem saldo suficiente para realizar a compra");
            }
            if (soma >= 4.50)
            {
                soma = soma - 4.50;
                lbl_Saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso!");
            }

        }

        private void btnSuflair_Click(object sender, EventArgs e)
        {
            if (soma < 4)
            {
                MessageBox.Show("Sinto muito, você não tem saldo suficiente para realizar a compra");
            }
            if (soma >= 4)
            {
                soma = soma - 4;
                lbl_Saldo.Text = $"{saldo}";
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }

        private void btnChokito_Click(object sender, EventArgs e)
        {
            if (soma < 3.50)
            {
                MessageBox.Show("Sinto muito, você não tem saldo suficiente para realizar a compra");
            }
            if (soma >= 3.50)
            {
                soma = soma - 3.50;
                lbl_Saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }

        private void btnMiniOreo_Click(object sender, EventArgs e)
        {
            if (soma < 6)
            {
                MessageBox.Show("Sinto muito, você não tem saldo suficiente para realizar a compra");
            }
            if (soma >= 6)
            {
                soma = soma - 6;
                lbl_Saldo.Text = $"{saldo}";
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }

        private void btnPringles_Click(object sender, EventArgs e)
        {
            if (soma < 6.50)
            {
                MessageBox.Show("Sinto muito, você não tem saldo suficiente para realizar a compra");
            }
            if (soma >= 6.50)
            {
                soma = soma - 6.50;
                lbl_Saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }

        private void btnCookies_Click(object sender, EventArgs e)
        {
            if (soma < 5)
            {
                MessageBox.Show("Sinto muito, você não tem saldo suficiente para realizar a compra");
            }
            if (soma >= 5)
            {
                soma = soma - 5;
                lbl_Saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }

        private void btnFini_Click(object sender, EventArgs e)
        {
            if (soma < 2)
            {
                MessageBox.Show("Sinto muito, você não tem saldo suficiente para realizar a compra");
            }
            if (soma >= 2)
            {
                soma = soma - 2;
                lbl_Saldo.Text = $"{soma}";
                MessageBox.Show("Compra realizada com sucesso!");
            }
        }
    }
}