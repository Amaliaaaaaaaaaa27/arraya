

//Printarea unui vector pe consola 

//Adesea trebuie să imprimăm elementele unui tablou dat pe consolă, după am terminat de lucrat cu el.Tipărim elemente ale unui tablou pe consolă în mod similar cu inițializarea elemente,
//adică prin utilizarea unei bucle pentru a itera prin matrice. Nu există stricte reguli pentru imprimare, dar adesea se folosește un fel de formatare adecvata .O greșeală frecventă este
//încercarea de a imprima o matrice ca un număr: 

//string[] array = { "one", "two", "three", "four" }; ]
//Console.WriteLine(array);                           ] - > daca scriem asa o sa ne arate o eroare 


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Amalia__CSHARP_Lab_3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] vectorIntregi = new int[10];

//            Console.WriteLine("Introduceti cate valori vreti sa introduce-ti in vector !");
//            int numere = int.Parse(Console.ReadLine());
//            Console.WriteLine("Acum va rugam sa introduceti elementele in vector !");


//            for (int i = 1; i <= numere; i++)
//            {
//                vectorIntregi[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Elementele vectorului sunt urmatoarele : ");

//            for (int i = 1; i <= numere; i++)
//            {
//                Console.WriteLine(vectorIntregi[i]);
//            }


//            // stergem un element de pe o anumita pozitie

//            Console.WriteLine("Alegeti un element de pe o pozitie dorita din vector pentru a-l elimina ! ");
//            int pozitieElementDinVector = int.Parse(Console.ReadLine());

//            for (int i = pozitieElementDinVector + 1; i <= numere; i++)
//            {
//                vectorIntregi[i - 1] = vectorIntregi[i];
//            }

//            numere--;

//            // Afisam elementele ramase dupa stergerea unui element de pe o pozitie aleasa a vectorului setat

//            Console.WriteLine("Elementele vectoru-lui nou este : ");

//            for (int i = 1; i <= numere; i++)
//            {
//                Console.WriteLine(vectorIntregi[i] + " ");
//            }
//            Console.ReadKey();


//            // adaugam un element dintr o anumita pozitie 


//        }
//    }
//}


//BUBLE SORT 
//Considerăm un vector de elemente comparabile între ele şi dorim să le ordonăm crescător.
//Pentru aceasta comparăm primul element cu toate elementele care urmează după el. Dacă găsim un element mai mic decât primul atunci le
//interschimbăm pe cele două. Apoi continuăm cu al doilea element al şirului, pe care, de asemenea îl comparăm cu toate elementele care urmează după el
//şi în caz de inversiune interschimbăm cele două elemente. Apoi procedăm la fel cu al treilea element al şirului iar procesul continuă astfel pâna la
//penultimul element al şirului care va fi comparat cu ultimul element din şir 

//using System;

//namespace Program
//{
//    class arrays
//    {
//        static void Main(string[] args)
//        {

//            int aux = 0;

//            Console.WriteLine("Tastati cate numere o sa contina array ul ");


//            int number = int.Parse(Console.ReadLine());


//            int[] myArray = new int[number];

//            for (int i = 0; i < number; i++)
//            {
//                myArray[i] = int.Parse(Console.ReadLine());

//            }
//            for (int j = 0; j < number - 1; j++)
//            {
//                for (int i = 0; i < number - 1; i++)
//                {
//                     if (myArray[i] > myArray[i + 1])
//                    {
//                        aux = myArray[i];
//                        myArray[i] = myArray[i + 1];
//                        myArray[i + 1] = aux;
//                    }
//                }
//            }
//            for (int i = 0; i < number; i++)
//            {
//                Console.Write(myArray[i] + " ");
//            }

//        }
//    }



//}



