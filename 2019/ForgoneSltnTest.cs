using System;
class Program
{
    static void Main(string[] args)
    {
        var Forgone = new Forgone();

        int[] result = Forgone.Input(78149);

        if (result[0] + result[1] != 78149)
            throw new InvalidOperationException();
    }
}
