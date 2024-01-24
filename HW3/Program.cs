internal class Program
{
    static void Main(string[] args)
    {
        int[,,] labirynth1 = new int[5, 5, 5];

        Console.WriteLine(Find(labirynth1, 3, 2, 3));
    }

    static int Find(int[,,] array, int x, int y, int z)
    {
        int count = 0;

        if (!IsEmpty(array, x, y, z))
            return 0;

        array[x, y, z] = 2;

        if (x == 0 && y == 0 && z ==0
            || x == array.GetLength(0) - 1 && y == 0 && z == 0
            || x == 0 && y == array.GetLength(1) - 1 && z == 0
            || x == 0 && y == 0 && z == array.GetLength(2) - 1
            || x == array.GetLength(0) - 1 && y == array.GetLength(1) - 1 && z == array.GetLength(2) - 1
            || x == array.GetLength(0) - 1 && y == array.GetLength(1) - 1 && z == 0
            || x == 0 && y == array.GetLength(1) - 1 && z == array.GetLength(2) - 1
            || x == array.GetLength(0) - 1 && y == 0 && z == array.GetLength(2) - 1)
        {
            count += 3;
        }
        else if (x != 0 && x != array.GetLength(0) - 1 && y == 0 && z == 0
            || x == 0 && y != 0 && y != array.GetLength(1) - 1 && z == 0
            || x == 0 && y == 0 && z != 0 && z != array.GetLength(2) - 1

            || x != 0 && x != array.GetLength(0) - 1 && y == array.GetLength(1) - 1 && z == array.GetLength(2) - 1
            || x == array.GetLength(0) - 1 && y != 0 && y != array.GetLength(1) - 1 && z == array.GetLength(2) - 1
            || x == array.GetLength(0) - 1 && y == array.GetLength(1) - 1 && z != 0 && z != array.GetLength(2) - 1

            || x == 0 && y != 0 && y != array.GetLength(1) - 1 && z == array.GetLength(2) - 1
            || x != 0 && x != array.GetLength(0) - 1 && y == 0 && z == array.GetLength(2) - 1
            || x == array.GetLength(0) - 1 && y == 0 && z != 0 && z != array.GetLength(2) - 1
            || x == array.GetLength(0) - 1 && y != 0 && y != array.GetLength(1) - 1 && z == 0
            || x != 0 && x != array.GetLength(0) - 1 && y == array.GetLength(1) - 1 && z == 0
            || x == 0 && y == array.GetLength(1) - 1 && z != 0 && z != array.GetLength(2) - 1)
        {
            count += 2;
        }
        else if (x == 0 || y == 0 || z == 0 || x == array.GetLength(0) - 1 || y == array.GetLength(1) - 1 || z == array.GetLength(2) - 1)
        {
            count++;
        }

        count += Find(array, x + 1, y, z);
        count += Find(array, x, y + 1, z);
        count += Find(array, x - 1, y, z);
        count += Find(array, x, y - 1, z);
        count += Find(array, x, y, z + 1);
        count += Find(array, x, y, z - 1);

        return count;
    }

    static bool IsEmpty(int[,,] array, int x, int y, int z)
    {
        if (x < 0 || x >= array.GetLength(0))
            return false;
        if (y < 0 || y >= array.GetLength(1))
            return false;
        if (z < 0 || z >= array.GetLength(1))
            return false;
        return array[x, y, z] == 0;
    }
}