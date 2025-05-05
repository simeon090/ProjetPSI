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
            label_prix = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(437, 45);
            label1.TabIndex = 0;
            label1.Text = "Résumé de votre commande ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(196, 45);
            label2.TabIndex = 1;
            label2.Text = "Mets choisis";
            // 
            // _box_resume
            // 
            _box_resume.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _box_resume.ItemHeight = 32;
            _box_resume.Location = new Point(23, 112);
            _box_resume.Name = "_box_resume";
            _box_resume.Size = new Size(529, 164);
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 299);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(696, 250);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, -8);
            label4.Name = "label4";
            label4.Size = new Size(42, 40);
            label4.TabIndex = 9;
            label4.Text = "←";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(581, 154);
            label5.Name = "label5";
            label5.Size = new Size(80, 45);
            label5.TabIndex = 10;
            label5.Text = "Prix";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(696, 169);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(676, 166);
            label7.Name = "label7";
            label7.Size = new Size(68, 30);
            label7.TabIndex = 12;
            label7.Text = "label7";
            // 
            // Panier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label_prix);
            Controls.Add(label3);
            Controls.Add(_box_resume);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Panier";
            Text = "Panier";
            Load += Panier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox _box_resume;
        private Label label3;
        private Label label_prix;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}