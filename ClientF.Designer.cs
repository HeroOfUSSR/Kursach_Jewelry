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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addClick = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CleareBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.ClientName,
            this.Idclient,
            this.PhoneClient,
            this.OrderClient});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(343, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "NameClient";
            this.ClientName.HeaderText = "Имя Клиенты";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Idclient
            // 
            this.Idclient.DataPropertyName = "IdClient";
            this.Idclient.HeaderText = "номер клиента";
            this.Idclient.Name = "Idclient";
            this.Idclient.ReadOnly = true;
            this.Idclient.Visible = false;
            // 
            // PhoneClient
            // 
            this.PhoneClient.DataPropertyName = "PhoneClient";
            this.PhoneClient.HeaderText = "Телефон Клиента";
            this.PhoneClient.Name = "PhoneClient";
            this.PhoneClient.ReadOnly = true;
            // 
            // OrderClient
            // 
            this.OrderClient.DataPropertyName = "OrderClient";
            this.OrderClient.HeaderText = "Номер заказа клиента";
            this.OrderClient.Name = "OrderClient";
            this.OrderClient.ReadOnly = true;
            // 
            // addClick
            // 
            this.addClick.Location = new System.Drawing.Point(16, 12);
            this.addClick.Name = "addClick";
            this.addClick.Size = new System.Drawing.Size(230, 28);
            this.addClick.TabIndex = 1;
            this.addClick.Text = "Добавить";
            this.addClick.UseVisualStyleBackColor = true;
            this.addClick.Click += new System.EventHandler(this.addClick_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(16, 46);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(230, 27);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(16, 79);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(230, 28);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Редактирование";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Телефон клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер заказа клиента";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 9;
            // 
            // CleareBtn
            // 
            this.CleareBtn.Location = new System.Drawing.Point(16, 156);
            this.CleareBtn.Name = "CleareBtn";
            this.CleareBtn.Size = new System.Drawing.Size(230, 28);
            this.CleareBtn.TabIndex = 10;
            this.CleareBtn.Text = "Очистить поля";
            this.CleareBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(347, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 216);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CleareBtn);
            this.panel2.Controls.Add(this.addClick);
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Location = new System.Drawing.Point(347, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 206);
            this.panel2.TabIndex = 12;
            // 
            // ClientF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(659, 489);
            this.MinimumSize = new System.Drawing.Size(659, 489);
            this.Name = "ClientF";
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel panel1;
        private Panel panel2;
    }
}