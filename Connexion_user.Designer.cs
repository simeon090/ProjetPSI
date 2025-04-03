namespace WinFormsApp1
{
    partial class Connexion_user
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
            _text_box_connexion_id = new TextBox();
            label1 = new Label();
            _text_box_con = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            _button_create_account = new Button();
            SuspendLayout();
            // 
            // _text_box_connexion_id
            // 
            _text_box_connexion_id.Location = new Point(443, 166);
            _text_box_connexion_id.Name = "_text_box_connexion_id";
            _text_box_connexion_id.Size = new Size(584, 23);
            _text_box_connexion_id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(443, 133);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 1;
            label1.Text = "Identifiant ";
            // 
            // _text_box_con
            // 
            _text_box_con.Location = new Point(443, 258);
            _text_box_con.Name = "_text_box_con";
            _text_box_con.PasswordChar = '$';
            _text_box_con.Size = new Size(584, 23);
            _text_box_con.TabIndex = 2;
            _text_box_con.TextChanged += _text_box_con_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(443, 223);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 3;
            label2.Text = "Mot de Passe ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(491, 365);
            button1.Name = "button1";
            button1.Size = new Size(352, 110);
            button1.TabIndex = 4;
            button1.Text = "Connexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // _button_create_account
            // 
            _button_create_account.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _button_create_account.Location = new Point(1050, 523);
            _button_create_account.Name = "_button_create_account";
            _button_create_account.Size = new Size(340, 92);
            _button_create_account.TabIndex = 6;
            _button_create_account.Text = "Créer un compte ";
            _button_create_account.UseVisualStyleBackColor = true;
            _button_create_account.Click += _button_create_account_Click;
            // 
            // Connexion_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 808);
            Controls.Add(_button_create_account);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(_text_box_con);
            Controls.Add(label1);
            Controls.Add(_text_box_connexion_id);
            Name = "Connexion_user";
            Text = "Connexion_user";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _text_box_connexion_id;
        private Label label1;
        private TextBox _text_box_con;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button _button_create_account;
    }
}