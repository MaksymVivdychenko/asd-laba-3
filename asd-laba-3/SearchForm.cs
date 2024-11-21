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
    public partial class SearchForm : Form
    {
        private Form1 menu;
        public SearchForm(Form1 form)
        {
            menu = form;
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            menu.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int ID;
            if(int.TryParse(IDInput.Text,out ID))
            {

                int comparisons = 0;
                Entry value = menu.Btree.Search(ID,ref comparisons);
                if (value != null)
                {
                    ResultLabel.Text = $"{value.Pointer} \n порівняння: {comparisons}";
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
