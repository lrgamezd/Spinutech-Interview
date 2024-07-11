using Core.Entities.Poker;
using Services;

namespace Unit
{
    public class PokerServicesTests
    {
        private readonly PokerService _pokerService;

        public PokerServicesTests()
        {
            _pokerService = new PokerService();
        }

        [Fact]
        public void Hand_Should_Be_Royal_Flush()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "H", Value = "A"},
                    new Card { Suit = "H", Value = "K"},
                    new Card { Suit = "H", Value = "Q"},
                    new Card { Suit = "H", Value = "J"},
                    new Card { Suit = "H", Value = "10"},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("Royal Flush", handRanking);
        }

        [Fact]
        public void Hand_Should_Be_Straight_Flush ()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "H", Value = "6", NumericalValue = 5},
                    new Card { Suit = "H", Value = "7", NumericalValue = 6},
                    new Card { Suit = "H", Value = "8", NumericalValue = 7},
                    new Card { Suit = "H", Value = "9", NumericalValue = 8},
                    new Card { Suit = "H", Value = "10", NumericalValue = 9},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("Straight Flush", handRanking);
        }
        
        [Fact]
        public void Hand_Should_Be_Four_Of_A_Kind()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "H", Value = "9"},
                    new Card { Suit = "S", Value = "9"},
                    new Card { Suit = "C", Value = "9"},
                    new Card { Suit = "D", Value = "9"},
                    new Card { Suit = "H", Value = "A"},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("Four of a Kind", handRanking);
        }
        
        [Fact]
        public void Hand_Should_Be_Full_House()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "D", Value = "A"},
                    new Card { Suit = "S", Value = "A"},
                    new Card { Suit = "C", Value = "A"},
                    new Card { Suit = "C", Value = "7"},
                    new Card { Suit = "H", Value = "7"},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("Full House", handRanking);
        }
        
        [Fact]
        public void Hand_Should_Be_Straight()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "D", Value = "7", NumericalValue = 7},
                    new Card { Suit = "S", Value = "8", NumericalValue = 8},
                    new Card { Suit = "C", Value = "9", NumericalValue = 9},
                    new Card { Suit = "C", Value = "10", NumericalValue = 10},
                    new Card { Suit = "H", Value = "J", NumericalValue = 11},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("Straight", handRanking);
        }
        
        [Fact]
        public void Hand_Should_Be_Three_Of_A_Kind()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "C", Value = "10", NumericalValue = 10},
                    new Card { Suit = "D", Value = "10", NumericalValue = 10},
                    new Card { Suit = "S", Value = "10", NumericalValue = 10},
                    new Card { Suit = "H", Value = "6", NumericalValue = 6},
                    new Card { Suit = "S", Value = "4", NumericalValue = 4},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("Three of a Kind", handRanking);
        }
        
        [Fact]
        public void Hand_Should_Be_Two_Pairs()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "C", Value = "6"},
                    new Card { Suit = "D", Value = "6"},
                    new Card { Suit = "S", Value = "Q"},
                    new Card { Suit = "H", Value = "Q"},
                    new Card { Suit = "S", Value = "4"},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("Two Pairs", handRanking);
        }
        
        [Fact]
        public void Hand_Should_Be_One_Pair()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "C", Value = "6"},
                    new Card { Suit = "D", Value = "6"},
                    new Card { Suit = "S", Value = "10"},
                    new Card { Suit = "H", Value = "Q"},
                    new Card { Suit = "S", Value = "4"},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("One Pair", handRanking);
        }
        
        [Fact]
        public void Hand_Should_Be_High_Card()
        {
            var hand = new Hand
            {
                Cards = new List<Card>
                {
                    new Card { Suit = "C", Value = "K"},
                    new Card { Suit = "D", Value = "7"},
                    new Card { Suit = "S", Value = "8"},
                    new Card { Suit = "H", Value = "J"},
                    new Card { Suit = "S", Value = "10"},
                }
            };

            var handRanking = _pokerService.EvaluateHand(hand);

            Assert.Equal("High Card", handRanking);
        }
    }
}