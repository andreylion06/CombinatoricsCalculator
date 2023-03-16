namespace CombinatoricsCalculator.UserControlls
{
    partial class LetterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Letter = new Label();
            label_n = new Label();
            label_k = new Label();
            textBox_k = new TextBox();
            textBox_n = new TextBox();
            SuspendLayout();
            // 
            // label_Letter
            // 
            label_Letter.AutoSize = true;
            label_Letter.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label_Letter.Location = new Point(66, 17);
            label_Letter.Name = "label_Letter";
            label_Letter.Size = new Size(111, 128);
            label_Letter.TabIndex = 0;
            label_Letter.Text = "X";
            // 
            // label_n
            // 
            label_n.AutoSize = true;
            label_n.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_n.Location = new Point(154, 90);
            label_n.Name = "label_n";
            label_n.Size = new Size(57, 37);
            label_n.TabIndex = 1;
            label_n.Text = "n =";
            // 
            // label_k
            // 
            label_k.AutoSize = true;
            label_k.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_k.Location = new Point(154, 31);
            label_k.Name = "label_k";
            label_k.Size = new Size(55, 37);
            label_k.TabIndex = 2;
            label_k.Text = "k =";
            // 
            // textBox_k
            // 
            textBox_k.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_k.Location = new Point(215, 28);
            textBox_k.Name = "textBox_k";
            textBox_k.Size = new Size(56, 43);
            textBox_k.TabIndex = 3;
            textBox_k.TextChanged += textBox_TextChanged;
            // 
            // textBox_n
            // 
            textBox_n.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_n.Location = new Point(215, 87);
            textBox_n.Name = "textBox_n";
            textBox_n.Size = new Size(56, 43);
            textBox_n.TabIndex = 4;
            textBox_n.TextChanged += textBox_TextChanged;
            // 
            // LetterCombonent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox_n);
            Controls.Add(textBox_k);
            Controls.Add(label_k);
            Controls.Add(label_n);
            Controls.Add(label_Letter);
            Name = "LetterCombonent";
            Size = new Size(350, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Letter;
        private Label label_n;
        private Label label_k;
        private TextBox textBox_k;
        private TextBox textBox_n;
    }
}
