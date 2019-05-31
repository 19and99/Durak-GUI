using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Cards;

namespace CardsGUI
{
    public partial class GameGUI : Form
    {
        Game g = new Game();

        public GameGUI()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            g.Start();
            switch (g.kozr)
            {
                case Suit.club: kozarPic.Image = Properties.Resources.club1; break;
                case Suit.spade: kozarPic.Image = Properties.Resources.spade1; break;
                case Suit.heart: kozarPic.Image = Properties.Resources.heart1; break;
                case Suit.diamond: kozarPic.Image = Properties.Resources.diamond1; break;
            }
            kolodCount.Text = g.kolod.Cards.Count.ToString();
            UpdateCards();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            CardForm card = sender as CardForm;
            String suit = card.Controls.Find("Suit", false)[0].Text;
            int rank;
            Int32.TryParse(card.Controls.Find("Rank", false)[0].Text, out rank);

            g.userThrows(suit, rank);
            Info.Text = g.info;
            UpdateCards();

            g.computerThrows();
            Info.Text = g.info;
            UpdateCards();
            kolodCount.Text = g.kolod.Cards.Count.ToString();

        }

        private void DrawUserCards()
        {
            int drawX = 15;
            int drawY = 550;

            foreach (Card c in g.userDeck.Cards)
            {
                CardForm card1 = new CardForm();
                card1.Location = new Point(drawX, drawY);
                switch (c.Suit)
                {
                    case Suit.club: card1.Controls.Find("Suit", false)[0].BackgroundImage = Properties.Resources.club1; break;
                    case Suit.spade: card1.Controls.Find("Suit", false)[0].BackgroundImage =  Properties.Resources.spade1; break;
                    case Suit.heart: card1.Controls.Find("Suit", false)[0].BackgroundImage = Properties.Resources.heart1; break;
                    case Suit.diamond: card1.Controls.Find("Suit", false)[0].BackgroundImage = Properties.Resources.diamond1; break;
                }
                
                card1.Controls.Find("Rank", false)[0].Text = c.Rank.ToString();
                card1.Click += Card_Click;
                Controls.Add(card1);
                drawX += 105;
               
            }
        }
        private void DrawCurrentCards()
        {
            int drawX = 200;
            int drawY = 250;
            bool even = true;
            foreach (Card c in g.currentDeck.Cards)
            {
                CardForm card1 = new CardForm();
                card1.Name = "card";
                card1.Location = new Point(drawX, drawY);
                card1.Controls.Find("Suit", false)[0].Text = c.Suit.ToString();
                card1.Controls.Find("Rank", false)[0].Text = c.Rank.ToString();
                Controls.Add(card1);
                //if (even) drawX += 32; else
                drawX += 105;
            }
        }

        private void UpdateCards()
        {
            for (int i = 0; i < Controls.Count; ++i) {
                if (Controls[i] is CardForm) { Controls.RemoveAt(i); --i; }
            }
           DrawUserCards();
           DrawCurrentCards();
        }

        private void Bita_Click(object sender, EventArgs e)
        {
            if (g.currentDeck.Cards.Count % 2 == 0)
            {
                g.Bita();
                UpdateCards();
                kolodCount.Text = g.kolod.Cards.Count.ToString();
            }
            else { Info.Text = "You cannot make Bita"; }
        }

        private void Collect_Click(object sender, EventArgs e)
        {
            g.Collect();
            kolodCount.Text = g.kolod.Cards.Count.ToString();
            UpdateCards();
        }
    }
}
