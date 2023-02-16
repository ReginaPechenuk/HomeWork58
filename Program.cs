/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] getArray(int colLength, int rowLength, int start, int Finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, Finish + 1);
        }
    }
    return array;
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int [,] MultiMatrix (int [,] array, int [,] array2)
{
    int [,] matrix = new int [2,2];
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < 1; j++)
        {
            matrix[i,j] = (array[i,j]*array2[i,j])+(array[i,j+1]*array2[i+1,j]);
            matrix[i,j+1] = (array[i,j]*array2[i,j+1])+(array[i,j+1]*array2[i+1,j+1]);
            matrix[i+1,j] = (array[i+1,j]*array2[i,j])+(array[i+1,j+1]*array2[i+1,j]);
            matrix[i+1,j+1] = (array[i+1,j]*array2[i,j+1])+(array[i+1,j+1]*array2[i+1,j+1]);
        }
    }
    return matrix;
}

int [,] array = getArray(2,2,0,10);
printArray(array);
Console.WriteLine("-----------");
int [,] array2 = getArray(2,2,0,10);
printArray(array2);
Console.WriteLine("-----------");
Console.WriteLine("Результирующая матрица будет:");
int [,] matrixU = MultiMatrix(array,array2);
printArray(matrixU);

