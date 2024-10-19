namespace BTL
{
    partial class UserInterface
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
            panel1 = new Panel();
            button7 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button5 = new Button();
            button3 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1196, 68);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlText;
            button7.Image = Properties.Resources.icons8_find_24;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(760, 9);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(178, 46);
            button7.TabIndex = 20;
            button7.Text = "      Grade lookup";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.GrayText;
            button4.Image = Properties.Resources.icons8_user_50;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(946, 2);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 14;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1012, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 5;
            label1.Text = "Nguyễn Thị Vân Anh";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1012, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Xin chào,";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(297, 68);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(899, 580);
            panel5.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 68);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 580);
            panel2.TabIndex = 1;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.GrayText;
            button10.Image = Properties.Resources.icons8_exit_48;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(21, 488);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(276, 86);
            button10.TabIndex = 6;
            button10.Text = "             Sign Out";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.GrayText;
            button9.Image = Properties.Resources.icons8_support_50;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(21, 392);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(276, 86);
            button9.TabIndex = 5;
            button9.Text = "             Support";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.GrayText;
            button8.Image = Properties.Resources.icons8_change_password_58;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(12, 190);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(285, 86);
            button8.TabIndex = 4;
            button8.Text = "               Password";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.GrayText;
            button5.Image = Properties.Resources.icons8_payment_64;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(21, 289);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(276, 86);
            button5.TabIndex = 3;
            button5.Text = "             Payment";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.GrayText;
            button3.Image = Properties.Resources.icons8_create_64;
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point(12, 98);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(285, 86);
            button3.TabIndex = 2;
            button3.Text = "               Preferences";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.GrayText;
            button1.Image = Properties.Resources.icons8_building_100;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(4, 4);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(293, 86);
            button1.TabIndex = 0;
            button1.Text = "                 Home";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 57);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 41);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 33);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "ID USER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "FULL NAME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 198);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "BORN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 281);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 9;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(278, 281);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 11;
            label7.Text = "Telephone Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 365);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 13;
            label8.Text = "Address";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(366, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(748, 463);
            panel4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(24, 222);
            textBox5.Margin = new Padding(4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(484, 41);
            textBox5.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(26, 389);
            textBox4.Margin = new Padding(4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(484, 41);
            textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(278, 307);
            textBox3.Margin = new Padding(4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 41);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 307);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 41);
            textBox2.TabIndex = 25;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(24, 143);
            textBox6.Margin = new Padding(4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(484, 41);
            textBox6.TabIndex = 24;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(566, 380);
            button2.Name = "button2";
            button2.Size = new Size(152, 48);
            button2.TabIndex = 23;
            button2.Text = "Save Changes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = Properties.Resources.icons8_available_updates_32;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(566, 265);
            button6.Name = "button6";
            button6.Size = new Size(152, 48);
            button6.TabIndex = 22;
            button6.Text = "      Change Avatar";
            button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.tiem_chup_hinh_the_nhut_phuong_1003425;
            pictureBox1.Location = new Point(566, 59);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(297, 68);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(899, 580);
            panel6.TabIndex = 19;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1196, 648);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "UserInterface";
            Text = "USER INTERFACE";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button3;
        private Label label2;
        private Label label1;
        private Button button5;
        private Button button4;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button button6;
        private PictureBox pictureBox1;
        private Button button7;
        private FileSystemWatcher fileSystemWatcher1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button8;
        private Button button10;
        private Button button9;
    }
}