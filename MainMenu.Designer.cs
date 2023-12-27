namespace Kursach_Jewelry
{
    partial class MainMenu
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
            this.ClientButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(12, 12);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(270, 59);
            this.ClientButton.TabIndex = 0;
            this.ClientButton.Text = "Клиенты";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Мастера";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ClientBtn
            // 
            this.ClientBtn.Location = new System.Drawing.Point(12, 77);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(270, 59);
            this.ClientBtn.TabIndex = 2;
            this.ClientBtn.Text = "Материалы";
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click_1);
            // 
            // Productbtn
            // 
            this.Productbtn.Location = new System.Drawing.Point(12, 142);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Size = new System.Drawing.Size(270, 59);
            this.Productbtn.TabIndex = 3;
            this.Productbtn.Text = "Продукты";
            this.Productbtn.UseVisualStyleBackColor = true;
            this.Productbtn.Click += new System.EventHandler(this.Productbtn_Click_1);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(12, 272);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(270, 59);
            this.OrderBtn.TabIndex = 4;
            this.OrderBtn.Text = "Заказы";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 346);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.Productbtn);
            this.Controls.Add(this.ClientBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClientButton);
            this.MaximumSize = new System.Drawing.Size(310, 385);
            this.MinimumSize = new System.Drawing.Size(310, 385);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ClientButton;
        private Button button1;
        private Button ClientBtn;
        private Button Productbtn;
        private Button OrderBtn;
    }
}