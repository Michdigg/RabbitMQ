using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Consumer
{
    public class FirstScenario
    {
        public static bool checkFirstScenario()
        {
            return FirstScenarioRule.firstCheckRule() || FirstScenarioRule.secondCheckRule() || FirstScenarioRule.thirdCheckRule() || FirstScenarioRule.fourthCheckRule() || FirstScenarioRule.fifthCheckRule();
        }
    }
}
