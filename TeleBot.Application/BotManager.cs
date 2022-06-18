using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleBot.Application.Abstractions;
using Telegram.Bot;

namespace TeleBot.Application
{
    public class BotManager : IBotManager
    {
        public readonly string token;
        private readonly IConfiguration _config;
        private readonly ILogger<BotManager> _logger;
        public BotManager(IConfiguration configuration, ILogger<BotManager> logger)
        {
            _config = configuration;
            token = _config["TelegramSettinds:BotToken"];
            _logger = logger;
        }
        public async Task testc()
        {
            var botClient = new TelegramBotClient(token);

            var me = await botClient.GetMeAsync();
            _logger.LogInformation($"Hello, World! I am user {me.Id} and my name is {me.FirstName}.");
        }
    }
}
