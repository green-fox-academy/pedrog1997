using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YondusArrow.Models
{
    public class ArrowSpeed
    {
        [JsonProperty(PropertyName = "distance")]
        public int? Distance { get; set; }

        [JsonProperty(PropertyName = "time")]
        public int? Time { get; set; }

        [JsonProperty(PropertyName = ("speed"))]
        public int? Speed
        {
            get
            {
                return Distance / Speed;
            }
        }
    }
}
