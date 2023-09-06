using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class BengaliTranslatorAdapter : ILanguageTranslator
    {
        BengaliTranslator bengaliTranslator;

        public BengaliTranslatorAdapter(BengaliTranslator bengaliTranslator)
        {
            this.bengaliTranslator = bengaliTranslator;
        }

        public string TranslateText(string text)
        {
            return bengaliTranslator.TranslateToBengali(text);
        }
    }
}
