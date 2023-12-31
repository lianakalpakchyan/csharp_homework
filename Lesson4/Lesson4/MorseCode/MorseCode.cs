﻿string phrase = "what hath god wrought";
string morseTranslation = "";

var cities = new Dictionary<char, string>(){
    {'a', ".-"},
    {'b', "-..."},
    {'c', "-.-."},
    {'d', "-.."},
    {'e', "."},
    {'f', "..-."},
    {'g', "--."},
    {'h', "...."},
    {'i', ".."},
    {'j', ".---"},
    {'k', "-.-"},
    {'l', ".-.."},
    {'m', "--"},
    {'n', "-."},
    {'o', "---"},
    {'p', ".--."},
    {'q', "--.-"},
    {'r', ".-."},
    {'s', "..."},
    {'t', "-"},
    {'u', "..-"},
    {'v', "...-"},
    {'w', ".--"},
    {'x', "-..-"},
    {'y', "-.--"},
    {'z', "--.."},
    {'1', ".----"},
    {'2', "..---"},
    {'3', "...--"},
    {'4', "....-"},
    {'5', "....."},
    {'6', "-...."},
    {'7', "--..."},
    {'8', "---.."},
    {'9', "----."},
    {'0', "-----"},
    {' ', "   "},
};


foreach (char c in phrase)
{
    Console.Write(cities[c] + " ");
}
Console.WriteLine("\n======");

var reversedCities = new Dictionary<string, char>()
{
    {".-", 'a'},
    {"-...", 'b'},
    {"-.-.", 'c'},
    {"-..", 'd'},
    {".", 'e'},
    {"..-.", 'f'},
    {"--.", 'g'},
    {"....", 'h'},
    {"..", 'i'},
    {".---", 'j'},
    {"-.-", 'k'},
    {".-..", 'l'},
    {"--", 'm'},
    {"-.", 'n'},
    {"---", 'o'},
    {".--.", 'p'},
    {"--.-", 'q'},
    {".-.", 'r'},
    {"...", 's'},
    {"-", 't'},
    {"..-", 'u'},
    {"...-", 'v'},
    {".--", 'w'},
    {"-..-", 'x'},
    {"-.--", 'y'},
    {"--..", 'z'},
    {".----", '1'},
    {"..---", '2'},
    {"...--", '3'},
    {"....-", '4'},
    {".....", '5'},
    {"-....", '6'},
    {"--...", '7'},
    {"---..", '8'},
    {"----.", '9'},
    {"-----", '0'}
};


string[] splittedMorseTranslation = ".-- .... .- -   .... .- - ....   --. --- -..   .-- .-. --- ..- --. .... -".Split("   ");

foreach (string s in splittedMorseTranslation)
{
    string[] word = s.Split(" ");
    foreach (string c in word)
    {
        Console.Write(reversedCities[c]);
    }
    Console.Write(" ");
}

