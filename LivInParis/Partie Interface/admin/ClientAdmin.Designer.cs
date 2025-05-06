
namespace LivInParis
{
    partial class ClientAdmin
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(435, 561);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(-18, 79);
            button2.Name = "button2";
            button2.Size = new Size(345, 70);
            button2.TabIndex = 2;
            button2.Text = "Supprimer le client ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(-20, 3);
            button3.Name = "button3";
            button3.Size = new Size(345, 70);
            button3.TabIndex = 3;
            button3.Text = "Ajouter un client ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(button7);
            splitContainer1.Panel2.Controls.Add(button6);
            splitContainer1.Panel2.Controls.Add(button5);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Size = new Size(784, 561);
            splitContainer1.SplitterDistance = 455;
            splitContainer1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, -13);
            label1.Name = "label1";
            label1.Size = new Size(42, 40);
            label1.TabIndex = 9;
            label1.Text = "←";
            label1.Click += label1_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Font = new Font("Segoe UI", 12F);
            button7.Location = new Point(-13, 459);
            button7.Name = "button7";
            button7.Size = new Size(345, 70);
            button7.TabIndex = 8;
            button7.Text = "Voir les commandes du client";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(-13, 383);
            button6.Name = "button6";
            button6.Size = new Size(345, 70);
            button6.TabIndex = 7;
            button6.Text = "Trier par achats cumulés";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(-18, 307);
            button5.Name = "button5";
            button5.Size = new Size(345, 70);
            button5.TabIndex = 6;
            button5.Text = "Trie par nom ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(-13, 231);
            button1.Name = "button1";
            button1.Size = new Size(345, 70);
            button1.TabIndex = 5;
            button1.Text = "Trier par rue ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(-13, 155);
            button4.Name = "button4";
            button4.Size = new Size(345, 70);
            button4.TabIndex = 9;
            button4.Text = "Modifier le client ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ClientAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "ClientAdmin";
            Text = "Client";
            Load += ClientPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Button button2;
        private Button button3;
        private SplitContainer splitContainer1;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Button button4;
    }
}