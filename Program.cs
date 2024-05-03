using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    class operacion
    {
        //declaracion de variables que usa la clase
        //tipo de acceso        tipo de dato          nombre de dato
        protected               float                     valor1;
        protected               float                      valor2;
        protected               float                     resultado;

        //atributos de la clase operacion NINGUNO

        //Metodods o funciones de operacion
        /*Los metodos que se ponen acontinuacion 
         * son las funciones de obtener el valor
         * de la caja de texto y guardarlo en la
         * memoria dentro de la variable indicada*/
        //USAMOS UN constructor POR CADA CAJA DE MEMORIA

        public float  Valor1 //CAJA DE MEMORIA 1
        { 
         get { return valor1; }//vamos por el valor
                               // de la caja de texto
         set { valor1 = value; }//Lo guardamos en memoria
        }

        public float Valor2 //CAJA DE MEMORIA 2
        {
            get { return valor2; }//vamos por el valor
                                  // de la caja de texto
            set { valor2 = value; }//Lo guardamos en memoria
        }

        public float Resultado //CAJA DE MEMORIA 3
        {
            get { return resultado; }//vamos por el valor
                                     // de la caja de texto
            set { resultado = value; }//Lo guardamos en memoria
        }

        //comentario desde web
    }
    //creamos nuestra clasr hijo que usara los metodos de crear dato
    class Sumar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
      //las clases hijas tambien pueden tener sus propios atributos y metodos pueden tener
      //variables de esta clase atributos e esta clase metodos de clase
      public float operar(float v1, float v2)
        {
            valor1 = v1;//acesso al constructor de operacion
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class Restar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y metodos pueden tener
        //variables de esta clase atributos e esta clase metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1;//acesso al constructor de opercacion
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class Multiplicar : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y metodos pueden tener
        //variables de esta clase atributos e esta clase metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1;//acesso al constructor de operacion
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    class Division : operacion //los : nos dan permiso de usar lo que tiene operacion
    {
        //las clases hijas tambien pueden tener sus propios atributos y metodos pueden tener
        //variables de esta clase atributos e esta clase metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1;//acesso al constructor de operacion
            valor2 = v2;
            return resultado = valor1 / valor2;

        }


    }
    //esto es un comentario nuevo 26 de abril
    //esto es un segunod comentario nuevo 26 de abril
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
