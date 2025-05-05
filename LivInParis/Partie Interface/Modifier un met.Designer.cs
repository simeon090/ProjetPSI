namespace LivInParis.Partie_Interface
{
    partial class Modifier_un_met
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
            _box_nom_met = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            _type_box = new TextBox();
            _regime_ali_box = new TextBox();
            _prix_box = new TextBox();
            _quantité_box = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, -5);
            label1.Name = "label1";
            label1.Size = new Size(48, 45);
            label1.TabIndex = 0;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // _box_nom_met
            // 
            _box_nom_met.FormattingEnabled = true;
            _box_nom_met.Location = new Point(170, 98);
            _box_nom_met.Name = "_box_nom_met";
            _box_nom_met.Size = new Size(474, 23);
            _box_nom_met.TabIndex = 1;
            _box_nom_met.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 41);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 2;
            label2.Text = "Choisir le met à modifier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 101);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "Nom du met ";
            // 
            // _type_box
            // 
            _type_box.Location = new Point(170, 155);
            _type_box.Name = "_type_box";
            _type_box.Size = new Size(474, 23);
            _type_box.TabIndex = 4;
            _type_box.TextChanged += textBox1_TextChanged;
            // 
            // _regime_ali_box
            // 
            _regime_ali_box.Location = new Point(170, 213);
            _regime_ali_box.Name = "_regime_ali_box";
            _regime_ali_box.Size = new Size(474, 23);
            _regime_ali_box.TabIndex = 5;
            // 
            // _prix_box
            // 
            _prix_box.Location = new Point(170, 269);
            _prix_box.Name = "_prix_box";
            _prix_box.Size = new Size(474, 23);
            _prix_box.TabIndex = 6;
            // 
            // _quantité_box
            // 
            _quantité_box.Location = new Point(170, 332);
            _quantité_box.Name = "_quantité_box";
            _quantité_box.Size = new Size(474, 23);
            _quantité_box.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 221);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 8;
            label4.Text = "Régime_alimentaire";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 154);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 9;
            label5.Text = "type du met";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 272);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 10;
            label6.Text = "Prix ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 340);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 11;
            label7.Text = "quantité ";
            // 
            // button1
            // 
            button1.Location = new Point(282, 396);
            button1.Name = "button1";
            button1.Size = new Size(205, 68);
            button1.TabIndex = 12;
            button1.Text = "Confirmer les modifications ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Modifier_un_met
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(_quantité_box);
            Controls.Add(_prix_box);
            Controls.Add(_regime_ali_box);
            Controls.Add(_type_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(_box_nom_met);
            Controls.Add(label1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Modifier_un_met";
            Text = "Modifier_un_met";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox _box_nom_met;
        private Label label2;
        private Label label3;
        private TextBox _type_box;
        private TextBox _regime_ali_box;
        private TextBox _prix_box;
        private TextBox _quantité_box;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}