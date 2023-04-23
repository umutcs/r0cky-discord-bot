using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using r0cky.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;



namespace r0cky
{

    public class Bot
    {

        public DiscordClient DiscordClient { get; private set; }
        public InteractivityExtension Interactivity { get; private set; }
        public CommandsNextExtension Commands { get; private set; }
        public async Task RunAsync()
        {
            var json = string.Empty;
            using (var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync();

            var configjson = JsonConvert.DeserializeObject<ConfigJson>(json);
            var config = new DiscordConfiguration
            {
                Intents = DiscordIntents.AllUnprivileged | DiscordIntents.MessageContents,
                Token = configjson.Token,
                TokenType = TokenType.Bot,
                MinimumLogLevel = LogLevel.Debug

            };

            DiscordClient = new DiscordClient(config);
            DiscordClient.UseInteractivity(new InteractivityConfiguration()
            {
                Timeout = TimeSpan.FromMinutes(2)
            });
            var commandsconfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new string[] { configjson.Prefix },
                EnableMentionPrefix = true,
                EnableDms = true,
                EnableDefaultHelp = false
            };
            Commands = DiscordClient.UseCommandsNext(commandsconfig);
            Commands.RegisterCommands<FunCommands>();
            Commands.RegisterCommands<ModerationCommands>();
            Commands.RegisterCommands<Blackjack>();

            DiscordClient.Ready += OnClientReady;

            //DiscordClient.MessageCreated += OnMessageCreated;

            await DiscordClient.ConnectAsync();
            await Task.Delay(-1);


            //-1 dememmizin sebebi eğer ki connection atarken hata olursa bunu engellemesi ve tekrardan denemesinde yardımcı olması
            //içindir.

        }

        private Task OnClientReady(DiscordClient sender, ReadyEventArgs e)
        {
            Console.WriteLine("Bot is ready!");

            return Task.CompletedTask;

        }

    }
}