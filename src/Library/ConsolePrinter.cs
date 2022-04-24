using System;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter: IPrinter{
        /// <summary>
        /// Metodo que imprime el String Builder recibido por la clase Recipe. Recordemos que StringBuilder es una
        /// cadena de caracateres.
        /// </summary>
        /// <param name="strToPrint"></param>
         public void print(StringBuilder strToPrint){
            Console.WriteLine(strToPrint);
         }
    }
}