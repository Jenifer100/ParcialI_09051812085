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

            Console.WriteLine("Ingrese su profesion: ");
            string profesion = Console.ReadLine();

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

            Console.WriteLine("Ingrese frase que aplica a su vida: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Ingrese lugares que ha visitado : ");
            string lugares = Console.ReadLine();

            Console.WriteLine("Ingrese su libro favorito: ");
            string libro = Console.ReadLine();

            Console.WriteLine("Ingrese su Link de Whatsapp: ");
            string numero = Console.ReadLine();


            Console.WriteLine("Ingrese el link de su facebook: ");
            string facebook = Console.ReadLine();

            Console.WriteLine("Ingrese el link de su instagram: ");
            string instagram = Console.ReadLine();

            Console.WriteLine("Ingrese su correo electronico: ");
            string correo = Console.ReadLine();


            Console.WriteLine("Ingrese la direccion de su fotografia: ");
            string imagen = Console.ReadLine();


            string pagina1 = @"<!DOCTYPE html>
<html lang=""es"">
<head>
<meta charset = ""UTF-8"">
 
<meta http - equiv = ""X-UA-Compatible"" content = ""IE=edge"">
<meta name = ""viewport"" content = ""width=device-width, initial-scale=1.0"">
         
<title> Acerca de mi </title>

    <STYLE type=""text/css"">
   table{
      margin: auto;
      text-align: center;
      border-style: solid;
      border-color: ""Orange"";    
  }
 </STYLE>
</head>
</head>
            

<body bgcolor=""black"">
             
<center>
             
 <font color=""cyan"">            
<font face=""imprint mt shadow"">

<h1 style="" font-size:60px"">" + nombre + @"
                  
 </font>
<br>
<font color=""Yellow"">      
    <p>CONOCE MAS ACERCA DE MI<p/>
<font > 
   <font color=""White"">            
<font face=""Times New Roman"">
<font style="" font-size:20px"" >
<br>
</center>    
    <ul>
    <li>Fecha de nacimiento</li>
    <li>Nacionalidad</li>
    <li>Deporte favorito</li>
<li>Comida favorita</li>
<li>Libro favorito</li>
<li>Edad </li>
<li>Carrera que Estudia</li>
    <p>Entre otros...</p>
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
     <td>" + profesion + @"</td>
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
     <td>" + frase + @"</td>
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


            string pagina = @"
<!DOCTYPE html>
<html lang=""es"">
<head>
<meta charset = ""UTF-8"">
 
<meta http - equiv = ""X-UA-Compatible"" content = ""IE=edge"">
<meta name = ""viewport"" content = ""width=device-width, initial-scale=1.0"">
         
<title> Biografia  </title>
</head>
            

<body bgcolor=""black"">
             
<center>
             
 <font color=""cyan"">            
<font face=""imprint mt shadow"">

<h1 style="" font-size:60px"">" + nombre + @"
                  
 </font>
                  
 <marquee>
<img src=" + imagen + @" alt=""Esto es una imagen"" height=""400"">
 <img src=""07.jpg"" height=""200"">
</marquee>
<hr>
</center>
 <font face=""Comic Sans MS"">
<font color=""white"">
 <header>
<p> <h3>*Estudiante " + carrera + @"
  </h3>
 </p>
  <p>  <h3>*" + profesion + @"
</h3>
 </p>
  <p>  <h3>*" + nacionalidad + @"
 </h3>
  </p>
 <p>  <h3> *Nacio un " + fecha + @"
 </h3>
 </p>
 </header>
<font color=""cyan"">
 <font face=""imprint mt shadow"">
<h1> ********************************************************************************
  </font>
<center>
                                                                  
 <font face=""Comic Sans MS"">
                                                                   
<font color=""white"">
                                                                    
<h2> " + frase + @"
 </center>
                                                                      
</font>
                                                                      

<hr>
                                                                      

</p>
                                                                      

<a href=""logros.html"" target = ""_blank"" style = ""color:bisque"" > Logros Optenidos </ a>
                                                                          
 <hr>
                                                                          
 <a href=""acerca.html"" target = ""_blank "" style = ""color:bisque"" > Conoce mas acerca de mi</ a>
                                                                            
<hr>
                                                                            
<a href=""contacto.html""target = ""_blank"" style = ""color:bisque"" > Contactame </ a>
  
<hr>
                                                                   
                                                                                       <a href=""info.html"">ir a contenido</a>
</body>
</html>";

            string pagina2 = @"<!DOCTYPE html>
<html lang=""es>
<head>
<meta charset = ""UTF-8"">
<meta http - equiv = ""X-UA-Compatible"" content = ""IE=edge"">
<meta name = ""viewport"" content = ""width=device-width, initial-scale=1.0"">
<title> Logros Jenifer Corado </title>
<style type=""text/css"">
body {
background: black;
}
ul {
width: 920px;
margin: 0 auto;
 }
 ul li {
 list - style: none;
}
ul li img {
background - size:cover;
 border - radius: 6px;
float:left;
opacity: 6;
margin - right: 20px;
 height: 350px;
}
ul li img: hover {
 opacity: 1;
 border - radius: 200px;
box - shadow:0px 0px 20px #ddd;
    }
</style>
</head>

