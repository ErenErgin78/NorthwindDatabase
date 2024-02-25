using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();

            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadDatabase();
        }

        private void LoadCategory()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";


            KategoriAdd.DataSource = _categoryService.GetAll();
            KategoriAdd.DisplayMember = "CategoryName";
            KategoriAdd.ValueMember = "CategoryId";


            CategoryUpdate.DataSource = _categoryService.GetAll();
            CategoryUpdate.DisplayMember = "CategoryName";
            CategoryUpdate.ValueMember = "CategoryId";
        }

        private void LoadDatabase() { DgwProducts.DataSource = _productService.GetAll(); }

        private void CbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategory.SelectedItem is Category selectedCategory)
            {
                int categoryId = selectedCategory.CategoryID;
                DgwProducts.DataSource = _productService.GetProductsByCategory(categoryId);
            }

        }

        private void IsimTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IsimTxt.Text))
            {
                DgwProducts.DataSource = _productService.GetProductsByName(IsimTxt.Text);
            }
            else { DgwProducts.DataSource = _productService.GetAll(); }
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
     
            {
                try
                {
                    _productService.Add(new Product
                    {
                        CategoryId = Convert.ToInt32(KategoriAdd.SelectedValue),
                        ProductName = NameAdd.Text,
                        QuantityPerUnit = StokBasýnaAdetAdd.Text,
                        UnitPrice = Convert.ToDecimal(FiyatAdd.Text),
                        UnitsInStock = Convert.ToInt16(StokAdd.Text)
                    });
                    LoadDatabase();
                }
                catch (Exception exception)
                {
                    if (exception.Message == "The input string '' was not in a correct format.")
                    { MessageBox.Show("You left one or more fields blank"); }
                    else { MessageBox.Show(exception.Message); }
                }
            }
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(DgwProducts.CurrentRow.Cells[0].Value),
                    ProductName = NameUpdateTxt.Text,
                    CategoryId = Convert.ToInt32(CategoryUpdate.SelectedValue),
                    QuantityPerUnit = QPerUnitUpdateTxt.Text,
                    UnitPrice = Convert.ToDecimal(PriceUpdateTxt.Text),
                    UnitsInStock = Convert.ToInt16(StockUpdateTxt.Text)
                });
                LoadDatabase();
            }
            catch (Exception exception)
            {
                if (exception.Message == "The input string '' was not in a correct format.")
                { MessageBox.Show("You left one or more fields blank"); }
                else { MessageBox.Show(exception.Message); }
            }

        }

        private void DgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryUpdate.SelectedValue = DgwProducts.CurrentRow.Cells[1].Value;

            NameUpdateTxt.Text = DgwProducts.CurrentRow.Cells[2].Value.ToString();

            PriceUpdateTxt.Text = DgwProducts.CurrentRow.Cells[3].Value.ToString();

            StockUpdateTxt.Text = DgwProducts.CurrentRow.Cells[4].Value.ToString();

            QPerUnitUpdateTxt.Text = DgwProducts.CurrentRow.Cells[5].Value.ToString();
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Delete(new Product { ProductId = Convert.ToInt32(DgwProducts.CurrentRow.Cells[0].Value) });
                LoadDatabase();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadDatabase();
        }
    }
}
