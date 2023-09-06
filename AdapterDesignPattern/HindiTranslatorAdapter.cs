using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class HindiTranslatorAdapter : ILanguageTranslator
    {
        HindiTranslator hindiTransalator;

        public HindiTranslatorAdapter(HindiTranslator hindiTransalator)
        {
            this.hindiTransalator = hindiTransalator;
        }

        public string TranslateText(string text)
        {
            return hindiTransalator.TranslateToHindi(text);
        }
    }
}
