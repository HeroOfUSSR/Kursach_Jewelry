namespace Kursach_Jewelry
{
    partial class MasterF
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
            NameMaster = new DataGridViewTextBoxColumn();
            PhoneMaster = new DataGridViewTextBoxColumn();
            OrderMaster = new DataGridViewTextBoxColumn();
            Id_Master = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameMaster, PhoneMaster, OrderMaster, Id_Master });
            dataGridView1.Location = new Point(-2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 447);
            dataGridView1.TabIndex = 33;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // NameMaster
            // 
            NameMaster.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameMaster.DataPropertyName = "NameMaster";
            NameMaster.HeaderText = "Имя Мастера";
            NameMaster.Name = "NameMaster";
            NameMaster.ReadOnly = true;
            // 
            // PhoneMaster
            // 
            PhoneMaster.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneMaster.DataPropertyName = "PhoneMaster";
            PhoneMaster.HeaderText = "Телефон мастера";
            PhoneMaster.Name = "PhoneMaster";
            PhoneMaster.ReadOnly = true;
            // 
            // OrderMaster
            // 
            OrderMaster.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderMaster.DataPropertyName = "OrderMaster";
            OrderMaster.HeaderText = "Номер заказа мастера";
            OrderMaster.Name = "OrderMaster";
            OrderMaster.ReadOnly = true;
            // 
            // Id_Master
            // 
            Id_Master.DataPropertyName = "IdMaster";
            Id_Master.HeaderText = "Номер мастера";
            Id_Master.Name = "Id_Master";
            Id_Master.ReadOnly = true;
            Id_Master.Visible = false;
            // 
            // CleareBtn
            // 
            CleareBtn.Location = new Point(524, 272);
            CleareBtn.Name = "CleareBtn";
            CleareBtn.Size = new Size(108, 47);
            CleareBtn.TabIndex = 32;
            CleareBtn.Text = "Очистить поля";
            CleareBtn.UseVisualStyleBackColor = true;
            CleareBtn.Click += CleareBtn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(659, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(659, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(659, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 83);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 28;
            label3.Text = "Номер заказа мастера";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 54);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 27;
            label2.Text = "Телефон мастера";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(524, 22);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 26;
            label1.Text = "Имя мастера";
            // 
            // Edit
            // 
            Edit.Location = new Point(524, 219);
            Edit.Name = "Edit";
            Edit.Size = new Size(108, 47);
            Edit.TabIndex = 25;
            Edit.Text = "Редактирование";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(524, 169);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(108, 44);
            DeleteButton.TabIndex = 24;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addClick
            // 
            addClick.Location = new Point(524, 125);
            addClick.Name = "addClick";
            addClick.Size = new Size(108, 38);
            addClick.TabIndex = 23;
            addClick.Text = "Добавить";
            addClick.UseVisualStyleBackColor = true;
            addClick.Click += addClick_Click;
            // 
            // MasterF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "MasterF";
            Text = "MasterF";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
        private DataGridViewTextBoxColumn NameMaster;
        private DataGridViewTextBoxColumn PhoneMaster;
        private DataGridViewTextBoxColumn OrderMaster;
        private DataGridViewTextBoxColumn Id_Master;
    }
}