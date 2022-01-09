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
    public partial class Page_Two : Form
    {
        private BackgroundWorker backgroundWorker;
        public Page_Two()
        {
            InitializeComponent();
            this.backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.DoWork += BackgroundWorker_DoWork;
            this.backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void Page_Two_Load(object sender, EventArgs e)
        {
            label1.Text = "Which one of these is a major\nadvantage of space telescopes?";
            backgroundWorker.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.CancelAsync();
            MessageBox.Show("Correct Answer..");
            Page_Three page_Three = new Page_Three();
            this.Hide();
            page_Three.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.CancelAsync();
            MessageBox.Show("Wrong Answer.. The Correct Answer is 'Avoid light pollution'");
            Page_Three page_Three = new Page_Three();
            this.Hide();
            page_Three.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.CancelAsync();
            MessageBox.Show("Wrong Answer.. The Correct Answer is 'Avoid light pollution'");
            Page_Three page_Three = new Page_Three();
            this.Hide();
            page_Three.Show();
        }

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
                                                MessageBox.Show("Time's Up! The Correct Answer is 'Avoid light pollution'");
                                                Page_Three page_Three = new Page_Three();
                                                page_Three.ShowDialog();
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
    }
}
