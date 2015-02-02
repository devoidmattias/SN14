using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public class Lista<T> 
    {
        private T[] _lista;

        public Lista()
        {
            _lista = new T[10];
        }
        public void Add(T value)
        {
            _lista[0] = value;
        }

    }

    //public class StringLista : Lista
    //{

    //    public override void Add(int value)
    //    {
    //        _lista[0] = obj;
    //    }
    //}
    //public class IntLista : Lista
    //{

    //    public override void Add(object obj)
    //    {
    //        _lista[0] = obj;
    //    }
    //}


}
