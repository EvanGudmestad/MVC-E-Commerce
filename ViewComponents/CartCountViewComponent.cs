using Microsoft.AspNetCore.Mvc;
using OneToManyDemo.ViewModels;
using OneToManyDemo.Extensions;


namespace OneToManyDemo.ViewComponents
{
    public class CartCountViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.GetObject<CartViewModel>("ShoppingCart");
            var count = cart?.ItemCount ?? 0;
            return View(count);
        }
    }
}
