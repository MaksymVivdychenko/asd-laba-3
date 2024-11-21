using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asd_laba_3
{
    public partial class AddForm : Form
    {
        private Form1 menu;
        public AddForm(Form1 menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            menu.Show();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            string ID = IDInput.Text;
            string text = TextInput.Text;
            int intID;
            if(int.TryParse(ID,out intID))
            {
                if (menu.Btree.Search(intID) == null)
                {
                    menu.Btree.Insert(intID, text);
                    ResultLabel.Text = "Елемент доданий";
                    await ChangeColorFormAsync(Color.LightGreen, 1500);
                }
                else
                {
                    ResultLabel.Text = "Даний ID вже існує";
                    await ChangeColorAsync(Color.FromArgb(245, 108, 66), 1500);
                }
            }
            else
            {
                ResultLabel.Text = "Некоректний ID";
                await ChangeColorAsync(Color.FromArgb(245, 108, 66), 1500);
            }

        }
        private async Task ChangeColorAsync(Color color, int delay)
        {
            // Зберігаємо початковий колір
            Color originalColor = this.BackColor;

            IDInput.BackColor = color;

            // Змінюємо колір форми
            AddButton.BackColor = color;

            // Очікуємо заданий час
            await Task.Delay(delay);

            // Повертаємо початковий колір
            AddButton.BackColor = originalColor;
            IDInput.BackColor = originalColor;
        }
        private async Task ChangeColorFormAsync(Color color, int delay)
        {
            // Зберігаємо початковий колір
            Color originalColor = this.BackColor;

            // Змінюємо колір форми
            this.BackColor = color;

            // Очікуємо заданий час
            await Task.Delay(delay);

            // Повертаємо початковий колір
            this.BackColor = originalColor;
        }
        private void IDInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
