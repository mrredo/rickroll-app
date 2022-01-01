using System.Diagnostics;
using System.Windows.Input;
namespace Windows_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        string urls = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        
        
        public void OpenUrl(string url)
        {
            try
            {
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = url;
                Process.Start(psi);
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "ERROR");
            }
        }


        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Normal;
            OpenUrl(urls);
            this.WindowState = FormWindowState.Maximized;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Normal;
            OpenUrl(urls);
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            this.TopMost = false; // FALSE

            this.FormBorderStyle = FormBorderStyle.None;

            this.WindowState = FormWindowState.Maximized; // maximized
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Not so fast kid :)");
            this.WindowState = FormWindowState.Normal;
            OpenUrl(urls);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}