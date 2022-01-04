using System.Diagnostics;
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
        string[] codeS = { "were", "strangers", "never", "give", "known", "down", "desert", "cry", "wanna", "goodbye" };
        
        
        public void OpenUrl(string url)
        {
            try
            {
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = url;
                for(int i = 0; i < 5; i++)
                {
                    Process.Start(psi);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return;
            this.WindowState = FormWindowState.Normal;
            OpenUrl(urls);
            Thread.Sleep(1000);
            MessageBox.Show("enjoy rickroll my dude");
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            return;
            MessageBox.Show("enjoy rickroll my dude");
            this.WindowState = FormWindowState.Normal;
            OpenUrl(urls);
            this.WindowState = FormWindowState.Maximized;
        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
            switch(RulesLabel.Visible)
            {
                case true:
                    RulesLabel.Visible = false;
                    break;
                case false:
                    RulesLabel.Visible = true;
                    break;
            }
        }

        private void RulesLabel_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hello u have unlocked the secret! U will not get rickrolled :)", "IDK", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            switch(result)
            {
                case DialogResult.OK:
                    OpenUrl(urls);
                    break;
                case DialogResult.Cancel:
                    Application.Exit();
                    break;
            }
        }

        private void CodeLabel_DoubleClick(object sender, EventArgs e)
        {
            
            if(CodeLabelMenu.Text == "Enter secret code to not get rickrolled.")
            {
                CodeLabelMenu.Text = "Enter secret code to not get rickrolled.  Notes:  1. Code length can be from 4-9 characters.  2. Code is a single word from a song rick astley made.  3. Code can change everytime u enter it.";
            } else
            {
                CodeLabelMenu.Text = "Enter secret code to not get rickrolled.";
            }
            
        }

        private void CodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Random random = new Random();
            int num = random.Next(0, codeS.Length);
            string value = codeS[num];
            if (e.KeyCode == Keys.Enter)
            {
                if(CodeTextBox.Text.ToLower() == value)
                {
                    MessageBox.Show("U have guessed the code! \n Good luck on rickrolling.\n By pressing that button u can leave this app :)", "Just close this box", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Application.Exit();
                } else
                {
                    OpenUrl(urls);
                }
            }
        }

        

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Random random = new Random();
            int num = random.Next(0, codeS.Length);
            string value = codeS[num];
            if (e.KeyCode == Keys.Enter)
            {
                if (CodeTextBoxMenu.Text.ToLower() == value)
                {
                    MessageBox.Show("U have guessed the code! \n Good luck on rickrolling.\n By pressing that button u can leave this app :)", "Just close this box", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Application.Exit();
                }
                else
                {
                    OpenUrl(urls);
                }
            }
        }
    }
}
