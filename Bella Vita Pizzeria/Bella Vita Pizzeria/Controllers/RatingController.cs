using BellaVitaPizzeria.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Bella_Vita_Pizzeria.Controllers
{
    public class RatingController : BaseController
    {
        private readonly IRatingService ratingService;

        public RatingController(IRatingService _ratingService)
        {
            ratingService = _ratingService;
        }
    }
}
