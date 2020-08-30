using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIII.Clases
{
    class clsmainmenu
    {
        int opcion = 0;
        public void menu()//Despliega el menu principal
        {
            Console.WriteLine("Bienvenido a Mi Proyecto III de Programacion I\n".PadLeft(200));
            Console.WriteLine("Opciones\n\n".PadLeft(60));
            Console.WriteLine("1.Leer el archivo .csv completo\n");
            Console.WriteLine("2.Crear archivos con Carnet 2019\n");
            Console.WriteLine("3.Crear archivos con Carnet 2018\n");
            Console.WriteLine("4.Creat archivos con Apellidos Perez\n");
            Console.WriteLine("5.Crear archivos con Apellidos Martinez\n");
            Console.WriteLine("6.Archivo con Estudiantes de Seccion 'A'\n");
            Console.WriteLine("7.Archivo con Estudiantes de Seccion 'B'\n");
            Console.WriteLine("8. Salir");
            Console.WriteLine("Introduzca el numero de su opcion de preferencia\n");
            opcion = Convert.ToInt32(Console.ReadLine());
            OpcionSwitch();
        }
        public void OpcionSwitch()
        {
            string opcExit = "";
            clsTextFiles Opc = new clsTextFiles();
            String[] contenido = Opc.ReadFiles(@"C:\tmp\alumnosTexto.csv");
            if (opcion != 8)
            {
                switch (opcion)
                {
                    case 1:
                        Opc.PrintcsvConsole(contenido);
                        break;
                    case 2:
                        Opc.Print2019(contenido);
                        break;
                    case 3:
                        Opc.Print2018(contenido);
                        break;
                    case 4:
                        Opc.PrintPerez(contenido);
                        break;
                    case 5:
                        Opc.PrintMartinez(contenido);
                        break;
                    case 6:
                        Opc.PrintA(contenido);
                        break;
                    case 7:
                        Opc.PrintB(contenido);
                        break;
                }
                Console.WriteLine("\nDesea realizar otra accion?  Si para continuar o enter para cerrar...");
                opcExit = Console.ReadLine();
                if (opcExit.ToLower() == "si")
                {
                    Console.Clear();
                    menu();
                    
                }
            }
            
        }
    }
}
