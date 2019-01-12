using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pairs.Models
{
    public class GameBoard
    {
        private List<Card> _pieces = new List<Card>();

        public GameBoard()
        {
            int imgIndex = 1;

            for (int i=1; i <= 30; i++)
            {
                if (IsOdd(i))
                {
                    _pieces.Add(new Card()
                    {
                        Id = i,
                        Pair = i + 1,
                        Name = "card-" + Convert.ToString(i),
                        Image = string.Format("/content/img/{0}.png", imgIndex)
                    });
                }
                else
                {
                    _pieces.Add(new Card()
                    {
                        Id = i,
                        Pair = i - 1,
                        Name = "card-" + Convert.ToString(i),
                        Image = string.Format("/content/img/{0}.png", imgIndex)
                    });

                    imgIndex++;
                }
            }

            _pieces.Shuffle();
        }

        public List<Card> Pieces
        {
            get
            {
                return _pieces;
            }
            set
            {
                _pieces = value;
            }
        }

        private bool IsOdd(int i)
        {
            return i % 2 != 0;
        }
    }
}