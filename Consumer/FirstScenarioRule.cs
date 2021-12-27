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
            if (Consumer.consumeTemperature() > 59 && Consumer.consumeBrightness() < 400) ;
            {
                check = true;
            }else
            {
                check = false;
            }
            return check;
        }

        /// <summary>
        /// Check the second rule (Noise under 500 + Brightness under 400)
        /// </summary>
        /// <returns></returns>
        public static bool secondCheckRule()
        {
            if (Consumer.consumeVolume() < 500 && Consumer.consumeBrightness() < 400)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

        /// <summary>
        /// Check the third rule (Temperature over 59°C + Motion detected)
        /// </summary>
        /// <returns></returns>
        public static bool thirdCheckRule()
        {
            if (Consumer.consumeTemperature() > 59 && Consumer.consumeMotion())
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

        /// <summary>
        /// Check the fourth rule (Noise under 500 + Motion detected)
        /// </summary>
        /// <returns></returns>
        public static bool fourthCheckRule()
        {
            if (Consumer.consumeVolume < 500 && Consumer.consumeMotion())
            {
                check = true;
            } else
            {
                check = false;
            }
            return check;
        }

        /// <summary>
        /// Check the fifth rule (Jammer detected under 400 or over 600 (offline rule))
        /// </summary>
        /// <returns></returns>
        public static bool fifthCheckRule()
        {
            if (Consumer.consumeMagneticField()<400 || Consumer.consumeMagneticField()>600)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}
