// основа
string[] words = new string[10];
Input(words);
Search(words);

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

// Функция поиска строк 3 или меньше 2-3
void Search(string[] words) {
    int j = 0;
    string[] newArray = new string[10];

    for (int i = 0; i < 10; i++) {
        if (words[i] == "stop") break;

        if (words[i].Length <= 3) {
            newArray[j] = words[i];
            j++;
        }
    }

    Output(newArray, j);
}

// Функция вывода массива 4
void Output(string[] newArray, int n) {
    for (int i = 0; i < n; i++) {
        Console.Write($"{newArray[i]} ");
    }
}
