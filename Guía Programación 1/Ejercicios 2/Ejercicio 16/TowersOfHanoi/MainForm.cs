using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TowersOfHanoi
{
    public partial class MainForm : Form
    {
        private bool printMoves;
        private bool printTable;
        private int numberDisks;
        private BackgroundWorker bw;

        public MainForm()
        {
            InitializeComponent();
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox1.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "&Compute")
            {
                numberDisks = (int)numericUpDown1.Value;
                printMoves = radioButton1.Checked;
                printTable = radioButton2.Checked;
                bw = new BackgroundWorker();
                bw.WorkerSupportsCancellation = true;
                bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                bw.RunWorkerAsync();
                while (!bw.IsBusy) { }
                button1.Text = "&Stop";
            }

            else
                bw.CancelAsync();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button1.Text = "&Compute";
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string text = textBox1.Text;

            Hanoi h = new Hanoi(
                printMoves, printTable, numberDisks,
                ref text, bw, SetText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}