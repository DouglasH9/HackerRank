static int MarsExploration(string s)
{
    int changedChars = 0;

    for (int i = 0; i < s.Length; i+= 3)
    {
        if (s[i] != 'S')
        {
            changedChars++;
        }
        if (s[i+1] != 'O')
        {
            changedChars++;
        }
        if (s[i+2] != 'S')
        {
            changedChars++;
        }
    }
    return changedChars;
}

System.Console.WriteLine(MarsExploration("SOSSISSOSSUSSOS"));