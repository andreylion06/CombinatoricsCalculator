namespace CombinatoricsCalculator.UserControlls
{
    partial class PermutationControl
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
            textBox_n = new TextBox();
            label_Letter = new Label();
            textBox_k = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox_n
            // 
            textBox_n.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_n.Location = new Point(70, 91);
            textBox_n.Name = "textBox_n";
            textBox_n.Size = new Size(28, 33);
            textBox_n.TabIndex = 11;
            textBox_n.TextChanged += textBox_TextChanged;
            // 
            // label_Letter
            // 
            label_Letter.AutoSize = true;
            label_Letter.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label_Letter.Location = new Point(15, 11);
            label_Letter.Name = "label_Letter";
            label_Letter.Size = new Size(108, 128);
            label_Letter.TabIndex = 10;
            label_Letter.Text = "P";
            // 
            // textBox_k
            // 
            textBox_k.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_k.Location = new Point(115, 59);
            textBox_k.Name = "textBox_k";
            textBox_k.Size = new Size(195, 43);
            textBox_k.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 109);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 13;
            label1.Text = "Input elements like: \"1, 2, 3\"";
            // 
            // PermutationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(textBox_k);
            Controls.Add(textBox_n);
            Controls.Add(label_Letter);
            Name = "PermutationControl";
            Size = new Size(350, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_n;
        private Label label_Letter;
        private TextBox textBox_k;
        private Label label1;
    }
}
