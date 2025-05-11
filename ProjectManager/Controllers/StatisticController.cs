using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class StatisticController : Controller
{
    private readonly IStatisticService _statisticService;
    private static int _companyId, _projectId;

    public StatisticController(IStatisticService statisticService)
    {
        _statisticService = statisticService;
    }

    [HttpGet]
    public IActionResult Index(int cId, int pId)
    {
        _companyId = cId;
        _projectId = pId;
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(DateTime startDate, DateTime endDate)
    {
        var statistics = _statisticService.ReadStatistic(_companyId, _projectId, startDate.Date, endDate.Date);
        return View(statistics);
    }
}
