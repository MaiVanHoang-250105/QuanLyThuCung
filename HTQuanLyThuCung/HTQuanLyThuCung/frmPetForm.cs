using System;
using System.Drawing;
using System.Windows.Forms;
using static QuanLyThuCung.frmKhachHang;

namespace QuanLyThuCung
{
    public partial class frmPetForm : Form
    {
        private Pet editingPet;

        public frmPetForm(Pet pet, bool isAddMode)
        {
            this.editingPet = pet;
            InitializeComponent();

            if (!isAddMode && pet != null)
            {
                LoadPetData();
            }
        }

        private void LoadPetData()
        {
            if (editingPet != null)
            {
                txtPetName.Text = editingPet.Name;
                cmbType.Text = editingPet.Type;
                txtBreed.Text = editingPet.Breed;
                numAge.Value = editingPet.Age;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPetName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thú cưng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPetName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbType.Text))
            {
                MessageBox.Show("Vui lòng chọn loại thú cưng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbType.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Pet GetPetData()
        {
            return new Pet
            {
                Name = txtPetName.Text.Trim(),
                Type = cmbType.Text,
                Breed = txtBreed.Text.Trim(),
                Age = (int)numAge.Value
            };
        }
    }
}