using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KoperasiBadBoy.Forms
{
    public partial class AccessPage : UserControl
    {
        public AccessPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Contoh logika ambil data member saat combobox berubah
            if (cbMember.SelectedItem != null)
            {
                // Misal ambil nama member
                string selectedMember = cbMember.SelectedItem.ToString();
                labelFullName.Text = $"Nama: {selectedMember}";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Contoh logika: jika item pertama ("Grant All") dicentang, maka semua akan dicentang
            if (LbGrup.GetSelected(0))
            {
                for (int i = 1; i < LbGrup.Items.Count; i++)
                {
                    LbGrup.SetSelected(i, true);
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Misal logika sederhana menyimpan akses member
                string accessList = string.Join(", ", LbGrup.SelectedItems.Cast<string>());

                if (cbMember.SelectedItem == null)
                {
                    MessageBox.Show("Pilih member terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedMember = cbMember.SelectedItem.ToString();

                // Simulasi simpan ke database (bisa ganti dengan logika nyata)
                await Task.Delay(500);

                MessageBox.Show($"Akses untuk '{selectedMember}' disimpan:\n{accessList}", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Bersihkan form setelah submit
                cbMember.SelectedIndex = -1;
                for (int i = 0; i < LbGrup.Items.Count; i++)
                {
                    LbGrup.SetSelected(i, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAccess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
