namespace PAB4
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            textbox_uwagi = new TextBox();
            label5 = new Label();
            textbox_kod = new TextBox();
            label4 = new Label();
            textbox_powiat = new TextBox();
            label3 = new Label();
            textbox_wojewodztwo = new TextBox();
            label2 = new Label();
            textbox_miejscowosc = new TextBox();
            label1 = new Label();
            textbox_adres = new TextBox();
            editButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(248, 117);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 38;
            label6.Text = "Uwagi:";
            // 
            // textbox_uwagi
            // 
            textbox_uwagi.Location = new Point(248, 135);
            textbox_uwagi.Name = "textbox_uwagi";
            textbox_uwagi.Size = new Size(222, 23);
            textbox_uwagi.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 10);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 36;
            label5.Text = "Kod pocztowy:";
            // 
            // textbox_kod
            // 
            textbox_kod.Location = new Point(20, 28);
            textbox_kod.Name = "textbox_kod";
            textbox_kod.Size = new Size(222, 23);
            textbox_kod.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(248, 63);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 34;
            label4.Text = "Powiat:";
            // 
            // textbox_powiat
            // 
            textbox_powiat.Location = new Point(248, 81);
            textbox_powiat.Name = "textbox_powiat";
            textbox_powiat.Size = new Size(222, 23);
            textbox_powiat.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(248, 10);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 32;
            label3.Text = "Województwo:";
            // 
            // textbox_wojewodztwo
            // 
            textbox_wojewodztwo.Location = new Point(248, 28);
            textbox_wojewodztwo.Name = "textbox_wojewodztwo";
            textbox_wojewodztwo.Size = new Size(222, 23);
            textbox_wojewodztwo.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 117);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 30;
            label2.Text = "Miejscowość:";
            // 
            // textbox_miejscowosc
            // 
            textbox_miejscowosc.Location = new Point(20, 135);
            textbox_miejscowosc.Name = "textbox_miejscowosc";
            textbox_miejscowosc.Size = new Size(222, 23);
            textbox_miejscowosc.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 28;
            label1.Text = "Adres:";
            // 
            // textbox_adres
            // 
            textbox_adres.Location = new Point(20, 81);
            textbox_adres.Name = "textbox_adres";
            textbox_adres.Size = new Size(222, 23);
            textbox_adres.TabIndex = 27;
            // 
            // editButton
            // 
            editButton.Location = new Point(20, 189);
            editButton.Name = "editButton";
            editButton.Size = new Size(222, 23);
            editButton.TabIndex = 39;
            editButton.Text = "edytuj wpis";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(248, 189);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(222, 23);
            deleteButton.TabIndex = 40;
            deleteButton.Text = "usuń wpis";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(label6);
            Controls.Add(textbox_uwagi);
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
            Name = "UserControl2";
            Size = new Size(492, 231);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button editButton;
        public Button deleteButton;
        public TextBox textbox_uwagi;
        public TextBox textbox_kod;
        public TextBox textbox_powiat;
        public TextBox textbox_wojewodztwo;
        public TextBox textbox_miejscowosc;
        public TextBox textbox_adres;
    }
}
