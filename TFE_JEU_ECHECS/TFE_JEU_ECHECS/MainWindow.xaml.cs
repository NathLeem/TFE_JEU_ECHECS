using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TFE_JEU_ECHECS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] cases = new Button[8, 8];
        public int[,] memPlate = new int[8, 8];
        public MainWindow()
        {
            InitializeComponent();
            Interface();
            SetUpGame();

            for (int i = 0; i < cases.GetLength(0); i++)
            {
                for (int j = 0; j < cases.GetLength(1); j++)
                {
                    cases[i, j].MouseUp += new MouseButtonEventHandler(ShowCases);
                }
            }
        }
        public void Interface()
        {
            // Création des colonnes et des lignes
            for (int i = 0; i < 8; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                grdPlate.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                grdPlate.RowDefinitions.Add(rowDef);
            }

            // Création des button avec des "?" et coloration des cases
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cases[i, j] = new Button();

                    if (i < 2 || i > 5)
                    {
                        cases[i, j].Content = "?";
                    }

                    cases[i, j].FontSize = 50;

                    if ((i + 1) % 2 == 0)
                    {
                        if ((j + 1) % 2 != 0)
                        {
                            cases[i, j].Background = Brushes.Green;
                        }

                    }
                    else
                    {
                        if ((j + 1) % 2 == 0)
                        {
                            cases[i, j].Background = Brushes.Green;
                        }
                    }

                    cases[i, j].Name = "B_" + i + "_" + j;

                    Grid.SetColumn(cases[i, j], j);
                    Grid.SetRow(cases[i, j], i);
                    grdPlate.Children.Add(cases[i, j]);
                }
            }


        }
        public void SetUpGame()
        {
            List<string> pieces = new List<string>()
            {
                "♜","♞","♝","♛","♚","♝","♞","♜",
                "♟","♟️","♟️","♟️","♟️","♟️","♟️","♟️",
                "♙","♙","♙","♙","♙","♙","♙","♙",
                "♖","♘","♗","♕","♔","♗","♘","♖"
            };

            int j = 0;
            int i = 0;

            foreach (Button button in grdPlate.Children.OfType<Button>())
            {              
                if (button.Content == "?")
                {
                    button.Content = pieces[0];
                    pieces.RemoveAt(0);

                    //memPlate[i, j] = 1;
                }
                else
                {                   
                    //memPlate[i, j] = 0;
                }

                if (i < 8)
                {
                    i++;
                }
                else
                {
                    i = 0;
                    j++;
                }
            }
        }

        public void ShowCases(object sender, MouseEventArgs e)
        {
            int nLigne;
            int nColonne;
            SplitName(((Button)sender).Name, out nLigne, out nColonne);

            switch (cases[nLigne, nColonne].Name)
            {
                case "♟":

                    break;

                case "♜":

                    break;

                case "♞":

                    break;

                case "♝":

                    break;

                case "♛":

                    break;

                case "♚":

                    break;

                case "♙":

                    break;

                case "♖":

                    break;

                case "♘":

                    break;

                case "♗":

                    break;

                case "♕":

                    break;

                case "♔":

                    break;
            }
        }

        public void SplitName(string nomCase, out int nLigne, out int nColonne)
        {
            string[] nom = nomCase.Split('_');

            int.TryParse(nom[1], out nLigne);

            int.TryParse(nom[2], out nColonne);
        }
    }
}
