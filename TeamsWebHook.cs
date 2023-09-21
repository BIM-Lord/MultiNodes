using Autodesk.DesignScript.Runtime;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MultiNodes
	{
	public class TeamsMessenger
		{
		
		private readonly string webhookUrl;

		public TeamsMessenger(string webhookUrl)
			{
			
			this.webhookUrl = webhookUrl;
			}

		//[IsVisibleInDynamoLibrary(true)]
		public static async Task SendTeamsMessage(string webhookUrl, string message)
			{
			using (HttpClient client = new HttpClient())
				{
				var content = new StringContent($"{{\"text\":\"**{message}**\"}}", Encoding.UTF8, "application/json");
				var response = await client.PostAsync(webhookUrl, content);

				if (!response.IsSuccessStatusCode)
					{
					throw new Exception($"Failed to send message: {response.ReasonPhrase}");
					}
				}
			}
		}
	}
