namespace CombinatoricsCalculator
{
    partial class MainForm
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
            groupBox_Expression = new GroupBox();
            comboBox_CombName = new ComboBox();
            button_Count = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // groupBox_Expression
            // 
            groupBox_Expression.Location = new Point(12, 51);
            groupBox_Expression.Name = "groupBox_Expression";
            groupBox_Expression.Size = new Size(350, 150);
            groupBox_Expression.TabIndex = 0;
            groupBox_Expression.TabStop = false;
            groupBox_Expression.Text = "Expression";
            // 
            // comboBox_CombName
            // 
            comboBox_CombName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_CombName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_CombName.FormattingEnabled = true;
            comboBox_CombName.Location = new Point(12, 12);
            comboBox_CombName.Name = "comboBox_CombName";
            comboBox_CombName.Size = new Size(347, 33);
            comboBox_CombName.TabIndex = 1;
            comboBox_CombName.SelectedIndexChanged += comboBox_CombName_SelectedIndexChanged;
            // 
            // button_Count
            // 
            button_Count.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_Count.Location = new Point(12, 207);
            button_Count.Name = "button_Count";
            button_Count.Size = new Size(134, 55);
            button_Count.TabIndex = 2;
            button_Count.Text = "Count";
            button_Count.UseVisualStyleBackColor = true;
            button_Count.Click += button_Count_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(177, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 35);
            textBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 273);
            Controls.Add(textBox1);
            Controls.Add(button_Count);
            Controls.Add(comboBox_CombName);
            Controls.Add(groupBox_Expression);
            Name = "MainForm";
            Text = "Combinatorics Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_Expression;
        private ComboBox comboBox_CombName;
        private Button button_Count;
        private TextBox textBox1;
    }
}