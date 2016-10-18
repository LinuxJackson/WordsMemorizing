using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Models;

namespace IntegrationCall
{
    public class ClassicalMode : MemorizingMode
    {
        public ClassicalMode(List<PublicWordInfo_mod> arrWords) : base(arrWords)
        {
        }

        public override bool CheckCurrent(string answer)
        {
            throw new NotImplementedException();
        }

        public override Feedback_mod GetFeedback()
        {
            throw new NotImplementedException();
        }

        public override void RandomList()
        {
            throw new NotImplementedException();
        }

        public override List<PublicWordInfo_mod> ReadList()
        {
            throw new NotImplementedException();
        }

        public override PublicWordInfo_mod ReadNext()
        {
            throw new NotImplementedException();
        }

        public override void ResetList()
        {
            throw new NotImplementedException();
        }
    }
}
