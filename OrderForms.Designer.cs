﻿namespace Kursach_Jewelry
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
            this.CleareBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.addClick = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasterOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCoust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idORder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CleareBtn
            // 
            this.CleareBtn.Location = new System.Drawing.Point(16, 186);
            this.CleareBtn.Name = "CleareBtn";
            this.CleareBtn.Size = new System.Drawing.Size(204, 27);
            this.CleareBtn.TabIndex = 64;
            this.CleareBtn.Text = "Очистить поля";
            this.CleareBtn.UseVisualStyleBackColor = true;
            this.CleareBtn.Click += new System.EventHandler(this.CleareBtn_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 63;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Кол-во";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Дата заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Номер клиента";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(16, 87);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(204, 28);
            this.Edit.TabIndex = 57;
            this.Edit.Text = "Редактирование";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(16, 50);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(204, 31);
            this.DeleteButton.TabIndex = 56;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // addClick
            // 
            this.addClick.Location = new System.Drawing.Point(16, 14);
            this.addClick.Name = "addClick";
            this.addClick.Size = new System.Drawing.Size(204, 30);
            this.addClick.TabIndex = 55;
            this.addClick.Text = "Добавить";
            this.addClick.UseVisualStyleBackColor = true;
            this.addClick.Click += new System.EventHandler(this.addClick_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.DateOrder,
            this.CountOrder,
            this.MasterOrder,
            this.OrderCoust,
            this.ProductId,
            this.idORder});
            this.dataGridView1.Location = new System.Drawing.Point(-5, 3);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(642, 449);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(642, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(642, 449);
            this.dataGridView1.TabIndex = 65;
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientID";
            this.ClientId.HeaderText = "Номер клиента";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // DateOrder
            // 
            this.DateOrder.DataPropertyName = "DateOrder";
            this.DateOrder.HeaderText = "Дата заказа";
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.ReadOnly = true;
            // 
            // CountOrder
            // 
            this.CountOrder.DataPropertyName = "CountOrder";
            this.CountOrder.HeaderText = "Кол-во заказа";
            this.CountOrder.Name = "CountOrder";
            this.CountOrder.ReadOnly = true;
            // 
            // MasterOrder
            // 
            this.MasterOrder.DataPropertyName = "MasterOrder";
            this.MasterOrder.HeaderText = "Номер Мастера ";
            this.MasterOrder.Name = "MasterOrder";
            this.MasterOrder.ReadOnly = true;
            // 
            // OrderCoust
            // 
            this.OrderCoust.DataPropertyName = "OrderCost";
            this.OrderCoust.HeaderText = "Сумма заказа";
            this.OrderCoust.Name = "OrderCoust";
            this.OrderCoust.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductsID";
            this.ProductId.HeaderText = "Номер продукта";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // idORder
            // 
            this.idORder.DataPropertyName = "IDProducts";
            this.idORder.HeaderText = "Номер заказа";
            this.idORder.Name = "idORder";
            this.idORder.ReadOnly = true;
            this.idORder.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 131);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 70;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 163);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "Номер продукта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "Номер мастера";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 71;
            this.label4.Text = "Сумма заказа";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Location = new System.Drawing.Point(653, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 196);
            this.panel1.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.addClick);
            this.panel2.Controls.Add(this.CleareBtn);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Location = new System.Drawing.Point(653, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 230);
            this.panel2.TabIndex = 74;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 26);
            this.button2.TabIndex = 66;
            this.button2.Text = "Сортировка по возрастанию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 27);
            this.button1.TabIndex = 65;
            this.button1.Text = "Сортировка по убыванию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "OrderForms";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
    }
}