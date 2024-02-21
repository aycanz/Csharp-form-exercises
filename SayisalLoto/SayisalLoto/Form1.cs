namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random can = new Random();
            int sayi1, sayi2, sayi3, sayi4;

            sayi1 = can.Next(1, 3);
            sayi2 = can.Next(1, 3);
            sayi3 = can.Next(1, 3);
            sayi4 = can.Next(1, 3);
            label1.Text = sayi1.ToString();
            this.sayi2.Text = sayi2.ToString();
            this.label3.Text = sayi3.ToString();
            this.label4.Text = sayi4.ToString();

            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;

            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text == this.sayi2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else { textBox2.BackColor = Color.Red; }



            if (textBox3.Text == this.label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }




            if (textBox4.Text == this.label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

        }
    }
}
