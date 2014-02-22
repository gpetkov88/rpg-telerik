using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form3 : Form
    {
        public int direction {set; get;}
        public Point prevCoords { set; get; }
        public Point curCoords { set; get; }
        public int roll { set; get; }

        public static readonly int[,] Map = new int[,]
        {
            {9,9,1,1,1,0,0,0,0,0,1,0,0,0,0,0},
            {9,9,9,0,1,0,0,0,0,0,1,0,0,0,0,0},
            {0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0},
            {0,0,0,0,1,0,0,0,0,0,1,0,1,1,1,1},
            {0,0,0,0,1,0,0,0,0,0,1,0,1,0,0,1},
            {9,9,9,0,2,1,1,1,1,2,2,1,1,0,0,1},
            {1,9,9,0,1,0,0,0,0,1,0,0,0,0,0,1},
            {1,0,0,1,1,0,0,0,0,1,0,0,0,0,0,1},
            {1,0,0,1,0,0,0,0,0,1,3,3,3,3,3,2},
            {1,0,1,2,1,1,1,1,1,2,3,1,1,1,1,1},
            {1,0,1,0,0,0,0,0,0,2,3,0,0,0,0,0},
            {1,1,2,1,1,1,1,1,1,2,1,1,1,1,1,1}
        };
        public Form3()
        {
            InitializeComponent();
            direction = -1;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            PlayerPicture.BackgroundImage = new Bitmap(@"C:\Users\Ghos7\Documents\GitHub\rpg-telerik\20140222-RPG-Game\Interface\Resources\Sorcerer.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 960;
            pictureBox1.Height = 720;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            roll--;
            if(roll==0)
            {
                button7.Visible = true;
                label7.Text = null;
            }
            label7.Text = String.Format("You have {0} more moves",roll.ToString());
            
      //    label7.Text = String.Format("You rolled " + (PlayerPicture.Location.X / 55).ToString() + "   " + (PlayerPicture.Location.Y / 55).ToString());

     //     for (int i = 0; i < roll; i++)
            {
                //PlayerPicture.Location = new Point(PlayerPicture.Location.X-55, PlayerPicture.Location.Y-55);

                //   ShowChoice(PlayerPicture.Location.X / 55, PlayerPicture.Location.Y / 55);
                //  prevCoords = PlayerPicture.Location;
             //   if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true) 
                PlayerPicture.Location = checkMovement(PlayerPicture.Location.X / 55, PlayerPicture.Location.Y / 55, direction);
            }
        }

        private void HideChoice()
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }
        private void ShowChoice(int x, int y)
        {
            if (Map[y - 1, x - 1] == 2)
            {
                radioButton1.Location = new Point((x - 1) * 55, y * 55);
                radioButton2.Location = new Point((x + 1) * 55, y * 55);
                radioButton3.Location = new Point(x * 55, (y - 1) * 55);
                radioButton4.Location = new Point(x * 55, (y + 1) * 55);

                if (x > 1 && Map[y - 1, x - 2] != 0 && CheckCurLoc(new Point(x - 1, y)))
                    radioButton1.Visible = true;
                if (x > 1 && x < 16 && Map[y - 1, x] != 0 && CheckCurLoc(new Point(x + 1, y)) && !(x + 1 == 11 && y == 10) && !(x + 1 == 11 && y == 9))
                    radioButton2.Visible = true;
                if (y > 1 && Map[y - 2, x - 1] != 0 && CheckCurLoc(new Point((x), (y - 1))))
                    radioButton3.Visible = true;
                if (y > 1 && y < 12 && Map[y, x - 1] != 0 && CheckCurLoc(new Point((x), (y + 1))))
                    radioButton4.Visible = true;

            }
        }
        private void UnCheck()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private bool CheckPrevLoc(Point cur)
        {
            if (cur.X == prevCoords.X && cur.Y == prevCoords.Y)
                return false;
            //  if (cur != prevCoords) return true;
            else return true;
        }
        private bool CheckCurLoc(Point cur)
        {
            if (cur.X == curCoords.X && cur.Y == curCoords.Y)
                return false;
            //  if (cur != prevCoords) return true;
            else return true;
        }
        private Point checkMovement(int x, int y, int direction)
        {
            curCoords = new Point(x, y);
            
            if (y > 0 && x > 0)
            {
                if (Map[y - 1, x - 1] == 2)
                {
                   while (true)
                    {
                        if(radioButton1.Checked==true)//left
                        {
                            direction = -1;
                            if (x > 1 && Map[y - 1, x + direction - 1] != 0 )
                            {
                                HideChoice();
                                UnCheck();
                                if (Map[y - 1, x - 1 + direction] == 2)
                                    ShowChoice(x + direction, y);
                                prevCoords = new Point(x, y);
                                return new Point((x + direction) * 55, (y) * 55);
                            }
                        }
                        if (radioButton2.Checked == true)//right
                        {
                            direction = 1;
                            if (x > 1 && Map[y - 1, x + direction - 1] != 0 )
                            {
                                HideChoice();
                                UnCheck();
                                if (Map[y - 1, x - 1 + direction] == 2)
                                    ShowChoice(x + direction, y);
                                prevCoords = new Point(x, y);
                                return new Point((x + direction) * 55, (y) * 55);
                            }
                        }
                        if (radioButton3.Checked == true)//up
                        {
                            direction = -1;
                            if (y > 1 && Map[y + direction - 1, x - 1] != 0)
                            {
                                HideChoice();
                                UnCheck();
                                if (Map[y - 1 + direction, x - 1] == 2)
                                    ShowChoice(x, y + direction);
                                prevCoords = new Point(x, y);
                                return new Point((x) * 55, (y + direction) * 55);
                            }
                        }
                        if (radioButton4.Checked == true)//down
                        {
                            direction = 1;
                            if (y > 1 && Map[y + direction - 1, x - 1] != 0)
                            {
                                HideChoice();
                                UnCheck();
                                if (Map[y - 1 + direction, x - 1] == 2)
                                    ShowChoice(x, y + direction);
                                prevCoords = new Point(x, y);
                                return new Point((x) * 55, (y + direction) * 55);
                            }
                        }
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                if (Map[y - 1, x - 1] == 3)
                {
                    if (x == 15 && y ==9&&direction<0&&prevCoords.X==14)
                    {
                        ShowChoice(x + 1, y);
                        prevCoords = new Point(x, y);
                        return new Point((x + 1) * 55, (y) * 55);
                    }
                    if (y > 1 && Map[y + direction - 1, x - 1] == 3 && CheckPrevLoc(new Point((x), (y + direction))))
                    {
                        prevCoords = new Point(x, y);
                        return new Point((x) * 55, (y + direction) * 55);
                    }
                    if (x > 1 && Map[y - 1, x + direction - 1] == 3 && CheckPrevLoc(new Point((x + direction), (y))))
                    {
                        prevCoords = new Point(x, y);
                        return new Point((x + direction) * 55, (y) * 55);
                    }

                    if (y > 1 && Map[y - direction - 1, x - 1] == 3 && CheckPrevLoc(new Point((x), (y - direction))))
                    {
                        prevCoords = new Point(x, y);
                        return new Point((x) * 55, (y - direction) * 55);
                    }
                    if (x > 1 && Map[y - 1, x - direction - 1] == 3 && CheckPrevLoc(new Point((x - direction), (y))))
                    {
                        prevCoords = new Point(x, y);
                        return new Point((x - direction) * 55, (y) * 55);
                    }
                }

                if (y > 1 && Map[y + direction - 1, x - 1] != 0 && Map[y + direction - 1, x - 1] != 3 && CheckPrevLoc(new Point((x) , (y + direction) )))
                {
                    ShowChoice(x, y + direction);
                    prevCoords = new Point(x, y);
                    return new Point((x) * 55, (y + direction) * 55);
                }
                if (x > 1 && Map[y - 1, x + direction - 1] != 0 && Map[y - 1, x + direction - 1] != 3 && CheckPrevLoc(new Point((x + direction) , (y) )))
                {
                    ShowChoice(x + direction, y);
                    prevCoords = new Point(x, y);
                    return new Point((x + direction) * 55, (y) * 55);
                }
                if (y > 1 && y - direction < 13 && Map[y - direction - 1, x - 1] != 0 && Map[y - direction - 1, x - 1] != 3 && CheckPrevLoc(new Point((x), (y - direction))))
                {
                    ShowChoice(x, y - direction);
                    prevCoords = new Point(x, y);
                    return new Point((x) * 55, (y - direction) * 55);
                }
                if (x > 1 && Map[y - 1, x - direction - 1] != 0 && Map[y - 1, x - direction - 1] != 3 && CheckPrevLoc(new Point((x - direction) , (y) )))
                {
                    ShowChoice(x - direction, y);
                    prevCoords = new Point(x, y);
                    return new Point((x - direction) * 55, (y) * 55);
                }
            }
            prevCoords = curCoords;
            return prevCoords;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            roll = RollADice.Roll(6);
            button7.Visible = false;
            label7.Text = String.Format("You've rolled {0}", roll.ToString());
        }
    }
}
