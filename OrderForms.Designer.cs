namespace Kursach_Jewelry
{
    partial class OrderForms
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
            CleareBtn = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Edit = new Button();
            DeleteButton = new Button();
            addClick = new Button();
            dataGridView1 = new DataGridView();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            ClientId = new DataGridViewTextBoxColumn();
            DateOrder = new DataGridViewTextBoxColumn();
            CountOrder = new DataGridViewTextBoxColumn();
            MasterOrder = new DataGridViewTextBoxColumn();
            OrderCoust = new DataGridViewTextBoxColumn();
            ProductId = new DataGridViewTextBoxColumn();
            idORder = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CleareBtn
            // 
            CleareBtn.Location = new Point(695, 391);
            CleareBtn.Name = "CleareBtn";
            CleareBtn.Size = new Size(108, 47);
            CleareBtn.TabIndex = 64;
            CleareBtn.Text = "Очистить поля";
            CleareBtn.UseVisualStyleBackColor = true;
            CleareBtn.Click += CleareBtn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(788, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 63;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(788, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 62;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(788, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 67);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 60;
            label3.Text = "Кол-во";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(653, 38);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 59;
            label2.Text = "Дата заказа";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 6);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 58;
            label1.Text = "Номер клиента";
            // 
            // Edit
            // 
            Edit.Location = new Point(695, 338);
            Edit.Name = "Edit";
            Edit.Size = new Size(108, 47);
            Edit.TabIndex = 57;
            Edit.Text = "Редактирование";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(695, 288);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(108, 44);
            DeleteButton.TabIndex = 56;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addClick
            // 
            addClick.Location = new Point(695, 244);
            addClick.Name = "addClick";
            addClick.Size = new Size(108, 38);
            addClick.TabIndex = 55;
            addClick.Text = "Добавить";
            addClick.UseVisualStyleBackColor = true;
            addClick.Click += addClick_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClientId, DateOrder, CountOrder, MasterOrder, OrderCoust, ProductId, idORder });
            dataGridView1.Location = new Point(-5, 3);
            dataGridView1.MaximumSize = new Size(642, 449);
            dataGridView1.MinimumSize = new Size(642, 449);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(642, 449);
            dataGridView1.TabIndex = 65;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(788, 116);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 70;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(788, 150);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 155);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 67;
            label5.Text = "Номер продукта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(653, 96);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 66;
            label6.Text = "Номер мастера";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(788, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(653, 124);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 71;
            label4.Text = "Сумма заказа";
            // 
            // ClientId
            // 
            ClientId.DataPropertyName = "ClientID";
            ClientId.HeaderText = "Номер клиента";
            ClientId.Name = "ClientId";
            ClientId.ReadOnly = true;
            // 
            // DateOrder
            // 
            DateOrder.DataPropertyName = "DateOrder";
            DateOrder.HeaderText = "Дата заказа";
            DateOrder.Name = "DateOrder";
            DateOrder.ReadOnly = true;
            // 
            // CountOrder
            // 
            CountOrder.DataPropertyName = "CountOrder";
            CountOrder.HeaderText = "Кол-во заказа";
            CountOrder.Name = "CountOrder";
            CountOrder.ReadOnly = true;
            // 
            // MasterOrder
            // 
            MasterOrder.DataPropertyName = "MasterOrder";
            MasterOrder.HeaderText = "Номер Мастера ";
            MasterOrder.Name = "MasterOrder";
            MasterOrder.ReadOnly = true;
            // 
            // OrderCoust
            // 
            OrderCoust.DataPropertyName = "OrderCost";
            OrderCoust.HeaderText = "Сумма заказа";
            OrderCoust.Name = "OrderCoust";
            OrderCoust.ReadOnly = true;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductsID";
            ProductId.HeaderText = "Номер продукта";
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            // 
            // idORder
            // 
            idORder.DataPropertyName = "IDProducts";
            idORder.HeaderText = "Номер заказа";
            idORder.Name = "idORder";
            idORder.ReadOnly = true;
            idORder.Visible = false;
            // 
            // OrderForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(CleareBtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Edit);
            Controls.Add(DeleteButton);
            Controls.Add(addClick);
            Name = "OrderForms";
            Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CleareBtn;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Edit;
        private Button DeleteButton;
        private Button addClick;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn DateOrder;
        private DataGridViewTextBoxColumn CountOrder;
        private DataGridViewTextBoxColumn MasterOrder;
        private DataGridViewTextBoxColumn OrderCoust;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn idORder;
    }
}