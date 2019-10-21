using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_avl
{
    public class ArbolBinarioOrdenado {
        class Nodo
        {
            public int info;
            public Nodo izq, der;
        }
        Nodo raiz;

        public ArbolBinarioOrdenado()
        {
            raiz=null;
        }
     
        public void Insertar (int info)
        {
            Nodo nuevo;
            nuevo = new Nodo ();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }


        private void ImprimirPre (Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre (reco.izq);
                ImprimirPre (reco.der);
            }
        }

        public void ImprimirPre ()
        {
            ImprimirPre (raiz);
            Console.WriteLine();
        }

        private void ImprimirEntre (Nodo reco)
        {
            if (reco != null)
            {   
                ImprimirEntre (reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre (reco.der);
            }
        }

        public void ImprimirEntre ()
        {
            ImprimirEntre (raiz);
            Console.WriteLine();
        }


        private void ImprimirPost (Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost (reco.izq);
                ImprimirPost (reco.der);
                Console.Write(reco.info + " ");
            }
        }


        public void ImprimirPost ()
        {
            ImprimirPost (raiz);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
           int  a, b, c, d, e;
            a = 100;
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado ();
            Console.WriteLine("Introdusca los Valores");
            Console.WriteLine("Introdusca el 1er valor");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("/_______________/");

            Console.WriteLine("Introdusca el 2do valor");
            Console.WriteLine("/_______________/");

            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdusca el 3er valor");
            Console.WriteLine("/_______________/");

            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdusca el 4to valor");
            Console.WriteLine("/_______________/");

            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdusca el 5to valor");

            e = Convert.ToInt32(Console.ReadLine());

            abo.Insertar (a);
            abo.Insertar (b);
            abo.Insertar (c);
            abo.Insertar (d);
            abo.Insertar (e);
            Console.WriteLine ("Impresion preorden: ");
            abo.ImprimirPre ();
            Console.WriteLine ("Impresion entreorden: ");
            abo.ImprimirEntre ();
            Console.WriteLine ("Impresion postorden: ");
            abo.ImprimirPost ();
            Console.ReadKey();
        }
    }
}
