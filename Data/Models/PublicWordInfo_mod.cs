using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Models
{
    public class PublicWordInfo_mod
    {
        public PublicWordInfo_mod(string strWord, string strTranslation, short level)
        {
            this.strWord = strWord;
            this.strTranslation = strTranslation;
            this.level = level;
        }

        private string strWord;
        private string strTranslation;
        private short level;

        public string StrWord
        {
            get
            {
                return strWord;
            }

            set
            {
                strWord = value;
            }
        }

        public string StrTranslation
        {
            get
            {
                return strTranslation;
            }

            set
            {
                strTranslation = value;
            }
        }

        public short Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }
    }
}
