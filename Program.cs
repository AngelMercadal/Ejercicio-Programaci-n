using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {


            string texto = "ilerna online programacion a 2º semestre 2022";
            string texto2 = texto.ToUpper();
            string texto3 = texto2.Replace(" ", string.Empty);
            Console.WriteLine(texto3);


        

           String consonantes = "bcdfghjklmnñpqrstvwxyz";

           

            int contador_cons = 0;


            String numeros = "0123456789"; 

            

            int contador_num = 0;


            char[] ArraySolocons = new char[miArray.Length];



            for (int i = 0; i < miArray.Length; i++)
            {
                for (int j = 0; j < Arraycons.Length; j++)
                {
                    if (miArray[i] == Arraycons[j]) { contador_cons++; }
                }

            }




            for (int i = 0; i < miArray.Length; i++)
            {
                for (int j = 0; j < Arraynum.Length; j++)
                {
                    if (miArray[i] == Arraynum[j]) { contador_num++; }
                }

            }



            for (int i = 0; i < miArray.Length; i++)
            {
                for (int j = 0; j < Arraycons.Length; j++)
                {
                    if (miArray[i] == Arraycons[j]) { ArraySolocons[i] = miArray[i]; }
                }

            }


            Console.WriteLine();
            Console.WriteLine(contador_cons);
            Console.WriteLine();
            Console.WriteLine(contador_num);
            Console.WriteLine();


            for (int i = 0; i < ArraySolocons.Length; i++)
            {
                Console.Write(ArraySolocons[i]);
            }

            Console.WriteLine();




            /*  OTRO METODO POSIBLE EN LUGAR DEL ULTIMO BUCLE:   foreach (char ArraySolocon in ArraySolocons)
                                                                   { Console.Write(ArraySolocon); }       */



        }
    }
}
