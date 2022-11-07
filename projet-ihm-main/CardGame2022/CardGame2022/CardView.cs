using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame2022
{
    internal class CardView
    {
        public Point Position { get; set; }     // Pour l'affichage
        public Size Taille { get; set; }
        public int card { get; set; }          //  Représente la carte

        public int Malus { get; set; }  // Pour récupérer(peut-être dans une propriété calculée) la valeur de pénalité(malus).
                                       //CardsHandling(Malu);           

        public void Dessine(Graphics g) // Permet de se dessiner, par exemple en tant que chaîne de caractères dans un rectangle pour commencer.
        {
            Pen p = new Pen(Color.White,2);
            Rectangle r = new Rectangle(Position, Taille);
            g.DrawRectangle(p, r);
            g.DrawString("B", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Red, Position);
        }

        public bool Contient(Point p) // Permet à la vue de savoir si un point est dedans.
        {
            Rectangle r = new Rectangle(Position, Taille);
            return r.Contains(p);
        }                   
    }
}
