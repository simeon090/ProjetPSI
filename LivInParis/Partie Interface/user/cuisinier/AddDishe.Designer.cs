namespace LivInParis.Partie_Interface
{
    partial class AddDishe
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
            _nom_met_box = new TextBox();
            _prix_met_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            _quantité_box = new TextBox();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            _type_met_box = new TextBox();
            _regime_ali_box = new TextBox();
            _quantite_box = new Label();
            _confirmer_button = new Button();
            label8 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // _nom_met_box
            // 
            _nom_met_box.Location = new Point(60, 180);
            _nom_met_box.Margin = new Padding(4, 5, 4, 5);
            _nom_met_box.Name = "_nom_met_box";
            _nom_met_box.Size = new Size(945, 31);
            _nom_met_box.TabIndex = 0;
            _nom_met_box.TextChanged += textBox1_TextChanged;
            // 
            // _prix_met_box
            // 
            _prix_met_box.Location = new Point(60, 515);
            _prix_met_box.Margin = new Padding(4, 5, 4, 5);
            _prix_met_box.Name = "_prix_met_box";
            _prix_met_box.Size = new Size(941, 31);
            _prix_met_box.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 4;
            label1.Text = "Nom du met";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 253);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 5;
            label2.Text = "Type du met ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 485);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 7;
            label4.Text = "Prix ";
            // 
            // _quantité_box
            // 
            _quantité_box.Location = new Point(517, 1092);
            _quantité_box.Margin = new Padding(4, 5, 4, 5);
            _quantité_box.Name = "_quantité_box";
            _quantité_box.Size = new Size(1063, 31);
            _quantité_box.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 1062);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 9;
            label5.Text = "Quantité ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 365);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 6;
            label3.Text = "Régime alimentaire ";
            // 
            // button1
            // 
            button1.Location = new Point(811, 1297);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(430, 163);
            button1.TabIndex = 12;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            // 
            // _type_met_box
            // 
            _type_met_box.Location = new Point(60, 293);
            _type_met_box.Margin = new Padding(4, 5, 4, 5);
            _type_met_box.Name = "_type_met_box";
            _type_met_box.Size = new Size(945, 31);
            _type_met_box.TabIndex = 17;
            // 
            // _regime_ali_box
            // 
            _regime_ali_box.Location = new Point(64, 395);
            _regime_ali_box.Margin = new Padding(4, 5, 4, 5);
            _regime_ali_box.Name = "_regime_ali_box";
            _regime_ali_box.Size = new Size(941, 31);
            _regime_ali_box.TabIndex = 18;
            // 
            // _quantite_box
            // 
            _quantite_box.AutoSize = true;
            _quantite_box.Location = new Point(60, 583);
            _quantite_box.Margin = new Padding(4, 0, 4, 0);
            _quantite_box.Name = "_quantite_box";
            _quantite_box.Size = new Size(80, 25);
            _quantite_box.TabIndex = 20;
            _quantite_box.Text = "Quantité";
            _quantite_box.Click += _quantite_box_Click;
            // 
            // _confirmer_button
            // 
            _confirmer_button.Location = new Point(383, 833);
            _confirmer_button.Margin = new Padding(4, 5, 4, 5);
            _confirmer_button.Name = "_confirmer_button";
            _confirmer_button.Size = new Size(293, 82);
            _confirmer_button.TabIndex = 21;
            _confirmer_button.Text = "Confirmer";
            _confirmer_button.UseVisualStyleBackColor = true;
            _confirmer_button.Click += _confirmer_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(-4, -23);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 65);
            label8.TabIndex = 22;
            label8.Text = "←";
            label8.Click += label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 720);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 23;
            label6.Text = "Nationalité";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 767);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(941, 31);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 638);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(941, 31);
            textBox2.TabIndex = 25;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(319, 34);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(410, 65);
            label7.TabIndex = 26;
            label7.Text = "Ajouter un met : ";
            label7.Click += label7_Click;
            // 
            // AddDishe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 907);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(_confirmer_button);
            Controls.Add(_quantite_box);
            Controls.Add(_regime_ali_box);
            Controls.Add(_type_met_box);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(_quantité_box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_prix_met_box);
            Controls.Add(_nom_met_box);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1133, 963);
            MinimumSize = new Size(1133, 963);
            Name = "AddDishe";
            Text = "Ajouter_un_met";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _nom_met_box;
        private TextBox _prix_met_box;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox _quantité_box;
        private Label label5;
        private Label label3;
      
        private ComboBox _regime_alimentaire_box;
        private Button button1;
        private TextBox _type_met_box;
        private TextBox _regime_ali_box;
        private Label _quantite_box;
        private Button _confirmer_button;
        private Label label8;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
    }
}