using System;

namespace Small_unit_testing
{
    public class Unit_test:IDisposable
    {
        public int Addition(int a, int b)
        {
           return  a + b;
            
        }
        public int subtraction(int a,int b)
        {
            if (a < b)
            {
                throw new ArgumentException();
            }
            return a - b;
           
        }
        

        public void Dispose()
        {
            //todo
        }

       
    }

}
