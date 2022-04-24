using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// La interfaz IPrinter se desarolla con el fin de poder agregar nuevos metodos de impresion sin modificar la clase printer y ademas
    /// se cumple con el patron SRP ya que le asignamos la responsabilidad correspondiente a cada clase en espacifico.  
    /// La clase ConsolePrinter es responsable de imprimir en consola y otras clases que se crean luego pueden ser responsables de imprimir 
    /// en su formato, por ejemplo en una impresora sin la necesidad de que la clase Console Printer tambien tenga dicha responsabilidad.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Se crea el emtodo print que sera heredado y sobreescrito por las clases que hereden dicho metodo.
        /// </summary>
        /// <param name="strToPrint"></param>
        void print(StringBuilder strToPrint);
    }
}