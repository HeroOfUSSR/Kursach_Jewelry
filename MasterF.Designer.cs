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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Master = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.NameMaster,
            this.PhoneMaster,
            this.OrderMaster,
            this.Id_Master});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(520, 447);
            this.dataGridView1.TabIndex = 33;
            // 
            // NameMaster
            // 
            this.NameMaster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameMaster.DataPropertyName = "NameMaster";
            this.NameMaster.HeaderText = "Имя Мастера";
            this.NameMaster.Name = "NameMaster";
            this.NameMaster.ReadOnly = true;
            // 
            // PhoneMaster
            // 
            this.PhoneMaster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneMaster.DataPropertyName = "PhoneMaster";
            this.PhoneMaster.HeaderText = "Телефон мастера";
            this.PhoneMaster.Name = "PhoneMaster";
            this.PhoneMaster.ReadOnly = true;
            // 
            // OrderMaster
            // 
            this.OrderMaster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderMaster.DataPropertyName = "OrderMaster";
            this.OrderMaster.HeaderText = "Номер заказа мастера";
            this.OrderMaster.Name = "OrderMaster";
            this.OrderMaster.ReadOnly = true;
            // 
            // Id_Master
            // 
            this.Id_Master.DataPropertyName = "IdMaster";
            this.Id_Master.HeaderText = "Номер мастера";
            this.Id_Master.Name = "Id_Master";
            this.Id_Master.ReadOnly = true;
            this.Id_Master.Visible = false;
            // 
            // CleareBtn
            // 
            this.CleareBtn.Location = new System.Drawing.Point(14, 173);
            this.CleareBtn.Name = "CleareBtn";
            this.CleareBtn.Size = new System.Drawing.Size(236, 30);
            this.CleareBtn.TabIndex = 32;
            this.CleareBtn.Text = "Очистить поля";
            this.CleareBtn.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Номер заказа мастера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Телефон мастера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Имя мастера";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(14, 76);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(236, 28);
            this.Edit.TabIndex = 25;
            this.Edit.Text = "Редактирование";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(14, 44);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(236, 26);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // addClick
            // 
            this.addClick.Location = new System.Drawing.Point(14, 12);
            this.addClick.Name = "addClick";
            this.addClick.Size = new System.Drawing.Size(236, 26);
            this.addClick.TabIndex = 23;
            this.addClick.Text = "Добавить";
            this.addClick.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(524, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 130);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addClick);
            this.panel2.Controls.Add(this.CleareBtn);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Location = new System.Drawing.Point(524, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 219);
            this.panel2.TabIndex = 35;
            // 
            // MasterF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MasterF";
            this.Text = "MasterF";
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
        private Panel panel1;
        private Panel panel2;
    }
}