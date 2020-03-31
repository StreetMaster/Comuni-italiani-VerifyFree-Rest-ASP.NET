using RestSharp;
using System;

namespace VerifyFreeRest_ASPNET
{
    /// <summary>
    /// Esempio di utilizzo del servizio WS VERIFY Free per la verifica e la normalizzazione degli indirizzi italiani 
    /// realizzato da StreetMaster Italia
    /// 
    /// L'end point del servizio è 
    ///     https://streetmaster.streetmaster.it/smrest/webresources/verify_free
    ///     
    /// Per l'utilizzo registrarsi sul sito http://streetmaster.it e richiedere la chiave per il servizio Verify Free solo localita' 
    /// Il protocollo di comunicazione e' in formato JSON
    /// Per le comunicazioni REST è utilizzata la libreria opensource RestSharp (http://restsharp.org/)
    /// 
    ///  2016 - Software by StreetMaster (c)
    /// </summary>
    public partial class DemoVerify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCallVerifyFree_Click(object sender, EventArgs e)
        {
            outArea.Style["Border"] = "none";
            outArea.Style["Border-color"] = "#336600";

            // inizializzazione client del servizio VERIFY Free
            var clientVerifyFree = new RestSharp.RestClient();
            clientVerifyFree.BaseUrl = new Uri("https://streetmaster.streetmaster.it");

            var request = new RestRequest("smrest/webresources/verify_free", Method.GET);
            request.RequestFormat = DataFormat.Json;

            // valorizzazione input
            // per l'esempio viene valorizzato un insieme minimo dei parametri
            request.AddParameter("Key", txtKey.Text);
            request.AddParameter("Localita", txtComune.Text);
            request.AddParameter("Cap", txtCap.Text);
            request.AddParameter("Provincia", txtProv.Text);
            request.AddParameter("Localita2", txtFrazione.Text);
            request.AddParameter("Dug", String.Empty);
            request.AddParameter("Civico", String.Empty);


            // chiamata al servizio
            var response = clientVerifyFree.Execute<VerifyFreeResponse>(request);

            // recupero result
            var outCall = response.Data;

            if (outCall.Norm==1)
            {
                // verifica OK
                txtCap.Text = outCall.Output[0].Cap;
                txtProv.Text= outCall.Output[0].Prov;
                txtComune.Text = outCall.Output[0].Comune;
                txtFrazione.Text = outCall.Output[0].Frazione;
                outArea.InnerHtml = "<p><font color=\"green\">INDIRIZZO VALIDO</font></p>";
            }
            else
            {
                // verifica KO, gestione errore

                // errore di licenza
                if (outCall.CodErr == 997)
                    outArea.InnerHtml = "<p><font color=\"red\">LICENSE KEY NON RICONOSCIUTA</font></p>";
                else if (outCall.CodErr == 123)
                    outArea.InnerHtml = "<p><font color=\"red\">NON E' STATO VALORIZZATO IL COMUNE</font></p>";
                else if (outCall.CodErr == 124)
                    outArea.InnerHtml = "<p><font color=\"red\">COMUNE\\FRAZIONE NON RICONOSCIUTO</font></p>";
                else if (outCall.CodErr == 125)
                {
                    String htmlOut= "<p><font color=\"red\">COMUNE\\FRAZIONE AMBIGUO</font></p>";

                    htmlOut += "<table>";
                    foreach (VerifyFreeCand outElem in outCall.Output)
                    {
                        htmlOut += "<tr><td>";

                        htmlOut += outElem.Cap + " "+ outElem.Comune+ " " + outElem.Prov;
                        if (outElem.Frazione != string.Empty)
                            htmlOut += " - " + outElem.Frazione;
                        htmlOut += "</td></tr>";
                    }
                    htmlOut += "</table>";
                    outArea.InnerHtml = htmlOut;
                }
            }
            outArea.Style["Border"] = "groove";
        }
    }
}