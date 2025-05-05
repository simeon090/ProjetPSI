namespace LivInParis.Partie_Interface
{
    partial class Ajouter_cuisinier
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
            _metro_box = new TextBox();
            _adresse_box = new TextBox();
            adresse = new Label();
            _confirmer_button = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 59);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 137);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "prenom ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 215);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "telephone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 292);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "adresse mail ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 409);
            label5.Name = "label5";
            label5.Size = new Size(174, 15);
            label5.TabIndex = 4;
            label5.Text = "station de métro la plus proche ";
            // 
            // _nom_box
            // 
            _nom_box.Location = new Point(86, 86);
            _nom_box.Name = "_nom_box";
            _nom_box.Size = new Size(442, 23);
            _nom_box.TabIndex = 5;
            // 
            // _prenom_box
            // 
            _prenom_box.Location = new Point(86, 158);
            _prenom_box.Name = "_prenom_box";
            _prenom_box.Size = new Size(442, 23);
            _prenom_box.TabIndex = 6;
            // 
            // _telephone_box
            // 
            _telephone_box.Location = new Point(90, 235);
            _telephone_box.Name = "_telephone_box";
            _telephone_box.Size = new Size(438, 23);
            _telephone_box.TabIndex = 7;
            // 
            // _mail_box
            // 
            _mail_box.Location = new Point(86, 310);
            _mail_box.Name = "_mail_box";
            _mail_box.Size = new Size(442, 23);
            _mail_box.TabIndex = 8;
            // 
            // _metro_box
            // 
            _metro_box.Location = new Point(84, 427);
            _metro_box.Name = "_metro_box";
            _metro_box.Size = new Size(440, 23);
            _metro_box.TabIndex = 9;
            // 
            // _adresse_box
            // 
            _adresse_box.Location = new Point(84, 373);
            _adresse_box.Name = "_adresse_box";
            _adresse_box.Size = new Size(440, 23);
            _adresse_box.TabIndex = 10;
            // 
            // adresse
            // 
            adresse.AutoSize = true;
            adresse.Location = new Point(88, 351);
            adresse.Name = "adresse";
            adresse.Size = new Size(46, 15);
            adresse.TabIndex = 11;
            adresse.Text = "adresse";
            // 
            // _confirmer_button
            // 
            _confirmer_button.Location = new Point(277, 481);
            _confirmer_button.Name = "_confirmer_button";
            _confirmer_button.Size = new Size(130, 41);
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
            label6.Location = new Point(2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 45);
            label6.TabIndex = 13;
            label6.Text = "⭠";
            label6.Click += label6_Click;
            // 
            // Ajouter_cuisinier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 534);
            Controls.Add(label6);
            Controls.Add(_confirmer_button);
            Controls.Add(adresse);
            Controls.Add(_adresse_box);
            Controls.Add(_metro_box);
            Controls.Add(_mail_box);
            Controls.Add(_telephone_box);
            Controls.Add(_prenom_box);
            Controls.Add(_nom_box);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private TextBox _metro_box;
        private TextBox _adresse_box;
        private Label adresse;
        private Button _confirmer_button;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Label label6;
    }
}