using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Program
	{
		private DiscordSocketClient _client;

		public static void Main(string[] args)
			=> new Program().MainAsync().GetAwaiter().GetResult();

		public async Task MainAsync()
		{
			_client = new DiscordSocketClient();
			_client.Log += Log;
			await _client.LoginAsync(TokenType.Bot,
				Environment.GetEnvironmentVariable("ODcyMDE0NDQxNzAzNjczODc3.YQjsvA.7RKpA1_qh_61LEuu1m2FLwAzWQk"));
			await _client.StartAsync();

			// Block this task until the program is closed.
			await Task.Delay(-1);
		}
		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}
	}
}