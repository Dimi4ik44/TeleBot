using Microsoft.AspNetCore.Mvc;
using TeleBot.Application.Abstractions;
using TeleBot.DataAcces;
using TeleBot.Domain.Models;

namespace TeleBot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DataContext _dataContext;
        private readonly IBotManager _botManager;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DataContext context, IBotManager botManager)
        {
            _logger = logger;
            _dataContext = context;
            _botManager = botManager;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Chat> Get()
        {
            _botManager.testc();
            var result = _dataContext.Chats.ToList();
            return result;
        }
    }
}