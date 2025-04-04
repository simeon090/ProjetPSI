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
            label5 = new Label();
            label6 = new Label();
            _mdp_create = new TextBox();
            label7 = new Label();
            _confirm_button = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // _nom_create
            // 
            _nom_create.Location = new Point(449, 125);
            _nom_create.Name = "_nom_create";
            _nom_create.Size = new Size(527, 23);
            _nom_create.TabIndex = 0;
            // 
            // _prenom_create
            // 
            _prenom_create.Location = new Point(449, 192);
            _prenom_create.Name = "_prenom_create";
            _prenom_create.Size = new Size(527, 23);
            _prenom_create.TabIndex = 1;
            // 
            // _adresse_create
            // 
            _adresse_create.Location = new Point(451, 271);
            _adresse_create.Name = "_adresse_create";
            _adresse_create.Size = new Size(527, 23);
            _adresse_create.TabIndex = 2;
            // 
            // _tel_create
            // 
            _tel_create.Location = new Point(449, 344);
            _tel_create.Name = "_tel_create";
            _tel_create.Size = new Size(527, 23);
            _tel_create.TabIndex = 3;
            // 
            // _id_create
            // 
            _id_create.Location = new Point(436, 507);
            _id_create.Name = "_id_create";
            _id_create.Size = new Size(527, 23);
            _id_create.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 77);
            label1.Name = "label1";
            label1.Size = new Size(91, 45);
            label1.TabIndex = 5;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(438, 151);
            label2.Name = "label2";
            label2.Size = new Size(131, 45);
            label2.TabIndex = 6;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(438, 223);
            label3.Name = "label3";
            label3.Size = new Size(133, 45);
            label3.TabIndex = 7;
            label3.Text = "Adresse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(438, 297);
            label4.Name = "label4";
            label4.Size = new Size(167, 45);
            label4.TabIndex = 8;
            label4.Text = "Téléphone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(211, 392);
            label5.Name = "label5";
            label5.Size = new Size(1153, 45);
            label5.TabIndex = 9;
            label5.Text = "Créer les identifiants que vous allez utilisés pour vos connecter sur l'application ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(436, 450);
            label6.Name = "label6";
            label6.Size = new Size(165, 45);
            label6.TabIndex = 10;
            label6.Text = "Identifiant";
            // 
            // _mdp_create
            // 
            _mdp_create.Location = new Point(438, 596);
            _mdp_create.Name = "_mdp_create";
            _mdp_create.Size = new Size(525, 23);
            _mdp_create.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(429, 533);
            label7.Name = "label7";
            label7.Size = new Size(222, 45);
            label7.TabIndex = 12;
            label7.Text = "Mot de passe ";
            // 
            // _confirm_button
            // 
            _confirm_button.Location = new Point(532, 664);
            _confirm_button.Name = "_confirm_button";
            _confirm_button.Size = new Size(219, 72);
            _confirm_button.TabIndex = 13;
            _confirm_button.Text = "Confirmer";
            _confirm_button.UseVisualStyleBackColor = true;
            _confirm_button.Click += _confirm_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(415, 9);
            label8.Name = "label8";
            label8.Size = new Size(563, 45);
            label8.TabIndex = 14;
            label8.Text = "Renseigner les informations suivantes ";
            // 
            // Créer_un_compte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 879);
            Controls.Add(label8);
            Controls.Add(_confirm_button);
            Controls.Add(label7);
            Controls.Add(_mdp_create);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_id_create);
            Controls.Add(_tel_create);
            Controls.Add(_adresse_create);
            Controls.Add(_prenom_create);
            Controls.Add(_nom_create);
            Name = "Créer_un_compte";
            Text = "Créer_un_compte";
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
        private Label label5;
        private Label label6;
        private TextBox _mdp_create;
        private Label label7;
        private Button _confirm_button;
        private Label label8;
    }
}