namespace LivInParis.Partie_Interface
{
    partial class CreateCuisinier
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
            button1 = new Button();
            _choix_station_commande = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(742, 45);
            label1.TabIndex = 3;
            label1.Text = "Entrez la station la plus proche de votre cuisine :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(173, 251);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(408, 80);
            button1.TabIndex = 5;
            button1.Text = "Devenir Cuisinier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // _choix_station_commande
            // 
            _choix_station_commande.FormattingEnabled = true;
            _choix_station_commande.Location = new Point(87, 173);
            _choix_station_commande.Name = "_choix_station_commande";
            _choix_station_commande.Size = new Size(590, 33);
            _choix_station_commande.TabIndex = 6;
            _choix_station_commande.SelectedIndexChanged += _choix_station_commande_SelectedIndexChanged;
            // 
            // CréationCuisinier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_choix_station_commande);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CréationCuisinier";
            Text = "CréationCuisinier";
            Load += CréationCuisinier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ComboBox _choix_station_commande;
    }
}