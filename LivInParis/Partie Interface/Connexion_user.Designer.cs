namespace LivInParis
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
            _button_create_account = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // _text_box_connexion_id
            // 
            _text_box_connexion_id.Location = new Point(153, 265);
            _text_box_connexion_id.Margin = new Padding(4, 5, 4, 5);
            _text_box_connexion_id.Name = "_text_box_connexion_id";
            _text_box_connexion_id.Size = new Size(833, 31);
            _text_box_connexion_id.TabIndex = 0;
            _text_box_connexion_id.TextChanged += _text_box_connexion_id_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 210);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 45);
            label1.TabIndex = 1;
            label1.Text = "Identifiant ";
            // 
            // _text_box_con
            // 
            _text_box_con.Location = new Point(153, 448);
            _text_box_con.Margin = new Padding(4, 5, 4, 5);
            _text_box_con.Name = "_text_box_con";
            _text_box_con.PasswordChar = '$';
            _text_box_con.Size = new Size(833, 31);
            _text_box_con.TabIndex = 2;
            _text_box_con.TextChanged += _text_box_con_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 390);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 48);
            label2.TabIndex = 3;
            label2.Text = "Mot de Passe ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(430, 543);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(247, 80);
            button1.TabIndex = 4;
            button1.Text = "Connexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _button_create_account
            // 
            _button_create_account.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _button_create_account.Location = new Point(317, 685);
            _button_create_account.Margin = new Padding(4, 5, 4, 5);
            _button_create_account.Name = "_button_create_account";
            _button_create_account.Size = new Size(489, 90);
            _button_create_account.TabIndex = 6;
            _button_create_account.Text = "Créer un compte ";
            _button_create_account.UseVisualStyleBackColor = true;
            _button_create_account.Click += _button_create_account_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(317, 805);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(489, 90);
            button2.TabIndex = 7;
            button2.Text = "Mode Admin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(270, 70);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(626, 65);
            label3.TabIndex = 8;
            label3.Text = "Bienvenue dans LivInParis ";
            label3.Click += label3_Click;
            // 
            // Connexion_user
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 907);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(_button_create_account);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(_text_box_con);
            Controls.Add(label1);
            Controls.Add(_text_box_connexion_id);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1133, 963);
            MinimumSize = new Size(1133, 963);
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
        private Button _button_create_account;
        private Button button2;
        private Label label3;
    }
}