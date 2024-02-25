namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgwProducts = new DataGridView();
            IsimTxt = new TextBox();
            Kategorilbl = new Label();
            Isımlbl = new Label();
            Aramabox = new GroupBox();
            button1 = new Button();
            cbxCategory = new ComboBox();
            EklemeBox = new GroupBox();
            EkleBtn = new Button();
            KategoriAdd = new ComboBox();
            StokBasınaAdetAdd = new TextBox();
            StokAdd = new TextBox();
            FiyatAdd = new TextBox();
            NameAdd = new TextBox();
            UpdateBox = new GroupBox();
            UpdateBtn = new Button();
            CategoryUpdate = new ComboBox();
            QPerUnitUpdateTxt = new TextBox();
            StockUpdateTxt = new TextBox();
            PriceUpdateTxt = new TextBox();
            NameUpdateTxt = new TextBox();
            SilBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DgwProducts).BeginInit();
            Aramabox.SuspendLayout();
            EklemeBox.SuspendLayout();
            UpdateBox.SuspendLayout();
            SuspendLayout();
            // 
            // DgwProducts
            // 
            DgwProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgwProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgwProducts.Location = new Point(51, 296);
            DgwProducts.Name = "DgwProducts";
            DgwProducts.Size = new Size(707, 267);
            DgwProducts.TabIndex = 0;
            DgwProducts.CellClick += DgwProducts_CellClick;
            // 
            // IsimTxt
            // 
            IsimTxt.Location = new Point(130, 123);
            IsimTxt.Name = "IsimTxt";
            IsimTxt.Size = new Size(131, 23);
            IsimTxt.TabIndex = 2;
            IsimTxt.TextChanged += IsimTxt_TextChanged;
            // 
            // Kategorilbl
            // 
            Kategorilbl.AutoSize = true;
            Kategorilbl.Font = new Font("Segoe UI", 12F);
            Kategorilbl.Location = new Point(20, 54);
            Kategorilbl.Name = "Kategorilbl";
            Kategorilbl.Size = new Size(71, 21);
            Kategorilbl.TabIndex = 3;
            Kategorilbl.Text = "Kategori:";
            // 
            // Isımlbl
            // 
            Isımlbl.AutoSize = true;
            Isımlbl.Font = new Font("Segoe UI", 12F);
            Isımlbl.Location = new Point(20, 125);
            Isımlbl.Name = "Isımlbl";
            Isımlbl.Size = new Size(42, 21);
            Isımlbl.TabIndex = 4;
            Isımlbl.Text = "İsim:";
            // 
            // Aramabox
            // 
            Aramabox.Controls.Add(button1);
            Aramabox.Controls.Add(cbxCategory);
            Aramabox.Controls.Add(Kategorilbl);
            Aramabox.Controls.Add(Isımlbl);
            Aramabox.Controls.Add(IsimTxt);
            Aramabox.Location = new Point(51, 49);
            Aramabox.Name = "Aramabox";
            Aramabox.Size = new Size(291, 203);
            Aramabox.TabIndex = 5;
            Aramabox.TabStop = false;
            Aramabox.Text = "Arama";
            // 
            // button1
            // 
            button1.Location = new Point(108, 57);
            button1.Name = "button1";
            button1.Size = new Size(16, 19);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(130, 56);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(131, 23);
            cbxCategory.TabIndex = 5;
            cbxCategory.SelectedIndexChanged += CbxCategory_SelectedIndexChanged;
            // 
            // EklemeBox
            // 
            EklemeBox.Controls.Add(EkleBtn);
            EklemeBox.Controls.Add(KategoriAdd);
            EklemeBox.Controls.Add(StokBasınaAdetAdd);
            EklemeBox.Controls.Add(StokAdd);
            EklemeBox.Controls.Add(FiyatAdd);
            EklemeBox.Controls.Add(NameAdd);
            EklemeBox.Location = new Point(402, 49);
            EklemeBox.Name = "EklemeBox";
            EklemeBox.Size = new Size(319, 203);
            EklemeBox.TabIndex = 6;
            EklemeBox.TabStop = false;
            EklemeBox.Text = "Ekleme";
            // 
            // EkleBtn
            // 
            EkleBtn.Location = new Point(176, 154);
            EkleBtn.Name = "EkleBtn";
            EkleBtn.Size = new Size(99, 23);
            EkleBtn.TabIndex = 12;
            EkleBtn.Text = "Ekle";
            EkleBtn.UseVisualStyleBackColor = true;
            EkleBtn.Click += EkleBtn_Click;
            // 
            // KategoriAdd
            // 
            KategoriAdd.AllowDrop = true;
            KategoriAdd.FormattingEnabled = true;
            KategoriAdd.Location = new Point(32, 100);
            KategoriAdd.Name = "KategoriAdd";
            KategoriAdd.Size = new Size(99, 23);
            KategoriAdd.TabIndex = 7;
            // 
            // StokBasınaAdetAdd
            // 
            StokBasınaAdetAdd.Location = new Point(176, 100);
            StokBasınaAdetAdd.Name = "StokBasınaAdetAdd";
            StokBasınaAdetAdd.PlaceholderText = "Stok başına adet";
            StokBasınaAdetAdd.Size = new Size(99, 23);
            StokBasınaAdetAdd.TabIndex = 11;
            // 
            // StokAdd
            // 
            StokAdd.Location = new Point(176, 40);
            StokAdd.Name = "StokAdd";
            StokAdd.PlaceholderText = "Stok";
            StokAdd.Size = new Size(99, 23);
            StokAdd.TabIndex = 10;
            // 
            // FiyatAdd
            // 
            FiyatAdd.Location = new Point(32, 154);
            FiyatAdd.Name = "FiyatAdd";
            FiyatAdd.PlaceholderText = "Fiyat";
            FiyatAdd.Size = new Size(99, 23);
            FiyatAdd.TabIndex = 9;
            // 
            // NameAdd
            // 
            NameAdd.Location = new Point(32, 40);
            NameAdd.Name = "NameAdd";
            NameAdd.PlaceholderText = "İsim";
            NameAdd.Size = new Size(99, 23);
            NameAdd.TabIndex = 7;
            // 
            // UpdateBox
            // 
            UpdateBox.Controls.Add(UpdateBtn);
            UpdateBox.Controls.Add(CategoryUpdate);
            UpdateBox.Controls.Add(QPerUnitUpdateTxt);
            UpdateBox.Controls.Add(StockUpdateTxt);
            UpdateBox.Controls.Add(PriceUpdateTxt);
            UpdateBox.Controls.Add(NameUpdateTxt);
            UpdateBox.Location = new Point(784, 49);
            UpdateBox.Name = "UpdateBox";
            UpdateBox.Size = new Size(319, 203);
            UpdateBox.TabIndex = 7;
            UpdateBox.TabStop = false;
            UpdateBox.Text = "Güncelle";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(176, 154);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(99, 23);
            UpdateBtn.TabIndex = 12;
            UpdateBtn.Text = "Güncelle";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // CategoryUpdate
            // 
            CategoryUpdate.AllowDrop = true;
            CategoryUpdate.FormattingEnabled = true;
            CategoryUpdate.Location = new Point(32, 100);
            CategoryUpdate.Name = "CategoryUpdate";
            CategoryUpdate.Size = new Size(99, 23);
            CategoryUpdate.TabIndex = 7;
            // 
            // QPerUnitUpdateTxt
            // 
            QPerUnitUpdateTxt.Location = new Point(176, 100);
            QPerUnitUpdateTxt.Name = "QPerUnitUpdateTxt";
            QPerUnitUpdateTxt.PlaceholderText = "Stok başına adet";
            QPerUnitUpdateTxt.Size = new Size(99, 23);
            QPerUnitUpdateTxt.TabIndex = 11;
            // 
            // StockUpdateTxt
            // 
            StockUpdateTxt.Location = new Point(176, 40);
            StockUpdateTxt.Name = "StockUpdateTxt";
            StockUpdateTxt.PlaceholderText = "Stok";
            StockUpdateTxt.Size = new Size(99, 23);
            StockUpdateTxt.TabIndex = 10;
            // 
            // PriceUpdateTxt
            // 
            PriceUpdateTxt.Location = new Point(32, 154);
            PriceUpdateTxt.Name = "PriceUpdateTxt";
            PriceUpdateTxt.PlaceholderText = "Fiyat";
            PriceUpdateTxt.Size = new Size(99, 23);
            PriceUpdateTxt.TabIndex = 9;
            // 
            // NameUpdateTxt
            // 
            NameUpdateTxt.Location = new Point(32, 40);
            NameUpdateTxt.Name = "NameUpdateTxt";
            NameUpdateTxt.PlaceholderText = "İsim";
            NameUpdateTxt.Size = new Size(99, 23);
            NameUpdateTxt.TabIndex = 7;
            // 
            // SilBtn
            // 
            SilBtn.Location = new Point(893, 296);
            SilBtn.Name = "SilBtn";
            SilBtn.Size = new Size(113, 32);
            SilBtn.TabIndex = 13;
            SilBtn.Text = "Sil";
            SilBtn.UseVisualStyleBackColor = true;
            SilBtn.Click += SilBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 630);
            Controls.Add(SilBtn);
            Controls.Add(UpdateBox);
            Controls.Add(EklemeBox);
            Controls.Add(Aramabox);
            Controls.Add(DgwProducts);
            Name = "Form1";
            Text = "Database";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgwProducts).EndInit();
            Aramabox.ResumeLayout(false);
            Aramabox.PerformLayout();
            EklemeBox.ResumeLayout(false);
            EklemeBox.PerformLayout();
            UpdateBox.ResumeLayout(false);
            UpdateBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgwProducts;
        private TextBox IsimTxt;
        private Label Kategorilbl;
        private Label Isımlbl;
        private GroupBox Aramabox;
        private ComboBox cbxCategory;
        private GroupBox EklemeBox;
        private TextBox StokBasınaAdetAdd;
        private TextBox StokAdd;
        private TextBox FiyatAdd;
        private TextBox NameAdd;
        private ComboBox KategoriAdd;
        private Button EkleBtn;
        private GroupBox UpdateBox;
        private Button UpdateBtn;
        private ComboBox CategoryUpdate;
        private TextBox QPerUnitUpdateTxt;
        private TextBox StockUpdateTxt;
        private TextBox PriceUpdateTxt;
        private TextBox NameUpdateTxt;
        private Button SilBtn;
        private Button button1;
    }
}
