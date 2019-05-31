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
           
            if (g.userAttacks) { Info.Text = "You have smaller kozr. Start"; }
            else
            {
                Info.Text = "Computer has smaller kozr. It starts";
                g.computerThrows();
            }
            UpdateCards();
        }

        private async void Card_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            CardForm card = p.Parent as CardForm;
            String suit = card.Controls.Find("Suit", false)[0].AccessibleDescription;
            int rank;
            if (card.Controls.Find("Rank", false)[0].Text == "A") rank = 14;
            else Int32.TryParse(card.Controls.Find("Rank", false)[0].Text, out rank);

            if (g.userThrows(suit, rank))
            {
                Info.Text = g.info;
                UpdateCards();
                await Task.Delay(1200);
                g.computerThrows();
                Info.Text = g.info;
                UpdateCards();
            }
            Info.Text = g.info;
            kolodCount.Text = g.kolod.Cards.Count.ToString();

        }
        private void Current_Card_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            CardForm card = p.Parent as CardForm;
            card.BringToFront();
        }
        private void DrawUserCards()
        {
            int drawX = 15;
            int drawY = 550;

            foreach (Card c in g.userDeck.Cards)
            {
                CardForm card1 = new CardForm();
                card1.Location = new Point(drawX, drawY);
                PictureBox p = card1.Controls.Find("Suit", false)[0] as PictureBox;
                switch (c.Suit)
                {
                    case Suit.club: p.BackgroundImage = Properties.Resources.club1; p.AccessibleDescription = "club"; break;
                    case Suit.spade: p.BackgroundImage =  Properties.Resources.spade1; p.AccessibleDescription = "spade"; break;
                    case Suit.heart: p.BackgroundImage = Properties.Resources.heart1; p.AccessibleDescription = "heart"; break;
                    case Suit.diamond: p.BackgroundImage = Properties.Resources.diamond1; p.AccessibleDescription = "diamond"; break;
                }
                
                card1.Controls.Find("Rank", false)[0].Text = c.Rank.ToString();
                if (c.Rank == 14) {
                    card1.Controls.Find("Rank", false)[0].Text = "A";
                }
                switch (c.Rank)
                {
                    case 11: card1.Controls.Find("CharacterPic", false)[0].BackgroundImage = Properties.Resources.valet; break;
                    case 12: card1.Controls.Find("CharacterPic", false)[0].BackgroundImage = Properties.Resources.dama; break;
                    case 13: card1.Controls.Find("CharacterPic", false)[0].BackgroundImage = Properties.Resources.korol; break;
                }
                if (c.Rank > 10 && c.Rank < 14) card1.Controls.Find("Rank", false)[0].Visible = false;
                card1.Controls.Find("CharacterPic", false)[0].Click += Card_Click;
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
                card1.Location = new Point(drawX, drawY);
                switch (c.Suit)
                {
                    case Suit.club: card1.Controls.Find("Suit", false)[0].BackgroundImage = Properties.Resources.club1; break;
                    case Suit.spade: card1.Controls.Find("Suit", false)[0].BackgroundImage = Properties.Resources.spade1; break;
                    case Suit.heart: card1.Controls.Find("Suit", false)[0].BackgroundImage = Properties.Resources.heart1; break;
                    case Suit.diamond: card1.Controls.Find("Suit", false)[0].BackgroundImage = Properties.Resources.diamond1; break;
                }

                card1.Controls.Find("Rank", false)[0].Text = c.Rank.ToString();
                if (c.Rank == 14)
                {
                    card1.Controls.Find("Rank", false)[0].Text = "A";
                }
                switch (c.Rank)
                {
                    case 11: card1.Controls.Find("CharacterPic", false)[0].BackgroundImage = Properties.Resources.valet; break;
                    case 12: card1.Controls.Find("CharacterPic", false)[0].BackgroundImage = Properties.Resources.dama; break;
                    case 13: card1.Controls.Find("CharacterPic", false)[0].BackgroundImage = Properties.Resources.korol; break;
                }
                if (c.Rank > 10 && c.Rank < 14) card1.Controls.Find("Rank", false)[0].Visible = false;
                card1.Controls.Find("CharacterPic", false)[0].Click += Current_Card_Click;
                Controls.Add(card1);
                card1.BringToFront();
                if (even) { drawX += 32; even = false; }
                else
                { drawX += 105; even = true; }
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
