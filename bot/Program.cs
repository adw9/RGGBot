using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Net;

namespace bot
{
	public class Program
	{
		public static Task Main(string[] args) => new Program().MainAsync();

		public async Task MainAsync()
		{
		}

		private Task Log(LogMessage msg)
		{
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
		}













	}
}
