using Core.Entities.Poker;
using Web.ViewModels;

namespace Web.Mappers
{
    public static class CreateHandViewModelMapper
    {
        public static Hand ToHand(this CreateHandViewModel viewModel)
        {
            var cardOne = viewModel.CardOne.ToCard();
            var cardTwo = viewModel.CardTwo.ToCard();
            var cardThree = viewModel.CardThree.ToCard();
            var cardFour = viewModel.CardFour.ToCard();
            var cardFive = viewModel.CardFive.ToCard();

            return new Hand
            {
                Cards = new List<Card> { cardOne, cardTwo, cardThree, cardFour, cardFive }
            };
        }
    }
}
