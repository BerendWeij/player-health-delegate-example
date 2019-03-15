**Simpel voorbeeld voor delegates in C#**

Wat leer je in deze repository: Action<T>
Dit is een simpele manier van het aanmaken van een delegate die mag verwijzen naar functies die niets returnen.

Door op de player te klikken, deel je damage uit. Dit zie je in de UI terugkomen. De UI weet dat hij moet updaten doordat hij naar de player netjes luistert.

 
Hierdoor is onze code:

* Flexibeler
* Beter te hergebruiken
* Duidelijk welke Class welke veranwoordelijkheid heeft (SRP, single responsibility principle)

 
Ik zou hier nog veel verder mee gaan. Een player zou ook delegates kunnen gebruiken om te laten weten dat hij:
* Dood gaat
* Iets heeft opgepakt
* Schiet
* Etc.
* Etc.
