using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
    public class Deck
    {
        /// <summary>
        /// 全部52张牌
        /// </summary>
        private Card[] cards;

        /// <summary>
        /// 创建一副牌
        /// </summary>
        public Deck()
        {
            cards = new Card[52];
            for (int suitVal= 0; suitVal <4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal ++)
                {
                    cards[suitVal*13 + rankVal - 1] = new Card((Suit) suitVal, (Rank) rankVal);
                }
            }
        }

        /// <summary>
        /// 从牌堆中获取一张牌
        /// </summary>
        /// <returns>当前获取的一张牌</returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                    "Value must be between 0 and 51."));
        }

        /// <summary>
        /// 洗牌
        /// </summary>
        public void Shuffle()
        {
            ArrayList newDeck = new ArrayList(cards);
            Random ran = new Random();
            int index = 0;
            for (int i = 0; i < 52; i++)
            {
                index = ran.Next(52 - i);
                cards[i] = (Card) newDeck[index];
                newDeck.RemoveAt(index);
            }
        }
    }
}