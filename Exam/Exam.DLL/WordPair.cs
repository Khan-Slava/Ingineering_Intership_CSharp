using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DLL
{
    public class WordPair
    {
        public string Language { get; set; }//язык
        public string WordInOriginal { get; set; }//оригинал слова
        public string Translation { get; set; }//перевод

        public int CountOfCorrectAnswer=0;//количество правильных ответов

        public int CountOfIncorrectAnswer=0;//количество не правильных ответов
        
        public WordPair()
        {
            
        }
        public WordPair(string Language, string WordInOriginal, string Translation, int CountOfCorrectAnswer = 0, int CountOfIncorrectAnswer =0)
        {
            this.Language = Language;
            this.WordInOriginal = WordInOriginal;
            this.Translation = Translation;
            this.CountOfCorrectAnswer = CountOfCorrectAnswer;
            this.CountOfIncorrectAnswer = CountOfIncorrectAnswer;
            
        }



    }
}
