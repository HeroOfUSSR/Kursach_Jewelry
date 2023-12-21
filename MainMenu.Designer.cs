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
            ClientButton = new Button();
            button1 = new Button();
            ClientBtn = new Button();
            Productbtn = new Button();
            OrderBtn = new Button();
            SuspendLayout();
            // 
            // ClientButton
            // 
            ClientButton.Location = new Point(12, 12);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new Size(127, 59);
            ClientButton.TabIndex = 0;
            ClientButton.Text = "Клиенты";
            ClientButton.UseVisualStyleBackColor = true;
            ClientButton.Click += ClientButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(127, 59);
            button1.TabIndex = 1;
            button1.Text = "Мастера";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClientBtn
            // 
            ClientBtn.Location = new Point(145, 12);
            ClientBtn.Name = "ClientBtn";
            ClientBtn.Size = new Size(127, 59);
            ClientBtn.TabIndex = 2;
            ClientBtn.Text = "Материалы";
            ClientBtn.UseVisualStyleBackColor = true;
            ClientBtn.Click += ClientBtn_Click;
            // 
            // Productbtn
            // 
            Productbtn.Location = new Point(145, 77);
            Productbtn.Name = "Productbtn";
            Productbtn.Size = new Size(127, 59);
            Productbtn.TabIndex = 3;
            Productbtn.Text = "Продукты";
            Productbtn.UseVisualStyleBackColor = true;
            Productbtn.Click += Productbtn_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.Location = new Point(84, 142);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(127, 59);
            OrderBtn.TabIndex = 4;
            OrderBtn.Text = "Заказы";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click_1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 216);
            Controls.Add(OrderBtn);
            Controls.Add(Productbtn);
            Controls.Add(ClientBtn);
            Controls.Add(button1);
            Controls.Add(ClientButton);
            MaximumSize = new Size(310, 255);
            MinimumSize = new Size(310, 255);
            Name = "MainMenu";
            Text = "Главное меню";
            ResumeLayout(false);
        }

        #endregion

        private Button ClientButton;
        private Button button1;
        private Button ClientBtn;
        private Button Productbtn;
        private Button OrderBtn;
    }
}