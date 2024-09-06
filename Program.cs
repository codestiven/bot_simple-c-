

bool afirmacion = true;

List<Name> nombres = new List<Name>();


if (System.IO.File.Exists("YourName.json"))
{
    var archivo = System.IO.File.ReadAllText("YourName.json");



        nombres = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Name>>(archivo);



}
else
{


    Clases.Scolor(@"
  ___ ___ ___  
 |__ \__ \__ \ 
    ) | ) | ) |
   / / / / / / 
  |_| |_| |_|  
  (_) (_) (_)  
             

cual es tu nombre :", "A", false);

    var Name = Console.ReadLine() ?? "";

    var algo = new Name();

    algo.Id = 1;

    algo.Nombre = Name;



    nombres.Add(algo);


    var json = Newtonsoft.Json.JsonConvert.SerializeObject(nombres);

    System.IO.File.WriteAllText("YourName.json", json);


   
    var archivo = System.IO.File.ReadAllText("YourName.json");
    nombres = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Name>>(archivo);
}



string baba = ";";
foreach (var palabra in nombres)
{

    baba = palabra.Nombre;
};



    while (afirmacion)
{

 





    Console.Clear();

    string solicitud = @$"

               _______
             _/       \_
            / |       | \
           /  |__   __|  \
          |__/((o| |o))\__|
          |      | |      |
          |\     |_|     /|
          | \           / |
           \| /  ___  \ |/
            \ | / _ \ | /
             \_________/
              _|_____|_
         ____|_________|____
        /                   \  
Bienvenido {baba} al itla, que desea preguntar: ";
    Clases.Scolor(solicitud , "V" , false);
    string posEntrada = Console.ReadLine() ?? "";
    string entrada = posEntrada.ToLower();


    //como me llamo---------------------------------------------------------------

    if (entrada.Contains("como") && entrada.Contains("llamo") || entrada.Contains("cual") && entrada.Contains("nombre"))
    {


        Console.WriteLine(@$"tu te llamas {baba}");

        Console.ReadKey();

    }
   else if (entrada.Contains("cambiar") && entrada.Contains("nombre") || entrada.Contains("otro") && entrada.Contains("nombre"))
    {

        Clases.Scolor("cual es tu nombre :", "A", false);

        var Name = Console.ReadLine() ?? "";

        var algo = new Name();

        algo.Id = 1;

        algo.Nombre = Name;



        nombres.Add(algo);


        var json = Newtonsoft.Json.JsonConvert.SerializeObject(nombres);

        System.IO.File.WriteAllText("YourName.json", json);


        var archivo = System.IO.File.ReadAllText("YourName.json");
        nombres = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Name>>(archivo);

        foreach (var palabra in nombres)
        {

            baba = palabra.Nombre;
        };

        Clases.Scolor("Nombre cambiado con exito", "A", false);

    }


    // Que carreras imparten itla -----------------------------------------------

    else if (entrada.Contains("carrera") && entrada.Contains("itla")){ 
        string salida = @"
Contamos con seis centros de excelencia y quince carreras técnicas en las áreas de

Redes
Software
Multimedia
Sonido
Mecatrónica
Manufactura Automatizada
Diseño Industrial
Manufactura de Dispositivos Médicos
Seguridad Informática, Analítica en Ciencia de los Datos
Informática Forense 
Energías Renovables
";
        Clases.Scolor(salida, "E", false);



}


 //Detalles sobre una carrera especifica. ------------------------------------------------------------
    else if (entrada.Contains("redes"))
    {
        string salida = @"
Diseñar, implementar y gestionar arquitecturas de redes empresariales, desarrollando su práctica profesional con una fuerte orientación a la resolución de problemas contemporáneos, adaptándose a escenarios cambiantes, con alto sentido innovador y apegándose a los principios éticos y legales de la profesión.
";
        Clases.Scolor(salida, "E", false);
    }

    else if (entrada.Contains("software"))
    {
        string salida = @"
Al concluir el Tecnólogo en Desarrollo de Software conocerás todas las etapas que intervienen en el proceso de desarrollo de software, enfocándose en la práctica de las tareas más técnicas.
";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("multimedia"))
    {
        string salida = @"
Al concluir el Tecnólogo en Multimedia serás capaz de brindar soluciones de comunicación audiovisual de forma creativa y eficaz que den respuesta a las necesidades del sector empresarial, educativo e industria en general. Con una formación altamente orientada a la praxis, podrás adquirir las competencias esenciales en el uso de técnicas y tecnologías que permitan conceptualizar, diseñar y ejecutar proyectos de comunicación comercial y corporativa por medio de la animación 2D y 3D, diseño gráfico, web y editorial, ilustración, video y audio digital en agencias de publicidad, televisión y casas editoras, con alto sentido crítico e innovador, orientado a las tendencias y necesidades del mercado, fomentando el espíritu emprendedor.";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("sonido"))
    {
        string salida = @"
Al concluir el Tecnólogo en Sonido, contarás con las competencias necesarias para diseñar, desarrollar y supervisar la ejecución de proyectos de sonido por medio de técnicas y softwares de audio digital aplicables para audiovisuales, la radio, industria discográfica y del entretenimiento, desde espectáculos musicales hasta eventos corporativos, con sentido ético y responsable.";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("mecatronica"))
    {
        string salida = @"
Como egresado del Tecnólogo en Mecatrónica dominarás la automatización de procesos de manufactura, integrando componentes mecánicos, eléctricos, electrónicos y de software aplicado al control. Podrás aplicar los procesos de producción la automatización para hacerlos más eficientes y emplear sistemas de control en los mismos.
";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("manufactura ") || entrada.Contains("automatizada"))
    {
        string salida = @"
Al concluir el Tecnólogo en Sonido, contarás con las competencias necesarias para diseñar, desarrollar y supervisar la ejecución de proyectos de sonido por medio de técnicas y softwares de audio digital aplicables para audiovisuales, la radio, industria discográfica y del entretenimiento, desde espectáculos musicales hasta eventos corporativos, con sentido ético y responsable.";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("industria"))
    {
        string salida = @"
Al finalizar el tecnólogo de Diseño Industrial estarás preparado para desempeñar labores en procesos de diseño y manufactura asistida por computador, construcción de componentes como moldes, los cuales permiten grandes volúmenes de fabricación; obtendrás destrezas en operaciones de construcción de maquetas, así como el manejo de materiales.

";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("medico"))
    {
        string salida = @"
Al concluir el Tecnólogo de Manufactura de Dispositivos Médicos podrás desempeñar una serie de posiciones de índole industrial y/o manufactura, dentro de un ambiente de trabajo de manufactura de dispositivos médicos, adquiriendo competencias como, potencial para identificar, analizar y resolver problemas técnicos en el funcionamiento del equipo médico, realizar operaciones de manufactura integrada por computador (CIM), operar y manejar con destreza máquinas herramientas programables, habilidades en el campo de la automatización de procesos.
";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("Seguridad") && entrada.Contains("informática"))
    {
        string salida = @"
Planificar, diseñar, implementar y administrar arquitecturas de ciberseguridad de acuerdo con las necesidades globales actuales, desempeñando sus funciones con un enfoque sólido de resolución de problemas complejos; siendo versátil, con actitud innovadora, ética, y de liderazgo.";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("ciencia") && entrada.Contains("datos"))
    {
        string salida = @"
Al finalizar el Tecnólogo en Analítica y Ciencia de los datos contarás con competencias para manejar de las técnicas y herramientas aplicables a la analítica de datos con el objetivo de proponer soluciones basadas en evidencias y ser aplicadas en el mercado local e internacional.
";
        Clases.Scolor(salida, "E", false);
    }
    else if (entrada.Contains("seguridad") && entrada.Contains("forense"))
    {
        string salida = @"
Planificar, gestionar y ejecutar investigaciones forenses que permitan identificar, preservar y presentar datos electrónicos válidos dentro de un proceso legal, ejerciendo su profesión con una fuerte orientación a la resolución de problemas complejos; adaptándose a los constantes cambios, con actitud emprendedora y ética.";
        Clases.Scolor(salida, "E", false);
    }

    else if (entrada.Contains("energías") && entrada.Contains("renovables"))
    {
        string salida = @"
Al concluir el Tecnólogo en Energías Renovables, obtendrás conocimiento sobre la instalación, operación y mantenimiento de proyectos de pequeña y mediana escala de Energías Renovables para las actividades productivas de los distintos sectores industriales. Además, recibirás una importante formación matemática y eléctrica; estarás preparado para desarrollar proyectos de emprendimiento asociados a las Energías Renovables. Esta carrera promueve el desarrollo de personas integrales comprometidas con la sociedad, integrando la ética y el desarrollo de las competencias necesarias para el mundo de hoy como la capacidad de trabajar en equipo, así como también, la capacidad de generar ideas innovadoras, de aprender y actualizarse permanentemente.";
        Clases.Scolor(salida, "E", false);
    }



    //Quien es su rector ------------------------------------------------------------
    else if (entrada.Contains("rector"))
    {
        string salida = @"
El rector del Instituto Tecnológico de las Américas (ITLA), Omar Méndez Lluberes, reveló que el Gobierno dominicano está desarrollando un sistema que permitirá enlazar todas las instituciones del Estado bajo un mismo programa.



El rector del Instituto Tecnológico de las Américas (ITLA), Omar Méndez Lluberes, reveló que el Gobierno dominicano está desarrollando un sistema que permitirá enlazar todas las instituciones del Estado bajo un mismo programa.



Méndez Lluberes ofreció estas declaraciones durante el Desayuno de elCaribe y CDN, donde dio detalles del proyecto.

“Vamos a tener un solo sistema para Recursos Humanos, con indicadores de desempeño, con indicadores institucionales, con selección, con reclutamientos, contrataciones; vamos también a tener el PEI, el Plan Estratégico, la nómina, los módulos financieros, contables, cuentas por pagar por cobrar, inventario, activos fijos, entre otros”, explicó el rector del ITLA.

Agregó que también estarán integrados de manera digital el Archivo General de la Nacional, además de la Firma Digital en el SIGEI.
";
        Clases.Scolor(salida, "A", false);

    }

    //Preguntar quien es amadis. -------------------------------------------------------
    else if (entrada.Contains("amadis") || entrada.Contains("suarez") || entrada.Contains("genao"))
    {
        var uri = "https://adamix.net/web/";
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        System.Diagnostics.Process.Start(psi);


    }
    //Si le pregunta por su autor el programa dira sus datos. --------------------------------

    else if (entrada.Contains("autor") || entrada.Contains("creador") || entrada.Contains("stiven") || entrada.Contains("20220457") || entrada.Contains("2022-0457"))
    {
        Console.Clear();
        Clases.color_R();
        Console.WriteLine(@"
	  /$$$$$$   /$$     /$$                              
	 /$$__  $$ | $$    |__/                              
	| $$  \__//$$$$$$   /$$ /$$    /$$ /$$$$$$  /$$$$$$$ 
	|  $$$$$$|_  $$_/  | $$|  $$  /$$//$$__  $$| $$__  $$
	 \____  $$ | $$    | $$ \  $$/$$/| $$$$$$$$| $$  \ $$
	 /$$  \ $$ | $$ /$$| $$  \  $$$/ | $$_____/| $$  | $$
	|  $$$$$$/ |  $$$$/| $$   \  $/  |  $$$$$$$| $$  | $$
	 \______/   \___/  |__/    \_/    \_______/|__/  |__/
                                                     
	 ___   ___  ___   ___        ___    __   ___  ___ 
	(__ \ / _ \(__ \ (__ \ ___  / _ \  /. | | __)(__ )
	 / _/( (_) )/ _/  / _/(___)( (_) )(_  _)|__ \ / / 
	(____)\___/(____)(____)     \___/   (_) (___/(_/                                                       
                                             
"); Clases.color_R();
        Console.WriteLine(@"

matricula : 2022-0457
nombre : Stiven 
apellido : de la rosa brito 







");
        Console.ReadKey();
    }


    //que dia es hoy------------------------------------------------------------
    else if (entrada.Contains("dia") && entrada.Contains("hoy"))
    {
        DateTime fecha = DateTime.Now;
        var dia = "";

        string hola = fecha.DayOfWeek.ToString();
        if (hola == "Monday")
        {
            dia = "lunes";
        }
        else if (hola == "Tuesday")
        {
            dia = "martes";
        }
        else if (hola == "Wednesday")
        {
            dia = "miercoles";
        }
        else if (hola == "Thursday")
        {
            dia = "jueves";
        }
        else if (hola == "Friday")
        {
            dia = "viernes";
        }
        else if (hola == "Saturday")
        {
            dia = "sabado";
        }
        else if (hola == "Sunday")
        {
            dia = "domingo";
        }
        else
        {
            dia = fecha.DayOfWeek.ToString();
        }






        Console.Write($"hoy es ");
        Clases.color_R();
        Console.WriteLine($"{dia}");
        Console.ResetColor();
    }
    //que hora es hoy------------------------------------------------------------

    else if (entrada.Contains("hora"))
    {
        var hora = string.Format("{0:hh:mm tt}", DateTime.Now);






        Console.Write($"son las ");
        Clases.color_R();
        Console.WriteLine($"{hora}");
        Console.ResetColor();



        Console.ReadKey();

    }
    //donde esta el itla ------------------------------------------------------------
    else if (entrada.Contains("donde") && entrada.Contains("itla")) { 
        string salida = @"
el itla esta en Autopista Las Américas, Km. 27, PCSD, La Caleta, Boca Chica 
";


    Clases.Scolor(salida, "E", false);



        Console.Write("desea ver el mapa S o N :");

        string cosas = Console.ReadLine()??"";

        while(cosas != "s" && cosas != "S" && cosas != "n" && cosas != "N")
        {
            Console.Write("seleccione S o N :");

            cosas = Console.ReadLine() ?? "";
            cosas = cosas.ToLower();
        }

        if (cosas == "s")
        {
            var uri = "https://www.google.com/search?rlz=1C1YTUH_esDO1005DO1005&q=donde+esta+el+itla&npsic=0&rflfq=1&rldoc=1&rllag=18956516,-70177019,77815&tbm=lcl&sa=X&ved=2ahUKEwjjwoyu_aD5AhVySDABHdA5BwMQtgN6BAgSEAE&biw=1600&bih=789&dpr=1#rlfi=hd:;si:;mv:[[19.08601680835555,-69.00241406367188],[18.261192786208387,-70.62289746210938],null,[18.674106441149956,-69.81265576289063],10]";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);

        }

    }

    //Cual sera la nota final de tu dueño en la materia de fundamentos.------------------------------------------------------------
   else if (entrada.Contains("cual") && entrada.Contains("nota"))
    {
        Console.Clear();
        string salida = @"

   __     ______    ______   __    __ 
 _/  |   /      \  /      \ /  |  /  |
/ $$ |  /$$$$$$  |/$$$$$$  |$$/  /$$/ 
$$$$ |  $$$  \$$ |$$$  \$$ |    /$$/  
  $$ |  $$$$  $$ |$$$$  $$ |   /$$/   
  $$ |  $$ $$ $$ |$$ $$ $$ |  /$$/    
 _$$ |_ $$ \$$$$ |$$ \$$$$ | /$$/  __ 
/ $$   |$$   $$$/ $$   $$$/ /$$/  /  |
$$$$$$/  $$$$$$/   $$$$$$/  $$/   $$/                                   
";
        Clases.Scolor(salida, "Ra", false);

        string salida2 = @"

la nota de el creador de esta pagina sera probablemente de un 100% pero con un punto menos :(";
        Clases.Scolor(salida2, "Ra", false);



        Console.ReadKey();
    }

    //como se llegua al itla -----------------------------------------------------
    else if (entrada.Contains("como") && entrada.Contains("itla"))
    {
        string salida = @"
1 -Ingresar a la página web transporte.itla.edu.do.
2 -Realizar solicitud de ticket.
3 - Reservar los tickets solicitados.
5 - Entregar el ticket de reservación a la hora de abordar el autobús.
";


        Clases.Scolor(salida, "Ra", false);





    }
    else
    {
        string salida = @"
Lo sentimos , no entendimos lo que desea preguntar
";


        Clases.Scolor(salida, "R", false);
    }

    //Si le pregunta por su autor el programa dira sus datos. ----------------------------------------------------------


    Console.ReadKey();
}










