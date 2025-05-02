namespace LivInParis
{
    partial class ModeClient
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(91, 129);
            button1.Name = "button1";
            button1.Size = new Size(589, 114);
            button1.TabIndex = 0;
            button1.Text = "Passer une commande ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(91, 285);
            button2.Name = "button2";
            button2.Size = new Size(589, 97);
            button2.TabIndex = 1;
            button2.Text = "Consulter vos statistiques ";
            button2.UseVisualStyleBackColor = true;
            // 
            // ModeClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "ModeClient";
            Text = "ModeClient";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}