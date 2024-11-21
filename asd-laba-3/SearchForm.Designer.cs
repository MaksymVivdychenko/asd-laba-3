namespace asd_laba_3
{
    partial class SearchForm
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
            SearchButton = new Button();
            ResultLabel = new Label();
            IDInput = new TextBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            MenuButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 15F);
            SearchButton.Location = new Point(129, 165);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(226, 65);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Шукати";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += button1_Click;
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
            // IDInput
            // 
            IDInput.Font = new Font("Segoe UI", 15F);
            IDInput.Location = new Point(255, 92);
            IDInput.Name = "IDInput";
            IDInput.Size = new Size(100, 34);
            IDInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(129, 95);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 3;
            label2.Text = "Введіть ID:";
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
            tableLayoutPanel1.TabIndex = 5;
            // 
            // MenuButton
            // 
            MenuButton.Font = new Font("Segoe UI", 15F);
            MenuButton.ImageAlign = ContentAlignment.BottomLeft;
            MenuButton.Location = new Point(129, 400);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(226, 38);
            MenuButton.TabIndex = 11;
            MenuButton.Text = "Меню";
            MenuButton.TextAlign = ContentAlignment.TopCenter;
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 450);
            Controls.Add(MenuButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(IDInput);
            Controls.Add(SearchButton);
            Name = "SearchForm";
            Text = "SearchForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private Label ResultLabel;
        private TextBox IDInput;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button MenuButton;
    }
}