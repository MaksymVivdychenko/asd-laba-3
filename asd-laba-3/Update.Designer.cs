namespace asd_laba_3
{
    partial class Update
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
            TextInput = new TextBox();
            label1 = new Label();
            MenuButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ResultLabel = new Label();
            label2 = new Label();
            IDInput = new TextBox();
            UpdateButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextInput
            // 
            TextInput.Font = new Font("Segoe UI", 15F);
            TextInput.Location = new Point(430, 172);
            TextInput.Margin = new Padding(4, 5, 4, 5);
            TextInput.Name = "TextInput";
            TextInput.Size = new Size(141, 47);
            TextInput.TabIndex = 25;
            TextInput.TextChanged += TextInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(331, 173);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 41);
            label1.TabIndex = 24;
            label1.Text = "Текст:";
            // 
            // MenuButton
            // 
            MenuButton.Font = new Font("Segoe UI", 15F);
            MenuButton.ImageAlign = ContentAlignment.BottomLeft;
            MenuButton.Location = new Point(184, 667);
            MenuButton.Margin = new Padding(4, 5, 4, 5);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(323, 63);
            MenuButton.TabIndex = 23;
            MenuButton.Text = "Меню";
            MenuButton.TextAlign = ContentAlignment.TopCenter;
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ResultLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(203, 435);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(286, 167);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // ResultLabel
            // 
            ResultLabel.Anchor = AnchorStyles.None;
            ResultLabel.AutoSize = true;
            ResultLabel.Cursor = Cursors.SizeWE;
            ResultLabel.Font = new Font("Segoe UI", 15F);
            ResultLabel.Location = new Point(66, 63);
            ResultLabel.Margin = new Padding(4, 0, 4, 0);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.RightToLeft = RightToLeft.No;
            ResultLabel.Size = new Size(154, 41);
            ResultLabel.TabIndex = 5;
            ResultLabel.Text = "Введіть ID";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(86, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 41);
            label2.TabIndex = 21;
            label2.Text = "ID:";
            // 
            // IDInput
            // 
            IDInput.Font = new Font("Segoe UI", 15F);
            IDInput.Location = new Point(144, 168);
            IDInput.Margin = new Padding(4, 5, 4, 5);
            IDInput.Name = "IDInput";
            IDInput.Size = new Size(141, 47);
            IDInput.TabIndex = 20;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 15F);
            UpdateButton.Location = new Point(184, 275);
            UpdateButton.Margin = new Padding(4, 5, 4, 5);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(323, 108);
            UpdateButton.TabIndex = 19;
            UpdateButton.Text = "Оновити";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 750);
            Controls.Add(TextInput);
            Controls.Add(label1);
            Controls.Add(MenuButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(IDInput);
            Controls.Add(UpdateButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Update";
            Text = "Update";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextInput;
        private Label label1;
        private Button MenuButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ResultLabel;
        private Label label2;
        private TextBox IDInput;
        private Button UpdateButton;
    }
}