<body bgcolor=""black"">
<center>
<h1 style=""color:rgb(236, 146, 229); font-size:80px; font-family:Georgia""> **Logros Obtenidos * *
</font >
 <hr>
 <ul>
 <li> <img src=" + imagen + @" alt=""Esto es una imagen"" height=""400"">
 </li>
 
 </ul>
 <hr>
</center>
<font face = ""Times New Roman"">
 <font color = ""white"">
 <p> <h3> *
 </p>
 
 <hr>
 <font color=""yellow"">
<font face=""imprint mt shadow"">
<h1> *******************************************************************************
 </font>
 <center>
 <font face=""Comic Sans MS"">
   <font color=""white"">
 <h2> Los Limites los pones Tú
 </center>
 </font>
   <hr>
</p>
 <a href =""index.html"" target = ""_blank"" style = ""color:lightsalmon"" > Ir a pagina Principal </a>
 <hr>
</body>
</html>";


            string pagina3 = @"
 <!DOCTYPE html>
  <html lang = ""es>
<head>
<meta charset=""UTF - 8"" >
<meta http - equiv = ""X - UA - Compatible"" content = ""IE = edge"">
<meta name=""viewport"" content = ""width = device - width, initial - scale = 1.0"">
 <title> Contactame </title>
<style type=""text / css"">
 body {
background: black;
 }
            ul {
            width: 920px;
            margin: 0 auto;
            }
            ul li {
                list - style: none;
            }
            ul li img {
                background - size:cover;
                border - radius: 6px;
                float:left;
            opacity: 6;
                margin - right: 20px;
            height: 350px;
            }
            ul li img: hover {
            opacity: 1;
                border - radius: 200px;
                box - shadow:0px 0px 20px #ddd;
    }
</style>
</head>

<body bgcolor=""black"">
   <center>
   <h1 style=""color: rgb(236, 146, 229); font - size:80px; font - family:Georgia"" > **Contactame* *
            </font>
            


                 <font color=""cyan"">
  

      <font face = ""imprint mt shadow"">
   
       <h1> ***********************************************************************************
   
       </font>
   

       <hr>
   
       <ul>
   
           <a href ="+instagram+@" target=""_blank"" style=""color:rgb(240, 105, 51)""> <li><img src = ""in.png"" height=""200""></li></a>
           
           <a href =" + facebook + @" target=""_blank"" style=""color:rgb(18, 32, 231)""><li> <img src=""fb.png"" height=""50""></li></a>
           <a href =" + numero + @"target=""_blank"" style=""color:rgb(151, 230, 24)"">  <li>  <img src = ""wa.png"" height=""50""> </li></a>
           <a href = " + correo + @" > <li> <img src=""co.png"" height=""50""></li></a>
                                       

                                           </ul>
                                       
                                           <font color= ""black"">
                                        
                                            <p>.</p>
                                        
                                            <p>.</p>
                                        
                                            <p>.</p>
                                        </font>
                                        
                                            </center>
                                        <center>
                                        
                                            <font face=""Comic Sans MS"">
                                         
                                             <font color=""white"">
                                          

                                                  <a href=""https://www.instagram.com/jeniifercorado/?hl=es"" target=""_blank"" style = ""color:rgb(240, 105, 51)""> Instagram: " + nombre + @" </a>
                                              
                                                      <a href=""https://www.facebook.com/jenni.corado/"" target = ""_blank"" style=""color:rgb(18, 32, 231)""> FB: " + nombre + @" </a>
                                                   
                                                           <a href =""https://wa.me/50230969276?"" target = ""_blank"" styl =""color:rgb(151, 230, 24)""> Whatsapp:  " + nombre + @" </a>
                                                       
                                                               <a href = ""mailto:jcoradoc5@miumg.edu.gt"" target = ""_blank"" style = ""color:rgb(230, 24, 24)"" > Enviar correo a " + nombre + @" </a>
                                                            
                                                                    <font color =""cyan"">
                                                             

                                                                 <font face=""imprint mt shadow"">
                                                              
                                                                      <h1> ***********************************************************************************
                                                              
                                                                  </font>
                                                              </center>
                                                              
                                                                  <center>
                                                              
                                                                  <font face=""Comic Sans MS"">
                                                               
                                                                   <font color = ""white"">
                                                                
                                                                    <h2>¡Contactame!
                                                                      </center>
                                                                  
                                                                      </font>
                                                                  

                                                                      <hr>
                                                                  

                                                                      </p>
                                                                  

                                                                      <a href=""index.html"" target =""_blank"" style = ""color:bisque"" > Ir a la pagina de inicio </a>
                                                                      
                                                                           <hr>
                                                                      



                                                                          </body>
                                                                      



                                                                          </html>";

            System.IO.File.WriteAllText(@"C:\tmp\ParcialI\acerca.html", pagina1);
            System.IO.File.WriteAllText(@"C:\tmp\ParcialI\index.html", pagina);
            System.IO.File.WriteAllText(@"C:\tmp\ParcialI\logros.html", pagina2);
            System.IO.File.WriteAllText(@"C:\tmp\ParcialI\contacto.html", pagina3);
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", @"C:\tmp\ParcialI\index.html");
            Console.WriteLine("Hello World!");
        }
    }
}

    
