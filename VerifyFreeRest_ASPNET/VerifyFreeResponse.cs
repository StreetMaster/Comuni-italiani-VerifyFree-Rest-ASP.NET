using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyFreeRest_ASPNET
{
  /// <summary>
  /// Classe per deserializzazione della risposta JSON del servizio VERIFY Free
  /// </summary>



    class VerifyFreeCand
    {
        public string Prov { get; set; }
        public string Comune { get; set; }
        public string Frazione { get; set; }
        public string Cap { get; set; }
        public string Regione { get; set; }
        public string ProvEstesa { get; set; }
        public int ScoreComune { get; set; }
        public int ScoreStrada { get; set; }

    }

    class VerifyFreeResponse
    {
      
        public int Norm { get; set; }
        public int CodErr { get; set; }
        public int NumCand { get; set; }
        public List<VerifyFreeCand> Output { get; set; }

    }
}
