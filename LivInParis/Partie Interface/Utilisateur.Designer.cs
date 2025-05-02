namespace LivInParis
{
    partial class Utilisateur
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 53);
            label1.Name = "label1";
            label1.Size = new Size(1023, 86);
            label1.TabIndex = 0;
            label1.Text = "Quelle mode voulez vous utiliser ? ";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(392, 192);
            button1.Name = "button1";
            button1.Size = new Size(687, 114);
            button1.TabIndex = 1;
            button1.Text = "Mode Client ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(392, 361);
            button2.Name = "button2";
            button2.Size = new Size(687, 100);
            button2.TabIndex = 2;
            button2.Text = "Mode Cuisinier ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Utilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 847);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Utilisateur";
            Text = "Utilisateur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}