﻿
namespace LivInParis
{
    partial class CuisinierPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1413, 465);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(533, 730);
            button1.Name = "button1";
            button1.Size = new Size(342, 58);
            button1.TabIndex = 1;
            button1.Text = "Load DataBase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(683, 541);
            button2.Name = "button2";
            button2.Size = new Size(383, 58);
            button2.TabIndex = 2;
            button2.Text = "Afficher client servi ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1108, 542);
            button3.Name = "button3";
            button3.Size = new Size(351, 58);
            button3.TabIndex = 3;
            button3.Text = "Mets mis en ligne ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(26, 542);
            button5.Name = "button5";
            button5.Size = new Size(315, 57);
            button5.TabIndex = 5;
            button5.Text = "Ajouter un cuisinier";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(380, 542);
            button4.Name = "button4";
            button4.Size = new Size(279, 57);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // CuisinierPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1708, 865);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "CuisinierPage";
            Text = "Form1";
            Load += CuisinierPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private BindingSource bindingSource1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
    }
}
