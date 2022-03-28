namespace MovieApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.updateSelectedData();
        }
        void updateSelectedData() {
            
            this.tbMovie.Text = this.rdMovie1.Checked ? "เทอมสอง" : "พี่นาค 3";

            if (this.rdTime1.Checked)
                this.tbTime.Text = "11:00";
            else if (this.rdTime2.Checked)
                this.tbTime.Text = "13:40";
            else if (this.rdTime3.Checked)
                this.tbTime.Text = "16:20";
            else
                this.tbTime.Text = "19:00";
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.updateSelectedData();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.tbSeat.Text = "";
            Control.ControlCollection controls = groupBox3.Controls;
            foreach (Control control in controls) 
            {
                if (control is CheckBox) 
                {
                    if (((CheckBox)control).Checked == true) 
                    {
                        if (this.tbSeat.Text != "")
                            this.tbSeat.Text = this.tbSeat.Text + ", ";

                        this.tbSeat.Text += ((CheckBox)control).Text;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movice = this.tbMovie.Text;
            string time = this.tbTime.Text;
            string seats = this.tbSeat.Text;

            MovieManagement mm = new MovieManagement();
            mm.createTicket(movice, time, seats);
            int price = mm.saleTicket();

            Payment p = new Payment(price);
            p.ShowDialog();
        }
    }
}