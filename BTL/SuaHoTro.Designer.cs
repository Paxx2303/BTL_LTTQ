namespace BTL
{
    partial class SuaHoTro
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
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(555, 390);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 19;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 297);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 18;
            label4.Text = "Hình thức hỗ trợ ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 213);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 17;
            label3.Text = "Thông tin hỗ trợ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 128);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 16;
            label2.Text = "Thông tin yêu cầu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 45);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 15;
            label1.Text = "Mã Hồ Sơ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(290, 289);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(346, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(346, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(346, 23);
            textBox2.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(224, 390);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 10;
            button1.Text = "Cập Nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 45);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 21;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // SuaHoTro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "SuaHoTro";
            Text = "SuaHoTro";
            Load += SuaHoTro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
    }
}