namespace LivInParis
{
    partial class OrderSumary
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
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(644, 65);
            label1.TabIndex = 0;
            label1.Text = "Résumé de votre commande ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(286, 65);
            label2.TabIndex = 1;
            label2.Text = "Mets choisis";
            // 
            // _box_resume
            // 
            _box_resume.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _box_resume.ItemHeight = 48;
            _box_resume.Location = new Point(33, 187);
            _box_resume.Margin = new Padding(4, 5, 4, 5);
            _box_resume.Name = "_box_resume";
            _box_resume.Size = new Size(754, 244);
            _box_resume.TabIndex = 5;
            _box_resume.SelectedIndexChanged += _box_resume_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 977);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(292, 40);
            label3.TabIndex = 4;
            label3.Text = "Prix de la commande ";
            // 
            // label_prix
            // 
            label_prix.AutoSize = true;
            label_prix.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_prix.Location = new Point(320, 943);
            label_prix.Margin = new Padding(4, 0, 4, 0);
            label_prix.Name = "label_prix";
            label_prix.Size = new Size(264, 96);
            label_prix.TabIndex = 7;
            label_prix.Text = "label4 ";
            label_prix.Click += label4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 498);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(993, 306);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, -13);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 60);
            label4.TabIndex = 9;
            label4.Text = "←";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 436);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(198, 48);
            label5.TabIndex = 10;
            label5.Text = "Prix totale :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(994, 282);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 48);
            label6.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(426, 830);
            button2.Name = "button2";
            button2.Size = new Size(255, 56);
            button2.TabIndex = 12;
            button2.Text = "Finaliser la commande";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrderSumary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 907);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label_prix);
            Controls.Add(label3);
            Controls.Add(_box_resume);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1133, 963);
            MinimumSize = new Size(1133, 963);
            Name = "OrderSumary";
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
        private Button button2;
    }
}