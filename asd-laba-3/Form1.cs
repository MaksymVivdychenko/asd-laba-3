namespace asd_laba_3
{
    public partial class Form1 : Form
    {
        public BTree Btree { get; set; }
        public Form1()
        {
            InitializeComponent();
            Btree = new(50, "C:\\Users\\user\\Desktop\\asd 3\\txt.txt");
            Btree.LoadTree();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.Show();
            Hide();
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.Show();
            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new(this);
            deleteForm.Show();
            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Update update = new(this);
            update.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Btree.SaveTree();
        }
    }
}