//Exemplu Check for Symmetric Array 
//O matrice simetrică este o matrice în care elementele de pe o parte a centrului matricei sunt imaginea în oglindă a elementelor de pe cealaltă parte. Cu alte cuvinte,
//dacă desenați o linie verticală prin centrul matricei, elementele din partea stângă a liniei sunt identice cu elementele din partea dreaptă a liniei, dar în ordine inversă. 
//De exemplu, următoarea matrice este simetrică: 
//[1, 2, 3, 4, 3, 2, 1]
//În această matrice, elementele din partea stângă a centrului (1, 2, 3, 4) sunt imaginea în oglindă a elementelor din partea dreaptă a centrului (3, 2, 1). 

//using System;

//namespace array
//{
//    class  array
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Tastati un nr pozitiv");
//            int number = int.Parse(Console.ReadLine());

//            int[] array = new  int [10];

//            for (int i = 0; i <number; i++) 
//            {
//                array[i] = int.Parse(Console.ReadLine()); // citit de la tastatura 

//            }

//            bool symmetric = true; // declarat o variabila de tip bool 

//            for (int i = 0; i < number/2; i++) // for ul merge pana la jumatatea array ului 
//            {
//               if (array[i] != array[number - 1 - i]) //daca primul element este la fel ca ultimul se incrementeaza acum indexul creste daca al doilea element este egal cu peultimul si tot asa
//               {
//                    symmetric = false;

//                    break;
//               }     

//            }
//            if (symmetric)
//            {
//                Console.WriteLine("Sirul este simetric");
//            }
//            else
//            {
//                Console.WriteLine("Sirul nu este simetric");
//            }



//        }
//    }
//}

//Inițializam o matrice și citim elementele acesteia din consolă. Avem nevoie să 

//iterați prin jumătate din matrice pentru a verifica dacă este simetrică. Mijlocul 

//elementul matricei are un tablou index.Lungimea / 2. Dacă lungimea este impară 

//număr acest indice este exact cel din mijloc, dar dacă este un număr par,

//indexul este în dreapta mijlocului (mijlocul este între două elemente). Prin urmare 

//bucla rulează de la 0 la matrice.Lungime / 2 (neinclusiv). 

//Pentru a verifica dacă o matrice este simetrică, folosim o variabilă bool și inițial 

//presupunem că tabloul este simetric. În timpul iterației prin matrice  

//comparați primul cu ultimul element, al doilea cu penultimul  și tot asa . Dacă la un moment dat elementele comparate nu sunt egale, atunci setăm 

//variabilă bool la fals, ceea ce înseamnă că tabloul nu este simetric. 

//În final, imprimăm valoarea variabilei bool în consolă. 




////AFISAREA inversa a array urilor
//using System;

//namespace Program
//{
//    class array
//    {

//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());

//            int[] array = new int[number];

//            for (int i = 0; i < number; i++)
//            {
//                array[i] = int.Parse(Console.ReadLine());
//            }
//            for(int i = number - 1; i >=0; i--)
//            {
//                Console.WriteLine(array[i]);    
//            }


//        }

//    }

//}

//alta metoda a celei de sus doar prin creearea unei alte matrice de aceeasi dimensiune 

//using System;
//    class inversare
//{

//    static void Main(string[] args)

//    {

//        int[] array = { 1, 2, 3, 4, 5 };

//        //Get array size  

//        int length = array.Length;

//        //Declare and create the reversed array 

//        int[] reversed = new int[length];

//        //Initialize the reserved array  

//        for (int index = 0; index < length; index++)

//        {

//            reversed[length - index - 1] = array[index];

//        }

//        //Print the reversed array  

//        for (int index = 0; index < length; index++)

//        {

//            Console.WriteLine(reversed[index] + " ");

//        }
//    }

//}
//output : 5 4 3 2 1  

