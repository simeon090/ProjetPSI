namespace WinFormsApp1
{
    partial class AddNewClient
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
            button1 = new Button();
            _Id_Box = new TextBox();
            _Pwd_Box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(182, 288);
            button1.Name = "button1";
            button1.Size = new Size(418, 78);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _Id_Box
            // 
            _Id_Box.Location = new Point(239, 78);
            _Id_Box.Name = "_Id_Box";
            _Id_Box.Size = new Size(308, 23);
            _Id_Box.TabIndex = 1;
            // 
            // _Pwd_Box
            // 
            _Pwd_Box.Location = new Point(239, 131);
            _Pwd_Box.Name = "_Pwd_Box";
            _Pwd_Box.Size = new Size(308, 23);
            _Pwd_Box.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 78);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 4;
            label1.Text = "Identifiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 129);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // AddNewClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 462);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_Pwd_Box);
            Controls.Add(_Id_Box);
            Controls.Add(button1);
            Name = "AddNewClient";
            Text = "AddNewClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox _Id_Box;
        private TextBox _Pwd_Box;
        private Label label1;
        private Label label2;
    }
}