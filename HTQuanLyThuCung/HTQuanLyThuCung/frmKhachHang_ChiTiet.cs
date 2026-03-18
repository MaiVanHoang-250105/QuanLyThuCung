using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static QuanLyThuCung.frmKhachHang;

namespace QuanLyThuCung
{
    public partial class frmKhachHang_ChiTiet : Form
    {
        private Customer customer;
        private List<PurchaseHistory> purchaseHistories;
        private List<Pet> customerPets;
        private frmKhachHang parentForm;
        private bool isEditMode = false;

        public frmKhachHang_ChiTiet(Customer customer, List<PurchaseHistory> histories, List<Pet> pets, frmKhachHang parent)
        {
            InitializeComponent();
            this.customer = customer;
            this.purchaseHistories = histories;
            this.customerPets = pets;
            this.parentForm = parent;
            LoadData();
            LoadPetList();
        }

        private void LoadData()
        {
            txtName.Text = customer.Name;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            txtOtherInfo.Text = customer.OtherInfo;

            dgvPurchaseHistory.Rows.Clear();
            foreach (var history in purchaseHistories)
            {
                int rowIndex = dgvPurchaseHistory.Rows.Add();
                dgvPurchaseHistory.Rows[rowIndex].Cells["colInvoiceId"].Value = history.InvoiceId;
                dgvPurchaseHistory.Rows[rowIndex].Cells["colDate"].Value = history.Date.ToString("dd/MM/yyyy HH:mm:ss");
                dgvPurchaseHistory.Rows[rowIndex].Cells["colTotal"].Value = history.TotalAmount.ToString("N0") + "đ";
                dgvPurchaseHistory.Rows[rowIndex].Cells["colEmployee"].Value = history.Employee;
            }

            SetReadOnlyMode(true);
        }

        private void LoadPetList()
        {
            dgvPets.Rows.Clear();

            foreach (var pet in customerPets)
            {
                int rowIndex = dgvPets.Rows.Add();
                dgvPets.Rows[rowIndex].Cells["colPetId"].Value = pet.Id;
                dgvPets.Rows[rowIndex].Cells["colPetName"].Value = pet.Name;
                dgvPets.Rows[rowIndex].Cells["colPetType"].Value = pet.Type;
                dgvPets.Rows[rowIndex].Cells["colPetBreed"].Value = pet.Breed;
                dgvPets.Rows[rowIndex].Cells["colPetAge"].Value = pet.Age;
                dgvPets.Rows[rowIndex].Cells["colPetEdit"].Value = "✏️";
                dgvPets.Rows[rowIndex].Cells["colPetDelete"].Value = "🗑";
            }
        }

        private void SetReadOnlyMode(bool readOnly)
        {
            txtName.ReadOnly = readOnly;
            txtPhone.ReadOnly = readOnly;
            txtAddress.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtOtherInfo.ReadOnly = readOnly;

            if (readOnly)
            {
                txtName.BackColor = Color.FromArgb(220, 220, 220);
                txtPhone.BackColor = Color.FromArgb(220, 220, 220);
                txtAddress.BackColor = Color.FromArgb(220, 220, 220);
                txtEmail.BackColor = Color.FromArgb(220, 220, 220);
                txtOtherInfo.BackColor = Color.FromArgb(220, 220, 220);
                btnEdit.Text = "Sửa";
                btnEdit.BackColor = Color.FromArgb(76, 175, 80);
            }
            else
            {
                txtName.BackColor = Color.White;
                txtPhone.BackColor = Color.White;
                txtAddress.BackColor = Color.White;
                txtEmail.BackColor = Color.White;
                txtOtherInfo.BackColor = Color.White;
                btnEdit.Text = "Lưu";
                btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                customer.Name = txtName.Text.Trim();
                customer.Phone = txtPhone.Text.Trim();
                customer.Address = txtAddress.Text.Trim();
                customer.Email = txtEmail.Text.Trim();
                customer.OtherInfo = txtOtherInfo.Text.Trim();

                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                isEditMode = false;
                SetReadOnlyMode(true);
            }
            else
            {
                isEditMode = true;
                SetReadOnlyMode(false);
                txtName.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ✅ Thêm thú cưng
        private void btnAddPet_Click(object sender, EventArgs e)
        {
            frmPetForm petForm = new frmPetForm(null, true); // true = chế độ thêm
            if (petForm.ShowDialog() == DialogResult.OK)
            {
                Pet newPet = petForm.GetPetData();
                newPet.CustomerId = customer.Id;
                newPet.Id = GetNextPetId();

                customerPets.Add(newPet);
                LoadPetList();

                // Cập nhật lại danh sách pets ở form cha
                parentForm.RefreshPetList(customer.Id, customerPets);

                MessageBox.Show("Thêm thú cưng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ✅ Sửa thú cưng
        private void dgvPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPets.Columns[e.ColumnIndex].Name == "colPetEdit")
            {
                int petId = Convert.ToInt32(dgvPets.Rows[e.RowIndex].Cells["colPetId"].Value);
                EditPet(petId);
            }
            else if (dgvPets.Columns[e.ColumnIndex].Name == "colPetDelete")
            {
                int petId = Convert.ToInt32(dgvPets.Rows[e.RowIndex].Cells["colPetId"].Value);
                DeletePet(petId);
            }
        }

        private void EditPet(int petId)
        {
            Pet pet = customerPets.Find(p => p.Id == petId);
            if (pet == null) return;

            frmPetForm petForm = new frmPetForm(pet, false); // false = chế độ sửa
            if (petForm.ShowDialog() == DialogResult.OK)
            {
                Pet updatedPet = petForm.GetPetData();
                updatedPet.Id = pet.Id;
                updatedPet.CustomerId = customer.Id;

                // Cập nhật trong list
                int index = customerPets.FindIndex(p => p.Id == petId);
                if (index >= 0)
                    customerPets[index] = updatedPet;

                LoadPetList();
                parentForm.RefreshPetList(customer.Id, customerPets);

                MessageBox.Show("Cập nhật thú cưng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeletePet(int petId)
        {
            Pet pet = customerPets.Find(p => p.Id == petId);
            if (pet == null) return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa thú cưng \"{pet.Name}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                customerPets.RemoveAll(p => p.Id == petId);
                LoadPetList();
                parentForm.RefreshPetList(customer.Id, customerPets);

                MessageBox.Show("Xóa thú cưng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetNextPetId()
        {
            return customerPets.Count > 0 ? customerPets.Max(p => p.Id) + 1 : 1;
        }
    }
}