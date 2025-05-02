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
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(745, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(365, 574);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(742, 23);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 191);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Nom du met";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 306);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Type du met ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 556);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Prix ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(362, 655);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(745, 23);
            textBox5.TabIndex = 8;
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
            label3.Location = new Point(365, 450);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 6;
            label3.Text = "Régime alimentaire ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(362, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(745, 23);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(365, 468);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(742, 23);
            comboBox2.TabIndex = 11;
            // 
            // Ajouter_un_met
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 991);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Name = "Ajouter_un_met";
            Text = "Ajouter_un_met";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}