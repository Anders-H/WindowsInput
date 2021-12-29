namespace WindowsInputDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread.Sleep(3000);

            if (checkBox1.Checked)
                WindowsInput.Buffer.FlushMouseBuffer(Handle);

            if (checkBox2.Checked)
                WindowsInput.Buffer.FlushKeyboardBuffer(Handle);

            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}