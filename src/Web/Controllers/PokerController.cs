using Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Web.Mappers;
using Web.ViewModels;

namespace Web.Controllers
{
    public class PokerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPokerService _pokerService;

        public PokerController(ILogger<HomeController> logger, IPokerService pokerService)
        {
            _logger = logger ??
                throw new ArgumentNullException(nameof(logger));

            _pokerService = pokerService ??
                throw new ArgumentNullException(nameof(pokerService));
        }

        public IActionResult Index()
        {
            var viewModel = new CreateHandViewModel();

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(CreateHandViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var hand = viewModel.ToHand();

            var result = _pokerService.EvaluateHand(hand);

            return RedirectToAction(
                nameof(EvaluateSuccess), 
                new EvaluateSuccessViewModel { Message = result });
        }

        public IActionResult EvaluateSuccess(EvaluateSuccessViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}