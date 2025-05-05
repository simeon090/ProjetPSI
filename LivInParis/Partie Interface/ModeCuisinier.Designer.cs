namespace LivInParis.Partie_Interface
{
    partial class ModeCuisinier
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(187, 40);
            button1.Name = "button1";
            button1.Size = new Size(397, 89);
            button1.TabIndex = 0;
            button1.Text = "Ajouter un met ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 179);
            button2.Name = "button2";
            button2.Size = new Size(397, 82);
            button2.TabIndex = 1;
            button2.Text = "Modifier un met ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(187, 307);
            button3.Name = "button3";
            button3.Size = new Size(397, 83);
            button3.TabIndex = 2;
            button3.Text = "Supprimer un mets ";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, -6);
            label1.Name = "label1";
            label1.Size = new Size(48, 45);
            label1.TabIndex = 3;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(187, 439);
            button4.Name = "button4";
            button4.Size = new Size(397, 83);
            button4.TabIndex = 4;
            button4.Text = "Voir ses mets en ligne";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ModeCuisinier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "ModeCuisinier";
            Text = "Cuisinier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}