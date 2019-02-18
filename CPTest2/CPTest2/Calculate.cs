using System;
namespace CPTest2.Shared
{
    public class Calculate
    {
        private int m_savedValue = 0;

        public Calculate(int init)
        {
            m_savedValue = init;
        } // Calculate()

        public int Add(int inc)
        {
            m_savedValue += inc;
            return m_savedValue;
        } // Add()

        public int PostAdd(int inc)
        {
            var ret = m_savedValue;
            m_savedValue += inc;
            return ret;
        } // PostAdd()
    }
}
