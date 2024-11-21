namespace asd_laba_3
{
    partial class DeleteForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ResultLabel = new Label();
            label2 = new Label();
            IDInput = new TextBox();
            DeleteButton = new Button();
            MenuButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 9;
            // 
            // ResultLabel
            // 
            ResultLabel.Anchor = AnchorStyles.None;
            ResultLabel.AutoSize = true;
            ResultLabel.Cursor = Cursors.SizeWE;
            ResultLabel.Font = new Font("Segoe UI", 15F);
            ResultLabel.Location = new Point(41, 36);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.RightToLeft = RightToLeft.No;
            ResultLabel.Size = new Size(118, 28);
            ResultLabel.TabIndex = 5;
            ResultLabel.Text = "Інформація";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(129, 97);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 8;
            label2.Text = "Введіть ID:";
            // 
            // IDInput
            // 
            IDInput.Font = new Font("Segoe UI", 15F);
            IDInput.Location = new Point(255, 94);
            IDInput.Name = "IDInput";
            IDInput.Size = new Size(100, 34);
            IDInput.TabIndex = 7;
            IDInput.TextChanged += textBox1_TextChanged;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 15F);
            DeleteButton.Location = new Point(129, 165);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(226, 65);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Видалити";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // MenuButton
            // 
            MenuButton.Font = new Font("Segoe UI", 15F);
            MenuButton.ImageAlign = ContentAlignment.BottomLeft;
            MenuButton.Location = new Point(129, 400);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(226, 38);
            MenuButton.TabIndex = 10;
            MenuButton.Text = "Меню";
            MenuButton.TextAlign = ContentAlignment.TopCenter;
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click_1;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 450);
            Controls.Add(MenuButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(IDInput);
            Controls.Add(DeleteButton);
            Name = "DeleteForm";
            Text = "DeleteFormcs";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label ResultLabel;
        private Label label2;
        private TextBox IDInput;
        private Button DeleteButton;
        private Button MenuButton;
    }
}