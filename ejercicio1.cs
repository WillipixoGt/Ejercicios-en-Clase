String dato ;
int convertidor;

Console.WriteLine("Bienvenido al calculador de los meses: ");
Console.WriteLine("Ingrese el numero del mes que desea visualizar");
dato = Console.ReadLine();

convertidor= Convert.ToInt32(dato);

switch (convertidor)
{
    case 1:
        Console.WriteLine("El mes que eligio fue Enero");
        break;
    case 2:
        Console.WriteLine("El mes que eligio fue Febrero");
        break;
    case 3:
        Console.WriteLine("El mes que eligio fue Marzo");
        break;
    case 4:
        Console.WriteLine("El mes que eligio fue Abril");
        break;
    case 5:
        Console.WriteLine("El mes que eligio fue Mayo");
        break;
    case 6:
        Console.WriteLine("El mes que eligio fue Junio");
        break;
    case 7:
        Console.WriteLine("El mes que eligio fue Julio");
        break;
    case 8:
        Console.WriteLine("El mes que eligio fue Agosto");
        break;
    case 9:
        Console.WriteLine("El mes que eligio fue Septiembre");
        break;
    case 10:
        Console.WriteLine("El mes que eligio fue Octubre");
        break;
    case 11:
        Console.WriteLine("El mes que eligio fue Noviembre");
        break;
    case 12:
        Console.WriteLine("El mes que eligio fue Diciembre");
        break;
    default:
        Console.WriteLine("El valor que ingreso fue incorrecto");
        break;
}