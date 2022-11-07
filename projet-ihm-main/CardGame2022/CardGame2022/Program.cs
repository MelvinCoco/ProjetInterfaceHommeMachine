using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame2022
{
    internal static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Basic init, do not change
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #endregion
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            bool many = MessageBox.Show("Voulez-vous jouer à plusieurs?", "", buttons) == DialogResult.Yes;
            if (many)
            {
                NumberPlayer player = new NumberPlayer();
                Application.Run(player);
                int nb = player.NBPlayer; 
                if (nb == 1)
                {
                    GameController gameController1 = new GameController(1);
                    Application.Run(new MainWindow(gameController1));
                }
                if (nb == 2)
                {
                    GameController gameController2 = new GameController(2);
                    Application.Run(new MainWindow(gameController2));
                }/*
                if (NumberOfPlayer.Value == 3)
                {
                    GameController gameController3 = new GameController(3);
                    Application.Run(new MainWindow(gameController3));
                }
                if (NumberOfPlayer.Value == 4)
                {
                    GameController gameController4 = new GameController(4);
                    Application.Run(new MainWindow(gameController4));
                }
                if (NumberOfPlayer.Value == 5)
                {
                    GameController gameController5 = new GameController(5);
                    Application.Run(new MainWindow(gameController5));
                }
                if (NumberOfPlayer.Value == 6)
                {
                    GameController gameController6 = new GameController(6);
                    Application.Run(new MainWindow(gameController6));
                }
                if (NumberOfPlayer.Value == 7)
                {
                    GameController gameController7 = new GameController(7);
                    Application.Run(new MainWindow(gameController7));
                }
                if (NumberOfPlayer.Value == 8)
                {
                    GameController gameController8 = new GameController(8);
                    Application.Run(new MainWindow(gameController8));
                }
                if (NumberOfPlayer.Value == 9)
                {
                    GameController gameController9 = new GameController(9);
                    Application.Run(new MainWindow(gameController9));
                }
                if (NumberOfPlayer.Value == 10)
                {
                    GameController gameController10 = new GameController(10);
                    Application.Run(new MainWindow(gameController10));
                }
                else
                {
                    if (NumberOfPlayer.Value > 10)
                    {
                        GameController gameControllerMoreThan10 = new GameController(1);
                        Application.Run(new MainWindow(gameControllerMoreThan10));
                    }
                }
            }
            else
            {
                GameController gameController1 = new GameController(1);
                Application.Run(new MainWindow(gameController1));
            }*/
            }
        }
    }
}
