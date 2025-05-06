namespace LivInParis.Partie_Interface
{
    partial class ModifyCuisinier
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
            label9 = new Label();
            SuspendLayout();
            // 
            // _modif_cuis_box
            // 
            _modif_cuis_box.FormattingEnabled = true;
            _modif_cuis_box.Location = new Point(374, 215);
            _modif_cuis_box.Margin = new Padding(4, 5, 4, 5);
            _modif_cuis_box.Name = "_modif_cuis_box";
            _modif_cuis_box.Size = new Size(820, 33);
            _modif_cuis_box.TabIndex = 0;
            _modif_cuis_box.SelectedIndexChanged += _modif_cuis_box_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(458, 649);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(324, 123);
            button1.TabIndex = 1;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 65);
            label1.TabIndex = 2;
            label1.Text = "⭠";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 213);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 31);
            label2.TabIndex = 3;
            label2.Text = "Nom du cuisinier";
            // 
            // _modif_adresse_box
            // 
            _modif_adresse_box.Location = new Point(374, 322);
            _modif_adresse_box.Margin = new Padding(4, 5, 4, 5);
            _modif_adresse_box.Name = "_modif_adresse_box";
            _modif_adresse_box.Size = new Size(820, 31);
            _modif_adresse_box.TabIndex = 4;
            // 
            // _station_box
            // 
            _station_box.Location = new Point(374, 412);
            _station_box.Margin = new Padding(4, 5, 4, 5);
            _station_box.Name = "_station_box";
            _station_box.Size = new Size(820, 31);
            _station_box.TabIndex = 5;
            // 
            // _mail_box
            // 
            _mail_box.Location = new Point(396, 510);
            _mail_box.Margin = new Padding(4, 5, 4, 5);
            _mail_box.Name = "_mail_box";
            _mail_box.Size = new Size(798, 31);
            _mail_box.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 318);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 7;
            label3.Text = "Adresse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 409);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(373, 32);
            label4.TabIndex = 8;
            label4.Text = "Station de métro la plus proche";
            // 
            // mail_box
            // 
            mail_box.AutoSize = true;
            mail_box.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mail_box.Location = new Point(303, 507);
            mail_box.Margin = new Padding(4, 0, 4, 0);
            mail_box.Name = "mail_box";
            mail_box.Size = new Size(86, 32);
            mail_box.TabIndex = 9;
            mail_box.Text = "e-mail";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(396, 50);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(446, 65);
            label9.TabIndex = 19;
            label9.Text = "Modifier un cuisinier : ";
            label9.Click += label9_Click;
            // 
            // ModifyCuisinier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 1050);
            Controls.Add(label9);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModifyCuisinier";
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
        private Label label9;
    }
}