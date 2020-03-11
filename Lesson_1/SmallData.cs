using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_1
{
    class SmallData
    {
        public SmallData something;

        private int ProgVersion;

        protected SmallData Something
        {
            get
            {
                return something;
            }
            private set
            {
                if (ProgVersion > 2)
                {
                    something = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public SmallData(int progVers)
        {
            ProgVersion = progVers;
        }

        public void BlackLoang(bool Condition)
        {
            Condition = true;
        }
        public float Report(bool Condition)
        {
            int Base = 0;

            return (Condition == true ? Base + 50 : Base);
        }

    }
}
