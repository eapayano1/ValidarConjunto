using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TendenciasKataRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Range range = new Range("[21,34)");
            //Range range1 = new Range("[22,29]");
            string intervalo;
            string intervalo1;
            string option;
            bool stay=true;
            int n=0;
            //Console.WriteLine(range.OverlapsRange(range1));
            //int[] arr = range.EndPoints();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]},");
            //}
            Console.WriteLine("Ingrese los intervalos de su conjunto:");
            intervalo=Console.ReadLine();
            Range range = new Range(intervalo);
            while(stay){
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Elija una de las siguientes opciones:");
            Console.WriteLine("[1]-Validar si el conjunto contiene los valores dados");
            Console.WriteLine("[2]-Validar si el conjunto no contiene los valores dados");
            Console.WriteLine("[3]-Retornar todos los valores de nuestro conjunto");
            Console.WriteLine("[4]-Validar si el conjunto contiene el intervalo dado");
            Console.WriteLine("[5]-Validar si el conjunto contiene el intervalo dado");
            Console.WriteLine("[6]-Retornar los extremos de nuestro conjunto(intervalo)");
            Console.WriteLine("[7]-Validar si el intervalo dado se solapa dentro del conjunto");
            Console.WriteLine("[8]-Validar si el intervalo dado no se solapa dentro del conjunto");
            Console.WriteLine("[9]-Validar si el intervalo dado es igual a nuestro conjunto");
            Console.WriteLine("[10]-Validar si el intervalo dado no es igual a nuestro conjunto");
            Console.WriteLine("[11]-Salir");
            Console.WriteLine("-----------------------------------------------------------------------");
            option=Console.ReadLine();
            Console.WriteLine();
                switch(option){
                    case "1":
                        Console.WriteLine("Ingrese el numero de valores");
                        n=Int32.Parse(Console.ReadLine());
                        int[] nelementos=new int[n];
                        for(int i=0;i<n;i++){
                            nelementos[i]=Int32.Parse(Console.ReadLine());
                        }
                      
                        Console.WriteLine(range.Contains(nelementos));
                    break;
                    case "2":
                        Console.WriteLine("Ingrese el numero de valores");
                        n=Int32.Parse(Console.ReadLine());
                        int[] nelementos1=new int[n];
                        for(int i=0;i<n;i++){
                            nelementos1[i]=Int32.Parse(Console.ReadLine());
                        }
                
                        Console.WriteLine(range.DoesNotContain(nelementos1));
                    break;
                    case "3":
                        for(int i=0;i<range.range.Length;i++){
                            Console.WriteLine($"{range.range[i]}");
                        }
                    break;
                    case "4":
                        Console.WriteLine("Ingrese los valores del intervalo");
                        intervalo1=Console.ReadLine();
                        Range range1=new Range(intervalo1);
                        Console.WriteLine(range.ContainsRange(range1));

                    break;
                    case "5":
                        Console.WriteLine("Ingrese los valores del intervalo");
                        intervalo1=Console.ReadLine();
                        Range range2=new Range(intervalo1);
                        Console.WriteLine(range.ContainsRange(range2));
                    break;
                    case "6":
                        int[] endpoints=range.EndPoints();
                        Console.WriteLine($"Primer extremo:{endpoints[0]} - Segundo extremo:{endpoints[1]}");
                    break;
                    case "7":
                        Console.WriteLine("Ingrese los valores del intervalo");
                        intervalo1=Console.ReadLine();
                        Range range3=new Range(intervalo1);
                        Console.WriteLine(range.OverlapsRange(range3));
                    break;
                    case "8":
                        Console.WriteLine("Ingrese los valores del intervalo");
                        intervalo1=Console.ReadLine();
                        Range range4=new Range(intervalo1);
                        Console.WriteLine(range.DoesNotOverlapRange(range4));
                    break;
                    case "9":
                        Console.WriteLine("Ingrese los valores del intervalo");
                        intervalo1=Console.ReadLine();
                        Range range5=new Range(intervalo1);
                        Console.WriteLine(range.Equals(range5));
                    break;
                    case "10":
                        Console.WriteLine("Ingrese los valores del intervalo");
                        intervalo1=Console.ReadLine();
                        Range range6=new Range(intervalo1);
                        Console.WriteLine(range.DoesNotEqual(range6));
                    break;

                    case "11":
                        stay=false;
                        break;
                    default:
                        break;

                }   

            }
           
            Console.ReadKey();
        }
    }
}
