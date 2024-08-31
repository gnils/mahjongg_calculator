using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mahjongg
{
    public partial class Mahjongg : Form
    {
        Form parent;
        string[] players = new string[3];
        int[] points = new int[3] { 0, 0, 0 };
        int eastPlayer = 0;
        List<int[]> games = new List<int[]>();
        public Mahjongg(Form pf, string p1, string p2, string p3, string p4)
        {
            parent = pf;
            InitializeComponent();

            textBox.SelectionTabs = new int[] { 120, 240, 360, 480, 600 };

            if (p4 != "")
            {
                players = new string[4];
                points = new int[4] { 0, 0, 0, 0 };
                players[3] = name4.Text = p4;
                games.Add(new int[4] { 0, 0, 0, 0 });
            }
            else
            {
                games.Add(new int[3] { 0, 0, 0 });
                name4.Enabled = sum4.Enabled = points4.Enabled = win4.Enabled = x24.Enabled = false;
            }

            players[0] = name1.Text = p1;
            players[1] = name2.Text = p2;
            players[2] = name3.Text = p3;
            
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool[] winner = new bool[players.Count()];
            winner[0] = win1.Checked;
            winner[1] = win2.Checked;
            winner[2] = win3.Checked;

            int[] punkte = null;
            int[] score = null;

            try
            {
                punkte = new int[players.Count()];
                punkte[0] = points1.Text == "" || points1.Text == "0" ? 8 : Convert.ToInt32(points1.Text);
                punkte[1] = points2.Text == "" || points1.Text == "0" ? 8 : Convert.ToInt32(points2.Text);
                punkte[2] = points3.Text == "" || points1.Text == "0" ? 8 : Convert.ToInt32(points3.Text);

                score = new int[players.Count()];
                score[0] = score[1] = score[2] = 0;

                if (players.Count() == 4)
                {
                    winner[3] = win4.Checked;
                    punkte[3] = points4.Text == "" || points1.Text == "0" ? 8 : Convert.ToInt32(points4.Text);
                    score[3] = 0;
                }
            }
            catch
            {
                MessageBox.Show("Bitte ganze Zahlen eingeben");
                return;
            }

            for (int p = 0; p < players.Count(); p++)
            {
                int sum = 0;
                for (int i = 0; i < players.Count(); i++)
                {
                    if (i == p)
                        continue;

                    int pay = punkte[p] * (p == eastPlayer || i == eastPlayer ? 2 : 1);

                    if (!winner[i])
                    {
                        score[i] -= pay;
                        sum += pay;
                    }

                }

                score[p] += sum;
            }

            for (int p = 0; p < players.Count(); p++)
            {
                points[p] += score[p];
            }

            if (winner[0] || winner[1] || winner[2] || (players.Count() == 4 && winner[3]))
            {
                if (!winner[eastPlayer])
                    eastPlayer = (eastPlayer + 1) % players.Count();
            }


            if (players.Count() == 4)
                games.Add(new int[4] { points[0], points[1], points[2], points[3] });
            else
                games.Add(new int[3] { points[0], points[1], points[2] });

            log("Punkte dieses Spiel:");
            log(players);
            log(score);

            log("Aktueller Punktestand:");
            log(players);
            log(points);

            log(players[eastPlayer] + " ist Osten!\r\n");

            sum1.Text = points[0].ToString();
            sum2.Text = points[1].ToString();
            sum3.Text = points[2].ToString();

            points1.BackColor = eastPlayer == 0 ? SystemColors.InactiveCaption : Color.White;
            points2.BackColor = eastPlayer == 1 ? SystemColors.InactiveCaption : Color.White;
            points3.BackColor = eastPlayer == 2 ? SystemColors.InactiveCaption : Color.White;

            if (players.Count() == 4)
            {
                sum4.Text = points[3].ToString();
                points4.BackColor = eastPlayer == 3 ? SystemColors.InactiveCaption : Color.White;
            }

            win1.Checked = win2.Checked = win3.Checked = win4.Checked = false;
            points1.Text = points2.Text = points3.Text = points4.Text = "";

            textBox.SelectionStart = textBox.TextLength;
            textBox.ScrollToCaret();

            pictureBox2.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            points1.Text = (Convert.ToInt32(points1.Text) * 2.0).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            points2.Text = (Convert.ToInt32(points2.Text) * 2.0).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            points3.Text = (Convert.ToInt32(points3.Text) * 2.0).ToString();
        }
        

        void log(string[] col)
        {
            for (int i = 0; i < col.Length; i++)
            {
                textBox.Text += col[i] + "\t";
            }

            if (col.Length > 0)
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);

            textBox.Text += "\r\n";
        }

        void log(int[] col)
        {
            for (int i = 0; i < col.Length; i++)
            {
                textBox.Text += col[i].ToString() + "\t";
            }

            if (col.Length > 0)
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);

            textBox.Text += "\r\n";

        }

        void log(string s)
        {
            textBox.Text += s + "\r\n";
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);

            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < games.Count; i++)
                for (int j = 0; j < games[i].Length; j++)
                {
                    max = Math.Max(max, games[i][j]);
                    min = Math.Min(min, games[i][j]);
                }

            if (max - min == 0 || games.Count == 0)
                return;


            int border = 15;

            double w = pictureBox2.Width - border * 2.0 - 100;
            double h = pictureBox2.Height - 5 - border * 2.0;


            int zero = Convert.ToInt32((double)-min / (double)(max - min) * h);

            g.DrawLine(new Pen(Color.LightGray, 5), new Point(0, border + (int)h - zero), new Point((int)w, border + (int)h - zero));

            for (int p = 0; p < players.Count(); p++)
            {
                List<Point> pnts = new List<Point>();
                for (int a = 0; a < games.Count; a++)
                {
                    double gameStep = w / ((double)games.Count - 1);

                    int game = Convert.ToInt32(a * gameStep);
                    int score = Convert.ToInt32((games[a][p] - min) / (double)(max - min) * h);

                    pnts.Add(new Point(border + game, border + (int)h - score));
                }

                Color c = Color.Black;
                if (p == 0)
                    c = name1.ForeColor;
                if (p == 1)
                    c = name2.ForeColor;
                if (p == 2)
                    c = name3.ForeColor;
                if (p == 3)
                    c = name4.ForeColor;

                int yy = Convert.ToInt32((games[games.Count - 1][p] - min) / (double)(max - min) * h);

                g.DrawLines(new Pen(c, 5), pnts.ToArray());
                g.DrawString(players[p], textBox.Font, new SolidBrush(c), 2 * border + (int)w , border + (int)h - yy - 13);
            }
        }

        private void Mahjongg_Load(object sender, EventArgs e)
        {

        }

        private void Mahjongg_ClientSizeChanged(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }
    }

}
