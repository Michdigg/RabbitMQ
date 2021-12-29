using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Consumer
{
    public static class SecondScenario
    {
        public static bool checkSecondScenario()
        {
            return SecondScenarioRule.firtCheckRule() || SecondScenarioRule.secondCheckRule();
        }
    }
}
