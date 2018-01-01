using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        TextWriter dosya1 = new StreamWriter(@"C:\Users\Umut\Desktop\bitmeyenler\thread1.txt");
        TextWriter dosya2 = new StreamWriter(@"C:\Users\Umut\Desktop\bitmeyenler\thread2.txt");
        TextWriter dosya3 = new StreamWriter(@"C:\Users\Umut\Desktop\bitmeyenler\thread3.txt");
        TextWriter dosya4 = new StreamWriter(@"C:\Users\Umut\Desktop\bitmeyenler\thread4.txt");



        public static char [,] degerler=new char[9,9];
        public static char[,] degerler1 = new char[9, 9];
        public static char[,] degerler2 = new char[9, 9];
        public static char[,] degerler3 = new char[9, 9];
        public static char[,] frm = new char[9, 9];
        public static char[,] deg3 = new char[9, 9];
        public static char[,] deg2 = new char[9, 9];
        public static char[,] deg1 = new char[9, 9];
        public static char[,] deg = new char[9, 9];
        public static int sayac1=0,sayac2=0,sayac3=0,sayac4=0;
        public static int sayac11 = 0, sayac22 = 0, sayac33 = 0, sayac44 = 0;
        public Stopwatch w = new Stopwatch();
        public Stopwatch w1 = new Stopwatch();
        public Stopwatch w2 = new Stopwatch();
        public Stopwatch w3 = new Stopwatch();
        char[] DIGITS = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public  void  yazdir(char[,] degerler)
        {
           
            
            richTextBox1.Text = degerler[0, 0].ToString();
            richTextBox2.Text = degerler[0, 1].ToString();
            richTextBox3.Text = degerler[0, 2].ToString();
            richTextBox4.Text = degerler[0, 3].ToString();
            richTextBox5.Text = degerler[0, 4].ToString();
            richTextBox6.Text = degerler[0, 5].ToString();
            richTextBox7.Text = degerler[0, 6].ToString();
            richTextBox8.Text = degerler[0, 7].ToString();
            richTextBox9.Text = degerler[0, 8].ToString();

            richTextBox10.Text = degerler[1, 0].ToString();
            richTextBox11.Text = degerler[1, 1].ToString();
            richTextBox12.Text = degerler[1, 2].ToString();
            richTextBox13.Text = degerler[1, 3].ToString();
            richTextBox14.Text = degerler[1, 4].ToString();
            richTextBox15.Text = degerler[1, 5].ToString();
            richTextBox16.Text = degerler[1, 6].ToString();
            richTextBox17.Text = degerler[1, 7].ToString();
            richTextBox18.Text = degerler[1, 8].ToString();

            richTextBox19.Text = degerler[2, 0].ToString();
            richTextBox20.Text = degerler[2, 1].ToString();
            richTextBox21.Text = degerler[2, 2].ToString();
            richTextBox22.Text = degerler[2, 3].ToString();
            richTextBox23.Text = degerler[2, 4].ToString();
            richTextBox24.Text = degerler[2, 5].ToString();
            richTextBox25.Text = degerler[2, 6].ToString();
            richTextBox26.Text = degerler[2, 7].ToString();
            richTextBox27.Text = degerler[2, 8].ToString();

            richTextBox28.Text = degerler[3, 0].ToString();
            richTextBox29.Text = degerler[3, 1].ToString();
            richTextBox30.Text = degerler[3, 2].ToString();
            richTextBox31.Text = degerler[3, 3].ToString();
            richTextBox32.Text = degerler[3, 4].ToString();
            richTextBox33.Text = degerler[3, 5].ToString();
            richTextBox34.Text = degerler[3, 6].ToString();
            richTextBox35.Text = degerler[3, 7].ToString();
            richTextBox36.Text = degerler[3, 8].ToString();

            richTextBox37.Text = degerler[4, 0].ToString();
            richTextBox38.Text = degerler[4, 1].ToString();
            richTextBox39.Text = degerler[4, 2].ToString();
            richTextBox40.Text = degerler[4, 3].ToString();
            richTextBox41.Text = degerler[4, 4].ToString();
            richTextBox42.Text = degerler[4, 5].ToString();
            richTextBox43.Text = degerler[4, 6].ToString();
            richTextBox44.Text = degerler[4, 7].ToString();
            richTextBox45.Text = degerler[4, 8].ToString();

            richTextBox46.Text = degerler[5, 0].ToString();
            richTextBox47.Text = degerler[5, 1].ToString();
            richTextBox48.Text = degerler[5, 2].ToString();
            richTextBox49.Text = degerler[5, 3].ToString();
            richTextBox50.Text = degerler[5, 4].ToString();
            richTextBox51.Text = degerler[5, 5].ToString();
            richTextBox52.Text = degerler[5, 6].ToString();
            richTextBox53.Text = degerler[5, 7].ToString();
            richTextBox54.Text = degerler[5, 8].ToString();

            richTextBox55.Text = degerler[6, 0].ToString();
            richTextBox56.Text = degerler[6, 1].ToString();
            richTextBox57.Text = degerler[6, 2].ToString();
            richTextBox58.Text = degerler[6, 3].ToString();
            richTextBox59.Text = degerler[6, 4].ToString();
            richTextBox60.Text = degerler[6, 5].ToString();
            richTextBox61.Text = degerler[6, 6].ToString();
            richTextBox62.Text = degerler[6, 7].ToString();
            richTextBox63.Text = degerler[6, 8].ToString();

            richTextBox64.Text = degerler[7, 0].ToString();
            richTextBox65.Text = degerler[7, 1].ToString();
            richTextBox66.Text = degerler[7, 2].ToString();
            richTextBox67.Text = degerler[7, 3].ToString();
            richTextBox68.Text = degerler[7, 4].ToString();
            richTextBox69.Text = degerler[7, 5].ToString();
            richTextBox70.Text = degerler[7, 6].ToString();
            richTextBox71.Text = degerler[7, 7].ToString();
            richTextBox72.Text = degerler[7, 8].ToString();

            richTextBox73.Text = degerler[8, 0].ToString();
            richTextBox74.Text = degerler[8, 1].ToString();
            richTextBox75.Text = degerler[8, 2].ToString();
            richTextBox76.Text = degerler[8, 3].ToString();
            richTextBox77.Text = degerler[8, 4].ToString();
            richTextBox78.Text = degerler[8, 5].ToString();
            richTextBox79.Text = degerler[8, 6].ToString();
            richTextBox80.Text = degerler[8, 7].ToString();
            richTextBox81.Text = degerler[8, 8].ToString();


        }
        
        public void txtyaz1(char[,] pu)
        {
            
            int i, j;
            for(i=0;i<9;i++)
            {
                for(j=0;j<9;j++)

                {
                    if (sayac11 == 0 && sayac22 == 0 && sayac33 == 0 && sayac44 == 0)
                    {
                        dosya1.Write(pu[i, j]);
                        dosya1.Write(" ");
                    }
                }
                dosya1.WriteLine();
            }
            dosya1.WriteLine();
        }
        public void txtyaz2(char[,] pu)
        {
            
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)

                {
                    if (sayac11 == 0 && sayac22 == 0 && sayac33 == 0 && sayac44 == 0)
                    {
                        dosya2.Write(pu[i, j]);
                        dosya2.Write(" ");
                    }
                }
                dosya2.WriteLine();
            }
           dosya2.WriteLine();
        }
        public void txtyaz3(char[,] pu)
        {
            
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)

                {
                    if (sayac11 == 0 && sayac22 == 0 && sayac33 == 0 && sayac44 == 0)
                    {
                        dosya3.Write(pu[i, j]);
                        dosya3.Write(" ");
                    }
                }
                dosya3.WriteLine();
            }
          dosya3.WriteLine();
        }
        public void txtyaz4(char[,] pu)
        {
            
            int i, j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)

                {
                    if (sayac11 == 0 && sayac22 == 0 && sayac33 == 0 && sayac44 == 0)
                    {
                        dosya4.Write(pu[i, j]);
                        dosya4.Write(" ");
                    }
                }
                dosya4.WriteLine();
            }
            dosya4.WriteLine();
        }
       
        public bool CanPlay(char[,] board, int r, int c, char x)
        {
            // check column
            for (int i = 0; i < 9; i++)
            {
                if (board[r, i] == x)
                    return false;
            }

            // check row
            for (int i = 0; i < 9; i++)
            {
                if (board[i, c] == x)
                    return false;
            }

            // check cell
            int r0 = 3 * (r / 3);
            int r1 = 3 * (r / 3) + 3;
            int c0 = 3 * (c / 3);
            int c1 = 3 * (c / 3) + 3;
            for (int i = r0; i < r1; i++)
            {
                for (int j = c0; j < c1; j++)
                {
                    if (board[i, j] == x) return false;
                }
            }

            // okay
            return true;
        }
       
       
        public bool Solve(char[,] board, int r, int c)
        {
            txtyaz1(board);
            if (sayac11 == 0 && sayac22 == 0 && sayac33 == 0 && sayac44 == 0)
            {
                
                int i, j;
                for (i = 0; i < 9; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        deg[i, j] = degerler[i, j];
                    }

                }

                w.Start();
                // move right until you get to end, then restart at next row
               

                if (c == 9)
                    return Solve(board, r + 1, 0);
                if (r == 9)
                {
                    
                    sayac11 = 1;
                    
                    w.Stop();
                    return true;

                }
                if (board[r, c] != '*')
                {
                    return Solve(board, r, c + 1);
                }

                foreach (char d in DIGITS)
                {

                    if (CanPlay(board, r, c, d))
                    {
                        
                        board[r, c] = d;


                        // if can solve remaining then done
                        if (Solve(board, r, c + 1))
                        {

                            return true;
                        }

                        // back tracking
                        board[r, c] = '*';

                        
                        sayac1++;


                    }

                }
               
            }
          
            
                return false;
            }
        
        public bool Solve1(char[,] board, int r, int c)
        {
            txtyaz2(board);
            if (sayac11 == 0 && sayac22 == 0 && sayac33 == 0 && sayac44 == 0)
            {
                
                int i, j;
                for (i = 0; i < 9; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        deg1[i, j] = degerler1[i, j];
                    }

                }
               
                w1.Start();
                
                if (c == 9)
                    
                return Solve1(board, r - 1, 0);
                if (r == -1)
                {
                    
                    sayac22 = 1;
                    
                    w1.Stop();
                    return true;
                    
                }
                if (board[r, c] != '*')

                    return Solve1(board, r, c + 1);


                foreach (char d in DIGITS)
                {
                    
                    if (CanPlay(board, r, c, d))
                    {
                        
                        board[r, c] = d;

                        // if can solve remaining then done
                        if (Solve1(board, r, c + 1))
                        {
                            
                            return true;
                        }
                        // back tracking
                        board[r, c] = '*';
                        
                        sayac2++;
                        
                    }
                    
                }
                
            }
          
            return false;
            }
        

        public bool Solve3(char[,] board, int r, int c)
        {
            txtyaz3(board);
            if (sayac11 == 0 && sayac22 == 0 && sayac33 == 0 && sayac44 == 0)
            {
                
                int i, j;
                for (i = 0; i < 9; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        deg2[i, j] = degerler2[i, j];
                    }

                }
                
                w2.Start();
                
                if (c == -1)
                    return Solve3(board, r + 1, 8);
                if (r == 9)
                {
                    
                    sayac33 = 1;
                   
                    w2.Stop();
                    return true;
                   
                }
                if (board[r, c] != '*')

                    return Solve3(board, r, c - 1);


                foreach (char d in DIGITS)
                {
                    
                    if (CanPlay(board, r, c, d))
                    {
                        
                        board[r, c] = d;

                        
                        if (Solve3(board, r, c - 1))
                        {
                            return true;
                        }
                        
                        board[r, c] = '*';
                       
                        sayac3++;
                        
                    }
                    
                }
                
            }
         
            return false;
            }
        
        public bool Solve4(char[,] board, int r, int c)
        {
            txtyaz4(board);
            if (sayac11 == 0 && sayac22 == 0 && sayac33 == 0 && sayac44 == 0)
            {
                
                int i, j;
                for (i = 0; i < 9; i++)
                {
                    for (j = 0; j < 9; j++)
                    {
                        deg3[i, j] = degerler3[i, j];
                    }

                }
                
                w3.Start();
                
                // move right until you get to end, then restart at next row
                if (c == -1)
                    return Solve4(board, r - 1, 8);
                if (r == -1)
                {
                    
                    sayac44 = 1;
                    
                    w3.Stop();
                    return true;
                    
                }
                if (board[r, c] != '*')

                    return Solve4(board, r, c - 1);


                foreach (char d in DIGITS)
                {
                    
                    if (CanPlay(board, r, c, d))
                    {
                        
                        board[r, c] = d;

                        
                        if (Solve4(board, r, c - 1))
                        {
                           
                            return true;
                        }
                      
                        board[r, c] = '*';
                       
                        sayac4++;
                        
                    }
                   
                }
                
            }
            
            return false;
            }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            String tempArray = File.ReadAllText(textBox1.Text);
            tempArray = tempArray.Replace("\r", "");
            tempArray = tempArray.Replace("\n", "");

            char[] charA = tempArray.ToCharArray();

          //  char [,] degerler=new char [9,9];
            int i, j,p=0;

          for(i=0;i<9;i++)
          {
              for(j=0;j<9;j++)
              {
                    degerler[i,j] = charA[p];
                    degerler1[i, j] = charA[p];
                    degerler2[i, j] = charA[p];
                    degerler3[i, j] = charA[p];
                    p++;
                  
              }

          }
            
            richTextBox1.Text = degerler[0, 0].ToString();
            richTextBox2.Text = degerler[0, 1].ToString();
            richTextBox3.Text = degerler[0, 2].ToString();
            richTextBox4.Text = degerler[0, 3].ToString();
            richTextBox5.Text = degerler[0, 4].ToString();
            richTextBox6.Text = degerler[0, 5].ToString();
            richTextBox7.Text = degerler[0, 6].ToString();
            richTextBox8.Text = degerler[0, 7].ToString();
            richTextBox9.Text = degerler[0, 8].ToString();

            richTextBox1.Text = degerler[0, 0].ToString();
            richTextBox2.Text = degerler[0, 1].ToString();
            richTextBox3.Text = degerler[0, 2].ToString();
            richTextBox4.Text = degerler[0, 3].ToString();
            richTextBox5.Text = degerler[0, 4].ToString();
            richTextBox6.Text = degerler[0, 5].ToString();
            richTextBox7.Text = degerler[0, 6].ToString();
            richTextBox8.Text = degerler[0, 7].ToString();
            richTextBox9.Text = degerler[0, 8].ToString();

            richTextBox10.Text = degerler[1, 0].ToString();
            richTextBox11.Text = degerler[1, 1].ToString();
            richTextBox12.Text = degerler[1, 2].ToString();
            richTextBox13.Text = degerler[1, 3].ToString();
            richTextBox14.Text = degerler[1, 4].ToString();
            richTextBox15.Text = degerler[1, 5].ToString();
            richTextBox16.Text = degerler[1, 6].ToString();
            richTextBox17.Text = degerler[1, 7].ToString();
            richTextBox18.Text = degerler[1, 8].ToString();

            richTextBox19.Text = degerler[2, 0].ToString();
            richTextBox20.Text = degerler[2, 1].ToString();
            richTextBox21.Text = degerler[2, 2].ToString();
            richTextBox22.Text = degerler[2, 3].ToString();
            richTextBox23.Text = degerler[2, 4].ToString();
            richTextBox24.Text = degerler[2, 5].ToString();
            richTextBox25.Text = degerler[2, 6].ToString();
            richTextBox26.Text = degerler[2, 7].ToString();
            richTextBox27.Text = degerler[2, 8].ToString();

            richTextBox28.Text = degerler[3, 0].ToString();
            richTextBox29.Text = degerler[3, 1].ToString();
            richTextBox30.Text = degerler[3, 2].ToString();
            richTextBox31.Text = degerler[3, 3].ToString();
            richTextBox32.Text = degerler[3, 4].ToString();
            richTextBox33.Text = degerler[3, 5].ToString();
            richTextBox34.Text = degerler[3, 6].ToString();
            richTextBox35.Text = degerler[3, 7].ToString();
            richTextBox36.Text = degerler[3, 8].ToString();

            richTextBox37.Text = degerler[4, 0].ToString();
            richTextBox38.Text = degerler[4, 1].ToString();
            richTextBox39.Text = degerler[4, 2].ToString();
            richTextBox40.Text = degerler[4, 3].ToString();
            richTextBox41.Text = degerler[4, 4].ToString();
            richTextBox42.Text = degerler[4, 5].ToString();
            richTextBox43.Text = degerler[4, 6].ToString();
            richTextBox44.Text = degerler[4, 7].ToString();
            richTextBox45.Text = degerler[4, 8].ToString();

            richTextBox46.Text = degerler[5, 0].ToString();
            richTextBox47.Text = degerler[5, 1].ToString();
            richTextBox48.Text = degerler[5, 2].ToString();
            richTextBox49.Text = degerler[5, 3].ToString();
            richTextBox50.Text = degerler[5, 4].ToString();
            richTextBox51.Text = degerler[5, 5].ToString();
            richTextBox52.Text = degerler[5, 6].ToString();
            richTextBox53.Text = degerler[5, 7].ToString();
            richTextBox54.Text = degerler[5, 8].ToString();

            richTextBox55.Text = degerler[6, 0].ToString();
            richTextBox56.Text = degerler[6, 1].ToString();
            richTextBox57.Text = degerler[6, 2].ToString();
            richTextBox58.Text = degerler[6, 3].ToString();
            richTextBox59.Text = degerler[6, 4].ToString();
            richTextBox60.Text = degerler[6, 5].ToString();
            richTextBox61.Text = degerler[6, 6].ToString();
            richTextBox62.Text = degerler[6, 7].ToString();
            richTextBox63.Text = degerler[6, 8].ToString();
        
            richTextBox64.Text = degerler[7, 0].ToString();
            richTextBox65.Text = degerler[7, 1].ToString();
            richTextBox66.Text = degerler[7, 2].ToString();
            richTextBox67.Text = degerler[7, 3].ToString();
            richTextBox68.Text = degerler[7, 4].ToString();
            richTextBox69.Text = degerler[7, 5].ToString();
            richTextBox70.Text = degerler[7, 6].ToString();
            richTextBox71.Text = degerler[7, 7].ToString();
            richTextBox72.Text = degerler[7, 8].ToString();

            richTextBox73.Text = degerler[8, 0].ToString();
            richTextBox74.Text = degerler[8, 1].ToString();
            richTextBox75.Text = degerler[8, 2].ToString();
            richTextBox76.Text = degerler[8, 3].ToString();
            richTextBox77.Text = degerler[8, 4].ToString();
            richTextBox78.Text = degerler[8, 5].ToString();
            richTextBox79.Text = degerler[8, 6].ToString();
            richTextBox80.Text = degerler[8, 7].ToString();
            richTextBox81.Text = degerler[8, 8].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Thread th1 = new Thread(() => Solve(degerler, 0, 0));
            Thread th2 = new Thread(() => Solve1(degerler1, 8, 0));
            Thread th3 = new Thread(() => Solve3(degerler2, 0, 8));
            Thread th4 = new Thread(() => Solve4(degerler3, 8, 8));
         

            th1.Start();
            th1.Interrupt();
            th2.Start();
            th2.Interrupt();

            th3.Start();
            th3.Interrupt();

            th4.Start();
            th4.Interrupt();


            yazdir(deg);
            if (sayac11 == 1) {
              //  txtyaz1(deg);
              //  txtyaz2(deg1);
              //  txtyaz3(deg2);
              //  txtyaz4(deg3);
                yazdir(deg);
                
             }
             else if (sayac22 == 1)
             {
              //  txtyaz1(deg);
               //txtyaz2(deg1);
              //  txtyaz3(deg2);
              //  txtyaz4(deg3);
                yazdir(deg1);
             }
            else if (sayac33 == 1)
            {
              //  txtyaz1(deg);
              //  txtyaz2(deg1);
              //  txtyaz3(deg2);
              //  txtyaz4(deg3);
                yazdir(deg2);
             }
             else if (sayac44 == 1)
             {
              //  txtyaz1(deg);
               // txtyaz2(deg1);
               // txtyaz3(deg2);
               // txtyaz4(deg3);

                yazdir(deg3);
             }
             
            Console.WriteLine(sayac1);
            Console.WriteLine(sayac2);
            Console.WriteLine(sayac3);
            Console.WriteLine(sayac4);

            Console.WriteLine(sayac11);
            Console.WriteLine("*********");
            Console.WriteLine(sayac22);
            Console.WriteLine("*********");
            Console.WriteLine(sayac33);
            Console.WriteLine("*********");
            Console.WriteLine(sayac44);

            textBox2.Text = w.Elapsed.TotalMilliseconds.ToString();
            textBox3.Text = w1.Elapsed.TotalMilliseconds.ToString();
            textBox4.Text = w2.Elapsed.TotalMilliseconds.ToString();
            textBox5.Text = w3.Elapsed.TotalMilliseconds.ToString();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Solve3(degerler, 8, 8);
            //this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
            Form3 f3 = new Form3();
            f3.Show();
            Form f4 = new Form4();
            f4.Show();
            Form f5 = new Form5();
            f5.Show();


        }
    }
   }

