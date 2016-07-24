using System;

namespace Paynter.ApiAi.Models
{
    public class ApiAiQueryResponse
    {
        public string Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public ApiAiQueryResponseResult Result { get; set; }
    }
}