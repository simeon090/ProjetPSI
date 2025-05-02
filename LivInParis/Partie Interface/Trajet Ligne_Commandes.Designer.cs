namespace LivInParis.Partie_Interface
{
    partial class Trajet_Ligne_Commandes
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
            arrivee_box = new TextBox();
            label1 = new Label();
            départ_box = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // arrivee_box
            // 
            arrivee_box.Location = new Point(286, 118);
            arrivee_box.Margin = new Padding(2);
            arrivee_box.Name = "arrivee_box";
            arrivee_box.Size = new Size(637, 23);
            arrivee_box.TabIndex = 0;
            arrivee_box.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 101);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Station d'arrivée ";
            // 
            // départ_box
            // 
            départ_box.Location = new Point(286, 271);
            départ_box.Name = "départ_box";
            départ_box.Size = new Size(637, 23);
            départ_box.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 253);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 3;
            label2.Text = "Station_de_depart ";
            // 
            // Trajet_Ligne_Commandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 980);
            Controls.Add(label2);
            Controls.Add(départ_box);
            Controls.Add(label1);
            Controls.Add(arrivee_box);
            Margin = new Padding(2);
            Name = "Trajet_Ligne_Commandes";
            Text = "Trajet_Ligne_Commandes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox arrivee_box;
        private Label label1;
        private TextBox départ_box;
        private Label label2;
    }
}