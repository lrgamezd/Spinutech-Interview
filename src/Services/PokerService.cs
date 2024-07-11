using Core.Contracts;
using Core.Entities.Poker;
using Services.Utilities;

namespace Services
{
    public class PokerService : IPokerService
    {
        public string EvaluateHand(Hand hand)
        {
            return hand switch
            {
                _ when Rules.IsRoyalFlush(hand) => Ranking.ROYAL_FLUSH,
                _ when Rules.IsStraightFlush(hand) => Ranking.STRAIGHT_FLUSH,
                _ when Rules.IsFourOfAKind(hand) => Ranking.FOUR_OF_A_KIND,
                _ when Rules.IsFullHouse(hand) => Ranking.FULL_HOUSE,
                _ when Rules.IsStraight(hand) => Ranking.STRAIGHT,
                _ when Rules.IsThreeOfAKind(hand) => Ranking.THREE_OF_A_KIND,
                _ when Rules.IsTwoPairs(hand) => Ranking.TWO_PAIRS,
                _ when Rules.IsOnePair(hand) => Ranking.ONE_PAIR,
                _ => Ranking.HIGH_CARD
            };
        }
    }
}