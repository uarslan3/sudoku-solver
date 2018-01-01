using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            char[,] degf2 = new char[9, 9];
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    degf2[i, j] = Form1.deg1[i, j];
                }

            }
            /*while (true) {
                if (Form1.sayac11 == 0 && Form1.sayac22 == 0 && Form1.sayac33 == 0 && Form1.sayac44 == 0)
                {
                    yazdir(deg);
                }
                else
                    break;
            }
            */


            richTextBox1.Text = degf2[0, 0].ToString();
            richTextBox2.Text = degf2[0, 1].ToString();
            richTextBox3.Text = degf2[0, 2].ToString();
            richTextBox4.Text = degf2[0, 3].ToString();
            richTextBox5.Text = degf2[0, 4].ToString();
            richTextBox6.Text = degf2[0, 5].ToString();
            richTextBox7.Text = degf2[0, 6].ToString();
            richTextBox8.Text = degf2[0, 7].ToString();
            richTextBox9.Text = degf2[0, 8].ToString();

            richTextBox10.Text = degf2[1, 0].ToString();
            richTextBox11.Text = degf2[1, 1].ToString();
            richTextBox12.Text = degf2[1, 2].ToString();
            richTextBox13.Text = degf2[1, 3].ToString();
            richTextBox14.Text = degf2[1, 4].ToString();
            richTextBox15.Text = degf2[1, 5].ToString();
            richTextBox16.Text = degf2[1, 6].ToString();
            richTextBox17.Text = degf2[1, 7].ToString();
            richTextBox18.Text = degf2[1, 8].ToString();

            richTextBox19.Text = degf2[2, 0].ToString();
            richTextBox20.Text = degf2[2, 1].ToString();
            richTextBox21.Text = degf2[2, 2].ToString();
            richTextBox22.Text = degf2[2, 3].ToString();
            richTextBox23.Text = degf2[2, 4].ToString();
            richTextBox24.Text = degf2[2, 5].ToString();
            richTextBox25.Text = degf2[2, 6].ToString();
            richTextBox26.Text = degf2[2, 7].ToString();
            richTextBox27.Text = degf2[2, 8].ToString();

            richTextBox28.Text = degf2[3, 0].ToString();
            richTextBox29.Text = degf2[3, 1].ToString();
            richTextBox30.Text = degf2[3, 2].ToString();
            richTextBox31.Text = degf2[3, 3].ToString();
            richTextBox32.Text = degf2[3, 4].ToString();
            richTextBox33.Text = degf2[3, 5].ToString();
            richTextBox34.Text = degf2[3, 6].ToString();
            richTextBox35.Text = degf2[3, 7].ToString();
            richTextBox36.Text = degf2[3, 8].ToString();

            richTextBox37.Text = degf2[4, 0].ToString();
            richTextBox38.Text = degf2[4, 1].ToString();
            richTextBox39.Text = degf2[4, 2].ToString();
            richTextBox40.Text = degf2[4, 3].ToString();
            richTextBox41.Text = degf2[4, 4].ToString();
            richTextBox42.Text = degf2[4, 5].ToString();
            richTextBox43.Text = degf2[4, 6].ToString();
            richTextBox44.Text = degf2[4, 7].ToString();
            richTextBox45.Text = degf2[4, 8].ToString();

            richTextBox46.Text = degf2[5, 0].ToString();
            richTextBox47.Text = degf2[5, 1].ToString();
            richTextBox48.Text = degf2[5, 2].ToString();
            richTextBox49.Text = degf2[5, 3].ToString();
            richTextBox50.Text = degf2[5, 4].ToString();
            richTextBox51.Text = degf2[5, 5].ToString();
            richTextBox52.Text = degf2[5, 6].ToString();
            richTextBox53.Text = degf2[5, 7].ToString();
            richTextBox54.Text = degf2[5, 8].ToString();

            richTextBox55.Text = degf2[6, 0].ToString();
            richTextBox56.Text = degf2[6, 1].ToString();
            richTextBox57.Text = degf2[6, 2].ToString();
            richTextBox58.Text = degf2[6, 3].ToString();
            richTextBox59.Text = degf2[6, 4].ToString();
            richTextBox60.Text = degf2[6, 5].ToString();
            richTextBox61.Text = degf2[6, 6].ToString();
            richTextBox62.Text = degf2[6, 7].ToString();
            richTextBox63.Text = degf2[6, 8].ToString();

            richTextBox64.Text = degf2[7, 0].ToString();
            richTextBox65.Text = degf2[7, 1].ToString();
            richTextBox66.Text = degf2[7, 2].ToString();
            richTextBox67.Text = degf2[7, 3].ToString();
            richTextBox68.Text = degf2[7, 4].ToString();
            richTextBox69.Text = degf2[7, 5].ToString();
            richTextBox70.Text = degf2[7, 6].ToString();
            richTextBox71.Text = degf2[7, 7].ToString();
            richTextBox72.Text = degf2[7, 8].ToString();

            richTextBox73.Text = degf2[8, 0].ToString();
            richTextBox74.Text = degf2[8, 1].ToString();
            richTextBox75.Text = degf2[8, 2].ToString();
            richTextBox76.Text = degf2[8, 3].ToString();
            richTextBox77.Text = degf2[8, 4].ToString();
            richTextBox78.Text = degf2[8, 5].ToString();
            richTextBox79.Text = degf2[8, 6].ToString();
            richTextBox80.Text = degf2[8, 7].ToString();
            richTextBox81.Text = degf2[8, 8].ToString();
        }
    }
}
