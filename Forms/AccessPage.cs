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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Contoh logika ambil data member saat combobox berubah
            if (comboBox1.SelectedItem != null)
            {
                // Misal ambil nama member
                string selectedMember = comboBox1.SelectedItem.ToString();
                label3.Text = $"Nama: {selectedMember}";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Contoh logika: jika item pertama ("Grant All") dicentang, maka semua akan dicentang
            if (listBox1.GetSelected(0))
            {
                for (int i = 1; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, true);
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
                string accessList = string.Join(", ", listBox1.SelectedItems.Cast<string>());

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Pilih member terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  
                }

                string selectedMember = comboBox1.SelectedItem.ToString();

                // Simulasi simpan ke database (bisa ganti dengan logika nyata)
                await Task.Delay(500);

                MessageBox.Show($"Akses untuk '{selectedMember}' disimpan:\n{accessList}", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Bersihkan form setelah submit
                comboBox1.SelectedIndex = -1;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
