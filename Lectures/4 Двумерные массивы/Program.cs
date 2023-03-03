// string [,] table = new string [2, 5];
// table[1, 2] = "Слово";
//Инициализаци строковой пеперменой String.Empty
// for (int row = 0; row < 2; row++)
// {
//     for (int colum = 0; colum < 5; colum++)
//     {
//         Console.WriteLine($"-{table[row, colum]}-");
//     }
// }


void PrintArray(int[,] matr)
{
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int colum = 0; colum < matr.GetLength(1); colum++)
        {
            Console.Write($"{matr[row, colum]} ");
        }
    Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int colum = 0; colum < matr.GetLength(1); colum++)
        {
            matr[row, colum] = new Random().Next(1, 10);
        }
    }
}

int [,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);