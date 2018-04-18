using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YondusArrow.Models
{
    public class ErrorMessage
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }
}
