namespace asd_laba_3
{
    partial class AddForm
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
            MenuButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ResultLabel = new Label();
            label2 = new Label();
            IDInput = new TextBox();
            AddButton = new Button();
            label1 = new Label();
            TextInput = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuButton
            // 
            MenuButton.Font = new Font("Segoe UI", 15F);
            MenuButton.ImageAlign = ContentAlignment.BottomLeft;
            MenuButton.Location = new Point(129, 400);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(226, 38);
            MenuButton.TabIndex = 16;
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
            tableLayoutPanel1.Location = new Point(142, 261);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // ResultLabel
            // 
            ResultLabel.Anchor = AnchorStyles.None;
            ResultLabel.AutoSize = true;
            ResultLabel.Cursor = Cursors.SizeWE;
            ResultLabel.Font = new Font("Segoe UI", 15F);
            ResultLabel.Location = new Point(49, 36);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.RightToLeft = RightToLeft.No;
            ResultLabel.Size = new Size(102, 28);
            ResultLabel.TabIndex = 5;
            ResultLabel.Text = "Введіть ID";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(60, 104);
            label2.Name = "label2";
            label2.Size = new Size(35, 28);
            label2.TabIndex = 14;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // IDInput
            // 
            IDInput.Font = new Font("Segoe UI", 15F);
            IDInput.Location = new Point(101, 101);
            IDInput.Name = "IDInput";
            IDInput.Size = new Size(100, 34);
            IDInput.TabIndex = 13;
            IDInput.TextChanged += IDInput_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 15F);
            AddButton.Location = new Point(129, 165);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(226, 65);
            AddButton.TabIndex = 12;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(232, 104);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 17;
            label1.Text = "Текст:";
            // 
            // TextInput
            // 
            TextInput.Font = new Font("Segoe UI", 15F);
            TextInput.Location = new Point(301, 104);
            TextInput.Name = "TextInput";
            TextInput.Size = new Size(100, 34);
            TextInput.TabIndex = 18;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 450);
            Controls.Add(TextInput);
            Controls.Add(label1);
            Controls.Add(MenuButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(IDInput);
            Controls.Add(AddButton);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MenuButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ResultLabel;
        private Label label2;
        private TextBox IDInput;
        private Button AddButton;
        private Label label1;
        private TextBox TextInput;
    }
}