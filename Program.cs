// Входные данные
string[] array = { "hello", "2", "world", ":-)" };


// Сформировать массив из имеющегося, строки которого <= 3 символа
string[] GetMinThreeSymbols(string[] array)
{
    string[] result = { };

    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            result.Append(item);
        }
    }
    return result;
}

GetMinThreeSymbols(array); // ["2", ":-)"]