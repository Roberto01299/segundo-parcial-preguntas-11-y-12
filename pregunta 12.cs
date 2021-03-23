using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberto_Michelle_Concepción

{
    class Pregunta 12
    {
        private string[] empleados;
        private float[,] sueldos;
        private float[] sueldo_total;

        public void Cargar()
        {
            empleados = new String[5];
            sueldos = new float[5, 3];
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado:");
                empleados[f] = Console.ReadLine();
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    Console.Write("Ingrese sueldo:");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f, c] = float.Parse(linea);
                }
            }
        }

        public void Calcular_la_Suma_de_Sueldos()
        {
            sueldo_total = new float[5];
            for (int f = 0; f < sueldos.GetLength(0); f++)
            {
                float suma = 0;
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    suma = suma + sueldos[f, c];
                }
                sueldo_total[f] = suma;
            }
        }

        public void Imprimir_Total_Pagado()
        {
            Console.WriteLine("Total de sueldos pagados por empleado.");
            for (int f = 0; f < sueldo_total.Length; f++)
            {
                Console.WriteLine(empleados[f] + " - " + sueldo_total[f]);
            }

        }

        public void Empleado_con_Mayor_Sueldo()
        {
            float mayor = sueldo_total[0];
            string nombre = empleados[0];
            for (int f = 0; f < sueldo_total.Length; f++)
            {
                if (sueldo_total[f] > mayor)
                {
                    mayor = sueldo_total[f];
                    nombre = empleados[f];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es " + nombre + " que tiene un sueldo de " + mayor);
        }

        static void Main(string[] args)
        {
            Pregunta 12 Roberto_Michelle_Concepción = new Proyecto_final();
            Roberto_Michelle_Concepción.Cargar();
            Roberto_Michelle_Concepción.Calcular_la_Suma_de_Sueldos();
            Roberto_Michelle_Concepción.Imprimir_Total_Pagado();
            Roberto_Michelle_Concepción.Empleado_con_Mayor_Sueldo();
            Console.ReadKey();
        }
    }
}