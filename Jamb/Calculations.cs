using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Jamb
{
    class Calculations
    {

        private static readonly Random getrandom = new Random();

        public int RollDice()
        {
            Random random = new Random();
            lock (getrandom) // synchronize
            {
                return getrandom.Next(1, 7);
            }
        }

        public string RollDiceString()
        {
            return RollDice().ToString();
        }

        public int SetUpImage(Button button)
        {
            var Dice = RollDice();
            if (button.Enabled == true)
            {
                if (Dice == 1)
                {
                    button.Text = "1";
                    button.Image = Jamb.Properties.Resources.One;
                }
                if (Dice == 2)
                {
                    button.Text = "2";
                    button.Image = Jamb.Properties.Resources.Two;
                }
                if (Dice == 3)
                {
                    button.Text = "3";
                    button.Image = Jamb.Properties.Resources.Three;
                }
                if (Dice == 4)
                {
                    button.Text = "4";
                    button.Image = Jamb.Properties.Resources.Four;
                }
                if (Dice == 5)
                {
                    button.Text = "5";
                    button.Image = Jamb.Properties.Resources.Five;
                }
                if (Dice == 6)
                {
                    button.Text = "6";
                    button.Image = Jamb.Properties.Resources.Six;
                }

            }
            return Dice;
        }








    }
}
