using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StudentHousing
{
    public class Rule
    {
        [JsonProperty("RuleName")]
        public string RuleName { get; private set; }
        public Rule(string rule_name)
        {
            this.RuleName = rule_name;
            //this.ruleDescription = rule_description;
        }

        public void UpdateRule(string rule_name)
        {
            this.RuleName = rule_name;
        }
    }
}
