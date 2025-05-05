namespace LivInParis.Partie_Interface
{
    partial class Modifier_cuisinier
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
            _modif_cuis_box = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            _modif_adresse_box = new TextBox();
            _station_box = new TextBox();
            _mail_box = new TextBox();
            label3 = new Label();
            label4 = new Label();
            mail_box = new Label();
            SuspendLayout();
            // 
            // _modif_cuis_box
            // 
            _modif_cuis_box.FormattingEnabled = true;
            _modif_cuis_box.Location = new Point(262, 129);
            _modif_cuis_box.Name = "_modif_cuis_box";
            _modif_cuis_box.Size = new Size(575, 23);
            _modif_cuis_box.TabIndex = 0;
            _modif_cuis_box.SelectedIndexChanged += _modif_cuis_box_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(437, 515);
            button1.Name = "button1";
            button1.Size = new Size(227, 74);
            button1.TabIndex = 1;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(53, 45);
            label1.TabIndex = 2;
            label1.Text = "⭠";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 128);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "Nom du cuisinier";
            // 
            // _modif_adresse_box
            // 
            _modif_adresse_box.Location = new Point(262, 193);
            _modif_adresse_box.Name = "_modif_adresse_box";
            _modif_adresse_box.Size = new Size(575, 23);
            _modif_adresse_box.TabIndex = 4;
            // 
            // _station_box
            // 
            _station_box.Location = new Point(277, 247);
            _station_box.Name = "_station_box";
            _station_box.Size = new Size(560, 23);
            _station_box.TabIndex = 5;
            // 
            // _mail_box
            // 
            _mail_box.Location = new Point(277, 306);
            _mail_box.Name = "_mail_box";
            _mail_box.Size = new Size(560, 23);
            _mail_box.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(187, 191);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 7;
            label3.Text = "Adresse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 249);
            label4.Name = "label4";
            label4.Size = new Size(247, 21);
            label4.TabIndex = 8;
            label4.Text = "station de métro la plus proche";
            // 
            // mail_box
            // 
            mail_box.AutoSize = true;
            mail_box.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mail_box.Location = new Point(212, 304);
            mail_box.Name = "mail_box";
            mail_box.Size = new Size(59, 21);
            mail_box.TabIndex = 9;
            mail_box.Text = "e-mail";
            // 
            // Modifier_cuisinier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 663);
            Controls.Add(mail_box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(_mail_box);
            Controls.Add(_station_box);
            Controls.Add(_modif_adresse_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(_modif_cuis_box);
            Name = "Modifier_cuisinier";
            Text = "Modifier_cuisinier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _modif_cuis_box;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox _modif_adresse_box;
        private TextBox _station_box;
        private TextBox _mail_box;
        private Label label3;
        private Label label4;
        private Label mail_box;
    }
}