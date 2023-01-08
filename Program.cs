// main
string[] words = new string[10];
Input(words);

// Функция ввода слов в массив 1
string[] Input(string[] words) {
    Console.WriteLine("Введите слова (максимум 10 слов, для остановки введите 'stop'):");
    int i = 0;

    for (; i < 10; i++) {
        Console.Write($"[{i + 1}]: ");
        words[i] = Console.ReadLine();
        if (words[i] == "stop") break;
    }

    return words;
}

