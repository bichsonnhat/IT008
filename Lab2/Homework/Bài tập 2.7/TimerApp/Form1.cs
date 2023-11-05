namespace TimerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        decimal downtime = 60;
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                numericUpDown2.Value++;
                box.Value = 0;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                numericUpDown1.Value++;
                box.Value = 0;
            }
        }

        void Shutdown(string command)
        {
            System.Diagnostics.Process.Start("shutdown", command);
        }

        void calculateDownTime()
        {
            downtime = numericUpDown3.Value + numericUpDown2.Value * 60 + numericUpDown1.Value * 60 * 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateDownTime();
            Shutdown("-s -t" + downtime.ToString());
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculateDownTime();
            Shutdown("-r -t" + downtime.ToString());
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculateDownTime();
            Shutdown("/l" + downtime.ToString());
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Shutdown("-a");
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            downtime--;
        }
    }
}