//Exemplul funcționează în felul următor: inițial alocăm un tablou unidimensional de tip int și îl inițializăm cu numerele de la 1 la 5. După aceea, păstrăm lungimea tabloului 
//în lungimea variabilă.Rețineți că folosim lungimea proprietății, care returnează numărul total al elemente ale tabloului.În C # fiecare tablou are o proprietate de lungime. După aceea,
//declarăm matricea inversată cu aceeași lungime, unde va păstra elemente ale tabloului original, dar într-o ordine inversată. Pentru a inversa elementele, folosim o buclă. 
//La fiecare iterație creștem variabila index cu una și ne asigurăm că accesăm toate consecutiv elemente ale tabloului. Condiția buclei asigură că matricea va fi iterat de la capăt la sfârșit.
//Să urmăm ce se întâmplă atunci când iterăm prin tablou. Pe primul iterație, indexul are o valoare de 0. Folosind matricea [ index ] accesăm primul element al tabloului și, respectiv, cu 
//lungimea [ inversată - index - 1 ] accesăm ultimul element al noului tablou inversat unde atribuim valori. Astfel, am însușit valoarea primului element al tabloului la ultimul element al
//tabloului inversat. La fiecare indice de iterație este incrementat cu unul. În acest fel, accesăm următorul element în ordinea matricea și elementul anterior în ordinea inversării. Drept
//urmare, am inversat tabloul și l-am imprimat. În exemplul pe care l-am arătat iterații consecutive prin tablou, care se poate face și cu diferite tipuri de construcții de buclă ( de ex.
//în timp ce și foreach ). 

/*______________________________________________________________________________________________________________________________________________________________________________________*/


//using System;
//namespace Program
//{
//    class DeleteArray
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Tastati un nr intreg pozitiv ce va reprezenta limita vectorului");
//            int number = int.Parse(Console.ReadLine());

//            int[] myArray = new int[number];

//            for (int i = 0; i < number; i++)
//            {
//                myArray[i] = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Tastati pozitia vectorului pe care doriti sa o stergeti");

//            int pozitie = int.Parse(Console.ReadLine());

//            for (int i = pozitie + 1; i < number - 1; i++) 
//            {
//                myArray[i - 1] = myArray[i];

//                number--;
//            }
//            //Afisam elementele ramase
//            for (int i = 0; i < number - 1; i++)
//            {
//                Console.WriteLine($"{myArray[i]}");
//            }
//        } 
//    }
//}


//adunarea a doua vectori 

//using System;
//using System.Diagnostics.CodeAnalysis;

//namespace vect
//{
//    class adunareaAdoiVectori
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Tastati cate limite o sa aiba vectorii");
//            int number = int.Parse(Console.ReadLine());

//            Console.WriteLine($"Limita fiecarui vector este de {number} elemente");

//            int[] myArray1 = new int[number];

//            int[] myArray2 = new int[number];

//            int[] sumOfArray = new int[number];
//            Console.WriteLine("Introduce ti elementele in primul vectorul");
//            for (int i = 0; i < number; i++)
//            {
//                myArray1[i] = int.Parse(Console.ReadLine()); // am citit primul  vector de la tastatura 
//            }
//            Console.WriteLine(" Introuduce ti elementul in al doilea vector");
//            for (int i = 0; i < number; i++)
//            {
//                myArray2[i] = int.Parse(Console.ReadLine()); // am citit al doilea vector de la tastatura 
//            }
//            for (int i = 0; i < number; i++)
//            {
//                sumOfArray[i] = myArray1[i] + myArray2[i];
//            }
//            Console.WriteLine($"Suma celor doi vectori");
//            for (int i = 0; i < number; i++)
//            {
//                Console.WriteLine($"Suma pozitiei  {i + 1 }  cu indexul {i} este  {sumOfArray[i]}");
//            }


//        }
//    }
//}

using System;

namespace programming
{
    class DeleteAnArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tastati limita vectorului");
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];

            int aux = 0;

            Console.WriteLine("Introduce ti numerele in vector");

            for (int i = 0; i < number; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tastati pozitia pe care o doriti sa o eliminati ");

            int pozitie = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numarul tastat de catre utilizator este{pozitie} ");

            for (int i = pozitie - 1; i < number-1; i ++)
            {
                aux = array[i];
                array[i] = array[i + 1];
                array[i + 1] = aux;

            }
            number--;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
