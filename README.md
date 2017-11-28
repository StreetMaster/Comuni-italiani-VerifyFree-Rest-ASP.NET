# Comuni italiani. Webservice gratuito di verifica e correzione. Servizio free
## Demo VerifyFree Rest ASP.NET
Comuni italiani, demo ASP.NET per l'utilizzo del ws rest VERIFY FREE di verifica e correzione. Il servizio è gratuito.

### Ambiente di sviluppo:
  - C#
  - Framework 4.6.1
  - Visual Studio Professional 2015 SP2
 
### Endpoint
```
     http://ec2-46-137-97-173.eu-west-1.compute.amazonaws.com/smrest/verify_free
```
Il protocollo di comunicazione e' in formato JSON e viene utilizzata la libreria opensource RestSharp (http://restsharp.org/)

### Key     
Per l'utilizzo registrarsi sul sito http://streetmaster.it e richiedere la chiave per il servizio VERIFY Free.
Se non viene utilizzata una chiave valida il servizio restituisce il codice di errore 997: chiave non riconosciuta.

### Condizioni
Il servizio è gratuito e permette di verificare e correggere la parte di localita dell'indirizzo (Comune,Provincia,Cap)
Per altri servizi consultare nel sito i piani di utilizzo.

### Output
La base dati di riferimento è costantemente aggiornata con le variazioni amministrative e postali ufficiali.
Per le città multicap in assenza di un CAP valido in input viene restituito il CAP generico.

  Output di base: 
  - comune
  - frazione
  - provincia
  - regione
  - cap
  - score di riconoscimento del comune

### Aggiornamenti base dati comunale
  - 01/01/2016 Istituzione
  - 05/12/2016 Inserimento nuovi comuni di Alpago e Val di Zoldo
  - 05/12/2016 Soppressione comuni di Zoldo Alto,Forno di Zoldo,Prestine, Ivano-Francena,Farra d'Alpago,Pieve d'Alpago,Puos d'Alpago
  - 08/05/2017 Inserimento nuovi comuni di Abetone Cutigliano,San Marcello Piteglio,Valfornace,Colli al Metauro,Terre Roveresche,Alta Valle Intelvi,Terre del Reno
  - 08/05/2017 Soppressione comuni di Selve Marcone,Cavallasca,Acquacanina,Abetone,Cutigliano,San Marcello Pistoiese,Piteglio,San Giovanni D'Asso,Fiordimonte,Pievebovigliana,Piagge,Barchi,Orciano Di Pesaro,San Giorgio Di Pesaro,Montemaggiore Al Metauro,Saltara,Serrungarina,Mirabello,Sant'Agostino,Lanzo D'Intelvi,Pellio Intelvi,Ramponio Verna
  
### Support  
Per ogni domanda o chiarimento manda una mail a supporto@streetmaster.it
