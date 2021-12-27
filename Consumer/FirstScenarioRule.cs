using Model;

namespace RabbitMQ.Consumer
{
    public static class FirstScenarioRule
    {
        /// <summary>
        /// Check the first rule (Temperature over 59°C + Brightness under 400) 
        /// </summary>
        /// <returns></returns>
        public static bool firtCheckRule()
        {
            return (Consumer.consumeTemperature() > 59 && Consumer.consumeBrightness() < 400) ;
        }

        /// <summary>
        /// Check the second rule (Noise under 500 + Brightness under 400)
        /// </summary>
        /// <returns></returns>
        public static bool secondCheckRule()
        {
            return (Consumer.consumeVolume() < 500 && Consumer.consumeBrightness() < 400);
        }

        /// <summary>
        /// Check the third rule (Temperature over 59°C + Motion detected)
        /// </summary>
        /// <returns></returns>
        public static bool thirdCheckRule()
        {
            return (Consumer.consumeTemperature() > 59 && Consumer.consumeMotion());
        }

        /// <summary>
        /// Check the fourth rule (Noise under 500 + Motion detected)
        /// </summary>
        /// <returns></returns>
        public static bool fourthCheckRule()
        {
            return (Consumer.consumeVolume < 500 && Consumer.consumeMotion());
        }

        /// <summary>
        /// Check the fifth rule (Jammer detected under 400 or over 600 (offline rule))
        /// </summary>
        /// <returns></returns>
        public static bool fifthCheckRule()
        {
            return (Consumer.consumeMagneticField() < 400 || Consumer.consumeMagneticField() > 600);
        }
    }
}
