namespace Kursach_Jewelry
{
    partial class MaterialForm
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn1,
            this.SampleMaterial,
            this.ColorMaterial,
            this.idMaterial});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(346, 453);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NameMaterial";
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя Материала";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SampleMaterial
            // 
            this.SampleMaterial.DataPropertyName = "SampleMaterial";
            this.SampleMaterial.HeaderText = "Проба материала";
            this.SampleMaterial.Name = "SampleMaterial";
            this.SampleMaterial.ReadOnly = true;
            // 
            // ColorMaterial
            // 
            this.ColorMaterial.DataPropertyName = "ColorMaterial";
            this.ColorMaterial.HeaderText = "Цвет материала";
            this.ColorMaterial.Name = "ColorMaterial";
            this.ColorMaterial.ReadOnly = true;
            // 
            // idMaterial
            // 
            this.idMaterial.DataPropertyName = "IdMaterials";
            this.idMaterial.HeaderText = "Номер материала";
            this.idMaterial.Name = "idMaterial";
            this.idMaterial.ReadOnly = true;
            this.idMaterial.Visible = false;
            // 
            // CleareBtn
            // 
            this.CleareBtn.Location = new System.Drawing.Point(30, 140);
            this.CleareBtn.Name = "CleareBtn";
            this.CleareBtn.Size = new System.Drawing.Size(183, 25);
            this.CleareBtn.TabIndex = 54;
            this.CleareBtn.Text = "Очистить поля";
            this.CleareBtn.UseVisualStyleBackColor = true;
            this.CleareBtn.Click += new System.EventHandler(this.CleareBtn_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 53;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Проба материала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Цвет Материала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Имя материала";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(30, 70);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(183, 25);
            this.Edit.TabIndex = 47;
            this.Edit.Text = "Редактирование";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(30, 41);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(183, 23);
            this.DeleteButton.TabIndex = 46;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // addClick
            // 
            this.addClick.Location = new System.Drawing.Point(30, 10);
            this.addClick.Name = "addClick";
            this.addClick.Size = new System.Drawing.Size(183, 25);
            this.addClick.TabIndex = 45;
            this.addClick.Text = "Добавить";
            this.addClick.UseVisualStyleBackColor = true;
            this.addClick.Click += new System.EventHandler(this.addClick_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(368, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 161);
            this.panel1.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Controls.Add(this.CleareBtn);
            this.panel2.Controls.Add(this.addClick);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Location = new System.Drawing.Point(368, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 182);
            this.panel2.TabIndex = 57;
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MaterialForm";
            this.Text = "MaterialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn SampleMaterial;
        private DataGridViewTextBoxColumn ColorMaterial;
        private DataGridViewTextBoxColumn idMaterial;
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
        private Panel panel1;
        private Panel panel2;
    }
}