using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIII.Clases
{
    class clsTextFiles
    {
        public string[] ReadFiles(String file) //Lee los archivos agregando un parametro string
        {
            String content = String.Empty;//Declaramos un string vacio
            string[] lines;//array para almacenar informacion
            if (File.Exists(file)) //Este If corre solamente si el archivo brindado existe
            {
                //getencoding(850) hace ref a Western European (DOS) lo cual nos permite leer tildes y ñ
                using (StreamReader sr = new StreamReader(file, Encoding.GetEncoding(850)))//abre el archivo y su contenido

                {
                    content = sr.ReadToEnd();
                    lines = content.Split('\n');
                }
                
            }
            else
            {
                lines = new string[0];
                lines[0] = "No existe el archivo";
            }
            return lines;
        }

        public String contains(string cadena, string clave = "r")
        {
            string retorno = "";
            if (cadena.ToLower().Contains(clave.ToLower()))
            {
                retorno = clave;
            }
            else
            {
                retorno = "";
            }
            return retorno;
        }
        public void PrintcsvConsole(string[] content)//Muestra el contenido del archivo csv en pantalla
        {
            foreach (string linea in content)
            {
                string[] data = linea.Split(','); 
                if (data.Length > 1)
                {
                    Console.WriteLine("Apellidos:" + data[0].PadLeft(25) + "|Nombre:".PadRight(15) + data[1].PadLeft(25) + "|Correo:".PadRight(15) + data[2].PadLeft(25) + "|Carne: ".PadRight(7) + data[3]);
                }
            }
        }
        public void Print2019(string[] content)//Imprime los alumnos 2019
        {
            StreamWriter sw = File.AppendText(@"C:\tmp\folder\alumnos2019.csv");//Creamos o modificamos el archivo usando Append
            foreach (string linea in content)//Recorre el array content obtenido en el directorio asignado en nuestro caso alumnos.csv
            {
                string[] data = linea.Split(',');//Divide la informacion y la inserta en el array data

                if (linea.ToLower().Contains("19-") == true) // Imprime carnet 2019 
                {
                    if (data.Length > 1)
                    {
                        sw.Write(linea, Encoding.GetEncoding(850));//Escribe la informacion con el formato western msdos 
                        //Imprime en pantalla el array data justificando los datos hacia la derecha
                        Console.WriteLine("Apellidos:" + data[0].PadLeft(25) + "|Nombre:".PadRight(15) + data[1].PadLeft(25) + "|Correo:".PadRight(15) + data[2].PadLeft(25) + "|Carne: ".PadRight(7) + data[3]);
                    }

                }
            }
            sw.Close();
        }
        public void Print2018(string[] content)//Imprime los alumnos 2018
        {
            StreamWriter sw = File.AppendText(@"C:\tmp\folder\alumnos2018.csv");
            foreach (string linea in content)
            {
                string[] data = linea.Split(',');

                if (linea.ToLower().Contains("18-") == true) // Imprime carnet 2018 
                {
                    if (data.Length > 1)
                    {
                        sw.Write(linea, Encoding.GetEncoding(850));
                        Console.WriteLine("Apellidos:" + data[0].PadLeft(25) + "|Nombre:".PadRight(15) + data[1].PadLeft(25) + "|Correo:".PadRight(15) + data[2].PadLeft(25) + "|Carne: ".PadRight(7) + data[3]);
                    }

                }
            }
            sw.Close();
        }
        public void PrintPerez(string[] content)//Imprime los alumnos con apellido Perez
        {
            StreamWriter sw = File.AppendText(@"C:\tmp\folder\alumnosPerez.csv");
            foreach (string linea in content)
            {
                string[] data = linea.Split(',');

                if (linea.ToLower().Contains("perez") == true) // Imprime carnet 2019 
                {
                    
                    int result = data.GetLength(0); //obtiene la longitud del array
                    if (data.Length > 1)
                    {
                        sw.Write(linea, Encoding.GetEncoding(850));
                        Console.WriteLine("Apellidos:" + data[0].PadLeft(25) + "|Nombre:".PadRight(15) + data[1].PadLeft(25) + "|Correo:".PadRight(15) + data[2].PadLeft(25) + "|Carne: ".PadRight(7) + data[3]);
                    }

                }
            }
            sw.Close();
        }
        public void PrintMartinez(string[] content)//Imprime los alumnos con apellido Martinez
        {
            StreamWriter sw = File.AppendText(@"C:\tmp\folder\alumnosMartinez.csv");
            foreach (string linea in content)
            {
                string[] data = linea.Split(',');

                if (linea.ToLower().Contains("martinez") == true) // Imprime carnet 2019 
                {

                    int result = data.GetLength(0); //obtiene la longitud del array
                    if (data.Length > 1)
                    {
                        sw.Write(linea, Encoding.GetEncoding(850));
                        Console.WriteLine("Apellidos:" + data[0].PadLeft(25) + "|Nombre:".PadRight(15) + data[1].PadLeft(25) + "|Correo:".PadRight(15) + data[2].PadLeft(25) + "|Carne: ".PadRight(7) + data[3]);
                    }

                }
            }
            sw.Close();
        }
        public void PrintA(string[] content)//Imprime los alumnos de la seccion A
        {
            clsTextFiles rf = new clsTextFiles();
            int i = 0;
            StreamWriter sw = File.AppendText(@"C:\tmp\folder\alumnosSeccionA.csv");
            String[] contenido =rf.ReadFiles(@"C:\tmp\alumnosTexto.csv");
            foreach (string line in content)
            {
                string[] data = line.Split(',');
                if (rf.contains(line, "otra") == "otra")
                {
                    i = 1;
                }
                else
                {
                    if (i < 1)//Imprime todo mientras que i sea menor a 1 lo cual se vuelve true cuando se encuentra la palabra otra
                    {
                        if (data.Length > 1)
                        {
                            sw.Write(line, Encoding.GetEncoding(850));
                            Console.WriteLine("Apellidos:" + data[0].PadLeft(25) + "|Nombre:".PadRight(15) + data[1].PadLeft(25) + "|Correo:".PadRight(15) + data[2].PadLeft(25) + "|Carne: ".PadRight(7) + data[3]);
                        }
                    }
                }
            }
            sw.Close();
            }
        public void PrintB(string[] content)//Imprime los alumnos de la seccion B
        {
            clsTextFiles rf = new clsTextFiles();
            int i = 0;
            StreamWriter sw = File.AppendText(@"C:\tmp\folder\alumnosSeccionB.csv");
            String[] contenido = rf.ReadFiles(@"C:\tmp\alumnosTexto.csv");
            foreach (string line in content)
            {
                string[] data = line.Split(',');
                if (rf.contains(line, "otra") == "otra")
                {
                    i = 1;
                }
                else
                {
                    if (i == 1)//Imprime todo desde que i sea igual a 1 lo cual se vuelve true cuando se encuentra la palabra otra
                    {
                        if (data.Length > 1)
                        {
                            sw.Write(line, Encoding.GetEncoding(850));
                            Console.WriteLine("Apellidos:" + data[0].PadLeft(25) + "|Nombre:".PadRight(15) + data[1].PadLeft(25) + "|Correo:".PadRight(15) + data[2].PadLeft(25) + "|Carne: ".PadRight(7) + data[3]);
                        }
                    }
                }
            }
            sw.Close();
        }

    }
}
