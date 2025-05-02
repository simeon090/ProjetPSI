namespace LivInParis
{
    partial class Passer_commande
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
            _choix_station_commande = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            box_commande = new CheckedListBox();
            SuspendLayout();
            // 
            // _choix_station_commande
            // 
            _choix_station_commande.FormattingEnabled = true;
            _choix_station_commande.Location = new Point(325, 166);
            _choix_station_commande.Name = "_choix_station_commande";
            _choix_station_commande.Size = new Size(974, 25);
            _choix_station_commande.TabIndex = 0;
            _choix_station_commande.SelectedIndexChanged += _choix_station_commande_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 26);
            label1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(504, 83);
            label3.Name = "label3";
            label3.Size = new Size(551, 40);
            label3.TabIndex = 4;
            label3.Text = "Choisir la station la plus proche de vous ? ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 242);
            label2.Name = "label2";
            label2.Size = new Size(961, 50);
            label2.TabIndex = 5;
            label2.Text = "Sélectionner les mets que vous souhaitez commander ";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1153, 893);
            button1.Name = "button1";
            button1.Size = new Size(265, 65);
            button1.TabIndex = 6;
            button1.Text = "Consulter votre Panier ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // box_commande
            // 
            box_commande.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            box_commande.FormattingEnabled = true;
            box_commande.Location = new Point(109, 356);
            box_commande.Name = "box_commande";
            box_commande.Size = new Size(1309, 454);
            box_commande.TabIndex = 7;
            box_commande.SelectedIndexChanged += box_commande_SelectedIndexChanged;
            // 
            // Passer_commande
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 1050);
            Controls.Add(box_commande);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(_choix_station_commande);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Passer_commande";
            Text = "Passer_commande";
            Load += Passer_commande_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _choix_station_commande;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button1;
        private CheckedListBox box_commande;
    }
}