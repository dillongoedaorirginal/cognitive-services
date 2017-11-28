﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DillonG.Microsoft.CognitiveServices.Bing.Search.Interfaces
{
    public interface ISpellChecker
    {
        Task<SpellCheckResult> CheckSpelling(string text);
    }

}
