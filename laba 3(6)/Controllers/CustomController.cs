using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

public class CustomController : Controller
{
    public IActionResult Execute(string actionName, int id)
    {
        if (actionName == "start" && id == 0)
        {
            // Переход на метод Index() обычного контроллера
            return RedirectToAction("Index", "Cinema");
        }
        else
        {
            // Вывод сообщения об ошибке и полного URL
            var url = HttpContext.Request.GetDisplayUrl(); // Получение полного URL
            return Content($"Ошибка: Неправильные параметры. Полный URL: {url}");
        }
    }
}
