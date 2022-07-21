using System.IO;
using System.Data;
using System.Collections;
public class Program
{
    private static void Main(string[] args)
    {

       // string archivo = @"Historial.txt";
        StreamWriter escritura = new StreamWriter("Historial.txt"); /// para escribir en el fichero que ya existe

        string hora_actual;
        string fecha_actual;
        string nombre;
        fecha_actual = DateTime.Now.ToString("dd-MM-yyyy");
        escritura.WriteLine("FECHA DE REALIZACION DE EJERCICIO "+ fecha_actual);
        Console.WriteLine("INGRESE SU NOMBRE: ");
        nombre = Console.ReadLine();
        escritura.WriteLine("NOMBRE ESTUDIANTE: "+ nombre);
       // IEnumerable<string> line = File.ReadLines(archivo);
        //Console.WriteLine(String.Join(Environment.NewLine, line));
        int opc = 0, puntos=0;
        do
        { 
            Console.Clear();
            Console.WriteLine("       ===========================");
            Console.WriteLine("           ESTU==SOCIAL==EDU");
            Console.WriteLine("       =========BIENVENIDOS========");
            Console.WriteLine("APLICACION DE ESTUDIOS SOCIALES / EDUCACION");
            Console.WriteLine("       ===========================");
            Console.WriteLine("  ");
            Console.WriteLine("       ==========  MENU  ==========");
            Console.WriteLine("           1. VERDADERO O FALSO");
            Console.WriteLine("           2. ELECCION UNICA");
            Console.WriteLine("           3. COMPLETE");
            Console.WriteLine("           4. SALIR");
            Console.WriteLine("       ===========================");
            try
            {
                opc = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
            if (opc <1 || opc >4 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
                Console.Clear();

                    switch (opc)
                    {
                        case 1:
                        puntos = V_F();
                        Console.WriteLine("EL PUNTAJE ALCANZADO EN LA ACTIVIDAD VERDADERO Y FALSO FUE DE: "+puntos+" DE 100");
                        escritura.WriteLine("");
                        escritura.WriteLine("-------------------------------");
                        escritura.WriteLine("--ACTIVIDAD VERDADERO Y FALSO--");
                        escritura.WriteLine("-------PUNTAJE OBTENIDO-------");
                        escritura.WriteLine(    puntos+" DE 100.");
                        hora_actual = DateTime.Now.ToString("hh:mm:ss tt"); //obtiene la hora exacta en que se realizo el ejercicio
                        escritura.WriteLine("HORA DE REALIZACION: "+ hora_actual);
                        escritura.WriteLine("");
                        Console.ReadKey();
                        Console.Clear();
                        opc = cerrar_programa();
                        break;
                        case 2:
                        puntos = ELECCION_UNICA();
                        Console.WriteLine("EL PUNTAJE ALCANZADO EN LA ACTIVIDAD ELECCION UNICA FUE DE: "+puntos+" DE 40");
                        escritura.WriteLine("");
                        escritura.WriteLine("-------------------------------");
                        escritura.WriteLine("--ACTIVIDAD ELECION MULTIPLE--");
                        escritura.WriteLine("-------PUNTAJE OBTENIDO-------");
                        escritura.WriteLine(    puntos+" DE 40.");
                        hora_actual = DateTime.Now.ToString("hh:mm:ss tt"); //obtiene la hora exacta en que se realizo el ejercicio
                        escritura.WriteLine("HORA DE REALIZACION: "+ hora_actual);
                        escritura.WriteLine("");
                        Console.ReadKey();
                        Console.Clear();
                        opc = cerrar_programa();
                        break;
                        case 3:
                        puntos = COMPLETE();
                        Console.WriteLine("EL PUNTAJE ALCANZADO EN LA ACTIVIDAD COMPLETE FUE DE: "+puntos+" 50");
                        Console.ReadKey();
                        Console.Clear();
                        escritura.WriteLine("");
                        escritura.WriteLine("-------------------------------");
                        escritura.WriteLine("--ACTIVIDAD COMPLETE--");
                        escritura.WriteLine("-------PUNTAJE OBTENIDO-------");
                        escritura.WriteLine(    puntos+" DE 50.");
                        hora_actual = DateTime.Now.ToString("hh:mm:ss tt"); //obtiene la hora exacta en que se realizo el ejercicio
                        escritura.WriteLine("HORA DE REALIZACION: "+ hora_actual);
                        escritura.WriteLine("");
                        opc = cerrar_programa();
                        break;
                       
                        case 4:
                           
                            Console.WriteLine("HA SELECCIONADO LA OPCION SALIR");
                            Console.WriteLine("       HASTA LUEGO :=)");
                            Console.ReadKey();
                            Console.Clear();
                            escritura.Close();
                            StreamReader read = new StreamReader("Historial.txt");
                            string linea;
                            ArrayList lectura = new ArrayList();
                            while ((linea = read.ReadLine()) != null)
                            {
                                        lectura.Add(linea);
                            }
                            foreach (var item in lectura)
                            {
                                Console.WriteLine(item);
                            }
                            Console.ReadKey();
                            Console.Clear();
                            Environment.Exit(0);                       
                        break;
                    }

        } while (opc >=1 || opc <=4);

       static int cerrar_programa()
    {
        int opc=0,var=0;
        bool bandera = true;
        do{ 
            try
            {
            Console.Clear();
            Console.WriteLine("¿DESEA SALIR?");
            Console.WriteLine("PRESIONE: ");
            Console.WriteLine("0: PARA SALIR");
            Console.WriteLine("1: PARA IR AL MENU PRINCIPAL");
            opc = Convert.ToInt32( Console.ReadLine());
            if (opc == 0)
                {
                    var = 4;
                }
            else
            {
                var =0;
            }
            }catch(FormatException)
            {
                    Console.Clear();
                    Console.WriteLine("DEBE INGRESAR UN VALOR NUMERICO PARA SU DESICION");
                    Console.WriteLine("MIENTRAS NO LO HAGA EL PROGRAMA NO CONTINUARA...");
                    Console.ReadKey();
                    bandera = false;
            }
            if (opc <0 || opc >1 )
                {
                    Console.Clear();
                    Console.WriteLine("OPCION SELECCIONADA FUERA DEL INDICE");
                    Console.WriteLine("INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                    bandera = false;
                }
                Console.Clear();
        } while (bandera == false);

        return var;

    }

        static int V_F()
    {
        int puntaje=0,opcion =0;
        Console.Clear();
        Console.WriteLine("         ========================================");
        Console.WriteLine("         =========  VERDADERO Y FALSO  ==========");
        Console.WriteLine("         ========================================");
        Console.WriteLine("===============SELECCIONE VERDADERO O FALSO ====================");
        Console.WriteLine("===============A LAS SIGUIENTES ASEVERACIONES===================");
        Console.WriteLine("   ");
        Console.WriteLine("       PRESIONE CUALQUIER TECLA PARA COMENZAR...");
        Console.ReadKey();
        Console.Clear();

        do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("1. LOS RELIEVES SON DIVERSAS FORMAS QUE PRESENTA");
            Console.WriteLine("                LA SUPERFICIE");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;

        do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("2. LOS MAPAS SIRVEN PARA TRABAJAR LOS DIVERSOS");
            Console.WriteLine("                RELIEVES");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;

do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("       3. LAS LLANURAS SON RELIEVES PLANOS");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;
       
       do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("4. LAS MONTAÑAS SON PRESENTADAS EN LOS MAPAS");
            Console.WriteLine("                EN COLOR VERDE");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;


        do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("    5. EL RELIEVE DE CENTROAMERICA ESTA FORMADO");
            Console.WriteLine("                POR ELEMENTOS NATURALES");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;

        do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("6. LA FLORA Y FAUNA ES EL CONJUNTO DE SERES VIVOS");
            Console.WriteLine("     QUE FORMAN PARTE DE UN ECOSISTEMA");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;

do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("7. EL LEON, EL CAIMAN, EL TIGRE DE VENGALA, LA CEBRA");
            Console.WriteLine(" EL LEOPARDO SON ANIMALES COMUNES EN CENTROAMERICA");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;

    do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("8. EL RESPETO A LOS PERIODOS DE REPRODUCCIONDE LOS");
            Console.WriteLine("ANIMALES Y LA NO CAZ DE LOS MISMOS ES UNA FORMA DE");
            Console.WriteLine("CUIDAR LA FAUNA");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;

         do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("9. HURACANES, TERREMOTOS, SEQUIAS, INUNDACIONES");
            Console.WriteLine("Y ERUPCIONES VOLCANICAS SON DESASTRES A LOS QUE");
            Console.WriteLine("ESTA PROPENSO EL CONTIENTE AMERICANO");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        Console.Clear();
        opcion = 0;
     do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("10. LAS ACCIONES HUMANAS QUE AMENAZAN A LOS ");
            Console.WriteLine("RECURSOS NATURALES SE LES CONOCE COMO AMENAZAS");
            Console.WriteLine("DE RANGO CINCO");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. --VERDADERO--");
            Console.WriteLine("2. --FALSO--");
            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >2 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 2) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >2);

        return puntaje;
    }


        static int ELECCION_UNICA()
        {
            int puntaje=0,opcion =0;
        Console.Clear();
        Console.WriteLine("         ========================================");
        Console.WriteLine("         ===========  SELECCION UNICA  ==========");
        Console.WriteLine("         ========================================");
        Console.WriteLine("===SELECCIONE LA OPCION QUE CONSIDERE CORRECTA =======");
        Console.WriteLine("======================================================");
        Console.WriteLine("   ");
        Console.WriteLine("       PRESIONE CUALQUIER TECLA PARA COMENZAR...");
        Console.ReadKey();
        Console.Clear();

        do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("1. LAS ZONAS CLIMATICAS SE PRODUCEN PORQUE LOS RAYOS DEL SOL");
            Console.WriteLine("   LLEGAN A LAS DISTINTAS PARTES DE LA TIERRA:");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. CON DISTINTA INCLINACION");
            Console.WriteLine("2. DE IGUAL FORMA ");
            Console.WriteLine("3. CASI NO LLEGAN");

            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >3 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >3);

        Console.Clear();
        opcion = 0;

         do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("2. LA ATMOSFERA ESTA COMPUESTA POR: ");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. UNA MEZCLA DE GASES Y AEROSOLES");
            Console.WriteLine("2. DIOXIDO DE CARBONO");
            Console.WriteLine("3. ENERGIA QUE SE COMPONE DEL SOL");

            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >3 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >3);
        
        Console.Clear();
        opcion = 0;

        
         do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("3. EL CLIMA GLOBAL ESTA COMPUESTO POR: ");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. TROPOSFERA, MESOSFERA, TERMOSFERA");
            Console.WriteLine("2. TROPOSFERA, BIOSFERA, GEOSFERA");
            Console.WriteLine("3. ATMOSFERA, CRIOSFERA, BIOSFERA, GEOSFERA");

            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >3 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 3) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >3);
        
        Console.Clear();
        opcion = 0;

          do{ 
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("4. LAS CARACTERISTICAS DEL CLIMA SON: ");
            Console.WriteLine("====================================================");
            Console.WriteLine("1. TEMPERATURA, HUMEDAD Y PRESION");
            Console.WriteLine("2. ACCIDENTES GEOFRAFICOS");
            Console.WriteLine("3. MONTAÑAS Y MARES");

            try
            {
               opcion = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("         ===============================");
                Console.WriteLine("         =========  ERROR!!!  ==========");
                Console.WriteLine("         ===============================");
                Console.WriteLine("   ");
                Console.WriteLine("        ES NECESARIO QUE INGRESE UN NUMERO");
                Console.WriteLine("SI INGRESA UN VALOR DIFERENTE EL PROGRAMA NO INICIARA...");
                Console.WriteLine("              INTENTE NUEVAMENTE...");
                Console.ReadKey();
            }
       
            if (opcion <1 || opcion >3 )
                {
                    Console.Clear();
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("         =========  ERROR!!!  ==========");
                    Console.WriteLine("         ===============================");
                    Console.WriteLine("   ");
                    Console.WriteLine("HA INGRESADO UNA OPCION QUE ESTA FUERA DEL INDICE ESTABLECIDO");
                    Console.WriteLine("                INTENTE NUEVAMENTE...");
                    Console.ReadKey();
                }
            if (opcion == 1) 
                {
                    puntaje+=10;
                }
                Console.Clear();
        } while (opcion <1 || opcion >3);
        
        Console.Clear();
       

        return puntaje;
        }  
    
        static int COMPLETE()
        {
            int puntaje=0;
            string respuesta = "ATLANTICA";
            string cadena;
            Console.Clear();
            Console.WriteLine("       ========================================");
            Console.WriteLine("       ===============  COMPLETE  =============");
            Console.WriteLine("       ========================================");
            Console.WriteLine("======RESPONDA CADA ESPACIO VACIO DE LAS PREGUNTAS =======");
            Console.WriteLine("======================================================");
            Console.WriteLine("   ");
            Console.WriteLine("       PRESIONE CUALQUIER TECLA PARA COMENZAR...");
            Console.ReadKey();
            Console.Clear();

        
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("1. EN AMERICA CENTRAL, LOS RIOS SON CORTOS Y CORRESPONDEN");
            Console.WriteLine("   PRINCIPALMENTE A LA VERTIENTE:");
            Console.WriteLine("====================================================");
            cadena = Console.ReadLine();
            if (cadena.Equals(respuesta, StringComparison.OrdinalIgnoreCase))
            {
                puntaje+=10;
            }

        Console.Clear();
        respuesta = "GEOGRAFIA";

       Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("2. CENTRO AMERICA NO CUENTA CON RIOS LARGOS");
            Console.WriteLine("   DEBIDO A SI TIPO DE:");
            Console.WriteLine("====================================================");
            cadena = Console.ReadLine();
            if (cadena.Equals(respuesta, StringComparison.OrdinalIgnoreCase))
            {
                puntaje+=10;
            }



            
        Console.Clear();
        respuesta = "COCO";

       Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("3. EL RIO QUE SIRVE COMO LINEA FRONTERIZA");
            Console.WriteLine("   ENTRE HONDURAS Y NICARAGUA ES EL RIO:");
            Console.WriteLine("====================================================");
            cadena = Console.ReadLine();
            if (cadena.Equals(respuesta, StringComparison.OrdinalIgnoreCase))
            {
                puntaje+=10;
            }
        
         Console.Clear();
          respuesta = "COCIBOLCA";
            Console.WriteLine("====================================================");
            Console.WriteLine("4. EL LAGO MAS GRANDE DE CENTROAMERICA");
            Console.WriteLine("   ES EL LAGO:");
            Console.WriteLine("====================================================");
            cadena = Console.ReadLine();
            if (cadena.Equals(respuesta, StringComparison.OrdinalIgnoreCase))
            {
                puntaje+=10;
            }


         Console.Clear();
          respuesta = "ANTROPICAS";
            Console.WriteLine("====================================================");
            Console.WriteLine("5.LAS ACCIONES HUMANAS QUE AFECTAN LOS");
            Console.WriteLine("RECURSOS NATURALES SE LES CONOCE COMO AMENAZAS");
            Console.WriteLine("====================================================");
            cadena = Console.ReadLine();
            if (cadena.Equals(respuesta, StringComparison.OrdinalIgnoreCase))
            {
                puntaje+=10;
            }

       

        return puntaje;
        }  


    
    }
}