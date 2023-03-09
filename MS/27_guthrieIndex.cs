static int GuthrieIndex(int n) {
    int count = 0;
    while (n > 1) {
        if (n % 2 == 0)
            n = n / 2;
        else
            n = n * 3 + 1;
        count++;
    }
    return count;
}

Console.WriteLine(GuthrieIndex(42));
