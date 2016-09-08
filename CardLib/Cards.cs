using System.Collections;

namespace CardLib
{
    public class Cards : CollectionBase
    {
        public Cards()
        {
            
        }

        public void Add(Card newCard)
        {
            List.Add(newCard);
        }

        public void Remove(Card oldCard)
        {
            List.Add(oldCard);
        }

        public Card this[int cardIndex]
        {
            get
            {
                return (Card)(List[cardIndex]);
            }
            set
            {
                List[cardIndex] = value;
            }
        }

        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        public bool Contains(Card card)
        {
            return InnerList.Contains(card);
        }

    }
}
