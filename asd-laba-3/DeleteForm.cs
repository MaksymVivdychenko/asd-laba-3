using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace asd_laba_3
{
    public partial class DeleteForm : Form
    {
        Form1 menu;
        public DeleteForm(Form1 form)
        {
            InitializeComponent();
            menu = form;
            ResultLabel.Text = "";
        }

        private void MenuButton_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            int ID;
            if (int.TryParse(IDInput.Text, out ID))
            {

                //Entry<int, string> value = menu.BTree.Search(ID);
                Entry value = menu.Btree.Search(ID);
                if (value != null)
                {
                    menu.Btree.Delete(ID);
                    ResultLabel.Text = "Запис успішно видалено";
                    await ChangeColorFormAsync(Color.LightGreen, 1500);
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
    }
}
