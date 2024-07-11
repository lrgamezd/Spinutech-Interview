using Core.Entities.Poker;

namespace Services.Utilities
{
    public static class Rules
    {
        public static bool IsOnePair(Hand hand)
        {
            // if its 2 - 1 - 1 - 1, then having 3 groups proof that you have A Pair    
            return hand.Cards
                .GroupBy(c => c.Value)
                .Count() == 4;
        }

        // Two different pairs in the same hand
        public static bool IsTwoPairs(Hand hand)
        {
            // if its 2 - 2 - 1, then having 3 groups proof that you have Two Pairs    
            return hand.Cards
                .GroupBy(c => c.Value)
                .Count() == 3;
        }

        // Any three numerically matching cards
        public static bool IsThreeOfAKind(Hand hand)
        {
            return hand.Cards
                .GroupBy(c => c.Value)
                .Any(g => g.Count() == 3);
        }

        public static bool IsRoyalFlush(Hand hand)
        {
            // Must have same suit
            var areCardsOfSameSuit = AreCardsOfSameSuit(hand);

            // Must contain 10 J Q K A
            var royalFlushCardValues = new List<string> { "10", "J", "Q", "K", "A" };
            var valuesInHand = hand.Cards.Select(c => c.Value);
            var areCardValuesRoyal = valuesInHand.All(value => royalFlushCardValues.Contains(value));

            return areCardsOfSameSuit && areCardValuesRoyal;

        }

        public static bool IsStraightFlush(Hand hand)
        {
            // Must have same suit
            var areCardsOfSameSuit = AreCardsOfSameSuit(hand);

            // Must be order senquentially
            var numericalValuesInHand = hand.Cards
                .Select(c => c.NumericalValue)
                .Order();

            var isOrderedSecuentally = numericalValuesInHand
                .Zip(numericalValuesInHand.Skip(1), (a, b) => b - a)
                .All(diff => diff == 1);

            return areCardsOfSameSuit && isOrderedSecuentally;
        }

        // Any four numerically matching cards
        public static bool IsFourOfAKind(Hand hand)
        {
            return hand.Cards
                .GroupBy(c => c.Value)
                .Any(g => g.Count() == 4);
        }

        // Combination of Three of a kind and pair
        public static bool IsFullHouse(Hand hand)
        {
            // if its 3 - 2, then having 2 groups proof that you have a FullHouse    
            return hand.Cards
                .GroupBy(c => c.Value)
                .Count() == 2;
        }

        // Five cards of any suit, in sequential order
        public static bool IsStraight(Hand hand)
        {
            // Must be order senquentially
            var numericalValuesInHand = hand.Cards
                .Select(c => c.NumericalValue)
                .Order();

            var isOrderedSecuentally = numericalValuesInHand
                .Zip(numericalValuesInHand.Skip(1), (a, b) => b - a)
                .All(diff => diff == 1);

            return isOrderedSecuentally;
        }


        public static bool AreCardsOfSameSuit(Hand hand)
            => hand.Cards.All(c => c.Suit == hand.Cards.First().Suit);
    }
}
