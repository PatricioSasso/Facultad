using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TowersOfHanoi
{
    class Hanoi
    {
        private string text;
        private BackgroundWorker bw;

        public Hanoi(
            bool printMoves, bool printTable,
            int numberDisks,
            ref string text,
            BackgroundWorker bw,
            Action<string> setText)
        {
            this.bw = bw;
            this.text = text;

            if (printMoves)
            {
                int moveNumber = 0;
                DateTime dt0 = DateTime.Now;

                this.text += "Move #\tFrom\tTo\r\n\r\n";
                MoveDisks(printMoves, numberDisks, 1, 2, 3, ref moveNumber);
                this.text += "\r\n";
                this.text += "Number of Moves = " + moveNumber + "\r\n";

                DateTime dt1 = DateTime.Now;
                TimeSpan ts = dt1 - dt0;

                this.text += "Time (min:sec.MS) - ";
                this.text += ts.Minutes.ToString("D2") + ":";
                this.text += ts.Seconds.ToString("D2") + ".";
                this.text += ts.Milliseconds.ToString("D3") + "\r\n\r\n";
                setText(this.text);
            }

            if (printTable)
            {
                this.text += "# Disks\t# Moves\tTime\r\n\r\n";

                for (numberDisks = 3; numberDisks <= 20; numberDisks++)
                {
                    int moveNumber = 0;
                    DateTime dt0 = DateTime.Now;

                    MoveDisks(false, numberDisks, 1, 2, 3, ref moveNumber);

                    if (bw.CancellationPending)
                        break;

                    DateTime dt1 = DateTime.Now;
                    TimeSpan ts = dt1 - dt0;

                    this.text += numberDisks + "\t" + moveNumber + "\t";
                    this.text += ts.Minutes.ToString("D2") + ":";
                    this.text += ts.Seconds.ToString("D2") + ".";
                    this.text += ts.Milliseconds.ToString("D3") + "\r\n";
                }

                setText(this.text);
            }
        }

        private void MoveDisks(
            bool printMoves,
            int numberDisks,
            int fromTower, int spareTower, int toTower,
            ref int moveNumber)
        {
            if (bw.CancellationPending)
                return;

            if (numberDisks > 1)
            {
                MoveDisks(printMoves, numberDisks - 1,
                    fromTower, toTower, spareTower,
                    ref moveNumber);
                MoveSingleDisk(printMoves, fromTower, toTower, ref moveNumber);
                MoveDisks(printMoves, numberDisks - 1,
                    spareTower, fromTower, toTower,
                    ref moveNumber);
            }

            else
                MoveSingleDisk(printMoves, fromTower, toTower, ref moveNumber);
        }

        private void MoveSingleDisk(
            bool printMoves,
            int fromTower, int toTower,
            ref int moveNumber)
        {
            moveNumber++;

            if (printMoves)
            {
                text += moveNumber.ToString() + "\t";
                text += fromTower.ToString() + "\t";
                text += toTower.ToString() + "\r\n";
            }
        }
    }
}
