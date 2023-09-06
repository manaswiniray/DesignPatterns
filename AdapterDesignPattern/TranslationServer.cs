using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class TranslationServer
    {
        readonly IUserInput userInput = new UserInput();

        public void Translate()
        {
            string inputText = userInput.fetchInputForConversion();
            int inputChoice = userInput.fetchInputForChoice();
            switch (inputChoice)
            {
                case 1:
                    ILanguageTranslator languageTranslatorHindi = new HindiTranslatorAdapter(new HindiTranslator());
                    string outputStringHindi = languageTranslatorHindi.TranslateText(inputText);
                    Console.WriteLine(outputStringHindi);
                    break;
                case 2:
                    ILanguageTranslator languageTranslatorBengali = new BengaliTranslatorAdapter(new BengaliTranslator());
                    string outputStringBengali = languageTranslatorBengali.TranslateText(inputText);
                    Console.WriteLine(outputStringBengali);
                    break;
                case 3:
                    Console.WriteLine("No Option selected!");
                    break;
            }
        }
    }
}
