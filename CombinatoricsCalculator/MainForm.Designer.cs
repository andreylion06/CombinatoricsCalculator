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
            textBox_Result = new TextBox();
            button_Reset = new Button();
            SuspendLayout();
            // 
            // groupBox_Expression
            // 
            groupBox_Expression.Location = new Point(12, 51);
            groupBox_Expression.Name = "groupBox_Expression";
            groupBox_Expression.Size = new Size(360, 150);
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
            comboBox_CombName.Size = new Size(360, 33);
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
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Result.Location = new Point(215, 208);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.Size = new Size(157, 54);
            textBox_Result.TabIndex = 3;
            textBox_Result.Text = "0";
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // button_Reset
            // 
            button_Reset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Reset.Location = new Point(152, 207);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(57, 55);
            button_Reset.TabIndex = 4;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = true;
            button_Reset.Visible = false;
            button_Reset.Click += button_Reset_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 271);
            Controls.Add(button_Reset);
            Controls.Add(textBox_Result);
            Controls.Add(button_Count);
            Controls.Add(comboBox_CombName);
            Controls.Add(groupBox_Expression);
            MaximumSize = new Size(400, 310);
            MinimumSize = new Size(400, 310);
            Name = "MainForm";
            Text = "Combinatorics Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox_Expression;
        private ComboBox comboBox_CombName;
        private Button button_Count;
        private TextBox textBox_Result;
        private Button button_Reset;
    }
}