namespace Kursach_Jewelry
{
    partial class ProductFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CleareBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.addClick = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_product,
            this.NameProduct,
            this.PriceProduct,
            this.TypeProduct,
            this.CountProduct,
            this.MaterialID});
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(521, 453);
            this.dataGridView1.TabIndex = 64;
            // 
            // id_product
            // 
            this.id_product.DataPropertyName = "IDProducts";
            this.id_product.HeaderText = "Номер продукта";
            this.id_product.Name = "id_product";
            this.id_product.ReadOnly = true;
            this.id_product.Visible = false;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "NameProduct";
            this.NameProduct.HeaderText = "Имя продукта";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // PriceProduct
            // 
            this.PriceProduct.DataPropertyName = "PriceProduct";
            this.PriceProduct.HeaderText = "Цена продукта";
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.ReadOnly = true;
            // 
            // TypeProduct
            // 
            this.TypeProduct.DataPropertyName = "TypeProduct";
            this.TypeProduct.HeaderText = "Тип продукта";
            this.TypeProduct.Name = "TypeProduct";
            this.TypeProduct.ReadOnly = true;
            // 
            // CountProduct
            // 
            this.CountProduct.DataPropertyName = "CountProduct";
            this.CountProduct.HeaderText = "Количество продукта";
            this.CountProduct.Name = "CountProduct";
            this.CountProduct.ReadOnly = true;
            // 
            // MaterialID
            // 
            this.MaterialID.DataPropertyName = "MaterialID";
            this.MaterialID.HeaderText = "Номер материала";
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.ReadOnly = true;
            // 
            // CleareBtn
            // 
            this.CleareBtn.Location = new System.Drawing.Point(11, 161);
            this.CleareBtn.Name = "CleareBtn";
            this.CleareBtn.Size = new System.Drawing.Size(239, 25);
            this.CleareBtn.TabIndex = 63;
            this.CleareBtn.Text = "Очистить поля";
            this.CleareBtn.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 62;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Цена товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Имя товара";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(12, 70);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(238, 26);
            this.Edit.TabIndex = 58;
            this.Edit.Text = "Редактирование";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 39);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(239, 25);
            this.DeleteButton.TabIndex = 57;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // addClick
            // 
            this.addClick.Location = new System.Drawing.Point(11, 7);
            this.addClick.Name = "addClick";
            this.addClick.Size = new System.Drawing.Size(240, 26);
            this.addClick.TabIndex = 56;
            this.addClick.Text = "Добавить";
            this.addClick.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 68;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "Кол-во товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "Тип товара";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 136);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 69;
            this.label5.Text = "Номер материала";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(525, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 172);
            this.panel1.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.addClick);
            this.panel2.Controls.Add(this.CleareBtn);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Location = new System.Drawing.Point(525, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 198);
            this.panel2.TabIndex = 72;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 26);
            this.button2.TabIndex = 65;
            this.button2.Text = "Сортировка по убыванию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 26);
            this.button1.TabIndex = 64;
            this.button1.Text = "Сортировка по возрастанию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ProductFormcs";
            this.Text = "ProductFormcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button CleareBtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Button Edit;
        private Button DeleteButton;
        private Button addClick;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label1;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private DataGridViewTextBoxColumn id_product;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn PriceProduct;
        private DataGridViewTextBoxColumn TypeProduct;
        private DataGridViewTextBoxColumn CountProduct;
        private DataGridViewTextBoxColumn MaterialID;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button1;
    }
}