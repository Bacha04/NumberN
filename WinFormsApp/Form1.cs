namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
            
                int c = int.Parse(textBox1.Text);
                MessageBox.Show($"�� ����� ����� {c}");
            }
            catch 
            {
                MessageBox.Show("�� �� ����� �����");
            }
        }
    }
}