namespace TemperatureConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            timerTemp.Start();
        }

        private void timerTemp_Tick(object sender, EventArgs e)
        {
            
            this.Hide();
            var temp = new Temperature();
            temp.Closed += (s, args) => this.Close();
            temp.Show();

            timerTemp.Stop();
        }
    }
}