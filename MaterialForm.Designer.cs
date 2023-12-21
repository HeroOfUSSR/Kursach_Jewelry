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
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            SampleMaterial = new DataGridViewTextBoxColumn();
            ColorMaterial = new DataGridViewTextBoxColumn();
            idMaterial = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, SampleMaterial, ColorMaterial, idMaterial });
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(346, 453);
            dataGridView1.TabIndex = 55;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "NameMaterial";
            dataGridViewTextBoxColumn1.HeaderText = "Имя Материала";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SampleMaterial
            // 
            SampleMaterial.DataPropertyName = "SampleMaterial";
            SampleMaterial.HeaderText = "Проба материала";
            SampleMaterial.Name = "SampleMaterial";
            SampleMaterial.ReadOnly = true;
            // 
            // ColorMaterial
            // 
            ColorMaterial.DataPropertyName = "ColorMaterial";
            ColorMaterial.HeaderText = "Цвет материала";
            ColorMaterial.Name = "ColorMaterial";
            ColorMaterial.ReadOnly = true;
            // 
            // idMaterial
            // 
            idMaterial.DataPropertyName = "IdMaterials";
            idMaterial.HeaderText = "Номер материала";
            idMaterial.Name = "idMaterial";
            idMaterial.ReadOnly = true;
            idMaterial.Visible = false;
            // 
            // CleareBtn
            // 
            CleareBtn.Location = new Point(368, 324);
            CleareBtn.Name = "CleareBtn";
            CleareBtn.Size = new Size(108, 47);
            CleareBtn.TabIndex = 54;
            CleareBtn.Text = "Очистить поля";
            CleareBtn.UseVisualStyleBackColor = true;
            CleareBtn.Click += CleareBtn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(503, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 53;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(503, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(503, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 74);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 50;
            label3.Text = "Проба материала";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 45);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 49;
            label2.Text = "Цвет Материала";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 13);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 48;
            label1.Text = "Имя материала";
            // 
            // Edit
            // 
            Edit.Location = new Point(368, 271);
            Edit.Name = "Edit";
            Edit.Size = new Size(108, 47);
            Edit.TabIndex = 47;
            Edit.Text = "Редактирование";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(368, 221);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(108, 44);
            DeleteButton.TabIndex = 46;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addClick
            // 
            addClick.Location = new Point(368, 177);
            addClick.Name = "addClick";
            addClick.Size = new Size(108, 38);
            addClick.TabIndex = 45;
            addClick.Text = "Добавить";
            addClick.UseVisualStyleBackColor = true;
            addClick.Click += addClick_Click;
            // 
            // MaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
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
            Name = "MaterialForm";
            Text = "MaterialForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}