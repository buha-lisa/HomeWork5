namespace hw5.Translation.ToMorthe
{
    internal class Text
    {
        public void TranslateToMorseCode(string text)
        {
            string morseCode = "";
            foreach (char c in text.ToUpper())
            {
                if (c == ' ')
                {
                    morseCode += "/ "; 
                }
                else
                {
                    int index = c - 'A'; 
                    if (index >= 0 && index < morseCodes.Length)
                    {
                        morseCode += morseCodes[index] + " ";
                    }
                }
            }
            Console.WriteLine($"Morse code:\n{morseCode}");
        }
        private string[] morseCodes = {
        ".-",   // A
        "-...", // B
        "-.-.", // C
        "-..",  // D
        ".",    // E
        "..-.", // F
        "--.",  // G
        "....", // H
        "..",   // I
        ".---", // J
        "-.-",  // K
        ".-..", // L
        "--",   // M
        "-.",   // N
        "---",  // O
        ".--.", // P
        "--.-", // Q
        ".-.",  // R
        "...",  // S
        "-",    // T
        "..-",  // U
        "...-", // V
        ".--",  // W
        "-..-", // X
        "-.--", // Y
        "--.."  // Z
        };
    }
}
