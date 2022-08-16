using Microsoft.AspNetCore.Mvc;

namespace Dosaaf.Components
{
    public class HeaderViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Dictionary<string, string> pairsOfPages = new Dictionary<string, string>
            {
                { "Home", "Главная" },
                { "Tips", "Сведения" },
                { "Price", "Цены" },
                { "Contacts", "Контакты" },
                { "OnlineEducation", "Онлайн обучение" }
            };


            return View("Header", pairsOfPages);
        }
    }
}
