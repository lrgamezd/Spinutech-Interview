using Core.Entities.Poker;
using Web.ViewModels;

namespace Web.Mappers
{
    public static class CreateCardViewModelMapper
    {
        public static Card ToCard(this CreateCardViewModel viewModel)
        {
            return viewModel is null
                ? new()
                : new Card
                {
                    Value = viewModel.Value,
                    Suit = viewModel.Suit,
                    NumericalValue = viewModel.NumericalValue,
                };
        }
    }
}
