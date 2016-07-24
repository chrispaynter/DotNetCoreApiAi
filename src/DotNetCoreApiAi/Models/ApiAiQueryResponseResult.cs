using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Paynter.ApiAi.Models
{
    public class ApiAiParameter
    {

    }
    public class ApiAiQueryResponseResult
    {
        public string Source { get; set; }
        public string ResolvedQuery { get; set; }
        public string Action { get; set; }
        public bool ActionIncomplete { get; set; }
        public JObject Parameters { get; set; }
        public IEnumerable<ApiAiQueryContext> Contexts { get; set; }
        public ApiAiQueryFulfillment Fulfillment { get; set; }
    }
    
}