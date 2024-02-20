namespace FormlarArasıveriTaşıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 can = new Form2();
            can.kimden = textBox1.Text;
            can.mesaj = textBox2.Text;
            can.Show();
            this.Hide();
        }
    }
}
