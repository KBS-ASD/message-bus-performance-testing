using System.Threading.Tasks;
using KBS.Topics.RequestResponseCase;
using MassTransit;

namespace KBS.TestCases.TestCases.RequestResponse.Consumers
{
    /// <summary>
    /// Consumer of 'IRequestMessage' topics
    /// </summary>
    public class RequestConsumer : IConsumer<IRequestMessage>
    {
        /// <summary>
        /// Always replies by publishing a 'IResponseMessage' topic
        /// </summary>
        /// <param name="context">
        /// Received context from message bus
        /// </param>
        public async Task Consume(ConsumeContext<IRequestMessage> context)
        {
            await context.RespondAsync<IResponseMessage>((object)context.Message);
        }
    }
}
