
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
            label1 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(762, 346);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(333, 513);
            button1.Name = "button1";
            button1.Size = new Size(132, 36);
            button1.TabIndex = 1;
            button1.Text = "Load DataBase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 405);
            button2.Name = "button2";
            button2.Size = new Size(123, 92);
            button2.TabIndex = 2;
            button2.Text = "Afficher client servi ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(631, 405);
            button3.Name = "button3";
            button3.Size = new Size(141, 92);
            button3.TabIndex = 3;
            button3.Text = "Mets mis en ligne ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(10, 401);
            button5.Name = "button5";
            button5.Size = new Size(140, 96);
            button5.TabIndex = 5;
            button5.Text = "Ajouter un cuisinier";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(176, 401);
            button4.Name = "button4";
            button4.Size = new Size(138, 96);
            button4.TabIndex = 6;
            button4.Text = "Modifier un cuisinier";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, -10);
            label1.Name = "label1";
            label1.Size = new Size(42, 40);
            label1.TabIndex = 7;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(333, 405);
            button6.Name = "button6";
            button6.Size = new Size(127, 92);
            button6.TabIndex = 8;
            button6.Text = "Supprimer un cuisinier";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // CuisinierPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "CuisinierPage";
            Text = "Form1";
            Load += CuisinierPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private BindingSource bindingSource1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private Label label1;
        private Button button6;
    }
}
