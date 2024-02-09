// See https://aka.ms/new-console-template for more information

Console.WriteLine("Codigo de suma de la Matriz");
//Console.WriteLine("1-hacer un algoritmo que sume las diagonales de la matriz"); // se ve sucio mejor no

int[,] matriz = new int[3,3];
int contador = 1;
int sumatoria = 0;

//*****************  Diagonal ***************//

//Asignar a la matriz un valor
for (int f = 0; f < 3; f++) // filas
{
    for (int c = 0; c < 3; c++)//columnas
    {
        matriz[f, c] = contador+=10; // ++contador= primero suma el uno  //contador++ = primero suma el cero // contador+= # = acomulador que guarda la cantidad que se necesita 
    }
   // Console.WriteLine();  X
}

// ciclo para imprimir la matriz

for (int f = 0; f < 3; f++) //filas
{
    for (int c = 0; c < 3; c++) // columnas
    {
        if (c == f)
        {
            sumatoria = sumatoria + matriz[f, c];
        }

    }
    //  Console.WriteLine();  X
}
//Console.WriteLine($"la suma de la matriz es de: {sumatoria}"); X



for (int f = 0; f < 3; f++) //filas
{
    for (int c = 0; c < 3; c++) // columnas
    {
        Console.Write($"         {matriz[f,c]}");
    }
    Console.WriteLine();
    }

Console.WriteLine($"La suma de la diagonal es de: {sumatoria}");

//************************* Diagonal inversa *****************************//
//Console.WriteLine("1-hacer un algoritmo que sume la diagonal inversa de la matriz"); // se ve sucio mejor no

int sum_diag_inversa = Sumar_Inversa(matriz);

Console.WriteLine("La suma de la diagonal inversa es de: " + sum_diag_inversa);
    

    static int Sumar_Inversa(int[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    if (filas != columnas)
    {
        Console.WriteLine("Verificar si es tangible");
        return 0;
    }

    int suma = 0;

    // Suma
    for (int i = 0; i < filas; i++)
    {
        suma += matriz[i, filas - 1 - i];
    }

    return suma;
}


//********************  2-hacer un algoritmo que sume la columan del centro ************************* //
//Console.WriteLine("2-hacer un algoritmo que sume la columna del centro  de la matriz"); //se ve sucio mejor no

int columnaCentro = matriz.GetLength(1) / 2;
int sumaColumnaCentro = SumarColumnaCentro(matriz, columnaCentro);

Console.WriteLine("La suma de la columna del centro es de: " + sumaColumnaCentro);
  
    static int SumarColumnaCentro(int[,] matriz, int columnaCentro)
{
    int suma = 0;

    for (int fila = 0; fila < matriz.GetLength(0); fila++)
    {
        suma += matriz[fila, columnaCentro];
    }

    return suma;
}
//*************** 3- hacer un algoritmo para sumar las esquinas **************** //
//Console.WriteLine("3-hacer un algoritmo que sume las esquinas de la matriz"); // se ve sucio mejor no

int suma_esquinas = SumarEsquinas(matriz);

Console.WriteLine("La suma de las esquinas es de: " + suma_esquinas);
    
    static int SumarEsquinas(int[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    if (filas < 2 || columnas < 2)
    {
        Console.WriteLine("Verificar si la matris es factible");
        return 0;
    }

    // Suma
    int suma = matriz[0, 0] + matriz[0, columnas - 1] + matriz[filas - 1, 0] + matriz[filas - 1, columnas - 1];

    return suma;
}
    Console.ReadLine();


