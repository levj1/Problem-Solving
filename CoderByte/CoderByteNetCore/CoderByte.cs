using System;

namespace CoderByteNetCore
{
    public class CoderByte
    {
        public string TimeConvert(int minutes)
        {
            return $"{minutes / 60}:{minutes % 60}";

        }
    }
}
