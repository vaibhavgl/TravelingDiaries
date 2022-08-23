using Microsoft.AspNetCore.Mvc;
using TravelingDiaries.Models;
using TravelingDiaries.ViewModel;

namespace TravelingDiaries.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPlaceRepository placeRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPlaceRepository placeRepository, ShoppingCart shoppingCart)
        {
            this.placeRepository = placeRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int id)
        {
            var selectedPie = placeRepository.GetAllPlaces().FirstOrDefault(p => p.PlaceID == id);

            if (selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var selectedPie = placeRepository.GetAllPlaces().FirstOrDefault(p => p.PlaceID == id);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}
