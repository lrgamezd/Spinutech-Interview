using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels
{
    public class CreateCardViewModel
    {
        [Required]
        public string Value { get; set; }

        public int NumericalValue { get => SetNumerivalValue(); }

        [Required]
        public string Suit { get; set; }

        private int SetNumerivalValue()
        {
            if (string.IsNullOrEmpty(Value))
                return 0;
            else if (Value == "J")
                return 11;
            else if (Value == "Q")
                return 12;
            else if (Value == "K")
                return 13;
            else if (Value == "A")
                return 14;
            else
                return int.Parse(Value);
        }
    }
}
