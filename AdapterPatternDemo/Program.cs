using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEuro> dom = new List<IEuro>();
            var enchunfle = new EnchunfleEuro();
            var toma = new TomaCorrienteDom();
            dom.Add(new TomaCorrienteAdapter(toma));
            dom.Add(new EnchunfleEuro());

            foreach (var item in dom)
            {
                item.Conectar();
                item.Desconectar();
            }

            Console.ReadLine();
        }
    }

    class TomaCorrienteDom: IDom 
    {

        public void Conectar()
        {
            Console.WriteLine("se conecto en el toma corriente dominicanno");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconecto el enchunfle dominicano");
        }
    }

    interface IDom
    {
        void Conectar();
        void Desconectar();


    }

    class EnchunfleEuro: IEuro 
    {

        public void Conectar()
        {
            Console.WriteLine("Conectando Enchunfle europeo");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectando Enchunfle europeo");
        }
    }

    interface IEuro
    {
        void Conectar();
        void Desconectar();
    }

    class TomaCorrienteAdapter:IEuro
    {

        TomaCorrienteDom tcodom;
        public TomaCorrienteAdapter( TomaCorrienteDom tcodom)
        {
            this.tcodom = tcodom;
        }
        public void Conectar()
        {
            tcodom.Conectar();
        }

        public void Desconectar()
        {
            tcodom.Desconectar();
        }
    }
}
