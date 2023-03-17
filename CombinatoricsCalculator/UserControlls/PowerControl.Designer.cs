namespace CombinatoricsCalculator.UserControlls
{
    partial class PowerControl
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
            textBox_Power = new TextBox();
            textBox_Base = new TextBox();
            SuspendLayout();
            // 
            // textBox_Power
            // 
            textBox_Power.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Power.Location = new Point(185, 31);
            textBox_Power.Name = "textBox_Power";
            textBox_Power.Size = new Size(56, 33);
            textBox_Power.TabIndex = 4;
            textBox_Power.TextChanged += textBox_TextChanged;
            // 
            // textBox_Base
            // 
            textBox_Base.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Base.Location = new Point(123, 50);
            textBox_Base.Name = "textBox_Base";
            textBox_Base.Size = new Size(56, 71);
            textBox_Base.TabIndex = 3;
            textBox_Base.TextChanged += textBox_TextChanged;
            // 
            // PowerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox_Power);
            Controls.Add(textBox_Base);
            Name = "PowerControl";
            Size = new Size(350, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Power;
        private TextBox textBox_Base;
    }
}
