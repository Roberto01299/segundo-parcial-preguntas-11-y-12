using System;
using System.Collections.Generic;
using System.Linq;

namespace pregunta 11 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Monedas y Billetes
            int[] Dinero = new int[] { 5, 10, 25, 50, 100, 200 };

            //Lista de Productos
            List<Productos> productos = new List<Productos>();
            int[] ID = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] Nombres = { "oreo","galletas dino","manzana","pan de gineo","coca-cola","Chocolate","agua","paquete de mentas","fanta", "galletas integlal"};
            int[] Precios = { 20, 15, 20, 25, 30, 20, 15, 20, 25, 15 };
            int[] Existencia = { 1, 2, 3, 4, 4, 2, 3, 7, 2, 2 };

            //Llenando lista de productos
            for (int i = 0; i < Nombres.Length; i++)
            {
                productos.Add(new Productos() { ID = ID[i], Nombre = Nombres[i], Precio = Precios[i], Existencia = Existencia[i] });

            }

            //TITULO
            Console.WriteLine("***************************************");
            Console.WriteLine("**        MAQUINA DE PRODUCTO        **");
            Console.WriteLine("***************************************");

            //Presentando Productos
            Console.WriteLine();
            foreach (Productos Articulos in productos)
            {
                Console.WriteLine($"{Articulos.ID}  - Articulo: {Articulos.Nombre} -- Precio: {Articulos.Precio}");
            }
            Console.WriteLine("***************************************");
            Console.Write("Introduce el dinero: ");

            //INICIO CICLO
            try {
                int DineroIngresado = int.Parse(Console.ReadLine());
                int DineroTotal = 0;

                if (Dinero.Contains(DineroIngresado))
                {
                    DineroTotal = DineroIngresado;
                    Console.WriteLine("");
                    Console.Write("Seleccione el Articulo a consumir: ");
                    int opcion = int.Parse(Console.ReadLine());
                    var data = productos.Where(x => x.ID == opcion).ToList();
                    Console.WriteLine();
                    foreach (var i in data)
                    {
                        Console.WriteLine($"{i.Nombre} -- {i.Precio}$ ");
                        Console.WriteLine("");
                        Console.WriteLine("*************");
                        Console.WriteLine("1 - Confirmar");
                        Console.WriteLine("2 - Cancelar");
                        Console.WriteLine("*************");
                        Console.Write("Selecciona una opcion: ");
                        int confirmar = int.Parse(Console.ReadLine());
                        if (confirmar == 1)
                        {
                            Console.WriteLine("");
                            int compra = ( DineroTotal - i.Precio);
                            if (compra >= 0)
                            {
                                int DineroRestante = (DineroTotal - i.Precio);

                                Console.WriteLine($"Compra confirmada, dinero total: {DineroRestante}");
                                Console.WriteLine($"Articulo seleccionado: {i.Nombre}");
                                i.ID = (i.ID - 1);
                                Console.WriteLine($"Existencia: {i.ID}");
                            }
                            else
                            {
                                Console.WriteLine("Dinero insuficiente");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Cancelando compra y regresando el dinero: {DineroTotal}$");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("No se admite ese tipo de Dinero");
                }
            }
           
            catch (Exception e)
            {
                Console.WriteLine("valor invalido");
            }
            //FIN CICLO
            Console.ReadKey();
        }

        //Clase de productos
        public class Productos
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public int Precio { get; set; }
            public int Existencia { get; set; }

        }
    }
}
