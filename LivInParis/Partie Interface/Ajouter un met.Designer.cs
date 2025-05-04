namespace LivInParis.Partie_Interface
{
    partial class Ajouter_un_met
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
            _id_met = new TextBox();
            label6 = new Label();
            _tel_cui_box = new TextBox();
            label7 = new Label();
            _type_met_box = new TextBox();
            _regime_ali_box = new TextBox();
            _quantite_box_ = new TextBox();
            _quantite_box = new Label();
            _confirmer_button = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // _nom_met_box
            // 
            _nom_met_box.Location = new Point(53, 116);
            _nom_met_box.Name = "_nom_met_box";
            _nom_met_box.Size = new Size(663, 23);
            _nom_met_box.TabIndex = 0;
            _nom_met_box.TextChanged += textBox1_TextChanged;
            // 
            // _prix_met_box
            // 
            _prix_met_box.Location = new Point(56, 361);
            _prix_met_box.Name = "_prix_met_box";
            _prix_met_box.Size = new Size(660, 23);
            _prix_met_box.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 98);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Nom du met";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 160);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Type du met ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 343);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Prix ";
            // 
            // _quantité_box
            // 
            _quantité_box.Location = new Point(362, 655);
            _quantité_box.Name = "_quantité_box";
            _quantité_box.Size = new Size(745, 23);
            _quantité_box.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 637);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Quantité ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 227);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 6;
            label3.Text = "Régime alimentaire ";
            // 
            // button1
            // 
            button1.Location = new Point(568, 778);
            button1.Name = "button1";
            button1.Size = new Size(301, 98);
            button1.TabIndex = 12;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            // 
            // _id_met
            // 
            _id_met.Location = new Point(53, 63);
            _id_met.Name = "_id_met";
            _id_met.Size = new Size(663, 23);
            _id_met.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 45);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "id_met";
            // 
            // _tel_cui_box
            // 
            _tel_cui_box.Location = new Point(56, 304);
            _tel_cui_box.Name = "_tel_cui_box";
            _tel_cui_box.Size = new Size(660, 23);
            _tel_cui_box.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 286);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 16;
            label7.Text = "Telephone_cuisinier";
            // 
            // _type_met_box
            // 
            _type_met_box.Location = new Point(53, 184);
            _type_met_box.Name = "_type_met_box";
            _type_met_box.Size = new Size(663, 23);
            _type_met_box.TabIndex = 17;
            // 
            // _regime_ali_box
            // 
            _regime_ali_box.Location = new Point(56, 245);
            _regime_ali_box.Name = "_regime_ali_box";
            _regime_ali_box.Size = new Size(660, 23);
            _regime_ali_box.TabIndex = 18;
            // 
            // _quantite_box_
            // 
            _quantite_box_.Location = new Point(56, 431);
            _quantite_box_.Name = "_quantite_box_";
            _quantite_box_.Size = new Size(660, 23);
            _quantite_box_.TabIndex = 19;
            // 
            // _quantite_box
            // 
            _quantite_box.AutoSize = true;
            _quantite_box.Location = new Point(60, 407);
            _quantite_box.Name = "_quantite_box";
            _quantite_box.Size = new Size(75, 15);
            _quantite_box.TabIndex = 20;
            _quantite_box.Text = "quantité_box";
            // 
            // _confirmer_button
            // 
            _confirmer_button.Location = new Point(280, 479);
            _confirmer_button.Name = "_confirmer_button";
            _confirmer_button.Size = new Size(205, 49);
            _confirmer_button.TabIndex = 21;
            _confirmer_button.Text = "Confirmer";
            _confirmer_button.UseVisualStyleBackColor = true;
            _confirmer_button.Click += _confirmer_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(-3, -14);
            label8.Name = "label8";
            label8.Size = new Size(48, 45);
            label8.TabIndex = 22;
            label8.Text = "←";
            label8.Click += label8_Click;
            // 
            // Ajouter_un_met
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label8);
            Controls.Add(_confirmer_button);
            Controls.Add(_quantite_box);
            Controls.Add(_quantite_box_);
            Controls.Add(_regime_ali_box);
            Controls.Add(_type_met_box);
            Controls.Add(label7);
            Controls.Add(_tel_cui_box);
            Controls.Add(label6);
            Controls.Add(_id_met);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(_quantité_box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_prix_met_box);
            Controls.Add(_nom_met_box);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Ajouter_un_met";
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
        private TextBox _id_met;
        private Label label6;
        private TextBox _tel_cui_box;
        private Label label7;
        private TextBox _type_met_box;
        private TextBox _regime_ali_box;
        private TextBox _quantite_box_;
        private Label _quantite_box;
        private Button _confirmer_button;
        private Label label8;
    }
}