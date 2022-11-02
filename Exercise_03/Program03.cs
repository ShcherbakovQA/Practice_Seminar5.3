int GetNumber()
{
    // do
    // {
    //     text = Console.ReadLine();
    // }
    // while (text.IndexOf(',') >= 0 || text.IndexOf('.') >= 0);
    string text = "";
    bool key = true;
    while (key)
    {
        text = Console.ReadLine();
        if (text.IndexOf(',') >= 0 || text.IndexOf('.') >= 0)
        {
            Console.WriteLine("Введите верное число!!!");
            key = true;
        }
        else
        {
            key = false;
        }
    
    }
    return Convert.ToInt32(text);
}
    Console.WriteLine(GetNumber());