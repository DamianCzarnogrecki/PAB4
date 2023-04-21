namespace PAB4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textbox_kod = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textbox_wojewodztwo = new TextBox();
            label2 = new Label();
            textbox_miejscowosc = new TextBox();
            label1 = new Label();
            textbox_adres = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            textbox_uwagi = new TextBox();
            textbox_powiat = new TextBox();
            userControl15 = new UserControl1();
            errorLabel = new Label();
            dataEditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 340);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(736, 299);
            dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 12);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 21;
            label5.Text = "Kod pocztowy:";
            // 
            // textbox_kod
            // 
            textbox_kod.Location = new Point(12, 30);
            textbox_kod.Name = "textbox_kod";
            textbox_kod.Size = new Size(222, 23);
            textbox_kod.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 228);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 19;
            label4.Text = "Powiat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 17;
            label3.Text = "Województwo:";
            // 
            // textbox_wojewodztwo
            // 
            textbox_wojewodztwo.Location = new Point(12, 192);
            textbox_wojewodztwo.Name = "textbox_wojewodztwo";
            textbox_wojewodztwo.Size = new Size(222, 23);
            textbox_wojewodztwo.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 15;
            label2.Text = "Miejscowość:";
            // 
            // textbox_miejscowosc
            // 
            textbox_miejscowosc.Location = new Point(12, 137);
            textbox_miejscowosc.Name = "textbox_miejscowosc";
            textbox_miejscowosc.Size = new Size(222, 23);
            textbox_miejscowosc.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 13;
            label1.Text = "Adres:";
            // 
            // textbox_adres
            // 
            textbox_adres.Location = new Point(12, 83);
            textbox_adres.Name = "textbox_adres";
            textbox_adres.Size = new Size(222, 23);
            textbox_adres.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(305, 29);
            button3.Name = "button3";
            button3.Size = new Size(222, 23);
            button3.TabIndex = 24;
            button3.Text = "Wyszukaj (pobranie i filtracja)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(305, 58);
            button2.Name = "button2";
            button2.Size = new Size(222, 23);
            button2.TabIndex = 23;
            button2.Text = "Wyszukaj (Entity Framework – LINQ)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(305, 87);
            button1.Name = "button1";
            button1.Size = new Size(222, 23);
            button1.TabIndex = 22;
            button1.Text = "Wyszukaj (Dapper – kwerenda SQL)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 26;
            label6.Text = "Uwagi:";
            // 
            // textbox_uwagi
            // 
            textbox_uwagi.Location = new Point(12, 302);
            textbox_uwagi.Name = "textbox_uwagi";
            textbox_uwagi.Size = new Size(222, 23);
            textbox_uwagi.TabIndex = 25;
            // 
            // textbox_powiat
            // 
            textbox_powiat.Location = new Point(12, 246);
            textbox_powiat.Name = "textbox_powiat";
            textbox_powiat.Size = new Size(222, 23);
            textbox_powiat.TabIndex = 18;
            // 
            // userControl15
            // 
            userControl15.Location = new Point(883, 340);
            userControl15.Name = "userControl15";
            userControl15.Size = new Size(448, 299);
            userControl15.TabIndex = 27;
            userControl15.Load += userControl15_Load;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(305, 137);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 28;
            // 
            // dataEditButton
            // 
            dataEditButton.Location = new Point(305, 301);
            dataEditButton.Name = "dataEditButton";
            dataEditButton.Size = new Size(222, 23);
            dataEditButton.TabIndex = 29;
            dataEditButton.Text = "Edytuj wpis";
            dataEditButton.UseVisualStyleBackColor = true;
            dataEditButton.Click += dataEditButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1343, 644);
            Controls.Add(dataEditButton);
            Controls.Add(errorLabel);
            Controls.Add(userControl15);
            Controls.Add(label6);
            Controls.Add(textbox_uwagi);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textbox_kod);
            Controls.Add(label4);
            Controls.Add(textbox_powiat);
            Controls.Add(label3);
            Controls.Add(textbox_wojewodztwo);
            Controls.Add(label2);
            Controls.Add(textbox_miejscowosc);
            Controls.Add(label1);
            Controls.Add(textbox_adres);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textbox_kod;
        private Label label4;
        private Label label3;
        private TextBox textbox_wojewodztwo;
        private Label label2;
        private TextBox textbox_miejscowosc;
        private Label label1;
        private TextBox textbox_adres;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private TextBox textbox_uwagi;
        private TextBox textbox_powiat;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        public UserControl1 userControl14;
        private UserControl1 userControl15;
        private Label errorLabel;
        private Button dataEditButton;
    }
}