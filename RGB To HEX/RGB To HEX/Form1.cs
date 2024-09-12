using System;
using System.Drawing;
using System.Windows.Forms;


namespace RGB_To_HEX
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

        private void btnRun_Click(object sender, EventArgs e)
        {


            int Red = int.Parse(txtRed.Text);
            int Green = int.Parse(txtGreen.Text);
            int Blue = int.Parse(txtBlue.Text);

            if (Red<0 || Red>255 ||Green<0||Green>255||Blue<0||Blue>255)
            {
                MessageBox.Show("meghdar RGB bayad bein 0 ta 255 bashad");
                return;
            }

            string hexColor = Color.FromArgb(Red, Green, Blue).Name;

            lblHexColor.Text = hexColor;
            lblColorShow.BackColor= Color.FromArgb(Red, Green, Blue);
            
            
        }

      
       

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblHexColor_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
