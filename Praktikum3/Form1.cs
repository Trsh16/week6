namespace Praktikum3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToString("dddd") == "Monday")
            {
                label1.Text = "Senin";
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Tuesday")
            {
                label1.Text = "Selasa";
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Wednesday")
            {
                label1.Text = "Rabu";
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Thursday")
            {
                label1.Text = "Kamis";
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Friday")
            {
                label1.Text = "Jumat";
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Saturday")
            {
                label1.Text = "Sabtu";
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Sunday")
            {
                label1.Text = "Minggu";
            }
        }
    }
}