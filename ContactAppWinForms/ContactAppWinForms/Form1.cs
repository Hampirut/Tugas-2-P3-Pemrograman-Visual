using System;
using System.Windows.Forms;

namespace ContactAppWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event untuk menambahkan kontak ke DataGridView
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Harap isi Nama, Email, dan Telepon!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewContacts.Rows.Add(txtName.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text);

            // Kosongkan input setelah ditambahkan
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtName.Focus();
        }

        // Event untuk menghapus kontak yang dipilih dari DataGridView
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewContacts.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewContacts.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridViewContacts.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event untuk keluar dari aplikasi
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
