using System;

namespace ParcialI_09051812085
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su fecha de nacimiento: ");
            string fecha = Console.ReadLine();

            Console.WriteLine("Ingrese su nacinalidad: ");
            string nacionalidad = Console.ReadLine();

            Console.WriteLine("Ingrese su profecion: ");
            string profecion = Console.ReadLine();

            Console.WriteLine("Ingrese su carrera de estudio: ");
            string carrera = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            string edad = Console.ReadLine();

            Console.WriteLine("Escriba sus hobies: ");
            string hobies = Console.ReadLine();

            Console.WriteLine("Ingrese su deporte favorito: ");
            string deporte = Console.ReadLine();

            Console.WriteLine("Ingrese su comida favorita: ");
            string comida = Console.ReadLine();

            Console.WriteLine("Ingrese logros alcanzados: ");
            string logros = Console.ReadLine();

            Console.WriteLine("Ingrese frace que aplica a su vida: ");
            string frace = Console.ReadLine();

            Console.WriteLine("Ingrese lugares que ha visitado : ");
            string lugares = Console.ReadLine();

            Console.WriteLine("Ingrese su libro favorito: ");
            string libro = Console.ReadLine();


            string pagina1 = @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <STYLE type=""text/css"">
   table{
      margin: auto;
      text-align: center;
      border-style: solid;
    
  }
 </STYLE>
</head>
<body>
    <H1>" + nombre + @"</H1>
    <br>
    <p>En esta pagina usted puede encontrar la siguiente informacion<p/>
    <ul>
    <li>Fecha de nacimiento</li>
    <li>Nacionalidad</li>
    <li>Deporte favorito</li>
    <p>entre otros...</p>
    </ul>
    <br>
    <BR>
    <table class=""default"">
    <tr>
    <th>Nombre</th>
     <td>" + nombre + @"</td>
    </tr>
    <tr>
    <th>Fecha de nacimiento</th>
     <td>" + fecha + @"</td>
    </tr>
    <tr>
    <th>Edad</th>
     <td>" + edad + @"</td>
    </tr>
     <tr>
    <th>Nacionalidad</th>
     <td>" + nacionalidad + @"</td>
    </tr>
    <tr>
    <th>Profesion</th>
     <td>" + profecion + @"</td>
    </tr>
     <tr>
    <th>Carrera</th>
     <td>" + carrera + @"</td>
    </tr>
        <tr>
    <th>Hobbies</th>
     <td>" + hobies + @"</td>
    </tr>
    <tr>
    <th>Deportes</th>
     <td>" + deporte + @"</td>
    </tr>
        <tr>
    <th>Comida</th>
     <td>" + comida + @"</td>
    </tr>
        <tr>
    <th>Logros</th>
     <td>" + logros + @"</td>
    </tr>
        <tr>
    <th>Frace de vida</th>
     <td>" + frace + @"</td>
    </tr>
        <tr>
    <th>Lugares</th>
     <td>" + lugares + @"</td>
    </tr>
        <tr>
    <th>Libro</th>
     <td>" + libro + @"</td>
    </tr>
    
    </table>

    <a href=""index.html"">ir a Principal</a>
</body>
</html>";


            string pagina = @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
</head>
<body>
    <h1 algin = ""center"">" + nombre + @"</h1>
    <br>
    <P>Conoce mas acerca de " + nombre + @"</P>
    <BR>
        <a href=""info.html"">ir a contenido</a>
</body>
</html>";


            System.IO.File.WriteAllText(@"C:\tmp\ParcialI\info.html", pagina1);
            System.IO.File.WriteAllText(@"C:\tmp\ParcialI\index.html", pagina);

            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", @"C:\tmp\ParcialI\index.html");
            Console.WriteLine("Hello World!");
        }
    }
}
