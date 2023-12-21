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
            dataGridView1 = new DataGridView();
            CleareBtn = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Edit = new Button();
            DeleteButton = new Button();
            addClick = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            id_product = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            PriceProduct = new DataGridViewTextBoxColumn();
            TypeProduct = new DataGridViewTextBoxColumn();
            CountProduct = new DataGridViewTextBoxColumn();
            MaterialID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_product, NameProduct, PriceProduct, TypeProduct, CountProduct, MaterialID });
            dataGridView1.Location = new Point(-2, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(521, 453);
            dataGridView1.TabIndex = 64;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // CleareBtn
            // 
            CleareBtn.Location = new Point(652, 324);
            CleareBtn.Name = "CleareBtn";
            CleareBtn.Size = new Size(108, 47);
            CleareBtn.TabIndex = 63;
            CleareBtn.Text = "Очистить поля";
            CleareBtn.UseVisualStyleBackColor = true;
            CleareBtn.Click += CleareBtn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(660, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 62;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(660, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 38);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 60;
            label3.Text = "Цена товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 9);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 59;
            label2.Text = "Имя товара";
            // 
            // Edit
            // 
            Edit.Location = new Point(652, 271);
            Edit.Name = "Edit";
            Edit.Size = new Size(108, 47);
            Edit.TabIndex = 58;
            Edit.Text = "Редактирование";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(652, 221);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(108, 44);
            DeleteButton.TabIndex = 57;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addClick
            // 
            addClick.Location = new Point(652, 177);
            addClick.Name = "addClick";
            addClick.Size = new Size(108, 38);
            addClick.TabIndex = 56;
            addClick.Text = "Добавить";
            addClick.UseVisualStyleBackColor = true;
            addClick.Click += addClick_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(660, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 68;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(660, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 96);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 66;
            label1.Text = "Кол-во товара";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 67);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 65;
            label4.Text = "Тип товара";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(660, 117);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 125);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 69;
            label5.Text = "Номер материала";
            // 
            // id_product
            // 
            id_product.DataPropertyName = "IDProducts";
            id_product.HeaderText = "Номер продукта";
            id_product.Name = "id_product";
            id_product.ReadOnly = true;
            id_product.Visible = false;
            // 
            // NameProduct
            // 
            NameProduct.DataPropertyName = "NameProduct";
            NameProduct.HeaderText = "Имя продукта";
            NameProduct.Name = "NameProduct";
            NameProduct.ReadOnly = true;
            // 
            // PriceProduct
            // 
            PriceProduct.DataPropertyName = "PriceProduct";
            PriceProduct.HeaderText = "Цена продукта";
            PriceProduct.Name = "PriceProduct";
            PriceProduct.ReadOnly = true;
            // 
            // TypeProduct
            // 
            TypeProduct.DataPropertyName = "TypeProduct";
            TypeProduct.HeaderText = "Тип продукта";
            TypeProduct.Name = "TypeProduct";
            TypeProduct.ReadOnly = true;
            // 
            // CountProduct
            // 
            CountProduct.DataPropertyName = "CountProduct";
            CountProduct.HeaderText = "Количество продукта";
            CountProduct.Name = "CountProduct";
            CountProduct.ReadOnly = true;
            // 
            // MaterialID
            // 
            MaterialID.DataPropertyName = "MaterialID";
            MaterialID.HeaderText = "Номер материала";
            MaterialID.Name = "MaterialID";
            MaterialID.ReadOnly = true;
            // 
            // ProductFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(CleareBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Edit);
            Controls.Add(DeleteButton);
            Controls.Add(addClick);
            Name = "ProductFormcs";
            Text = "ProductFormcs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}