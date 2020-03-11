using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_1
{
    class SmallData
    {
        public SmallData something;

        private int BigBob;

        protected SmallData Something
        {
            get
            {
                return something;
            }
            private set
            {
                if (value.BigBob > 1)
                {
                    something = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }


}
