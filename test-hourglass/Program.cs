Console.Write("Type row quantity: ");
var rowQuantity = int.Parse(Console.ReadLine()!);

while(rowQuantity < 20)
{
    Console.WriteLine("Input inválido");
    Console.Write("Type row quantity: ");
    rowQuantity = int.Parse(Console.ReadLine()!);
}

Console.Clear();

var decrementCount = rowQuantity - 1;
var whiteSpace = " ";
var hashTag = "#";

for (int row = 0; row < rowQuantity; row++)
{
    for (int column = 0; column < rowQuantity; column++)
    {
        if (row < rowQuantity / 2)
        {
            if (column > 0 && column < row)
            {
                Console.Write(whiteSpace);
            }
            else if (column > decrementCount && column < rowQuantity - 1)
            {
                Console.Write(whiteSpace);
            }
            else
            {
                Console.Write(hashTag);
            }
        }
        else if (row >= rowQuantity / 2 && row < rowQuantity- 1)
        {
            if (column == 0 || column == rowQuantity - 1)
            {
                Console.Write(hashTag);
            }
            else if (column == row || column == decrementCount)
            {
                Console.Write(hashTag);
            } 
            else
            {
                Console.Write(whiteSpace);
            }
        }
        else
        {
            Console.Write(hashTag);
        }

    }
    decrementCount = decrementCount - 1;
    Console.WriteLine();
}
Console.WriteLine($"Row quantity: {rowQuantity}");
Console.ReadLine();
