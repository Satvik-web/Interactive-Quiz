using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveQuiz
{
    public partial class Page_Seven : Form
    {
        private BackgroundWorker backgroundWorker;
        private async void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\10.png");
            await Task.Delay(1000);
            if (!this.backgroundWorker.CancellationPending)
            {
                pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\9.png");
                await Task.Delay(1000);
                if (!this.backgroundWorker.CancellationPending)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\8.png");
                    await Task.Delay(1000);
                    if (!this.backgroundWorker.CancellationPending)
                    {
                        pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\7.png");
                        await Task.Delay(1000);
                        if (!this.backgroundWorker.CancellationPending)
                        {
                            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\6.png");
                            await Task.Delay(1000);
                            if (!this.backgroundWorker.CancellationPending)
                            {
                                pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\5.png");
                                await Task.Delay(1000);
                                if (!this.backgroundWorker.CancellationPending)
                                {
                                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\4.png");
                                    await Task.Delay(1000);
                                    if (!this.backgroundWorker.CancellationPending)
                                    {
                                        pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\3.png");
                                        await Task.Delay(1000);
                                        if (!this.backgroundWorker.CancellationPending)
                                        {
                                            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\2.png");
                                            await Task.Delay(1000);
                                            if (!this.backgroundWorker.CancellationPending)
                                            {
                                                pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\1.png");
                                                await Task.Delay(1000);
                                                pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\0.png");
                                                MessageBox.Show("Time's Up! 'The Correct Answer is 'Boeing 747'");
                                                Page_Five page_five = new Page_Five();
                                                page_five.ShowDialog();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public Page_Seven()
        {
            InitializeComponent();
            this.backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.DoWork += BackgroundWorker_DoWork;
            this.backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void Page_Seven_Load(object sender, EventArgs e)
        {
            this.backgroundWorker.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.CancelAsync();
            MessageBox.Show("Correct Answer..");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.CancelAsync();
            MessageBox.Show("Wrong Answer.. Correct Answer is 'Boeing 747'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.CancelAsync();
            MessageBox.Show("Wrong Answer.. Correct Answer is 'Boeing 747'");
        }
    }
}
