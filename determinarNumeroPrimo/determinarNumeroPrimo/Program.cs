using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace determinarNumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
             int a=0,i,num;  
             Console.WriteLine("Ingresa un numero");
             num = Convert.ToInt32(Console.ReadLine());  
             for(i=1;i<(num+1);i++){  
             if(num%i==0){  
                 a++;  
                }  
             }  
             if(a!=2){
                 Console.WriteLine("El numero ingresado no es Primo");  
                }else{
                    Console.WriteLine("El numero ingresado si es Primo");  
             }  
              Console.ReadLine();  
            
        }
    }
}
