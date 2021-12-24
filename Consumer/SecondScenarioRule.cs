using Model;

namespace RabbitMQ.Consumer
{
    public static class SecondScenarioRule
    { 
        /// <summary>
        /// Check the first rule (motion detected) 
        /// </summary>
        /// <returns></returns>
       public static bool firtCheckRule()
        {
            return Consumer.consumeMotion();
        }
        
        /// <summary>
        /// Check the second rule (inlination and speed detected)
        /// </summary>
        /// <returns></returns>
        public static bool secondCheckRule()
        {
            bool check;
            if ( Consumer.consumeInclination() > 10000 && Consumer.consumeSpeed() > 10000 )
            {
                check = true;
            } else {
                check = false;
            }
            return check;
        }
    }
}
