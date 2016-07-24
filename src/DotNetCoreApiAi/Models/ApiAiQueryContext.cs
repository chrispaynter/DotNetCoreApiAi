
using Newtonsoft.Json.Linq;

namespace Paynter.ApiAi.Models
{
    public class ApiAiQueryContext
    {
        public ApiAiQueryContext(){}
        public ApiAiQueryContext(string name):this(name, 5, null) {}

        public ApiAiQueryContext(string name, int lifespan):this(name, lifespan, null) {}
        public ApiAiQueryContext(string name, JObject parameters):this(name, 5, parameters) {}
        public ApiAiQueryContext(string name, int lifespan, JObject parameters)
        {
            Name = name;
            Parameters = parameters;
            Lifespan = lifespan;
        }

        public string Name { get; set; }
        public JObject Parameters { get; set; }
        public int Lifespan { get; set; }
    }
    
}