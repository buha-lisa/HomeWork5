namespace hw5.Translation.FromMorthe
{
    internal class Text
    {
        public void ToText(string morseCode)
        {
            string[] words = morseCode.Split('/');
            string text = "";
            foreach (string word in words)
            {
                string[] letters = word.Split(' ');
                foreach (string letter in letters)
                {
                    for (int i = 0; i < morseCodes.Length; i++)
                    {
                        if (morseCodes[i] == letter)
                        {
                            text += (char)('A' + i);
                            break;
                        }
                    }
                }
                text += " ";
            }
            Console.WriteLine($"Text: {text}");
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
