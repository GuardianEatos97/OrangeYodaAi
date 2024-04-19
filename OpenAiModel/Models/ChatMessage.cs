using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.AI.OpenAI;
using OpenAiModel.Enums;

namespace OpenAiModel.Models
{
    public class BobsChatMessage
    {
        /*public ChatMessage(ChatRole system, string yodaAiAssistantBehaviorDescription)
        {
            System = system;
            YodaAiAssistantBehaviorDescription = yodaAiAssistantBehaviorDescription;
        }*/

        /*public ChatMessage(ChatRole system, string yodaAiAssistantBehaviorDescription)
{
   System = system;
   YodaAiAssistantBehaviorDescription = yodaAiAssistantBehaviorDescription;
}*/

        public ChatMessageTypeEnum MessageType { get; set; }
        public string? MessageBody { get; set; }

        public static implicit operator BobsChatMessage(Response<ChatCompletions> v)
        {
            throw new NotImplementedException();
        }
        /*public ChatRole System { get; }
public string YodaAiAssistantBehaviorDescription { get; }*/
    }
}
