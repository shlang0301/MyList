using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Obj
    {
        private int a;
        private string str;
        public static int capacity;

        //public Obj()
        //{
        //    capacity++;
        //}

        public int getA()
        {
            return a;
        }

        public string getStr()
        {
            return str;
        }

        public void set(int A, string Str = "default")
        {
            a = A;
            str = Str;
        }

    }


    class MyList : Obj
    {
        public static int sizeArray = 1;

        public static int position = 0;

        public Obj[] array = new Obj[sizeArray];

        public void Add(Obj a)
        {
            capacity++;
            if (sizeArray == capacity)
            {
                array[position] = a;

                position++;
            }

            else if (sizeArray < capacity)
            {
                Obj[] array2 = new Obj[capacity];
                for (int i = 0; i < sizeArray; i++)
                {
                    array2[i] = array[i];
                }
                array = array2;
                array[position] = a;
                position++;
                sizeArray = capacity;
            }
        }

        public void Insert(int Num, Obj a)
        {
            capacity++;
            if (Num < 1 || Num > sizeArray)
            {
                Console.WriteLine("Error! Insert failed!");
                return;
            }
            else
            {
                Obj[] array2 = new Obj[capacity];
                for (int i = 0; i < Num - 1; i++)
                {
                    array2[i] = array[i];
                }

                for (int i = Num; i < capacity - 1; i++)
                {
                    array2[i] = array[i - 1];
                }

                array = array2;
                array[Num - 1] = a;
                sizeArray = capacity;
            }
        }

        public void ShowArray()
        {
            for (int i = 0; i < sizeArray - 1; i++)
            {
                Console.WriteLine(array[i].getA());
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Obj one = new Obj();

            one.set(10);

            MyList List = new MyList();

            List.Add(one);



            Obj two = new Obj();

            two.set(20);

            List.Add(two);


            Obj three = new Obj();

            three.set(30);

            List.Add(three);


            Obj fourth = new Obj();

            fourth.set(89);

            List.Insert(2, fourth);

            Obj five = new Obj();

            five.set(289);

            List.Insert(1, five);

            List.ShowArray();

            Console.ReadLine();
        }
    }
}
