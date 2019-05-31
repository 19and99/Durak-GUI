using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cards
{
    public class Game
    {
        public Deck userDeck = new Deck();
        public Deck computerDeck = new Deck();
        public Deck kolod = new Deck();
        public Deck currentDeck = new Deck();
        public Suit kozr;
        public bool userAttacks = true;
        public bool gameOver = false;
        public String info;


        public Game()
        {   
        }
        public void Start() {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 6; j < 15; ++j)
                {
                    kolod.AddCard(j, (Suit)i);
                }
            }

            kolod.shuffle();
            kolod.Deliver(userDeck, computerDeck);
            kozr = kolod.Cards[0].Suit;
            Card start = new Card(14,kozr);
            foreach(Card c in userDeck) {
                if (c.Suit == kozr) {
                    if (c.Rank < start.Rank) start = c;
                }
            }
            foreach (Card c in computerDeck) {
                if (c.Suit == kozr) {
                    if (c.Rank < start.Rank) {
                        userAttacks = false;
                        break;
                    }
                }
            }
        }

        public void NextMove() {
            if ((userAttacks && currentDeck.Cards.Count % 2 == 1) || (!userAttacks && currentDeck.Cards.Count % 2 == 0))
            {
                computerThrows();
            }
            else info = "Your turn";
        }

        public bool userThrows(String s,int rank)
        {
            
            Suit suit = (Suit)Enum.Parse(typeof(Suit), s,true);
            Card c = new Card(rank, suit);
            if (!userDeck.Cards.Contains(c)) return false;
            if (userAttacks)
            {
                if (currentDeck.Cards.Count == 0)
                {
                    currentDeck.AddCard(c);
                    userDeck.Remove(c);
                    info = "OK";
                }
                else
                {
                    if (currentDeck.Cards.Count % 2 == 0)
                    {
                        if (currentDeck.HasRank(c.Rank))
                        {
                            currentDeck.AddCard(c);
                            userDeck.Remove(c);
                        }
                        else { info = "Throw a valid card"; return false; }
                    }
                    else { info = "Wait until computer make move"; return false; }
                }
            }
            else
            {
                Card thrown = currentDeck.Cards[currentDeck.Cards.Count - 1];
                if (Covers(c, thrown))
                {
                    currentDeck.AddCard(c);
                    userDeck.Remove(c);
                }
                else
                {
                    info = "That card doesn't cover the thrown one"; return false;
                }
            }

            if (kolod.Cards.Count == 0 && userDeck.Cards.Count == 0)
            {
                GameOver();
                info = "Game is over. You have won";
                return false;
            }
            return true;
        }

        public void computerThrows()
        {
            if (userAttacks)
            {
                if (currentDeck.Cards.Count % 2 == 1)
                {
                    Card thrown = currentDeck.Cards[currentDeck.Cards.Count - 1];
                    Card cover = computerDeck.GetCover(thrown, kozr);

                    if (cover == null) { Collect(); info = "Computer collected"; }
                    else
                    {
                        currentDeck.AddCard(cover);
                        computerDeck.Remove(cover);
                    }
                }
            }
            else
            {
                if (currentDeck.Cards.Count == 0)
                {
                    Card c = computerDeck.minCard(
                        );
                    currentDeck.AddCard(c);
                    computerDeck.Remove(c);
                }
                if (currentDeck.Cards.Count % 2 == 0)
                {
                    bool canThrow = false;
                    foreach (Card c in computerDeck.Cards)
                    {
                        if (currentDeck.Cards.Count == 0 || currentDeck.HasRank(c.Rank))
                        {
                            currentDeck.AddCard(c);
                            computerDeck.Remove(c);
                            canThrow = true;
                            break;
                        }
                    }
                    if (!canThrow)
                    {
                        Bita();
                    }
                }

                if (kolod.Cards.Count == 0 && computerDeck.Cards.Count == 0)
                {
                    GameOver();
                    info = "Game is over. Computer has won";
                }
            }
        }

        public void Bita() {
            currentDeck.Clear();
            if (userAttacks)
            {
                kolod.Deliver(userDeck, computerDeck);
                userAttacks = false;
            }
            else {
                kolod.Deliver(computerDeck, userDeck);
                userAttacks = true;
            }
            NextMove();
        }

        public void Collect() {
            if (userAttacks)
            {
                computerDeck.AddDeck(currentDeck);
                currentDeck.Clear();
                kolod.Deliver(userDeck, computerDeck);

            }
            else {
                userDeck.AddDeck(currentDeck);
                currentDeck.Clear();
                kolod.Deliver(computerDeck, userDeck);
            }
            NextMove();
        }
        public bool Covers(Card cover, Card thrown) {
            if (cover == null) return false;
            if (cover.Suit == kozr) {
                if (thrown.Suit == kozr)
                {
                    if (cover.Rank > thrown.Rank) return true;
                    return false;
                }
                return true;
            }
            else {
                if (thrown.Suit != kozr)
                {
                    if (cover.Rank > thrown.Rank) return true;
                    return false;
                }
                return false;
            }
        }

        public void GameOver() {
            gameOver = true;
            currentDeck.Clear();
            userDeck.Clear();
            computerDeck.Clear();
        }
    }
}

