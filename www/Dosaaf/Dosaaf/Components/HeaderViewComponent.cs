using Microsoft.AspNetCore.Mvc;

namespace Dosaaf.Components
{
    public class HeaderViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Dictionary<string, string> pairsOfPages = new Dictionary<string, string>
            {
                { "/", "Главная" },
                { "Tips", "Сведения" },
                { "Price", "Цены" },
                { "Contacts", "Контакты" },
                { "OnlineEducation", "Онлайн обучение" },
                { "FeedBack", "Отзывы" }
            };


            return View("Header", pairsOfPages);
        }
    }
}
