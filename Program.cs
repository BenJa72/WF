namespace YAPEXAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                try
                {
                    int x = int.Parse(listBox1.Items[i].ToString());
                    if ((x % 2) == 0)
                    {
                        listBox2.Items.Add(listBox1.Items[i]);
                    }
                }   
                catch 
                {
                    
                }
            }
        }
    }
}
