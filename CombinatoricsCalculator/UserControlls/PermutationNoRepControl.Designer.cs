namespace CombinatoricsCalculator.UserControlls
{
    partial class PermutationNoRepControl
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
            SuspendLayout();
            // 
            // textBox_n
            // 
            textBox_n.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_n.Location = new Point(176, 90);
            textBox_n.Name = "textBox_n";
            textBox_n.Size = new Size(28, 33);
            textBox_n.TabIndex = 9;
            textBox_n.TextChanged += textBox_TextChanged;
            // 
            // label_Letter
            // 
            label_Letter.AutoSize = true;
            label_Letter.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label_Letter.Location = new Point(118, 10);
            label_Letter.Name = "label_Letter";
            label_Letter.Size = new Size(108, 128);
            label_Letter.TabIndex = 5;
            label_Letter.Text = "P";
            // 
            // PermutationNoRepControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox_n);
            Controls.Add(label_Letter);
            Name = "PermutationNoRepControl";
            Size = new Size(350, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_n;
        private Label label_Letter;
    }
}
