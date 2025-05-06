namespace LivInParis.Partie_Interface
{
    partial class Modifier_un_met
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
            label1 = new Label();
            mail_box = new Label();
            label4 = new Label();
            label3 = new Label();
            _mail_box = new TextBox();
            _station_box = new TextBox();
            _modif_adresse_box = new TextBox();
            label2 = new Label();
            _modif_cuis_box = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, -8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 65);
            label1.TabIndex = 0;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // mail_box
            // 
            mail_box.AutoSize = true;
            mail_box.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mail_box.Location = new Point(120, 487);
            mail_box.Margin = new Padding(4, 0, 4, 0);
            mail_box.Name = "mail_box";
            mail_box.Size = new Size(141, 32);
            mail_box.TabIndex = 15;
            mail_box.Text = "Nationalité";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(149, 398);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 14;
            label4.Text = "Quantité";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 308);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 13;
            label3.Text = "Régime";
            // 
            // _mail_box
            // 
            _mail_box.Location = new Point(311, 490);
            _mail_box.Margin = new Padding(4, 5, 4, 5);
            _mail_box.Name = "_mail_box";
            _mail_box.Size = new Size(628, 31);
            _mail_box.TabIndex = 12;
            _mail_box.TextChanged += _mail_box_TextChanged;
            // 
            // _station_box
            // 
            _station_box.Location = new Point(311, 395);
            _station_box.Margin = new Padding(4, 5, 4, 5);
            _station_box.Name = "_station_box";
            _station_box.Size = new Size(628, 31);
            _station_box.TabIndex = 11;
            _station_box.TextChanged += _station_box_TextChanged;
            // 
            // _modif_adresse_box
            // 
            _modif_adresse_box.Location = new Point(311, 305);
            _modif_adresse_box.Margin = new Padding(4, 5, 4, 5);
            _modif_adresse_box.Name = "_modif_adresse_box";
            _modif_adresse_box.Size = new Size(628, 31);
            _modif_adresse_box.TabIndex = 10;
            _modif_adresse_box.TextChanged += _modif_adresse_box_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 31);
            label2.TabIndex = 17;
            label2.Text = "Modifier le plat :";
            // 
            // _modif_cuis_box
            // 
            _modif_cuis_box.FormattingEnabled = true;
            _modif_cuis_box.Location = new Point(230, 125);
            _modif_cuis_box.Margin = new Padding(4, 5, 4, 5);
            _modif_cuis_box.Name = "_modif_cuis_box";
            _modif_cuis_box.Size = new Size(820, 33);
            _modif_cuis_box.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(177, 580);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 32);
            label5.TabIndex = 19;
            label5.Text = "Prix";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 583);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(628, 31);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(177, 670);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 32);
            label6.TabIndex = 21;
            label6.Text = "Type";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 673);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(628, 31);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(393, 768);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(324, 123);
            button1.TabIndex = 22;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(177, 208);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 32);
            label7.TabIndex = 24;
            label7.Text = "Nom";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(311, 212);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(628, 31);
            textBox3.TabIndex = 23;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(339, 25);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(436, 65);
            label8.TabIndex = 27;
            label8.Text = "Modifier un met : ";
            // 
            // Modifier_un_met
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 907);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(_modif_cuis_box);
            Controls.Add(mail_box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(_mail_box);
            Controls.Add(_station_box);
            Controls.Add(_modif_adresse_box);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1133, 963);
            MinimumSize = new Size(1133, 963);
            Name = "Modifier_un_met";
            Text = "Modifier_un_met";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label mail_box;
        private Label label4;
        private Label label3;
        private TextBox _mail_box;
        private TextBox _station_box;
        private TextBox _modif_adresse_box;
        private Label label2;
        private ComboBox _modif_cuis_box;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Button button1;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
    }
}