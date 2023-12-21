namespace Kursach_Jewelry
{
    partial class ClientF
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
            addClick = new Button();
            DeleteButton = new Button();
            Edit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            CleareBtn = new Button();
            ClientName = new DataGridViewTextBoxColumn();
            Idclient = new DataGridViewTextBoxColumn();
            PhoneClient = new DataGridViewTextBoxColumn();
            OrderClient = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClientName, Idclient, PhoneClient, OrderClient });
            dataGridView1.Location = new Point(-2, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(343, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // addClick
            // 
            addClick.Location = new Point(347, 12);
            addClick.Name = "addClick";
            addClick.Size = new Size(108, 38);
            addClick.TabIndex = 1;
            addClick.Text = "Добавить";
            addClick.UseVisualStyleBackColor = true;
            addClick.Click += addClick_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(347, 56);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(108, 44);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(347, 106);
            Edit.Name = "Edit";
            Edit.Size = new Size(108, 47);
            Edit.TabIndex = 3;
            Edit.Text = "Редактирование";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 24);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 4;
            label1.Text = "Имя клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 56);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 5;
            label2.Text = "Телефон клиента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 85);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 6;
            label3.Text = "Номер заказа клиента";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(660, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(660, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(660, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // CleareBtn
            // 
            CleareBtn.Location = new Point(347, 159);
            CleareBtn.Name = "CleareBtn";
            CleareBtn.Size = new Size(108, 47);
            CleareBtn.TabIndex = 10;
            CleareBtn.Text = "Очистить поля";
            CleareBtn.UseVisualStyleBackColor = true;
            CleareBtn.Click += CleareBtn_Click;
            // 
            // ClientName
            // 
            ClientName.DataPropertyName = "NameClient";
            ClientName.HeaderText = "Имя Клиенты";
            ClientName.Name = "ClientName";
            ClientName.ReadOnly = true;
            // 
            // Idclient
            // 
            Idclient.DataPropertyName = "IdClient";
            Idclient.HeaderText = "номер клиента";
            Idclient.Name = "Idclient";
            Idclient.ReadOnly = true;
            Idclient.Visible = false;
            // 
            // PhoneClient
            // 
            PhoneClient.DataPropertyName = "PhoneClient";
            PhoneClient.HeaderText = "Телефон Клиента";
            PhoneClient.Name = "PhoneClient";
            PhoneClient.ReadOnly = true;
            // 
            // OrderClient
            // 
            OrderClient.DataPropertyName = "OrderClient";
            OrderClient.HeaderText = "Номер заказа клиента";
            OrderClient.Name = "OrderClient";
            OrderClient.ReadOnly = true;
            // 
            // ClientF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(dataGridView1);
            Name = "ClientF";
            Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addClick;
        private Button DeleteButton;
        private Button Edit;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button CleareBtn;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn Idclient;
        private DataGridViewTextBoxColumn PhoneClient;
        private DataGridViewTextBoxColumn OrderClient;
    }
}