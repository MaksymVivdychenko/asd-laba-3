namespace asd_laba_3
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
            SearchButton = new Button();
            AddButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 15F);
            SearchButton.Location = new Point(165, 85);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(188, 72);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click_1;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 15F);
            AddButton.Location = new Point(165, 177);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(188, 72);
            AddButton.TabIndex = 3;
            AddButton.Text = "Додати запис";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += button4_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 15F);
            DeleteButton.Location = new Point(165, 276);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(188, 72);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Видалити запис";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 15F);
            UpdateButton.Location = new Point(165, 365);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(188, 72);
            UpdateButton.TabIndex = 5;
            UpdateButton.Text = "Редагувати запис";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 511);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(SearchButton);
            Name = "Form1";
            Text = "Btree db";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button SearchButton;
        private Button AddButton;
        private Button DeleteButton;
        private Button UpdateButton;
    }
}
