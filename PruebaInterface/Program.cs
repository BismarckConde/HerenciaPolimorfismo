using PruebaInterface;
int op = 0;
double vala = 0.0;
double valb = 0.0;

string valor =String.Empty;

IOperacion operacion = new suma();

while(op != 5)
{
    Console.WriteLine("1- SUMA\n2-RESTA\n3-MULTIPLICACION\n4-DIVISION\n5-SALIR");
    Console.WriteLine("¿QUE OPCION DESEA?");
    valor = Console.ReadLine();
    op = Convert.ToInt32(valor);

    Console.WriteLine(" DIGITE EL VALOR DE A");
    vala = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("DIGITE EL VALOR DE B");
    valb = Convert.ToDouble(Console.ReadLine());

    //POLIFORFISMO
    if(op==1)
        operacion =new suma();
    if(op==2)
        operacion =new resta();
    if(op==3)
        operacion=new multiplicacion();
    if (op == 4)
        operacion = new division();

    operacion.Calcular(vala, valb);
    operacion.Mostrar();


}


