using CuaHangBanThucAn.BLL;
using CuaHangBanThucAn.DTO;
using CuaHangBanThucAn.LIB;
using CuaHangBanThucAn.LIB.Error;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CuaHangBanThucAn.GUI.Food
{
    public partial class UCFood : UserControl
    {
        public UCFood()
        {
            InitializeComponent();
            lvProduct.ReadOnly = true;
            refresh();
            if(LoginBLL.UserLogin.role.permission=="STAFF")
            {
                groupDetail.Enabled = false;
                tabMenu.SelectedIndex = 1;
                tabMenu.TabPages["tabPage1"].Enabled = false;
            }    
        }
        private void show(int id)
        {
            try
            {
                ProductBLL productBLL = new ProductBLL();
                Product product = productBLL.Read(id);
                if (product.id == -1)
                {
                    return;
                }
                txtDID.Text = product.id.ToString();
                txtDName.Text = product.name.ToString();
                txtDStock.Text = product.stock.ToString();
                txtDPrice.Text = product.price.ToString();
                txtDDiscount.Text = product.discount.ToString();
                txtDLastPrice.Text = product.LastPrice().ToString();
                //Gắn comboxbox không được
                cbDType.SelectedIndex = cbDType.Items.Cast<TypeProduct>().ToList().FindIndex(a => a.id == product.typeProduct.id);

            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void checkEdit()
        {
            if (txtDID.Text.Length == 0)
            {
                throw new AppException(1, "Vui lòng chọn thực đơn");
            }
            if (txtDName.Text.Length == 0)
            {
                throw new AppException(1, "Tên không được để trống");
            }
            if (txtDStock.Text.Length == 0)
            { throw new AppException(1, "Số lượng không được để trống"); }
            if (txtDPrice.Text.Length == 0)
            { throw new AppException(1, "Giá tiền không được để trống"); }
            if (txtDDiscount.Text.Length == 0)
            {
                throw new AppException(1, "Giảm giá % không được để trống");
            }
            if (cbDType.Text.Length == 0)
            {
                throw new AppException(1, "Loại thực đơn không được để trống");
            }
            if (!Valid.isMoney(txtDPrice.Text)) throw new AppException(2, "Giá bán phải lớn hơn bằng 0 và là kiểu số nguyên");
            if (!Valid.isPercent(txtDDiscount.Text)) throw new AppException(2, "Giảm giá phải là kiểu số và nằm trong khoảng 0 đến 100");
            if (!Valid.isNumber(txtDStock.Text)) throw new AppException(2, "Số lượng phải là số nguyên và lớn hơn bằng 0");

        }
        private void checkAdd()
        {
            if (txtName.Text.Length == 0)
            {
                throw new AppException(1, "Tên không được để trống");
            }
            if (txtStock.Text.Length == 0)
            { throw new AppException(1, "Số lượng không được để trống"); }
            if (txtPrice.Text.Length == 0)
            { throw new AppException(1, "Giá tiền không được để trống"); }
            if (txtDiscount.Text.Length == 0)
            {
                throw new AppException(1, "Giảm giá % không được để trống");
            }
            if (cbType.Text.Length == 0)
            {
                throw new AppException(1, "Loại thực đơn không được để trống");
            }
            if (!Valid.isMoney(txtPrice.Text)) throw new AppException(2, "Giá bán phải lớn hơn bằng 0 và là kiểu số nguyên");
            if (!Valid.isPercent(txtDiscount.Text)) throw new AppException(2, "Giảm giá phải là kiểu số và nằm trong khoảng 0 đến 100");
            if (!Valid.isNumber(txtStock.Text)) throw new AppException(2, "Số lượng phải là số nguyên và lớn hơn bằng 0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                checkAdd();
                ProductBLL productBLL = new ProductBLL();
                Product temp = new Product(-1, txtName.Text, (TypeProduct)cbType.SelectedItem, long.Parse(txtPrice.Text), float.Parse(txtDiscount.Text), int.Parse(txtStock.Text), false);
                productBLL.Create(temp);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                refresh();
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void refresh()
        {
            cbType.DisplayMember = "name";
            cbType.ValueMember = "id";
            cbDType.DisplayMember = "name";
            cbDType.ValueMember = "id";
            TypeProductBLL typeProductBLL = new TypeProductBLL();
            cbType.DataSource = typeProductBLL.SearchAll();
            cbDType.DataSource = typeProductBLL.SearchAll();
            ProductBLL productBLL = new ProductBLL();
            showlist(productBLL.SearchAll());

        }
        private string calctxtLastPrice(string price, string discount)
        {
            if (!Valid.isPercent(discount))
            {
                return string.Empty;
            }
            else
            {
                return Product.LastPrice(long.Parse(price), float.Parse(discount)).ToString();
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
                txtLastPrice.Text = calctxtLastPrice(txtPrice.Text, txtDiscount.Text);
        }

        private void txtDPrice_TextChanged(object sender, EventArgs e)
        {
            txtDLastPrice.Text = calctxtLastPrice(txtDPrice.Text, txtDDiscount.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                checkEdit();
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Xác nhận thay đổi", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    ProductBLL productBLL = new ProductBLL();
                    Product temp = new Product(int.Parse(txtDID.Text), txtDName.Text, new TypeProduct(), long.Parse(txtDPrice.Text), float.Parse(txtDDiscount.Text), int.Parse(txtDStock.Text), false);
                    temp.typeProduct = (TypeProduct)cbDType.SelectedItem;
                    productBLL.Update(temp);
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
                    refresh();
                }
               
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDID.Text.Length == 0)
                {
                    throw new AppException(1, "Vui lòng chọn thực đơn");
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    ProductBLL productBLL = new ProductBLL();
                    productBLL.Delete(int.Parse(txtDID.Text));
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
                    refresh();
                }
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void showlist(List<Product> products)
        {
            lvProduct.Columns.Clear();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Tên", typeof(string));
            dataTable.Columns.Add("Loại", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Giá bán gốc", typeof(string));
            dataTable.Columns.Add("Giảm giá(%)", typeof(float));
            dataTable.Columns.Add("Giá bán", typeof(string));
            foreach (Product product in products)
            {
                dataTable.Rows.Add(product.id, product.name, product.typeProduct.name, product.stock, product.price.ToString(), product.discount, product.LastPrice().ToString());
            }
            lvProduct.DataSource = dataTable;
        }

        private void lvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                refresh();
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ProductBLL productBLL = new ProductBLL();
                showlist(productBLL.Search(txtSearch.Text));
            }
            catch (AppException ex)
            {
                MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void lvProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lvProduct.Rows[e.RowIndex].Selected = true;
            DataGridViewRow row = lvProduct.Rows[e.RowIndex];
            if (row != null)
            {
                if (row.Cells[0].Value != null)
                {
                    int value = int.Parse(row.Cells[0].Value.ToString());
                    show(value);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                try
                {
                    ProductBLL productBLL = new ProductBLL();
                    showlist(productBLL.Search(txtSearch.Text));
                }
                catch (AppException ex)
                {
                    MessageBox.Show(ex.message, "Thông báo", MessageBoxButtons.OK);
                }
        }
    }
}
