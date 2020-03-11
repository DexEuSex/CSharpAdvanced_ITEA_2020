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



    }
}
