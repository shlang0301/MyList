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
            
            if (sizeArray == 1)
            {
                array[sizeArray-1] = a;               
                sizeArray++;
            }

            else if (sizeArray > 1)
            {
                Obj[] array2 = new Obj[sizeArray];
                for (int i = 0; i < sizeArray-1; i++)
                {
                    array2[i] = array[i];
                }
                array = array2;
                array[sizeArray - 1] = a;              
                sizeArray++;
            }
        }

        public void Insert(int Num, Obj a)
        {
           
            if (Num < 1 || Num > sizeArray-1)
            {
                Console.WriteLine("Error! Insert failed!");
                return;
            }
            else
            {
                Obj[] array2 = new Obj[sizeArray];
                for (int i = 0; i < Num - 1; i++)
                {
                    array2[i] = array[i];
                }

                for (int i = Num; i < sizeArray; i++)
                {
                    array2[i] = array[i - 1];
                }

                array = array2;
                array[Num - 1] = a;
                sizeArray++;
            }
        }

        public void Remove(Obj a)
        {
            int positionObj = -1;

            for (int i = 0; i < sizeArray-1; i++)
            {
                if (array[i] == a)
                {
                    positionObj = i;
                }
               
            } 
            
            if (positionObj != -1)
            {
                Obj[] array2 = new Obj[sizeArray - 2];

                for (int i = 0; i < positionObj; i++)
                {
                    array2[i] = array[i];
                }

                for (int i = positionObj; i < sizeArray - 2; i++)
                {
                    array2[i] = array[i + 1];
                }

                array = array2;

                sizeArray--;
                
            }
            else
            {
                Console.WriteLine("Obj is not find in this array!");
            }           

        }

        public void RemoveAt(int positionObj)
        {
            positionObj--;

            Obj[] array2 = new Obj[sizeArray - 2];

            for (int i = 0; i < positionObj; i++)
            {
                array2[i] = array[i];
            }

            for (int i = positionObj; i < sizeArray - 2; i++)
            {
                array2[i] = array[i + 1];
            }

            array = array2;

            sizeArray--;
        }

        public void Clear ()
        {
            Obj[] array2 = new Obj[1];
            array = array2;
            sizeArray=1;
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


            List.Clear();


            Obj three = new Obj();

            three.set(30);

            List.Add(three);
            


            Obj fourth = new Obj();

            fourth.set(89);

            List.Insert(1, fourth);



            Obj five = new Obj();

            five.set(289);

            List.Insert(1, five);



            //List.Remove(one);

            //List.Remove(five);

            //List.Remove(three);

            //List.Remove(two);           

           
            //List.Add(three);

            //List.RemoveAt(2);


            List.ShowArray();

            Console.ReadLine();
        }
    }
}
