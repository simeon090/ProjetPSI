namespace LivInParis
{
    partial class Panier
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
            _box_resume = new ListBox();
            label3 = new Label();
            button1 = new Button();
            label_prix = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 33);
            label1.Name = "label1";
            label1.Size = new Size(864, 86);
            label1.TabIndex = 0;
            label1.Text = "Résumé de votre commande ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(196, 45);
            label2.TabIndex = 1;
            label2.Text = "Mets choisis";
            // 
            // _box_resume
            // 
            _box_resume.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _box_resume.ItemHeight = 32;
            _box_resume.Location = new Point(240, 211);
            _box_resume.Name = "_box_resume";
            _box_resume.Size = new Size(592, 324);
            _box_resume.TabIndex = 5;
            _box_resume.SelectedIndexChanged += _box_resume_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 586);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 4;
            label3.Text = "Prix de la commande ";
            // 
            // button1
            // 
            button1.Location = new Point(897, 228);
            button1.Name = "button1";
            button1.Size = new Size(335, 54);
            button1.TabIndex = 6;
            button1.Text = "Consulter le trajet de vos lignes de commandes ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_prix
            // 
            label_prix.AutoSize = true;
            label_prix.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_prix.Location = new Point(224, 566);
            label_prix.Name = "label_prix";
            label_prix.Size = new Size(179, 65);
            label_prix.TabIndex = 7;
            label_prix.Text = "label4 ";
            label_prix.Click += label4_Click;
            // 
            // Panier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 714);
            Controls.Add(label_prix);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(_box_resume);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Panier";
            Text = "Panier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox _box_resume;
        private Label label3;
        private Button button1;
        private Label label_prix;
    }
}