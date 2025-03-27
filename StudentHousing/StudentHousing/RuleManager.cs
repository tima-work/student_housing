using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class RuleManager
    {
        private List<Rule> rules = new List<Rule>();

        public RuleManager()
        {
            rules = MainPageForm.LoadSmthFromFile<Rule>("rules.json");
        }

        public Rule[] GetRules()
        {
            return rules.ToArray();
        }

        public void AddNewRule(string ruleName)
        {
            CheckValidRule(ruleName);
            this.rules.Add(new Rule(ruleName));
            MainPageForm.SaveSmthToFile<Rule>("rules.json", rules);
        }

        public void UpdateRule(Rule rule, string ruleName)
        {
            CheckValidRule(ruleName);
            rule.UpdateRule(ruleName);
            MainPageForm.SaveSmthToFile<Rule>("rules.json", rules);
        }

        public void CheckValidRule(string ruleName)
        {
            if (ruleName == string.Empty)
                throw new Exception("You haven't entered rule");
            foreach (Rule rule in rules)
            {
                if (rule.RuleName == ruleName)
                    throw new Exception("There is already such a rule");
            }
        }
    }
}
