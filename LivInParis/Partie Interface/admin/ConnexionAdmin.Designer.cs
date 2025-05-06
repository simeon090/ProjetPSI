namespace LivInParis.Partie_Interface.admin
{
    partial class ConnexionAdmin
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
            _text_box_con = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // _text_box_con
            // 
            _text_box_con.Font = new Font("Segoe UI", 14F);
            _text_box_con.Location = new Point(24, 199);
            _text_box_con.Margin = new Padding(4, 5, 4, 5);
            _text_box_con.Name = "_text_box_con";
            _text_box_con.PasswordChar = '*';
            _text_box_con.Size = new Size(730, 45);
            _text_box_con.TabIndex = 3;
            _text_box_con.TextChanged += _text_box_con_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(535, 48);
            label2.TabIndex = 4;
            label2.Text = "Entrer le mot de passe Admin :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(247, 294);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(247, 80);
            button1.TabIndex = 5;
            button1.Text = "Connexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ConnexionAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(_text_box_con);
            Name = "ConnexionAdmin";
            Text = "ConnexionAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _text_box_con;
        private Label label2;
        private Button button1;
    }
}