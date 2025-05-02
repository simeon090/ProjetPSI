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
            _type_met_box = new ComboBox();
            _regime_alimentaire_box = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // _nom_met_box
            // 
            _nom_met_box.Location = new Point(53, 86);
            _nom_met_box.Name = "_nom_met_box";
            _nom_met_box.Size = new Size(653, 23);
            _nom_met_box.TabIndex = 0;
            _nom_met_box.TextChanged += textBox1_TextChanged;
            // 
            // _prix_met_box
            // 
            _prix_met_box.Location = new Point(56, 451);
            _prix_met_box.Name = "_prix_met_box";
            _prix_met_box.Size = new Size(650, 23);
            _prix_met_box.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 68);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Nom du met";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 183);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Type du met ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 433);
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
            label3.Location = new Point(56, 327);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 6;
            label3.Text = "Régime alimentaire ";
            // 
            // _type_met_box
            // 
            _type_met_box.FormattingEnabled = true;
            _type_met_box.Location = new Point(53, 207);
            _type_met_box.Name = "_type_met_box";
            _type_met_box.Size = new Size(653, 23);
            _type_met_box.TabIndex = 10;
            // 
            // _regime_alimentaire_box
            // 
            _regime_alimentaire_box.FormattingEnabled = true;
            _regime_alimentaire_box.Location = new Point(56, 345);
            _regime_alimentaire_box.Name = "_regime_alimentaire_box";
            _regime_alimentaire_box.Size = new Size(650, 23);
            _regime_alimentaire_box.TabIndex = 11;
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
            // Ajouter_un_met
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button1);
            Controls.Add(_regime_alimentaire_box);
            Controls.Add(_type_met_box);
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
        private ComboBox _type_met_box;
        private ComboBox _regime_alimentaire_box;
        private Button button1;
    }
}