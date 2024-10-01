//Programa para ejemplificar las colas

bool menuPrincipal = true;
int numeromensajes = 0;
Queue<string> mensajes = new Queue<string>();

while (menuPrincipal)
{
 try
    {


        Console.Clear();
        Console.WriteLine("======================================");
        Console.WriteLine("---------- MENU DE MENSAJES ----------");
        Console.WriteLine("1. Mandar mensajes.");
        Console.WriteLine("2. Visualizar envío de mensajes.");
        Console.WriteLine("3. Eliminar chat.");
        Console.WriteLine("4. Ver mensaje más antiguo.");
        Console.WriteLine("5. Salir.");
        Console.WriteLine("======================================\n");
        Console.Write("Seleccione alguna de las opciones: "); int opcionMenu = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        switch (opcionMenu)
        {
            case 1:

                bool menuEnviar = true;

                while (menuEnviar)
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("Ingrese la cantidad de mensajes que desea ingresar: "); int cantidadMensajes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        numeromensajes = cantidadMensajes;
                        for (int i = 1; i <= cantidadMensajes; i++)
                        {
                            Console.Write($"Mensaje No.{i}: "); string mensaje = Console.ReadLine();
                            Console.WriteLine("");
                            mensajes.Enqueue( mensaje );
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Mensajes enviados.");
                        Console.ResetColor();
                        Console.ReadKey();
                        menuEnviar = false;
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error de formato.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    catch (OverflowException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error de formato.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }
                break;

            case 2:

                int numeroMensaje = 1;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mostrando chat:\n");
                Console.ResetColor();

                foreach (string mensajesEnviados in mensajes)
                {
                    
                    Console.WriteLine($"Mensaje No.{numeroMensaje}: " + mensajesEnviados);

                    numeroMensaje++;
                }
                Console.ReadKey();
                break;

            case 3:
                if (mensajes.Count == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("No hay mensajes para eliminar");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Mostrando orden de eliminados:\n");
                    Console.ResetColor();
                    for (int i = 1; i <= numeromensajes; i++)
                    {
                        Console.WriteLine($"Eliminando mensaje No.{i}: " + mensajes.Dequeue());
                        Console.WriteLine("");
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Todos los mensajes han sido eliminados.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                break;

            case 4:
                if (mensajes.Count == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Chat vacío.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Mensaje más antiguo encontrado: " + mensajes.Peek());
                    Console.ReadKey();
                }
                break;

            case 5:
                menuPrincipal = false;
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La opción {opcionMenu} no es válida.");
                Console.ResetColor();
                Console.ReadKey();
                break;
        }
    }
    catch(FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error de formato.");
        Console.ResetColor();
        Console.ReadKey();
    }
    catch (OverflowException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error de formato.");
        Console.ResetColor();
        Console.ReadKey();
    }
}