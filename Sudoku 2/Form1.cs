using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sudoku_2
{
    public partial class Sudoku : Form
    {
        public Sudoku()
        {
            InitializeComponent();
        }

        TextBox[,] txtbox = new TextBox[9, 9];
        String[,] b = new String[9, 9];

        private void Start_game()
        {
            String s;
            String[] r;
            Char[] sep = { ' ', '\r' };
            int l = 0;
            StreamReader openfile;

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openfile = new StreamReader(ofd.FileName);

                s = openfile.ReadToEnd();
                r = s.Split(sep);

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        txtbox[i, j].Text = "";
                        txtbox[i, j].BackColor = Color.White;
                        if (r[l].CompareTo("0") != 0 && r[l].CompareTo("\n0") != 0)
                        {
                            txtbox[i, j].Text = r[l];
                            txtbox[i, j].BackColor = Color.LightGray;
                        }
                        b[i, j] = r[l];
                        l++;
                    }
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start_game();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            String k;
            Boolean sw;

            for(int i=0 ; i<9 ; i++)
            {
                for(int j=0 ; j<9 ; j++)
                {
                    if (b[i, j].CompareTo("0") == 0)
                    {
                        sw = true;

                        if (txtbox[i, j].Text.CompareTo("") == 0)
                        {
                            continue;
                        }

                        k = txtbox[i, j].Text;
                        txtbox[i, j].Text = "";

                        for (int f = 0; f < 9; f++)
                        {
                            if (txtbox[i, f].Text.CompareTo(k) == 0)
                            {
                                sw = false;
                            }
                        }
                        for (int f = 0; f < 9; f++)
                        {
                            if (txtbox[f, j].Text.CompareTo(k) == 0)
                            {
                                sw = false;
                            }
                        }

                        for (int f = 0; f < 3; f++)
                        {
                            for (int g = 0; g < 3; g++)
                            {
                                if (i >= 3 * f && i <= 3 * f + 2 && j >= 3 * g && j <= 3 * g + 2)
                                {
                                    for (int n = 3 * f; n < 3 * f + 2; n++)
                                    {
                                        for (int m = 3 * g; m < 3 * g + 2; m++)
                                        {
                                            if (txtbox[n, m].Text.CompareTo(k) == 0)
                                            {
                                                sw = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (sw == false)
                        {
                            txtbox[i, j].BackColor = Color.Red;
                        }
                        else
                        {
                            txtbox[i, j].BackColor = Color.LightGreen;
                        }
                        txtbox[i, j].Text = k;
                    }
                }
            }
        }

        private void Sudoku_Load(object sender, EventArgs e)
        {
            txtbox[0, 0] = textBox1;
            txtbox[0, 1] = textBox2;
            txtbox[0, 2] = textBox3;
            txtbox[0, 3] = textBox4;
            txtbox[0, 4] = textBox5;
            txtbox[0, 5] = textBox6;
            txtbox[0, 6] = textBox7;
            txtbox[0, 7] = textBox8;
            txtbox[0, 8] = textBox9;
            txtbox[1, 0] = textBox10;
            txtbox[1, 1] = textBox11;
            txtbox[1, 2] = textBox12;
            txtbox[1, 3] = textBox13;
            txtbox[1, 4] = textBox14;
            txtbox[1, 5] = textBox15;
            txtbox[1, 6] = textBox16;
            txtbox[1, 7] = textBox17;
            txtbox[1, 8] = textBox18;
            txtbox[2, 0] = textBox19;
            txtbox[2, 1] = textBox20;
            txtbox[2, 2] = textBox21;
            txtbox[2, 3] = textBox22;
            txtbox[2, 4] = textBox23;
            txtbox[2, 5] = textBox24;
            txtbox[2, 6] = textBox25;
            txtbox[2, 7] = textBox26;
            txtbox[2, 8] = textBox27;
            txtbox[3, 0] = textBox28;
            txtbox[3, 1] = textBox29;
            txtbox[3, 2] = textBox30;
            txtbox[3, 3] = textBox31;
            txtbox[3, 4] = textBox32;
            txtbox[3, 5] = textBox33;
            txtbox[3, 6] = textBox34;
            txtbox[3, 7] = textBox35;
            txtbox[3, 8] = textBox36;
            txtbox[4, 0] = textBox37;
            txtbox[4, 1] = textBox38;
            txtbox[4, 2] = textBox39;
            txtbox[4, 3] = textBox40;
            txtbox[4, 4] = textBox41;
            txtbox[4, 5] = textBox42;
            txtbox[4, 6] = textBox43;
            txtbox[4, 7] = textBox44;
            txtbox[4, 8] = textBox45;
            txtbox[5, 0] = textBox46;
            txtbox[5, 1] = textBox47;
            txtbox[5, 2] = textBox48;
            txtbox[5, 3] = textBox49;
            txtbox[5, 4] = textBox50;
            txtbox[5, 5] = textBox51;
            txtbox[5, 6] = textBox52;
            txtbox[5, 7] = textBox53;
            txtbox[5, 8] = textBox54;
            txtbox[6, 0] = textBox55;
            txtbox[6, 1] = textBox56;
            txtbox[6, 2] = textBox57;
            txtbox[6, 3] = textBox58;
            txtbox[6, 4] = textBox59;
            txtbox[6, 5] = textBox60;
            txtbox[6, 6] = textBox61;
            txtbox[6, 7] = textBox62;
            txtbox[6, 8] = textBox63;
            txtbox[7, 0] = textBox64;
            txtbox[7, 1] = textBox65;
            txtbox[7, 2] = textBox66;
            txtbox[7, 3] = textBox67;
            txtbox[7, 4] = textBox68;
            txtbox[7, 5] = textBox69;
            txtbox[7, 6] = textBox70;
            txtbox[7, 7] = textBox71;
            txtbox[7, 8] = textBox72;
            txtbox[8, 0] = textBox73;
            txtbox[8, 1] = textBox74;
            txtbox[8, 2] = textBox75;
            txtbox[8, 3] = textBox76;
            txtbox[8, 4] = textBox77;
            txtbox[8, 5] = textBox78;
            txtbox[8, 6] = textBox79;
            txtbox[8, 7] = textBox80;
            txtbox[8, 8] = textBox81;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sudoku v 2.01 \nProgrammer: Sajjad Aemmi \nAll Rights Reserved!", "About",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_game();
        }
    }
}
