using System;
using System.Text;

class TextEditor
{
    static string EditText(string text)
    {
        // Create a new StringBuilder object to store the edited text.
        StringBuilder editedText = new StringBuilder();

        // Declare variables and initialize their starting values.
        bool periodExists = false;
        bool makeUpperCase = false;
        bool numberContinues = false;
        bool timeMode = false;
        StringBuilder temporaryNumber = new StringBuilder();

        // Iterate over the input text character by character.
        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];

            // If the first character is lowercase, convert it to uppercase.
            if (i == 0 && char.IsLower(character))
            {
                editedText.Append(char.ToUpper(character));
            }
            // If the character is a digit, mark that a number is in progress and append to temporaryNumber.
            else if (char.IsDigit(character))
            {
                numberContinues = true;
                temporaryNumber.Append(character);
            }
            // In time mode, a ':' character signifies the end of hours or minutes, formatting is done.
            else if (numberContinues && character == ':' && temporaryNumber.Length == 2)
            {
                numberContinues = true;
                timeMode = true;
                editedText.Append(temporaryNumber.ToString() + '.');
                temporaryNumber.Clear();
            }
            // If ':' is encountered in time mode, format the time segment.
            else if (numberContinues && character == ':' && timeMode)
            {
                numberContinues = true;
                editedText.Append(temporaryNumber.ToString() + '.');
                temporaryNumber.Clear();
            }
            // If ':' is encountered while not in time mode, it marks the end of hours or minutes.
            else if (numberContinues && character == ':' && !timeMode)
            {
                numberContinues = true;
                editedText.Append(temporaryNumber.ToString());
                temporaryNumber.Clear();
                timeMode = true;
                editedText.Append('.');
            }
            // If a number is in progress and the character is not a digit, format and append the number.
            else if (numberContinues && !char.IsDigit(character))
            {
                if (temporaryNumber.Length > 3)
                {
                    var formattedNumber = double.Parse(temporaryNumber.ToString()).ToString("#,0.###");
                    formattedNumber = formattedNumber.Replace(",", ".");
                    editedText.Append(formattedNumber);
                }
                else
                {
                    editedText.Append(temporaryNumber.ToString());
                }
                numberContinues = false;
                temporaryNumber.Clear();
                timeMode = false;
                editedText.Append(character);
            }
            // If the character is '.', check if a period exists.
            else if (character == '.')
            {
                if (!periodExists)
                {
                    periodExists = true;
                    editedText.Append(character);
                }
            }
            // If a period exists and a space is encountered, make the next letter uppercase.
            else if (character == ' ' && periodExists)
            {
                editedText.Append(character);
                makeUpperCase = true;
            }
            // If the character is a letter, convert it to uppercase or lowercase based on context.
            else if (char.IsLetter(character))
            {
                if (periodExists && makeUpperCase)
                {
                    editedText.Append(char.ToUpper(character));
                    makeUpperCase = false;
                }
                else
                {
                    editedText.Append(char.ToLower(character));
                }
                periodExists = false;
            }
            // For other characters, simply append them.
            else
            {
                editedText.Append(character);
                periodExists = false;
                makeUpperCase = false;
            }
        }

        // If a number is in progress at the end of the text, format and append it.
        if (numberContinues)
        {
            if (temporaryNumber.Length > 3)
            {
                var formattedNumber = double.Parse(temporaryNumber.ToString()).ToString("#,0.###");
                formattedNumber = formattedNumber.Replace(",", ".");
                editedText.Append(formattedNumber);
            }
            else
            {
                editedText.Append(temporaryNumber.ToString());
            }
        }

        // Return the edited text.
        return editedText.ToString();
    }

    static void Main()
    {
        // Define a test text.
        string text = "bu fonksiyonda çalışmalı. noktalama işareti var... Burada da var. iki nokta var.. 12:30 Türkiye saat stiline ayarlanıyor  255521 gibi bir sayı var.";
        //             Bu fonksiyonda çalışmalı. Noktalama işareti var. Burada da var. İki nokta var. 12.30 Türkiye saat stiline ayarlanıyor  255.521 gibi bir sayı var.
        // Call the EditText function to process the text.
        string editedText = EditText(text);

        // Display the edited text.
        Console.WriteLine(editedText);
    }
}
