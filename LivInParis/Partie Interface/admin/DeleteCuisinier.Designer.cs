namespace LivInParis.Partie_Interface
{
    partial class DeleteCuisinier
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
            _delete_box_cuis = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // _delete_box_cuis
            // 
            _delete_box_cuis.FormattingEnabled = true;
            _delete_box_cuis.Location = new Point(193, 130);
            _delete_box_cuis.Name = "_delete_box_cuis";
            _delete_box_cuis.Size = new Size(430, 23);
            _delete_box_cuis.TabIndex = 0;
            _delete_box_cuis.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(323, 297);
            button1.Name = "button1";
            button1.Size = new Size(143, 41);
            button1.TabIndex = 1;
            button1.Text = "Supprimer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, -6);
            label1.Name = "label1";
            label1.Size = new Size(53, 45);
            label1.TabIndex = 2;
            label1.Text = "⭠";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(824, 37);
            label2.TabIndex = 3;
            label2.Text = "Selectionner le nom du cuisinier que vous souhaitez supprimer ";
            // 
            // Delete_cuisinier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 480);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(_delete_box_cuis);
            Name = "Delete_cuisinier";
            Text = "Delete_cuisinier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox _delete_box_cuis;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}