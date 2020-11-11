namespace OOP__Lab2
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TransformButton = new System.Windows.Forms.Button();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyCheckBox = new System.Windows.Forms.CheckBox();
            this.LinqButton = new System.Windows.Forms.RadioButton();
            this.DomButton = new System.Windows.Forms.RadioButton();
            this.SaxButton = new System.Windows.Forms.RadioButton();
            this.DepartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.GroupCheckBox = new System.Windows.Forms.CheckBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.SurnameCheckBox = new System.Windows.Forms.CheckBox();
            this.RatingCheckBox = new System.Windows.Forms.CheckBox();
            this.RoomCheckBox = new System.Windows.Forms.CheckBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.SurnameComboBox = new System.Windows.Forms.ComboBox();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(519, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(449, 472);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(369, 64);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(144, 38);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearbuttonClick);
            // 
            // TransformButton
            // 
            this.TransformButton.Location = new System.Drawing.Point(369, 12);
            this.TransformButton.Name = "TransformButton";
            this.TransformButton.Size = new System.Drawing.Size(144, 46);
            this.TransformButton.TabIndex = 2;
            this.TransformButton.Text = "Transform to HTML";
            this.TransformButton.UseVisualStyleBackColor = true;
            this.TransformButton.Click += new System.EventHandler(this.TransformButtonClick);
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(141, 22);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(157, 28);
            this.FacultyComboBox.TabIndex = 3;
            // 
            // FacultyCheckBox
            // 
            this.FacultyCheckBox.AutoSize = true;
            this.FacultyCheckBox.Location = new System.Drawing.Point(24, 26);
            this.FacultyCheckBox.Name = "FacultyCheckBox";
            this.FacultyCheckBox.Size = new System.Drawing.Size(76, 24);
            this.FacultyCheckBox.TabIndex = 4;
            this.FacultyCheckBox.Text = "Faculty";
            this.FacultyCheckBox.UseVisualStyleBackColor = true;
            // 
            // LinqButton
            // 
            this.LinqButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LinqButton.AutoSize = true;
            this.LinqButton.Location = new System.Drawing.Point(24, 443);
            this.LinqButton.Name = "LinqButton";
            this.LinqButton.Size = new System.Drawing.Size(63, 24);
            this.LinqButton.TabIndex = 5;
            this.LinqButton.TabStop = true;
            this.LinqButton.Text = "LINQ";
            this.LinqButton.UseVisualStyleBackColor = true;
            // 
            // DomButton
            // 
            this.DomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DomButton.AutoSize = true;
            this.DomButton.Location = new System.Drawing.Point(113, 443);
            this.DomButton.Name = "DomButton";
            this.DomButton.Size = new System.Drawing.Size(65, 24);
            this.DomButton.TabIndex = 6;
            this.DomButton.TabStop = true;
            this.DomButton.Text = "DOM";
            this.DomButton.UseVisualStyleBackColor = true;
            // 
            // SaxButton
            // 
            this.SaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaxButton.AutoSize = true;
            this.SaxButton.Location = new System.Drawing.Point(198, 443);
            this.SaxButton.Name = "SaxButton";
            this.SaxButton.Size = new System.Drawing.Size(57, 24);
            this.SaxButton.TabIndex = 7;
            this.SaxButton.TabStop = true;
            this.SaxButton.Text = "SAX";
            this.SaxButton.UseVisualStyleBackColor = true;
            // 
            // DepartmentCheckBox
            // 
            this.DepartmentCheckBox.AutoSize = true;
            this.DepartmentCheckBox.Location = new System.Drawing.Point(24, 60);
            this.DepartmentCheckBox.Name = "DepartmentCheckBox";
            this.DepartmentCheckBox.Size = new System.Drawing.Size(111, 24);
            this.DepartmentCheckBox.TabIndex = 8;
            this.DepartmentCheckBox.Text = "Department";
            this.DepartmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(141, 56);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(157, 28);
            this.DepartmentComboBox.TabIndex = 9;
            // 
            // GroupCheckBox
            // 
            this.GroupCheckBox.AutoSize = true;
            this.GroupCheckBox.Location = new System.Drawing.Point(24, 94);
            this.GroupCheckBox.Name = "GroupCheckBox";
            this.GroupCheckBox.Size = new System.Drawing.Size(72, 24);
            this.GroupCheckBox.TabIndex = 10;
            this.GroupCheckBox.Text = "Group";
            this.GroupCheckBox.UseVisualStyleBackColor = true;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(141, 90);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(157, 28);
            this.GroupComboBox.TabIndex = 11;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(24, 130);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(71, 24);
            this.NameCheckBox.TabIndex = 12;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // SurnameCheckBox
            // 
            this.SurnameCheckBox.AutoSize = true;
            this.SurnameCheckBox.Location = new System.Drawing.Point(24, 164);
            this.SurnameCheckBox.Name = "SurnameCheckBox";
            this.SurnameCheckBox.Size = new System.Drawing.Size(89, 24);
            this.SurnameCheckBox.TabIndex = 13;
            this.SurnameCheckBox.Text = "Surname";
            this.SurnameCheckBox.UseVisualStyleBackColor = true;
            // 
            // RatingCheckBox
            // 
            this.RatingCheckBox.AutoSize = true;
            this.RatingCheckBox.Location = new System.Drawing.Point(24, 232);
            this.RatingCheckBox.Name = "RatingCheckBox";
            this.RatingCheckBox.Size = new System.Drawing.Size(74, 24);
            this.RatingCheckBox.TabIndex = 14;
            this.RatingCheckBox.Text = "Rating";
            this.RatingCheckBox.UseVisualStyleBackColor = true;
            // 
            // RoomCheckBox
            // 
            this.RoomCheckBox.AutoSize = true;
            this.RoomCheckBox.Location = new System.Drawing.Point(24, 198);
            this.RoomCheckBox.Name = "RoomCheckBox";
            this.RoomCheckBox.Size = new System.Drawing.Size(71, 24);
            this.RoomCheckBox.TabIndex = 15;
            this.RoomCheckBox.Text = "Room";
            this.RoomCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameComboBox
            // 
            this.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(141, 126);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(157, 28);
            this.NameComboBox.TabIndex = 16;
            // 
            // SurnameComboBox
            // 
            this.SurnameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SurnameComboBox.FormattingEnabled = true;
            this.SurnameComboBox.Location = new System.Drawing.Point(141, 160);
            this.SurnameComboBox.Name = "SurnameComboBox";
            this.SurnameComboBox.Size = new System.Drawing.Size(157, 28);
            this.SurnameComboBox.TabIndex = 17;
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(141, 194);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(157, 28);
            this.RoomComboBox.TabIndex = 18;
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Location = new System.Drawing.Point(141, 228);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(157, 28);
            this.RatingComboBox.TabIndex = 19;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.Location = new System.Drawing.Point(341, 434);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(172, 38);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 496);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RatingComboBox);
            this.Controls.Add(this.RoomComboBox);
            this.Controls.Add(this.SurnameComboBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.RoomCheckBox);
            this.Controls.Add(this.RatingCheckBox);
            this.Controls.Add(this.SurnameCheckBox);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.GroupCheckBox);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.DepartmentCheckBox);
            this.Controls.Add(this.SaxButton);
            this.Controls.Add(this.DomButton);
            this.Controls.Add(this.LinqButton);
            this.Controls.Add(this.FacultyCheckBox);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.TransformButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Students Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCloseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button TransformButton;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.CheckBox FacultyCheckBox;
        private System.Windows.Forms.RadioButton LinqButton;
        private System.Windows.Forms.RadioButton DomButton;
        private System.Windows.Forms.RadioButton SaxButton;
        private System.Windows.Forms.CheckBox DepartmentCheckBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.CheckBox GroupCheckBox;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.CheckBox SurnameCheckBox;
        private System.Windows.Forms.CheckBox RatingCheckBox;
        private System.Windows.Forms.CheckBox RoomCheckBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.ComboBox SurnameComboBox;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.Button SearchButton;
    }
}

