using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_1
{
    abstract class BigData
    {
        public virtual void CreateCells(int HowMany)
        {
            int Cells = 0;
            if (HowMany > 30)
                throw new NotImplementedException();
            else
                Cells = HowMany;
        }
        public abstract void GenerateList(string toList);
    }
}
