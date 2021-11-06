using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_4
{
    class Building
    {
        public string adress = "SPb";
        public int l;
        public int sh;
        public int vs;
        
        public string Adress
        {
            get
            {
                return adress;
            }
        }
        public int L
        {
            get
            {
                if (l <= 0)
                    return 1;
                return l;
            }

            set
            {
                l = value;
            }
        }
        public int Sh
        {
            get
            {
                if (sh <= 0)
                    return 1;
                return sh;
            }

            set
            {
                sh = value;
            }
        }
            public int Vs
        {
            get
            {
                if (vs <= 0)
                    return 1;
                return vs;
            }

            set
            {
                vs = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("Building: \nАдресс: {0}\nдлина: {1}\nширина:{2}\nвысота:{3}", adress, l, sh, vs);
        }
    }

    // Объявляем класс, унаследованный от класса Building
    sealed class MultiBuilding : Building
    {
        public int et;
        public int Et
        {
            get
            {
                if (et <= 0)
                    return 1;
                return et;
            }

            set
            {
                et = value;
            }
        }


        // Поля класса Building доступны через конструктор наследуемого класса
        public MultiBuilding(string adress, int l, int sh, int vs, int et)
        {
            this.adress = adress;
            this.l =l;
            this.sh = sh;
            this.vs = vs;
            this.et = et;
        }

        public void Print()
        {
            Console.WriteLine("Building: \nАдресс: {0}\nдлина: {1}\nширина:{2}\nвысота:{3}\nэтажность:{4}", adress, l, sh, vs, et);
        }
    }

    class Program
    {
        static void Main()
        {
            MultiBuilding obj = new MultiBuilding(adress: "SPb", l: 25, sh: 10, vs: 25, et: 5);
            obj.Print();
            

            Console.ReadLine();
        }
    }
}