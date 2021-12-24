using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Consumer
{
    public class SecondScenario
    {
        public static bool checkSecondScenario()
        {
            return SecondScenarioRule.firtCheckRule() || SecondScenarioRule.secondCheckRule();
        }
    }
}
