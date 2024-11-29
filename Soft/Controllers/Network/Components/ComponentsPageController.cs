using Microsoft.AspNetCore.Mvc;

namespace Nc.Soft.Controllers.Network.Components;
public class ComponentsPageController : Controller {
    public IActionResult Index() => View();
}
