namespace LivInParis
{
    partial class AddNewClient
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
            button1 = new Button();
            _Id_Box = new TextBox();
            _Pwd_Box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(182, 337);
            button1.Name = "button1";
            button1.Size = new Size(418, 78);
            button1.TabIndex = 0;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _Id_Box
            // 
            _Id_Box.Location = new Point(240, 35);
            _Id_Box.Name = "_Id_Box";
            _Id_Box.Size = new Size(308, 23);
            _Id_Box.TabIndex = 1;
            _Id_Box.TextChanged += _Id_Box_TextChanged;
            // 
            // _Pwd_Box
            // 
            _Pwd_Box.Location = new Point(240, 74);
            _Pwd_Box.Name = "_Pwd_Box";
            _Pwd_Box.Size = new Size(308, 23);
            _Pwd_Box.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 4;
            label1.Text = "Identifiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 74);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 5;
            label2.Text = "Mot de Passe";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, -1);
            label3.Name = "label3";
            label3.Size = new Size(50, 47);
            label3.TabIndex = 6;
            label3.Text = "←";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 158);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 10;
            label4.Text = "Nom";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 112);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 9;
            label5.Text = "Prenom";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(116, 204);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 13;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(240, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(308, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(106, 242);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 15;
            label6.Text = "Adresse";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 23);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(106, 281);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 17;
            label8.Text = "Telephone";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(240, 287);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(308, 23);
            textBox5.TabIndex = 16;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // AddNewClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 554);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_Pwd_Box);
            Controls.Add(_Id_Box);
            Controls.Add(button1);
            MaximumSize = new Size(798, 593);
            MinimumSize = new Size(798, 593);
            Name = "AddNewClient";
            Text = "AddNewClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox _Id_Box;
        private TextBox _Pwd_Box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox5;
    }
}