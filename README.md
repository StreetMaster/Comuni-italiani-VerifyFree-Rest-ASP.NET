# DemoVerifyFreeRestASP.NET
Demo ASP.NET per l'utilizzo del ws rest VERIFY FREE di verifica e normalizzazione indirizzi italiani di StreetMaster

Ambiente di sviluppo:
  - C#
  - Framework 4.6.1
  - Visual Studio Professional 2015 SP2
  
Il protocollo di comunicazione e' in formato JSON e viene utilizzata la libreria opensource RestSharp (http://restsharp.org/)

End point del servizio 
     http://ec2-46-137-97-173.eu-west-1.compute.amazonaws.com/smrest/verify_free
     
Per l'utilizzo registrarsi sul sito http://streetmaster.it e richiedere la chiave per il servizio VERIFY Free.
Il servizio è gratuito e permette di verificare e correggere la parte di localita dell'indirizzo (Comune,Provincia,Cap)
Per altri servizi consultare nel sito i piani di utilizzo.
Se non viene utilizzata una chiave valida il servizio restituisce il codice di errore 997: chiave non riconosciuta.

La base dati di riferimento è costantemente aggiornata con le variazioni amministrative e postali ufficiali.
Per le città multicap in assenza di un CAP valido in input viene restituito il CAP generico.

  Output di base: 
  - comune
  - frazione
  - provincia
  - regione
  - cap
  - score di riconoscimento del comune
    
Per ogni domanda o chiarimento manda una mail a supporto@streetmaster.it
