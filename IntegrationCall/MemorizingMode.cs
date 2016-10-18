using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Models;

namespace IntegrationCall
{
    abstract public class MemorizingMode
    {
        protected List<PublicWordInfo_mod> arrWords;
        public MemorizingMode(List<PublicWordInfo_mod> arrWords)
        {
            this.arrWords = arrWords;
        }

        protected PublicWordInfo_mod CurrentItem;
        protected bool IsRoundFinished = false;

        abstract public List<PublicWordInfo_mod> ReadList();
        abstract public void RandomList();
        abstract public PublicWordInfo_mod ReadNext(); //only word
        abstract public void ResetList();
        abstract public bool CheckCurrent(string answer);
        abstract public Feedback_mod GetFeedback();
    }
}
