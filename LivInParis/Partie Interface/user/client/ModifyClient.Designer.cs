namespace LivInParis
{
    partial class ModifyClient
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
            _text_box_mdp = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // _text_box_mdp
            // 
            _text_box_mdp.Location = new Point(229, 203);
            _text_box_mdp.Name = "_text_box_mdp";
            _text_box_mdp.Size = new Size(543, 23);
            _text_box_mdp.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 194);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 6;
            label2.Text = "Mot de Passe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, -11);
            label4.Name = "label4";
            label4.Size = new Size(48, 45);
            label4.TabIndex = 7;
            label4.Text = "←";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 50);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 9;
            label3.Text = "Nom";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(543, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 119);
            label5.Name = "label5";
            label5.Size = new Size(104, 32);
            label5.TabIndex = 11;
            label5.Text = "Prenom";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(543, 23);
            textBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 345);
            label6.Name = "label6";
            label6.Size = new Size(131, 32);
            label6.TabIndex = 15;
            label6.Text = "Telephone";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(229, 356);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(543, 23);
            textBox3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(68, 269);
            label7.Name = "label7";
            label7.Size = new Size(104, 32);
            label7.TabIndex = 13;
            label7.Text = "Adresse";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(229, 278);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(543, 23);
            textBox4.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(77, 416);
            label8.Name = "label8";
            label8.Size = new Size(86, 32);
            label8.TabIndex = 17;
            label8.Text = "E-mail";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(229, 427);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(543, 23);
            textBox5.TabIndex = 16;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(270, 475);
            button1.Name = "button1";
            button1.Size = new Size(227, 74);
            button1.TabIndex = 23;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // UpdateClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(_text_box_mdp);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "UpdateClient";
            Text = "UpdateClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox _text_box_mdp;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Button button1;
    }
}