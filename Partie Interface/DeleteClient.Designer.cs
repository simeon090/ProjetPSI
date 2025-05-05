namespace LivInParis
{
    partial class DeleteClient
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
            _ListDesClients = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // _ListDesClients
            // 
            _ListDesClients.FormattingEnabled = true;
            _ListDesClients.Location = new Point(153, 64);
            _ListDesClients.Name = "_ListDesClients";
            _ListDesClients.Size = new Size(498, 23);
            _ListDesClients.TabIndex = 0;
            _ListDesClients.SelectedIndexChanged += _ListDesClients_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 62);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 1;
            label1.Text = "Client";
            // 
            // button1
            // 
            button1.Location = new Point(228, 155);
            button1.Name = "button1";
            button1.Size = new Size(315, 103);
            button1.TabIndex = 2;
            button1.Text = "Supprimer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, -8);
            label2.Name = "label2";
            label2.Size = new Size(42, 40);
            label2.TabIndex = 3;
            label2.Text = "←";
            label2.Click += label2_Click;
            // 
            // DeleteClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(_ListDesClients);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "DeleteClient";
            Text = "DeleteClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _ListDesClients;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}