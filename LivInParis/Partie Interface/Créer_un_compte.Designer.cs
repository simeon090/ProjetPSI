namespace LivInParis
{
    partial class Créer_un_compte
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
            _nom_create = new TextBox();
            _prenom_create = new TextBox();
            _adresse_create = new TextBox();
            _tel_create = new TextBox();
            _id_create = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            _mdp_create = new TextBox();
            label7 = new Label();
            _confirm_button = new Button();
            label8 = new Label();
            label5 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // _nom_create
            // 
            _nom_create.Location = new Point(123, 119);
            _nom_create.Margin = new Padding(4, 5, 4, 5);
            _nom_create.Name = "_nom_create";
            _nom_create.Size = new Size(744, 31);
            _nom_create.TabIndex = 0;
            // 
            // _prenom_create
            // 
            _prenom_create.Location = new Point(119, 225);
            _prenom_create.Margin = new Padding(4, 5, 4, 5);
            _prenom_create.Name = "_prenom_create";
            _prenom_create.Size = new Size(747, 31);
            _prenom_create.TabIndex = 1;
            // 
            // _adresse_create
            // 
            _adresse_create.Location = new Point(122, 450);
            _adresse_create.Margin = new Padding(4, 5, 4, 5);
            _adresse_create.Name = "_adresse_create";
            _adresse_create.Size = new Size(747, 31);
            _adresse_create.TabIndex = 2;
            // 
            // _tel_create
            // 
            _tel_create.Location = new Point(120, 562);
            _tel_create.Margin = new Padding(4, 5, 4, 5);
            _tel_create.Name = "_tel_create";
            _tel_create.Size = new Size(747, 31);
            _tel_create.TabIndex = 3;
            // 
            // _id_create
            // 
            _id_create.Location = new Point(122, 335);
            _id_create.Margin = new Padding(4, 5, 4, 5);
            _id_create.Name = "_id_create";
            _id_create.Size = new Size(747, 31);
            _id_create.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 38);
            label1.TabIndex = 5;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 38);
            label2.TabIndex = 6;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 403);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 38);
            label3.TabIndex = 7;
            label3.Text = "Adresse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 508);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 38);
            label4.TabIndex = 8;
            label4.Text = "Téléphone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(119, 288);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(142, 38);
            label6.TabIndex = 10;
            label6.Text = "Identifiant";
            label6.Click += label6_Click;
            // 
            // _mdp_create
            // 
            _mdp_create.Location = new Point(119, 667);
            _mdp_create.Margin = new Padding(4, 5, 4, 5);
            _mdp_create.Name = "_mdp_create";
            _mdp_create.Size = new Size(744, 31);
            _mdp_create.TabIndex = 11;
            _mdp_create.TextChanged += _mdp_create_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(119, 614);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(191, 38);
            label7.TabIndex = 12;
            label7.Text = "Mot de passe ";
            // 
            // _confirm_button
            // 
            _confirm_button.Location = new Point(353, 808);
            _confirm_button.Margin = new Padding(4, 5, 4, 5);
            _confirm_button.Name = "_confirm_button";
            _confirm_button.Size = new Size(313, 120);
            _confirm_button.TabIndex = 13;
            _confirm_button.Text = "Confirmer";
            _confirm_button.UseVisualStyleBackColor = true;
            _confirm_button.Click += _confirm_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(120, -3);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(832, 65);
            label8.TabIndex = 14;
            label8.Text = "Renseigner les informations suivantes ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, -3);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 65);
            label5.TabIndex = 15;
            label5.Text = "←";
            label5.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(119, 717);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(83, 38);
            label9.TabIndex = 17;
            label9.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 767);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(744, 31);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Créer_un_compte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 907);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(_confirm_button);
            Controls.Add(label7);
            Controls.Add(_mdp_create);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_id_create);
            Controls.Add(_tel_create);
            Controls.Add(_adresse_create);
            Controls.Add(_prenom_create);
            Controls.Add(_nom_create);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1133, 963);
            MinimumSize = new Size(1133, 963);
            Name = "Créer_un_compte";
            Text = "Créer_un_compte";
            Load += Créer_un_compte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _nom_create;
        private TextBox _prenom_create;
        private TextBox _adresse_create;
        private TextBox _tel_create;
        private TextBox _id_create;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox _mdp_create;
        private Label label7;
        private Button _confirm_button;
        private Label label8;
        private Label label5;
        private Label label9;
        private TextBox textBox1;
    }
}