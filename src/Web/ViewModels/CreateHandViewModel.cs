using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.ViewModels
{
    public class CreateHandViewModel
    {
        public CreateCardViewModel CardOne { get; set; }
        public CreateCardViewModel CardTwo { get; set; }
        public CreateCardViewModel CardThree { get; set; }
        public CreateCardViewModel CardFour { get; set; }
        public CreateCardViewModel CardFive { get; set; }
        public List<SelectListItem> Suits { get; set; }
        public List<SelectListItem> Values { get; set; }

        public CreateHandViewModel()
        {
            CardOne = new CreateCardViewModel(); 
            CardTwo = new CreateCardViewModel(); 
            CardThree = new CreateCardViewModel(); 
            CardFour = new CreateCardViewModel(); 
            CardFive = new CreateCardViewModel();
            Suits = new List<SelectListItem>
            {
                new SelectListItem { Value = "C", Text = "Clubs" },
                new SelectListItem { Value = "H", Text = "Hearts" },
                new SelectListItem { Value = "D", Text = "Diamonds" },
                new SelectListItem { Value = "S", Text = "Spades" }
            };

            Values = new List<SelectListItem>
            {
                new SelectListItem { Value = "2", Text = "2" },
                new SelectListItem { Value = "3", Text = "3" },
                new SelectListItem { Value = "4", Text = "4" },
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "6", Text = "6" },
                new SelectListItem { Value = "7", Text = "7" },
                new SelectListItem { Value = "8", Text = "8" },
                new SelectListItem { Value = "9", Text = "9" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "J", Text = "J" },
                new SelectListItem { Value = "Q", Text = "Q" },
                new SelectListItem { Value = "K", Text = "K" },
                new SelectListItem { Value = "A", Text = "A" },

            };
        }
    }
}