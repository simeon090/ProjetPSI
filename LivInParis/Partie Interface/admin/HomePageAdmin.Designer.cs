﻿namespace LivInParis
{
    partial class HomePageAdmin
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
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(187, 26);
            button1.Name = "button1";
            button1.Size = new Size(386, 81);
            button1.TabIndex = 0;
            button1.Text = "Client";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(187, 122);
            button2.Name = "button2";
            button2.Size = new Size(386, 94);
            button2.TabIndex = 1;
            button2.Text = "Cuisinier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(187, 222);
            button3.Name = "button3";
            button3.Size = new Size(386, 92);
            button3.TabIndex = 2;
            button3.Text = "Graphe avec Coloration";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, -8);
            label1.Name = "label1";
            label1.Size = new Size(48, 45);
            label1.TabIndex = 3;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(187, 320);
            button4.Name = "button4";
            button4.Size = new Size(386, 92);
            button4.TabIndex = 4;
            button4.Text = "Export Données";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(187, 418);
            button5.Name = "button5";
            button5.Size = new Size(386, 92);
            button5.TabIndex = 5;
            button5.Text = "Statistiques";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // HomePageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 554);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(798, 593);
            MinimumSize = new Size(798, 593);
            Name = "HomePageAdmin";
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}