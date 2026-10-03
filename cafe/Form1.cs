namespace cafe
{
    public partial class Form1 : Form
    {
        decimal yekunHesab = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Zəhmət olmasa səbətdən yemək seçin.");
                return;
            }

            string yemeyinAdi = listBox1.SelectedItem.ToString();

            DialogResult d = MessageBox.Show(
                "Siyahıdan silinsinmi?",
                "Bildiriş",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (d == DialogResult.Yes)
            {
                if (yemeyinAdi.Contains("dort"))
                    yekunHesab -= 5;

                else if (yemeyinAdi.Contains("kola"))
                    yekunHesab -= 3;

                else if (yemeyinAdi.Contains("meyve suyu"))
                    yekunHesab -= 4;

                else if (yemeyinAdi.Contains("BURGER"))
                    yekunHesab -= 8;

                else if (yemeyinAdi.Contains("sendvic"))
                    yekunHesab -= 6;

                else if (yemeyinAdi.Contains("pizza"))
                    yekunHesab -= 7;

                else if (yemeyinAdi.Contains("kek"))
                    yekunHesab -= 3;

                else if (yemeyinAdi.Contains("hotdog"))
                    yekunHesab -= 3;

                else if (yemeyinAdi.Contains("pecenye"))
                    yekunHesab -= 2;

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                MessageBox.Show(yemeyinAdi + " səbətdən silindi.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(
       "Xanalar sıfırlansınmı?",
       "Bildiriş",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (d == DialogResult.Yes)
            {
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                textBox1.Clear();
                listBox1.Items.Clear();

                yekunHesab = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }

            textBox1.Text = yekunHesab.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal mebleg;
            decimal hesab;

            if (!decimal.TryParse(maskedTextBox1.Text, out mebleg))
            {
                MessageBox.Show("Məbləğ düzgün daxil edilməyib.");
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out hesab))
            {
                MessageBox.Show("Əvvəlcə yekun hesabı hesablayın.");
                return;
            }

            if (mebleg < hesab)
            {
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                return;
            }

            decimal qaliq = mebleg - hesab;

            maskedTextBox2.Text = qaliq.ToString("0.00");
        }
        int say = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") dort - 5 manat");
            yekunHesab += 5;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") kola - 3 manat");
            yekunHesab += 3;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") meyve suyu - 4 manat");
            yekunHesab += 4;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") BURGER - 8 manat");
            yekunHesab += 8;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") sendvic - 6 manat");
            yekunHesab += 6;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") pizza - 7 manat");
            yekunHesab += 7;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") kek - 3 manat");
            yekunHesab += 3;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") hotdog - 3 manat");
            yekunHesab += 3;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            say++;
            listBox1.Items.Add(say + ") pecenye - 2 manat");
            yekunHesab += 2;
        }
    }
}
