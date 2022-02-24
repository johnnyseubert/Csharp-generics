using System;
using System.Runtime.InteropServices;

namespace Generics
{
    //Generico é passado o tipo quando for instanciado assim posso utilizar 1 classe para string,int,double etc etc
    public class PrintService<Generico>
    {
        private Generico[] _values = new Generico[10];
        private int _count = 0;
         
        public void AddValue(Generico value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Print Service is full");
            }
            
            _values[_count] = value;
            _count++;
        }

        public Generico First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Print Service is empty");
            }

            return _values[0];
        }
        
        public void print(){
            Console.Write("[");
            for (int i = 0; i < _count -1; i++)
            {
                Console.Write($"{_values[i]}, ");
            }
            if (_count > 0 )
            {
                Console.Write(_values[_count -1]);
            }
            Console.WriteLine("]");
        }
    }
}