namespace LivInParis.Partie_Interface
{
    partial class AddCuisinier
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            _nom_box = new TextBox();
            _prenom_box = new TextBox();
            _telephone_box = new TextBox();
            _mail_box = new TextBox();
            _adresse_box = new TextBox();
            adresse = new Label();
            _confirmer_button = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label6 = new Label();
            _choix_station_commande = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Nom ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 228);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "prenom ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 358);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "telephone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 487);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "adresse mail ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 684);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(265, 25);
            label5.TabIndex = 4;
            label5.Text = "station de métro la plus proche ";
            // 
            // _nom_box
            // 
            _nom_box.Location = new Point(123, 143);
            _nom_box.Margin = new Padding(4, 5, 4, 5);
            _nom_box.Name = "_nom_box";
            _nom_box.Size = new Size(630, 31);
            _nom_box.TabIndex = 5;
            // 
            // _prenom_box
            // 
            _prenom_box.Location = new Point(123, 263);
            _prenom_box.Margin = new Padding(4, 5, 4, 5);
            _prenom_box.Name = "_prenom_box";
            _prenom_box.Size = new Size(630, 31);
            _prenom_box.TabIndex = 6;
            // 
            // _telephone_box
            // 
            _telephone_box.Location = new Point(129, 392);
            _telephone_box.Margin = new Padding(4, 5, 4, 5);
            _telephone_box.Name = "_telephone_box";
            _telephone_box.Size = new Size(624, 31);
            _telephone_box.TabIndex = 7;
            // 
            // _mail_box
            // 
            _mail_box.Location = new Point(123, 517);
            _mail_box.Margin = new Padding(4, 5, 4, 5);
            _mail_box.Name = "_mail_box";
            _mail_box.Size = new Size(630, 31);
            _mail_box.TabIndex = 8;
            // 
            // _adresse_box
            // 
            _adresse_box.Location = new Point(120, 622);
            _adresse_box.Margin = new Padding(4, 5, 4, 5);
            _adresse_box.Name = "_adresse_box";
            _adresse_box.Size = new Size(627, 31);
            _adresse_box.TabIndex = 10;
            // 
            // adresse
            // 
            adresse.AutoSize = true;
            adresse.Location = new Point(126, 585);
            adresse.Margin = new Padding(4, 0, 4, 0);
            adresse.Name = "adresse";
            adresse.Size = new Size(72, 25);
            adresse.TabIndex = 11;
            adresse.Text = "adresse";
            // 
            // _confirmer_button
            // 
            _confirmer_button.Location = new Point(396, 802);
            _confirmer_button.Margin = new Padding(4, 5, 4, 5);
            _confirmer_button.Name = "_confirmer_button";
            _confirmer_button.Size = new Size(186, 68);
            _confirmer_button.TabIndex = 12;
            _confirmer_button.Text = "Confirmer";
            _confirmer_button.UseVisualStyleBackColor = true;
            _confirmer_button.Click += _confirmer_button_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 65);
            label6.TabIndex = 13;
            label6.Text = "⭠";
            label6.Click += label6_Click;
            // 
            // _choix_station_commande
            // 
            _choix_station_commande.FormattingEnabled = true;
            _choix_station_commande.Location = new Point(120, 727);
            _choix_station_commande.Name = "_choix_station_commande";
            _choix_station_commande.Size = new Size(627, 33);
            _choix_station_commande.TabIndex = 14;
            _choix_station_commande.SelectedIndexChanged += _choix_station_commande_SelectedIndexChanged;
            // 
            // Ajouter_cuisinier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 890);
            Controls.Add(_choix_station_commande);
            Controls.Add(label6);
            Controls.Add(_confirmer_button);
            Controls.Add(adresse);
            Controls.Add(_adresse_box);
            Controls.Add(_mail_box);
            Controls.Add(_telephone_box);
            Controls.Add(_prenom_box);
            Controls.Add(_nom_box);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Ajouter_cuisinier";
            Text = "Ajouter_cuisinier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox _nom_box;
        private TextBox _prenom_box;
        private TextBox _telephone_box;
        private TextBox _mail_box;
        private TextBox _adresse_box;
        private Label adresse;
        private Button _confirmer_button;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label6;
        private ComboBox _choix_station_commande;
    }
}