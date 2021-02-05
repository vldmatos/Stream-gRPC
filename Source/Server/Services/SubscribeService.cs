using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Server
{
	public class SubscribeService : Subscribe.SubscribeBase
	{
		private readonly ILogger<SubscribeService> _logger;
		public SubscribeService(ILogger<SubscribeService> logger)
		{
			_logger = logger;
		}

		public override Task<Signature> Sign(Content request, ServerCallContext context)
		{
			return Task.FromResult(new Signature
			{
				Id = Guid.NewGuid().ToString()
			});
		}
	}
}
