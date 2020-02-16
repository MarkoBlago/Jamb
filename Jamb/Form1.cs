using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public int? CheckNumber1()
        {
            int j = 0;

            if (Int32.Parse(button21.Text) == 1)
            {
                j++;
            }
            if (Int32.Parse(button22.Text) == 1)
            {
                j++;
            }
            if (Int32.Parse(button23.Text) == 1)
            {
                j++;
            }
            if (Int32.Parse(button24.Text) == 1)
            {
                j++;
            }
            if (Int32.Parse(button25.Text) == 1)
            {
                j++;
            }
            if (Int32.Parse(button26.Text) == 1)
            {
                j++;
            }

            if (j == 0)
                return null;
            else
            {
                return j;
            }
        }
        public int? CheckNumber2()
        {
            int j = 0;
            Calculations cal = new Calculations();

            if (Int32.Parse(button21.Text) == 2)
            {
                j++;
            }
            if (Int32.Parse(button22.Text) == 2)
            {
                j++;
            }
            if (Int32.Parse(button23.Text) == 2)
            {
                j++;
            }
            if (Int32.Parse(button24.Text) == 2)
            {
                j++;
            }
            if (Int32.Parse(button25.Text) == 2)
            {
                j++;
            }
            if (Int32.Parse(button26.Text) == 2)
            {
                j++;
            }

            if (j == 0)
                return null;
            else
            {
                return j;
            }
        }
        public int? CheckNumber3()
        {
            int j = 0;
            Calculations cal = new Calculations();

            if (Int32.Parse(button21.Text) == 3)
            {
                j++;
            }
            if (Int32.Parse(button22.Text) == 3)
            {
                j++;
            }
            if (Int32.Parse(button23.Text) == 3)
            {
                j++;
            }
            if (Int32.Parse(button24.Text) == 3)
            {
                j++;
            }
            if (Int32.Parse(button25.Text) == 3)
            {
                j++;
            }
            if (Int32.Parse(button26.Text) == 3)
            {
                j++;
            }

            if (j == 0)
                return null;
            else
            {
                return j;
            }
        }
        public int? CheckNumber4()
        {
            int j = 0;
            Calculations cal = new Calculations();

            if (Int32.Parse(button21.Text) == 4)
            {
                j++;
            }
            if (Int32.Parse(button22.Text) == 4)
            {
                j++;
            }
            if (Int32.Parse(button23.Text) == 4)
            {
                j++;
            }
            if (Int32.Parse(button24.Text) == 4)
            {
                j++;
            }
            if (Int32.Parse(button25.Text) == 4)
            {
                j++;
            }
            if (Int32.Parse(button26.Text) == 4)
            {
                j++;
            }

            if (j == 0)
                return null;
            else
            {
                return j;
            }
        }
        public int? CheckNumber5()
        {
            int j = 0;
            Calculations cal = new Calculations();

            if (Int32.Parse(button21.Text) == 5)
            {
                j++;
            }
            if (Int32.Parse(button22.Text) == 5)
            {
                j++;
            }
            if (Int32.Parse(button23.Text) == 5)
            {
                j++;
            }
            if (Int32.Parse(button24.Text) == 5)
            {
                j++;
            }
            if (Int32.Parse(button25.Text) == 5)
            {
                j++;
            }
            if (Int32.Parse(button26.Text) == 5)
            {
                j++;
            }

            if (j == 0)
                return null;
            else
            {
                return j;
            }
        }
        public int? CheckNumber6()
        {
            int j = 0;

            if (Int32.Parse(button21.Text) == 6)
            {
                j++;
            }
            if (Int32.Parse(button22.Text) == 6)
            {
                j++;
            }
            if (Int32.Parse(button23.Text) == 6)
            {
                j++;
            }
            if (Int32.Parse(button24.Text) == 6)
            {
                j++;
            }
            if (Int32.Parse(button25.Text) == 6)
            {
                j++;
            }
            if (Int32.Parse(button26.Text) == 6)
            {
                j++;
            }

            if (j == 0)
                return null;
            else
            {
                return j;
            }
        }

        public int Maximum()
        {
            int[] i = { Int32.Parse(button21.Text),
                 Int32.Parse(button22.Text),
                 Int32.Parse(button23.Text),
                 Int32.Parse(button24.Text),
                 Int32.Parse(button25.Text),
                 Int32.Parse(button26.Text)};

            Array.Sort(i);

            return i[1] + i[2] + i[3] + i[4] + i[5];
        }
        public int Minimum()
        {
            int[] i = { Int32.Parse(button21.Text),
                 Int32.Parse(button22.Text),
                 Int32.Parse(button23.Text),
                 Int32.Parse(button24.Text),
                 Int32.Parse(button25.Text),
                 Int32.Parse(button26.Text)};

            Array.Sort(i);

            return i[0] + i[1] + i[2] + i[3] + i[4];
        }

        public int? CheckJamb()
        {
            int[] dices = { int.Parse(button21.Text), Int32.Parse(button22.Text), Int32.Parse(button23.Text), Int32.Parse(button24.Text), Int32.Parse(button25.Text), Int32.Parse(button26.Text) };

            int x = 0;
            int number = 0;
            for (int i = 0; i <= 5; i++)
            {
                int count = 0;
                for (int j = 0; j <= 5; j++)
                {
                    if (dices[i] == dices[j])
                    {
                        count++;
                        if (count >= 5)
                        {
                            number = dices[i];
                            x = count;
                        }
                    }
                }
            }

            if (x >= 5)
            {
                if (x == 6)
                {
                    return number * 6 + 70;
                }
                else
                    return number * 5 + 70;
            }
            else
                return null;

        }
        public int? CheckPoker()
        {

            int[] dices = { int.Parse(button21.Text), Int32.Parse(button22.Text), Int32.Parse(button23.Text), Int32.Parse(button24.Text), Int32.Parse(button25.Text), Int32.Parse(button26.Text) };

            int x = 0;
            int number = 0;
            for (int i = 0; i <= 5; i++)
            {
                int count = 0;
                for (int j = 0; j <= 5; j++)
                {
                    if (dices[i] == dices[j])
                    {
                        count++;
                        if (count >= 4)
                        {
                            number = dices[i];
                            x = count;
                        }
                    }
                }
            }

            if (x >= 4)
            {

                return number * 4 + 60;

            }
            else
                return null;
        }
        public int? CheckKenta()
        {
            int[] dices = { int.Parse(button21.Text), Int32.Parse(button22.Text), Int32.Parse(button23.Text), Int32.Parse(button24.Text), Int32.Parse(button25.Text), Int32.Parse(button26.Text) };

            Array.Sort(dices);

            bool OnePresent = false;
            bool TwoPresent = false;
            bool ThreePresent = false;
            bool FourPresent = false;
            bool FivePresent = false;
            bool SixPresent = false;

            for (int i = 0; i <= 5; i++)
            {
                if (1 == dices[i])
                    OnePresent = true;
            }
            for (int i = 0; i <= 5; i++)
            {
                if (2 == dices[i])
                    TwoPresent = true;
            }
            for (int i = 0; i <= 5; i++)
            {
                if (3 == dices[i])
                    ThreePresent = true;
            }
            for (int i = 0; i <= 5; i++)
            {
                if (4 == dices[i])
                    FourPresent = true;
            }
            for (int i = 0; i <= 5; i++)
            {
                if (5 == dices[i])
                    FivePresent = true;
            }
            for (int i = 0; i <= 5; i++)
            {
                if (6 == dices[i])
                    SixPresent = true;
            }

            if (OnePresent == true && TwoPresent == true && ThreePresent == true && FourPresent == true && FivePresent == true)
            {
                if (Bacanje == 0)
                    return 60;
                else if (Bacanje == 1)
                    return 50;
                else if (Bacanje == 2)
                    return 40;
                else
                    return null;
            }
            else if (TwoPresent == true && ThreePresent == true && FourPresent == true && FivePresent == true && SixPresent == true)
            {
                if (Bacanje == 0)
                    return 60;
                else if (Bacanje == 1)
                    return 50;
                else if (Bacanje == 2)
                    return 40;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }
        public int? CheckFull()
        {
            int[] dices = { int.Parse(button21.Text), Int32.Parse(button22.Text), Int32.Parse(button23.Text), Int32.Parse(button24.Text), Int32.Parse(button25.Text), Int32.Parse(button26.Text) };

            int x1 = 0;
            int number1 = 0;
            for (int i = 0; i <= 5; i++)
            {
                int count = 0;
                for (int j = 0; j <= 5; j++)
                {
                    if (dices[i] == dices[j])
                    {
                        count++;
                        if (count >= 3)
                        {
                            number1 = dices[i];
                            x1 = count;
                        }
                    }
                }
            }

            int x2 = 0;
            int number2 = 0;
            for (int i = 0; i <= 5; i++)
            {
                int count = 0;
                for (int j = 0; j <= 5; j++)
                {
                    if (dices[i] == dices[j])
                    {
                        count++;
                        if (count >= 2 && dices[i] != number1)
                        {
                            number2 = dices[i];
                            x2 = count;
                        }
                    }
                }
            }

            if (x1 == x2 && x1 == 3)
            {
                if (number1 > number2)
                    return (number1 * 3 + number2 * 2) + 50;
                else
                    return number2 * 3 + number1 * 2 + 50;
            }
            else if (x1 == 3 && x2 == 2)
            {
                if (number1 > number2)
                    return (number1 * 3 + number2 * 2) + 50;
                else
                    return number2 * 3 + number1 * 2 + 50;
            }
            else if (x2 == 3 && x1 == 2)
            {
                if (number1 > number2)
                    return (number1 * 3 + number2 * 2) + 50;
                else
                    return number2 * 3 + number1 * 2 + 50;
            }
            else if (x2 == 4 && x1 == 2)
            {
                if (number1 > number2)
                    return (number1 * 3 + number2 * 2) + 50;
                else
                    return number2 * 3 + number1 * 2 + 50;
            }
            else if (x1 == 4 && x2 == 2)
            {
                if (number1 > number2)
                    return (number1 * 3 + number2 * 2) + 50;
                else
                    return number2 * 3 + number1 * 2 + 50;
            }
            else
                return null;
        }

        public void RollDices()
        {
            Calculations Cal = new Calculations();

            Cal.SetUpImage(button21);

            Cal.SetUpImage(button22);

            Cal.SetUpImage(button23);

            Cal.SetUpImage(button24);

            Cal.SetUpImage(button25);

            Cal.SetUpImage(button26);
        }


        public void MinimumUpis()
        {
            if (button20.ForeColor != Color.Black && button20.Enabled == true)
                button20.Text = CheckNumber1().ToString();

            if (button36.ForeColor != Color.Black && button20.ForeColor == Color.Black && button36.Enabled == true)
                button36.Text = (CheckNumber2() * 2).ToString();

            if (button41.ForeColor != Color.Black && button36.ForeColor == Color.Black && button41.Enabled == true)
                button41.Text = (CheckNumber3() * 3).ToString();

            if (button56.ForeColor != Color.Black && button41.ForeColor == Color.Black && button56.Enabled == true)
                button56.Text = (CheckNumber4() * 4).ToString();

            if (button51.ForeColor != Color.Black && button56.ForeColor == Color.Black && button51.Enabled == true)
                button51.Text = (CheckNumber5() * 5).ToString();

            if (button91.ForeColor != Color.Black && button51.ForeColor == Color.Black && button91.Enabled == true)
                button91.Text = (CheckNumber6() * 6).ToString();

            if (button71.ForeColor != Color.Black && button91.ForeColor == Color.Black && button71.Enabled == true)
                button71.Text = Maximum().ToString();

            if (button66.ForeColor != Color.Black && button71.ForeColor == Color.Black && button66.Enabled == true)
                button66.Text = Minimum().ToString();

            if (button86.ForeColor != Color.Black && button66.ForeColor == Color.Black && button86.Enabled == true)
                button86.Text = CheckKenta().ToString();

            if (button81.ForeColor != Color.Black && button86.ForeColor == Color.Black && button81.Enabled == true)
                button81.Text = CheckFull().ToString();

            if (button76.ForeColor != Color.Black && button81.ForeColor == Color.Black && button76.Enabled == true)
                button76.Text = CheckPoker().ToString();

            if (button101.ForeColor != Color.Black && button76.ForeColor == Color.Black && button101.Enabled == true)
                button101.Text = CheckJamb().ToString();


        }
        public void SlobodnaUpis()
        {

            if (button29.ForeColor != Color.Black && button29.Enabled == true)
                button29.Text = CheckNumber1().ToString();

            if (button35.ForeColor != Color.Black && button35.Enabled == true)
                button35.Text = (CheckNumber2() * 2).ToString();

            if (button40.ForeColor != Color.Black && button40.Enabled == true)
                button40.Text = (CheckNumber3() * 3).ToString();

            if (button55.ForeColor != Color.Black && button55.Enabled == true)
                button55.Text = (CheckNumber4() * 4).ToString();

            if (button50.ForeColor != Color.Black && button50.Enabled == true)
                button50.Text = (CheckNumber5() * 5).ToString();

            if (button90.ForeColor != Color.Black && button90.Enabled == true)
                button90.Text = (CheckNumber6() * 6).ToString();

            if (button70.ForeColor != Color.Black && button70.Enabled == true)
                button70.Text = Maximum().ToString();

            if (button65.ForeColor != Color.Black && button65.Enabled == true)
                button65.Text = Minimum().ToString();

            if (button85.ForeColor != Color.Black && button85.Enabled == true)
                button85.Text = CheckKenta().ToString();

            if (button80.ForeColor != Color.Black && button80.Enabled == true)
                button80.Text = CheckFull().ToString();

            if (button75.ForeColor != Color.Black && button75.Enabled == true)
                button75.Text = CheckPoker().ToString();

            if (button100.ForeColor != Color.Black && button100.Enabled == true)
                button100.Text = CheckJamb().ToString();

        }
        public void MaximumUpis()
        {
            if (button99.ForeColor != Color.Black && button99.Enabled == true)
                button99.Text = CheckJamb().ToString();

            if (button74.ForeColor != Color.Black && button99.ForeColor == Color.Black && button74.Enabled == true)
                button74.Text = CheckPoker().ToString();

            if (button79.ForeColor != Color.Black && button74.ForeColor == Color.Black && button79.Enabled == true)
                button79.Text = CheckFull().ToString();

            if (button84.ForeColor != Color.Black && button79.ForeColor == Color.Black && button84.Enabled == true)
                button84.Text = CheckKenta().ToString();

            if (button64.ForeColor != Color.Black && button84.ForeColor == Color.Black && button64.Enabled == true)
                button64.Text = Minimum().ToString();

            if (button69.ForeColor != Color.Black && button64.ForeColor == Color.Black && button69.Enabled == true)
                button69.Text = Maximum().ToString();

            if (button89.ForeColor != Color.Black && button69.ForeColor == Color.Black && button89.Enabled == true)
                button89.Text = (CheckNumber6() * 6).ToString();

            if (button49.ForeColor != Color.Black && button89.ForeColor == Color.Black && button49.Enabled == true)
                button49.Text = (CheckNumber5() * 5).ToString();

            if (button54.ForeColor != Color.Black && button49.ForeColor == Color.Black && button54.Enabled == true)
                button54.Text = (CheckNumber4() * 4).ToString();

            if (button39.ForeColor != Color.Black && button54.ForeColor == Color.Black && button39.Enabled == true)
                button39.Text = (CheckNumber3() * 3).ToString();

            if (button34.ForeColor != Color.Black && button39.ForeColor == Color.Black && button34.Enabled == true)
                button34.Text = (CheckNumber2() * 2).ToString();

            if (button30.ForeColor != Color.Black && button34.ForeColor == Color.Black && button30.Enabled == true)
                button30.Text = (CheckNumber1()).ToString();



        }
        public void NajavaUpis()
        {
            if (Bacanje == 0 && button31.ForeColor != Color.Black || button31.ForeColor == Color.MediumOrchid)
                button31.Text = CheckNumber1().ToString();

            if (Bacanje == 0 && button33.ForeColor != Color.Black || button33.ForeColor == Color.MediumOrchid)
                button33.Text = (CheckNumber2() * 2).ToString();

            if (Bacanje == 0 && button38.ForeColor != Color.Black || button38.ForeColor == Color.MediumOrchid)
                button38.Text = (CheckNumber3() * 3).ToString();

            if (Bacanje == 0 && button53.ForeColor != Color.Black || button53.ForeColor == Color.MediumOrchid)
                button53.Text = (CheckNumber4() * 4).ToString();

            if (Bacanje == 0 && button48.ForeColor != Color.Black || button48.ForeColor == Color.MediumOrchid)
                button48.Text = (CheckNumber5() * 5).ToString();

            if (Bacanje == 0 && button88.ForeColor != Color.Black || button88.ForeColor == Color.MediumOrchid)
                button88.Text = (CheckNumber6() * 6).ToString();

            if (Bacanje == 0 && button68.ForeColor != Color.Black || button68.ForeColor == Color.MediumOrchid)
                button68.Text = Maximum().ToString();

            if (Bacanje == 0 && button63.ForeColor != Color.Black || button63.ForeColor == Color.MediumOrchid)
                button63.Text = Minimum().ToString();

            if (Bacanje == 0 && button83.ForeColor != Color.Black || button83.ForeColor == Color.MediumOrchid)
                button83.Text = CheckKenta().ToString();

            if (Bacanje == 0 && button78.ForeColor != Color.Black || button78.ForeColor == Color.MediumOrchid)
                button78.Text = CheckFull().ToString();

            if (Bacanje == 0 && button73.ForeColor != Color.Black || button73.ForeColor == Color.MediumOrchid)
                button73.Text = CheckPoker().ToString();

            if (Bacanje == 0 && button98.ForeColor != Color.Black || button98.ForeColor == Color.MediumOrchid)
                button98.Text = CheckJamb().ToString();

        }
        public void RucnaUpis()
        {

            if (button32.ForeColor != Color.Black && Bacanje == 0)
                button32.Text = CheckNumber1().ToString();

            if (button28.ForeColor != Color.Black && Bacanje == 0)
                button28.Text = (CheckNumber2() * 2).ToString();

            if (button37.ForeColor != Color.Black && Bacanje == 0)
                button37.Text = (CheckNumber3() * 3).ToString();

            if (button52.ForeColor != Color.Black && Bacanje == 0)
                button52.Text = (CheckNumber4() * 4).ToString();

            if (button47.ForeColor != Color.Black && Bacanje == 0)
                button47.Text = (CheckNumber5() * 5).ToString();

            if (button87.ForeColor != Color.Black && Bacanje == 0)
                button87.Text = (CheckNumber6() * 6).ToString();

            if (button67.ForeColor != Color.Black && Bacanje == 0)
                button67.Text = Maximum().ToString();

            if (button62.ForeColor != Color.Black && Bacanje == 0)
                button62.Text = Minimum().ToString();

            if (button82.ForeColor != Color.Black && Bacanje == 0)
                button82.Text = CheckKenta().ToString();

            if (button77.ForeColor != Color.Black && Bacanje == 0)
                button77.Text = CheckFull().ToString();

            if (button72.ForeColor != Color.Black && Bacanje == 0)
                button72.Text = CheckPoker().ToString();

            if (button97.ForeColor != Color.Black && Bacanje == 0)
                button97.Text = CheckJamb().ToString();

        }


        public void MinimumButtonEnabling()
        {
            if (button20.ForeColor == Color.Black && button36.ForeColor != Color.Black && label32.Text == "")
                button36.Enabled = true;
            else
                button36.Enabled = false;

            if (button36.ForeColor == Color.Black && button41.ForeColor != Color.Black && label32.Text == "")
                button41.Enabled = true;
            else
                button41.Enabled = false;

            if (button41.ForeColor == Color.Black && button56.ForeColor != Color.Black && label32.Text == "")
                button56.Enabled = true;
            else
                button56.Enabled = false;

            if (button56.ForeColor == Color.Black && button51.ForeColor != Color.Black && label32.Text == "")
                button51.Enabled = true;
            else
                button51.Enabled = false;

            if (button51.ForeColor == Color.Black && button91.ForeColor != Color.Black && label32.Text == "")
                button91.Enabled = true;
            else
                button91.Enabled = false;

            if (button91.ForeColor == Color.Black && button71.ForeColor != Color.Black && label32.Text == "")
                button71.Enabled = true;
            else
                button71.Enabled = false;

            if (button71.ForeColor == Color.Black && button66.ForeColor != Color.Black && label32.Text == "")
                button66.Enabled = true;
            else
                button66.Enabled = false;

            if (button66.ForeColor == Color.Black && button86.ForeColor != Color.Black && label32.Text == "")
                button86.Enabled = true;
            else
                button86.Enabled = false;

            if (button86.ForeColor == Color.Black && button81.ForeColor != Color.Black && label32.Text == "")
                button81.Enabled = true;
            else
                button81.Enabled = false;

            if (button81.ForeColor == Color.Black && button76.ForeColor != Color.Black && label32.Text == "")
                button76.Enabled = true;
            else
                button76.Enabled = false;

            if (button76.ForeColor == Color.Black && button101.ForeColor != Color.Black && label32.Text == "")
                button101.Enabled = true;
            else
                button101.Enabled = false;

        }
        public void MaksimumButtonEnabling()
        {

            if (button99.ForeColor == Color.Black && button74.ForeColor != Color.Black && label32.Text == "")
                button74.Enabled = true;
            else
                button74.Enabled = false;

            if (button74.ForeColor == Color.Black && button79.ForeColor != Color.Black && label32.Text == "")
                button79.Enabled = true;
            else
                button79.Enabled = false;

            if (button79.ForeColor == Color.Black && button84.ForeColor != Color.Black && label32.Text == "")
                button84.Enabled = true;
            else
                button84.Enabled = false;

            if (button84.ForeColor == Color.Black && button64.ForeColor != Color.Black && label32.Text == "")
                button64.Enabled = true;
            else
                button64.Enabled = false;

            if (button64.ForeColor == Color.Black && button69.ForeColor != Color.Black && label32.Text == "")
                button69.Enabled = true;
            else
                button69.Enabled = false;

            if (button69.ForeColor == Color.Black && button89.ForeColor != Color.Black && label32.Text == "")
                button89.Enabled = true;
            else
                button89.Enabled = false;

            if (button89.ForeColor == Color.Black && button49.ForeColor != Color.Black && label32.Text == "")
                button49.Enabled = true;
            else
                button49.Enabled = false;

            if (button49.ForeColor == Color.Black && button54.ForeColor != Color.Black && label32.Text == "")
                button54.Enabled = true;
            else
                button54.Enabled = false;

            if (button54.ForeColor == Color.Black && button39.ForeColor != Color.Black && label32.Text == "")
                button39.Enabled = true;
            else
                button39.Enabled = false;

            if (button39.ForeColor == Color.Black && button34.ForeColor != Color.Black && label32.Text == "")
                button34.Enabled = true;
            else
                button34.Enabled = false;

            if (button34.ForeColor == Color.Black && button30.ForeColor != Color.Black && label32.Text == "")
                button30.Enabled = true;
            else
                button30.Enabled = false;

        }

        public void WhichRound()
        {
            if (Bacanje == 0)
                button108.Text = "Prvo bacanje!";

            if (Bacanje == 1)
                button108.Text = "Drugo bacanje!";

            if (Bacanje == 2)
                button108.Text = "Trece bacanje!";

            if (button108.Text == "Trece bacanje!")
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
            }
        }


        public void CheckIfGameOver()
        {
            int i = 0;
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Tag.ToString() == "GameButton" || button.Tag.ToString() == "NajavaButton")
                {
                    if(button.ForeColor == Color.Black)
                    {
                        i++;
                    }
                }
            }
            if(i == 60)
            {
                button109.Enabled = false;

                CheckHighscore();

            }
        }

        public void CheckHighscore()
        {
            var fi = new FileInfo(@"C:\Users\Mare\source\repos\Jamb\Jamb\Resources\Highscores.xlsx");

            using (var package = new ExcelPackage(fi))
            {
                var workbook = package.Workbook;
                var sheet = workbook.Worksheets.First();

               // Range sortRange = sheet.SelectedRange["A1", "S100"];
                package.Save();
            }

        }


        public void DisplayHighscore()
        {
            var fi = new FileInfo(@"C:\Users\Mare\source\repos\Jamb\Jamb\Resources\Highscores.xlsx");

            using (var package = new ExcelPackage(fi))
            {
                var workbook = package.Workbook;
                var sheet = workbook.Worksheets.First();

                label22.Text = sheet.Cells[1, 2].Value.ToString();
                label23.Text = sheet.Cells[2, 2].Value.ToString();
                label24.Text = sheet.Cells[3, 2].Value.ToString();
                label25.Text = sheet.Cells[4, 2].Value.ToString();
                label26.Text = sheet.Cells[5, 2].Value.ToString();
                label27.Text = sheet.Cells[6, 2].Value.ToString();
                label28.Text = sheet.Cells[7, 2].Value.ToString();
                label29.Text = sheet.Cells[8, 2].Value.ToString();
                label30.Text = sheet.Cells[9, 2].Value.ToString();
                label31.Text = sheet.Cells[10, 2].Value.ToString();

                label12.Text = sheet.Cells[1, 1].Value.ToString();
                label13.Text = sheet.Cells[2, 1].Value.ToString();
                label14.Text = sheet.Cells[3, 1].Value.ToString();
                label15.Text = sheet.Cells[4, 1].Value.ToString();
                label16.Text = sheet.Cells[5, 1].Value.ToString();
                label17.Text = sheet.Cells[6, 1].Value.ToString();
                label18.Text = sheet.Cells[7, 1].Value.ToString();
                label19.Text = sheet.Cells[8, 1].Value.ToString();
                label20.Text = sheet.Cells[9, 1].Value.ToString();
                label21.Text = sheet.Cells[10, 1].Value.ToString();


                //package.Save();
            }
        }

        int Bacanje = 0;

        int interval = 0;

        private void button109_Click(object sender, EventArgs e)
        {

            timer1.Start();


            if (Bacanje < 3)
            {
                timer1.Start();


                ClearUnused();
                UnlockAllButtonsAfterSpin();
                //RollDices();

                LockRucna();
                LockNajava();

                MinimumUpis();
                SlobodnaUpis();
                MaximumUpis();
                RucnaUpis();




                NajavaUpis();

                // ClearLockedUnused();


                WhichRound();

                LockZavrtiButton();

                MinimumButtonEnabling();
                MaksimumButtonEnabling();

                label33.Text = "";
            }
            Bacanje++;

        }



        public void ClearUnused()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.ForeColor == Color.MediumOrchid || button.ForeColor == Color.DodgerBlue)
                    button.Text = null;
            }
        }

        public void ClearLockedUnused()
        {
            //foreach (var button in this.Controls.OfType<Button>())
            //{
            //    if (button.ForeColor != Color.Black && button.Enabled == false && button.Tag.ToString() == "GameButton" || button.Tag.ToString() == "NajavaButton" && button.ForeColor != Color.Black)
            //        button.Text = "";
            //}
        }

        public void UnlockButtons()
        {
            //foreach (var button in UnlockedButtons)
            //{
            //    button.Enabled = true;
            //}

            UnlockedButtons.Clear();
        }

        IList<Button> UnlockedButtons = new List<Button>();


        public void LockButtonsUntilNajavaPlayed()
        {

            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Tag.ToString() == "GameButton" && button.Enabled == true || button.Tag.ToString() == "NajavaButton" && button.Enabled == true)
                {
                    UnlockedButtons.Add(button);
                }
            }

            foreach (var button in UnlockedButtons)
            {
                if (button.Tag.ToString() != "NajavaButton" || button.ForeColor != Color.MediumOrchid && button.Tag.ToString() == "NajavaButton" && button.ForeColor != Color.Black)
                {
                    button.Text = "";
                    button.Enabled = false;

                }
            }
        }

        public void LockRucna()
        {
            if (Bacanje > 0)
            {
                button32.Enabled = false;
                button28.Enabled = false;
                button37.Enabled = false;
                button52.Enabled = false;
                button47.Enabled = false;
                button87.Enabled = false;

                button67.Enabled = false;
                button62.Enabled = false;

                button82.Enabled = false;
                button77.Enabled = false;
                button72.Enabled = false;
                button97.Enabled = false;
            }
            else
            {
                if(button32.ForeColor != Color.Black)
                     button32.Enabled = true;
                if (button28.ForeColor != Color.Black)
                    button28.Enabled = true;
                if (button37.ForeColor != Color.Black)
                    button37.Enabled = true;
                if (button52.ForeColor != Color.Black)
                    button52.Enabled = true;
                if (button47.ForeColor != Color.Black)
                    button47.Enabled = true;
                if (button87.ForeColor != Color.Black)
                    button87.Enabled = true;

                if (button67.ForeColor != Color.Black)
                    button67.Enabled = true;
                if (button62.ForeColor != Color.Black)
                    button62.Enabled = true;

                if (button82.ForeColor != Color.Black)
                    button82.Enabled = true;
                if (button77.ForeColor != Color.Black)
                    button77.Enabled = true;
                if (button72.ForeColor != Color.Black)
                    button72.Enabled = true;
                if (button97.ForeColor != Color.Black)
                    button97.Enabled = true;







            }

        }

        public void LockNajava()
        {
            if (Bacanje > 0)
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    if (button.Tag.ToString() == "NajavaButton" && button.ForeColor == Color.DodgerBlue)
                    {
                        button.Enabled = false;
                    }
                }
            }
        }

        public void LockAllButtonsAfterPlay()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Tag.ToString() == "GameButton" && button.Enabled == true || button.Tag.ToString() == "NajavaButton" && button.Enabled == true)
                {
                    button.Enabled = false;
                }
            }
        }

        public void UnlockAllButtonsAfterSpin()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Tag.ToString() == "GameButton" && button.Text == "" && Bacanje == 0 || button.Tag.ToString() == "NajavaButton" && button.Text == "" && Bacanje == 0)
                {
                    button.Enabled = true;
                }
            }
        }

        public void LockZavrtiButton()
        {
            if (Bacanje == 2)
                button109.Enabled = false;
        }

        public void UnlockZavrtiButton()
        {
            button109.Enabled = true;
        }
        public void button21_Click(object sender, EventArgs e)
        {

            if (Bacanje != 3 && label33.Text == "")
            {
                button21.Enabled = false;
                checkBox1.Checked = true;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (Bacanje != 3 && label33.Text == "")
            {
                button22.Enabled = false;
                checkBox2.Checked = true;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (Bacanje != 3 && label33.Text == "")
            {
                button23.Enabled = false;
                checkBox3.Checked = true;
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (Bacanje != 3 && label33.Text == "")
            {
                button24.Enabled = false;
                checkBox4.Checked = true;
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (Bacanje != 3 && label33.Text == "")
            {
                button25.Enabled = false;
                checkBox5.Checked = true;
            }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (Bacanje != 3 && label33.Text == "")
            {
                button26.Enabled = false;
                checkBox6.Checked = true;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Visible = true;
                button21.Enabled = false;
            }
            else
            {
                button21.Enabled = true;
                checkBox1.Visible = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                checkBox2.Visible = true;
                button22.Enabled = false;
            }
            else
            {
                button22.Enabled = true;
                checkBox2.Visible = false;
            }

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.Visible = true;
                button23.Enabled = false;
            }
            else
            {
                button23.Enabled = true;
                checkBox3.Visible = false;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox4.Visible = true;
                button24.Enabled = false;
            }
            else
            {
                button24.Enabled = true;
                checkBox4.Visible = false;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox5.Visible = true;
                button25.Enabled = false;
            }
            else
            {
                button25.Enabled = true;
                checkBox5.Visible = false;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6.Visible = true;
                button26.Enabled = false;
            }
            else
            {
                button26.Enabled = true;
                checkBox6.Visible = false;
            }
        }




        public void CalculateSum()
        {

        }

        public void MinimumFirstSum()
        {
            int sum = 0;
            if (button20.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button20.Text);

            if (button36.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button36.Text);

            if (button41.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button41.Text);

            if (button56.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button56.Text);

            if (button51.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button51.Text);

            if (button91.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button91.Text);

            if (sum >= 60)
                sum = sum + 30;

            if (sum == 0)
            {
                button46.Text = "";
            }
            else
                button46.Text = sum.ToString();

        }
        public void SlobodnaFirstSum()
        {
            int sum = 0;
            if (button29.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button29.Text);

            if (button35.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button35.Text);

            if (button40.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button40.Text);

            if (button55.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button55.Text);

            if (button50.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button50.Text);

            if (button90.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button90.Text);

            if (sum >= 60)
                sum = sum + 30;

            if (sum == 0)
            {
                button45.Text = "";
            }
            else
                button45.Text = sum.ToString();

        }
        public void MaksimumFirstSum()
        {
            int sum = 0;
            if (button30.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button30.Text);

            if (button34.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button34.Text);

            if (button39.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button39.Text);

            if (button54.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button54.Text);

            if (button49.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button49.Text);

            if (button89.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button89.Text);

            if (sum >= 60)
                sum = sum + 30;

            if (sum == 0)
            {
                button44.Text = "";
            }
            else
                button44.Text = sum.ToString();
        }
        public void NajavaFirstSum()
        {
            int sum = 0;
            if (button31.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button31.Text);

            if (button33.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button33.Text);

            if (button38.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button38.Text);

            if (button53.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button53.Text);

            if (button48.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button48.Text);

            if (button88.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button88.Text);

            if (sum >= 60)
                sum = sum + 30;

            if (sum == 0)
            {
                button43.Text = "";
            }
            else
                button43.Text = sum.ToString();
        }
        public void RucnaFirstSum()
        {
            int sum = 0;
            if (button32.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button32.Text);

            if (button28.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button28.Text);

            if (button37.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button37.Text);

            if (button52.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button52.Text);

            if (button47.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button47.Text);

            if (button87.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button87.Text);

            if (sum >= 60)
                sum = sum + 30;

            if (sum == 0)
            {
                button42.Text = "";
            }
            else
                button42.Text = sum.ToString();
        }


        public void MinimumSecondSum()
        {
            int sum = 0;
            if (button71.ForeColor == Color.Black && button66.ForeColor == Color.Black && button20.ForeColor == Color.Black)
                sum = (Int32.Parse(button71.Text) - Int32.Parse(button66.Text)) * Int32.Parse(button20.Text);

            if (sum == 0)
            {
                button61.Text = ""; ;
            }
            else
                button61.Text = sum.ToString();
        }
        public void SlobodnaSecondSum()
        {
            int sum = 0;
            if (button70.ForeColor == Color.Black && button65.ForeColor == Color.Black && button29.ForeColor == Color.Black)
                sum = (Int32.Parse(button70.Text) - Int32.Parse(button65.Text)) * Int32.Parse(button29.Text);

            if (sum == 0)
            {
                button60.Text = "";
            }
            else
                button60.Text = sum.ToString();
        }
        public void MaksimumSecondSum()
        {
            int sum = 0;
            if (button69.ForeColor == Color.Black && button64.ForeColor == Color.Black && button30.ForeColor == Color.Black)
                sum = (Int32.Parse(button69.Text) - Int32.Parse(button64.Text)) * Int32.Parse(button30.Text);

            if (sum == 0)
            {
                button59.Text = "";
            }
            else
                button59.Text = sum.ToString();
        }
        public void NajavaSecondSum()
        {
            int sum = 0;
            if (button68.ForeColor == Color.Black && button63.ForeColor == Color.Black && button31.ForeColor == Color.Black)
                sum = (Int32.Parse(button68.Text) - Int32.Parse(button63.Text)) * Int32.Parse(button31.Text);

            if (sum == 0)
            {
                button58.Text = "";
            }
            else
                button58.Text = sum.ToString();
        }
        public void RucnaSecondSum()
        {
            int sum = 0;
            if (button67.ForeColor == Color.Black && button62.ForeColor == Color.Black && button32.ForeColor == Color.Black)
                sum = (Int32.Parse(button67.Text) - Int32.Parse(button62.Text)) * Int32.Parse(button32.Text);

            if (sum == 0)
            {
                button57.Text = "";
            }
            else
                button57.Text = sum.ToString();
        }


        public void MinimumThirdSum()
        {
            int sum = 0;
            if (button86.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button86.Text);

            if (button81.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button81.Text);

            if (button76.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button76.Text);

            if (button101.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button101.Text);

            if (sum == 0)
            {
                button96.Text = null;
            }
            else
                button96.Text = sum.ToString();
        }
        public void SlobodnaThirdSum()
        {
            int sum = 0;
            if (button85.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button85.Text);

            if (button80.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button80.Text);

            if (button75.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button75.Text);

            if (button100.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button100.Text);

            if (sum == 0)
            {
                button95.Text = null;
            }
            else
                button95.Text = sum.ToString();
        }
        public void MaksimumThirdSum()
        {
            int sum = 0;
            if (button84.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button84.Text);

            if (button79.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button79.Text);

            if (button74.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button74.Text);

            if (button99.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button99.Text);

            if (sum == 0)
            {
                button94.Text = null;
            }
            else
                button94.Text = sum.ToString();
        }
        public void NajavaThirdSum()
        {
            int sum = 0;
            if (button83.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button83.Text);

            if (button78.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button78.Text);

            if (button73.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button73.Text);

            if (button98.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button98.Text);

            if (sum == 0)
            {
                button93.Text = null;
            }
            else
                button93.Text = sum.ToString();
        }
        public void RucnaThirdSum()
        {
            int sum = 0;
            if (button82.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button82.Text);

            if (button77.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button77.Text);

            if (button72.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button72.Text);

            if (button97.ForeColor == Color.Black)
                sum = sum + Int32.Parse(button97.Text);

            if (sum == 0)
            {
                button92.Text = null;
            }
            else
                button92.Text = sum.ToString();
        }


        public void FirstSumTotal()
        {
            int sum = 0;

            if (button46.Text != "")
                sum = sum + Int32.Parse(button46.Text);

            if (button45.Text != "")
                sum = sum + Int32.Parse(button45.Text);

            if (button44.Text != "")
                sum = sum + Int32.Parse(button44.Text);

            if (button43.Text != "")
                sum = sum + Int32.Parse(button43.Text);

            if (button42.Text != "")
                sum = sum + Int32.Parse(button42.Text);

            if (sum == 0)
            {
                button103.Text = null;
            }
            else
                button103.Text = sum.ToString();
        }
        public void SecondSumTotal()
        {
            int sum = 0;
            if (button61.Text != "")
                sum = sum + Int32.Parse(button61.Text);

            if (button60.Text != "")
                sum = sum + Int32.Parse(button60.Text);

            if (button59.Text != "")
                sum = sum + Int32.Parse(button59.Text);

            if (button58.Text != "")
                sum = sum + Int32.Parse(button58.Text);

            if (button57.Text != "")
                sum = sum + Int32.Parse(button57.Text);

            if (sum == 0)
            {
                button104.Text = null;
            }
            else
                button104.Text = sum.ToString();
        }
        public void ThirdSumTotal()
        {
            int sum = 0;


            if (button96.Text != "")
                sum = sum + Int32.Parse(button96.Text);

            if (button95.Text != "")
                sum = sum + Int32.Parse(button95.Text);

            if (button94.Text != "")
                sum = sum + Int32.Parse(button94.Text);

            if (button93.Text != "")
                sum = sum + Int32.Parse(button93.Text);

            if (button92.Text != "")
                sum = sum + Int32.Parse(button92.Text);

            if (sum == 0)
            {
                button105.Text = null;
            }
            else
                button105.Text = sum.ToString();
        }

        public void SumTotal()
        {
            int sum = 0;


            if (button103.Text != "")
                sum = sum + Int32.Parse(button103.Text);

            if (button104.Text != "")
                sum = sum + Int32.Parse(button104.Text);

            if (button105.Text != "")
                sum = sum + Int32.Parse(button105.Text);

            if (sum == 0)
            {
                button106.Text = null;
            }
            else
                button106.Text = sum.ToString();

        }


        //Tabela


        public void ButtonSharedProperties(Button button)
        {
            button.ForeColor = Color.Black;
            button.Enabled = false;
            Bacanje = 0;
            ClearUnused();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;

            if (button.Text == "")
            {
                button.Text = 0.ToString();
            }

            MinimumFirstSum();
            SlobodnaFirstSum();
            MaksimumFirstSum();
            NajavaFirstSum();
            RucnaFirstSum();

            MinimumSecondSum();
            SlobodnaSecondSum();
            MaksimumSecondSum();
            NajavaSecondSum();
            RucnaSecondSum();

            MinimumThirdSum();
            SlobodnaThirdSum();
            MaksimumThirdSum();
            NajavaThirdSum();
            RucnaThirdSum();


            FirstSumTotal();
            SecondSumTotal();
            ThirdSumTotal();

            SumTotal();

            LockAllButtonsAfterPlay();

            UnlockZavrtiButton();

            label32.Text = "";
            label33.Text = "Uspesno ste upisali! Bacite kockice.";
            CheckIfGameOver();
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button20);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button36);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button41);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button56);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button51);
        }

        private void button91_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button91);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button29);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button35);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button40);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button55);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button50);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button90);
        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button71_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button71);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button70);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button66);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button65);
        }

        private void button95_Click(object sender, EventArgs e)
        {

        }

        private void button100_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button100);
        }

        private void button99_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button99);
        }

        private void button107_Click(object sender, EventArgs e)
        {

        }

        private void button108_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.ForeColor == Color.DodgerBlue)
            {
                button31.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljene su jedinice!";
            }
            else
            {
                
                UnlockButtons();
                button31.Enabled = false;
                ButtonSharedProperties(button31);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.ForeColor == Color.DodgerBlue)
            {
                button33.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljene su dvojke!";
            }
            else
            {
                
                UnlockButtons();
                button33.Enabled = false;
                ButtonSharedProperties(button33);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.ForeColor == Color.DodgerBlue)
            {
                button38.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljene su trojke!";
            }
            else
            {
                
                UnlockButtons();
                button38.Enabled = false;
                ButtonSharedProperties(button38);
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (button53.ForeColor == Color.DodgerBlue)
            {
                button53.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljene su cetvorke!";
            }
            else
            {
                
                UnlockButtons();
                button53.Enabled = false;
                ButtonSharedProperties(button53);
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (button48.ForeColor == Color.DodgerBlue)
            {
                button48.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljene su petice!";
            }
            else
            {
                
                UnlockButtons();
                button48.Enabled = false;
                ButtonSharedProperties(button48);
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (button88.ForeColor == Color.DodgerBlue)
            {
                button88.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljene su šestice!";
            }
            else
            {
                
                UnlockButtons();
                button88.Enabled = false;
                ButtonSharedProperties(button88);
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button32);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button28);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button37);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button52);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button47);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button87);
        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button75_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button75);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button85);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button80);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button86);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button81);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button76);
        }

        private void button101_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button101);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button74);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button79);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button84);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button64);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button69);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button89);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button49);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button54);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button39);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button34);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button30);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (button68.ForeColor == Color.DodgerBlue)
            {
                button68.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljen je maksimum!";
            }
            else
            {
                
                UnlockButtons();
                button68.Enabled = false;
                ButtonSharedProperties(button68);
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (button63.ForeColor == Color.DodgerBlue)
            {
                button63.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljen je minimum!";
            }
            else
            {
                
                UnlockButtons();
                button63.Enabled = false;
                ButtonSharedProperties(button63);
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (button83.ForeColor == Color.DodgerBlue)
            {
                button83.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljena je kenta!";
            }
            else
            {
                
                UnlockButtons();
                button83.Enabled = false;
                ButtonSharedProperties(button83);
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (button78.ForeColor == Color.DodgerBlue)
            {
                button78.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljen je full!";
            }
            else
            {
               
                UnlockButtons();
                button78.Enabled = false;
                ButtonSharedProperties(button78);
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (button73.ForeColor == Color.DodgerBlue)
            {
                button73.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljen je poker!";
            }
            else
            {
                
                UnlockButtons();
                button73.Enabled = false;
                ButtonSharedProperties(button73);
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (button98.ForeColor == Color.DodgerBlue)
            {
                button98.ForeColor = Color.MediumOrchid;

                LockButtonsUntilNajavaPlayed();

                label32.Text = "Najavljen je jamb!";
            }
            else
            {
                
                UnlockButtons();
                button98.Enabled = false;
                ButtonSharedProperties(button98);
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button67);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button62);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button82);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button77);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button72);
        }

        private void button97_Click(object sender, EventArgs e)
        {
            ButtonSharedProperties(button97);
        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button107_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                button107.Visible = false;
                label35.Visible = false;
                textBox1.Visible = false;
                button27.Visible = false;
                label34.Visible = false;

                label36.Text = textBox1.Text;

                DisplayHighscore();
            }
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                button107.Visible = false;
                label35.Visible = false;
                textBox1.Visible = false;
                button27.Visible = false;
                label34.Visible = false;

                label36.Text = textBox1.Text;
                DisplayHighscore();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            interval++;
            
            RollDices();
            if(interval == 4)
            {

                timer1.Stop();
                interval = 0;
            }

        }
    }
}
