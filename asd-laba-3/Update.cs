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
    public partial class Update : Form
    {
        Form1 menu;
        public Update(Form1 form)
        {
            InitializeComponent();
            menu = form;

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            menu.Show();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            int ID;
            if (int.TryParse(IDInput.Text, out ID))
            {

                //Entry<int, string> value = menu.BTree.Search(ID);
                Entry value = menu.Btree.Search(ID);
                if (value != null)
                {
                    value.Pointer = TextInput.Text;
                    ResultLabel.Text = "Запис оновлено";
                    await ChangeColorFormAsync(Color.LightGreen,1000);
                }
                else
                {
                    ResultLabel.Text = "Запис відсутній";
                    await ChangeColorAsync(Color.FromArgb(245, 108, 66), 1500);
                }
            }
            else
            {
                ResultLabel.Text = "Неправильне ID";
                await ChangeColorAsync(Color.FromArgb(245, 108, 66), 1500);
            }
        }
        private async Task ChangeColorAsync(Color color, int delay)
        {
            // Зберігаємо початковий колір
            Color originalColor = this.BackColor;

            IDInput.BackColor = color;

            // Змінюємо колір форми

            // Очікуємо заданий час
            await Task.Delay(delay);

            // Повертаємо початковий колір
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
        private void TextInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
