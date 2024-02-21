namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "D", "g", "h","K","B" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            int sembol3;
            int sayi1, sayi2, sayi3;
            Random can =new Random();
            sayi1=can.Next(0,sembol1.Length);
            sayi2=can.Next(0,sembol2.Length);
            sayi3 = can.Next(0, 10);
            label1.Text = sembol1[sayi1].ToString() + sembol2[sayi2].ToString()+ sayi3.ToString();
                

        }
    }
}
