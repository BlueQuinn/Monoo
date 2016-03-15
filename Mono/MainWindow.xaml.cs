using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mono
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cell[] cell = new Cell[45];
        int delay = 10;
        int turn = 0;

        Token[] rec = new Token[5];
        Poro[] table = new Poro[5];

        public MainWindow()
        {
            InitializeComponent();

            InitCell();

            //InitToken();

            rec[0] = Fox;
            rec[1] = Deer;
            rec[2] = Bull;
            rec[3] = Python;
            rec[4] = Hypo;
        }

        void InitToken()
        {
            //token[0].Name = "Cat";
            //token[1].Name = "Human";

            //token[0].Left = (int)Canvas.GetLeft(Cat);
            //token[1].Left = (int)Canvas.GetLeft(Human);

            //token[0].Top = (int)Canvas.GetTop(Cat);
            //token[1].Top = (int)Canvas.GetTop(Human);


        }

        void Collapse()
        {
            for (int i=0;i<rec.Length;i++)
                if(rec[i].Position == rec[turn].Position)
                {

                }
        }

        void InitCell()
        {

            for (int i = 0; i < 45; i++)
            {
                cell[i] = new Cell();
                cell[i].ID = i;
            }

            // 1
            cell[0].Left = cell[34].Left = 20;
            cell[1].Left = cell[33].Left = 95;
            cell[2].Left = cell[32].Left = 170;
            cell[3].Left = cell[31].Left = 225;
            cell[4].Left = cell[30].Left = 285;
            cell[5].Left = cell[29].Left = 340;
            cell[6].Left = cell[28].Left = 397;
            cell[7].Left = cell[27].Left = 455;
            cell[8].Left = cell[26].Left = 510;
            cell[9].Left = cell[25].Left = 569;
            cell[10].Left = cell[24].Left = 625;
            cell[11].Left = 700;
            cell[12].Left = 775;
            for (int i = 0; i < 13; i++)
                cell[i].Top = 20;
            for (int i = 24; i < 35; i++)
                cell[i].Top = 775;

            // 2
            cell[13].Top = cell[43].Top = 170;
            cell[14].Top = cell[42].Top = 225;
            cell[15].Top = cell[41].Top = 285;
            cell[16].Top = cell[40].Top = 340;
            cell[17].Top = cell[39].Top = 397;
            cell[18].Top = cell[38].Top = 455;
            cell[19].Top = cell[37].Top = 510;
            cell[20].Top = cell[36].Top = 569;
            cell[21].Top = cell[35].Top = 625;
            cell[22].Top = 700;
            cell[23].Top = 775;
            for (int i = 13; i < 24; i++)
                cell[i].Left = 775;
            for (int i = 35; i < 44; i++)
                cell[i].Left = 20;

            cell[44].Left = 20;
            cell[44].Top = 95;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int move = int.Parse(txtDice1.Text);// + int.Parse(txtDice2.Text);
            
            int newPos = rec[turn].Position + move;
            //if (newPos > 44)
            //    newPos = newPos / 44 + 1;
            //if (newPos == 0 || newPos == 12 || newPos == 23 || newPos == 34)
            //    newPos++;

            int left = cell[rec[turn].Position].Left, top = cell[rec[turn].Position].Top;
            Thread t;
            int cloneTurn = turn;

            #region 1
            if (rec[cloneTurn].Position < 12)
            {
                if (newPos >= 12)
                {
                    newPos++;
                    t = new Thread(() =>
                    {
                        while (left != cell[12].Left)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetLeft(rec[cloneTurn], left + 1);
                            });

                            left++;
                            Thread.Sleep(delay);
                        }

                        while (top != cell[newPos].Top)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetTop(rec[cloneTurn], top + 1);
                            });

                            top++;
                            Thread.Sleep(delay);
                        }

                        rec[cloneTurn].Position = newPos;
                    });
                }
                else
                {
                    t = new Thread(() =>
                    {
                        while (left != cell[newPos].Left)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetLeft(rec[cloneTurn], left + 1);
                            });

                            left++;
                            Thread.Sleep(delay);
                        }
                        rec[cloneTurn].Position = newPos;
                    });
                }
                t.IsBackground = true;
                t.Start();
            }
            #endregion

            #region 2
            if (rec[cloneTurn].Position > 12 && rec[cloneTurn].Position < 23)
            {
                if (newPos >= 23)
                {
                    newPos++;
                    t = new Thread(() =>
                    {
                        while (top != cell[23].Top)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetTop(rec[cloneTurn], top + 1);
                            });

                            top++;
                            Thread.Sleep(delay);
                        }

                        while (left != cell[newPos].Left)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetLeft(rec[cloneTurn], left - 1);
                            });

                            left--;
                            Thread.Sleep(delay);
                        }

                        rec[cloneTurn].Position = newPos;
                    });
                }
                else
                {
                    t = new Thread(() =>
                    {
                        while (top != cell[newPos].Top)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetTop(rec[cloneTurn], top + 1);
                            });

                            top++;
                            Thread.Sleep(delay);
                        }
                        rec[cloneTurn].Position = newPos;
                    });
                    
                }
                t.IsBackground = true;
                t.Start();
            }
            #endregion

            #region 3
            if (rec[cloneTurn].Position > 23 && rec[cloneTurn].Position < 34)
            {
                if (newPos >= 34)
                {
                    newPos++;
                    t = new Thread(() =>
                    {
                        while (left != cell[34].Left)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetLeft(rec[cloneTurn], left - 1);
                            });

                            left--;
                            Thread.Sleep(delay);
                        }

                        while (top != cell[newPos].Top)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetTop(rec[cloneTurn], top - 1);
                            });

                            top--;
                            Thread.Sleep(delay);
                        }

                        rec[cloneTurn].Position = newPos;
                    });
                }
                else
                {
                    t = new Thread(() =>
                    {
                        while (left != cell[newPos].Left)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetLeft(rec[cloneTurn], left - 1);
                            });

                            left--;
                            Thread.Sleep(delay);
                        }
                        rec[cloneTurn].Position = newPos;
                    });
                    
                }
                t.IsBackground = true;
                t.Start();
            }
            #endregion

            #region 4
            if (rec[cloneTurn].Position > 34 && rec[cloneTurn].Position < 45)
            {
                if (newPos >= 44)
                {
                    newPos = newPos % 44 + 1;
                    t = new Thread(() =>
                    {
                        while (top != cell[0].Top)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetTop(rec[cloneTurn], top - 1);
                            });

                            top--;
                            Thread.Sleep(delay);
                        }

                        while (left != cell[newPos].Left)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetLeft(rec[cloneTurn], left + 1);
                            });

                            left++;
                            Thread.Sleep(delay);
                        }

                        rec[cloneTurn].Position = newPos;
                    });
                }
                else
                {
                    t = new Thread(() =>
                    {
                        while (top != cell[newPos].Top)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                Canvas.SetTop(rec[cloneTurn], top - 1);
                            });

                            top--;
                            Thread.Sleep(delay);
                        }
                        rec[cloneTurn].Position = newPos;
                    });
                    
                }
                t.IsBackground = true;
                t.Start();
            }
            #endregion




            if (turn == 1)
                turn = 0;
            else
            turn++;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            table[cbbTokens.SelectedIndex].Add(txtPlayer.Text);
        }
    }
}
