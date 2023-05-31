using Microsoft.AspNetCore.Mvc;

public class GreetingViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(string name)
    {
        var hour = DateTime.Now.Hour;
        var message = "";
        if (hour < 12)
        {
            message = $"Good morning, {name}!";
        }
        else
        {
            message = $"Good evening, {name}!";
        }
        ViewData["Message"] = message;
        return View();
    }
}