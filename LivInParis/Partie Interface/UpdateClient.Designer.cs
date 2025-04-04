namespace LivInParis
{
    partial class UpdateClient
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
            _Idenifiant_old = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            _text_box_modif_id = new TextBox();
            _text_box_mdp = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // _Idenifiant_old
            // 
            _Idenifiant_old.CausesValidation = false;
            _Idenifiant_old.FormattingEnabled = true;
            _Idenifiant_old.Location = new Point(454, 133);
            _Idenifiant_old.Margin = new Padding(4, 5, 4, 5);
            _Idenifiant_old.Name = "_Idenifiant_old";
            _Idenifiant_old.Size = new Size(771, 33);
            _Idenifiant_old.TabIndex = 0;
            _Idenifiant_old.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(673, 535);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(314, 123);
            button1.TabIndex = 1;
            button1.Text = "Modifier  le client ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 48);
            label1.TabIndex = 2;
            label1.Text = "Ancien Identifiant";
            label1.Click += label1_Click;
            // 
            // _text_box_modif_id
            // 
            _text_box_modif_id.Location = new Point(454, 250);
            _text_box_modif_id.Margin = new Padding(4, 5, 4, 5);
            _text_box_modif_id.Name = "_text_box_modif_id";
            _text_box_modif_id.Size = new Size(774, 31);
            _text_box_modif_id.TabIndex = 3;
            // 
            // _text_box_mdp
            // 
            _text_box_mdp.Location = new Point(451, 357);
            _text_box_mdp.Margin = new Padding(4, 5, 4, 5);
            _text_box_mdp.Name = "_text_box_mdp";
            _text_box_mdp.Size = new Size(774, 31);
            _text_box_mdp.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 357);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 40);
            label2.TabIndex = 6;
            label2.Text = "Mot de Passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(273, 250);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 40);
            label3.TabIndex = 5;
            label3.Text = "Identifiant ";
            // 
            // UpdateClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1730, 750);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(_text_box_mdp);
            Controls.Add(_text_box_modif_id);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(_Idenifiant_old);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UpdateClient";
            Text = "UpdateClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _Idenifiant_old;
        private Button button1;
        private Label label1;
        private TextBox _text_box_modif_id;
        private TextBox _text_box_mdp;
        private Label label2;
        private Label label3;
    }
}