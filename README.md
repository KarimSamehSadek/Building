# Building

## Aufgabenstellung 

Konzeptioniere eine Klassen- und Objektstruktur für ein Gebäude. 

Das Gebäude soll 2 Stockwerke (EG, OG) haben. Im EG befindet sich ein Büroraum, ein buchbarer Meetingraum und ein Technikraum. Im OG befinden sich buchbare Gästezimmer (1 Doppel und ein Einzelzimmer) 

Die Funktionalität "Buchbar" soll nur über eine einfache Boolean-Variable abgebildet werden, die dann angibt, ob ein Raum frei oder belegt ist. Es soll keine kalenderbasierte Buchungslösung oder ähnliches implementiert werden. 

Als Funktion betrachten wir exemplarisch die Beleuchtung. Jeder Raum hat ein Hauptlicht, welches ein- und ausgeschaltet werden kann. Der Meetingraum hat zusätzlich einen weiteren Beleuchtungskreis. 

Weitere Raumfunktionen wie z.B. Klimaanlage, Beschattung, Heizung, etc. werden in der ersten Implementierung nicht benötigt. Es soll allerdings auf Erweiterbarkeit geachtet werden. 

Wird das Licht in einem Raum geschaltet, soll eine entsprechende Konsolenausgabe (einfach) erfolgen und die Lichteigenschaft entsprechend geschaltet werden. 

  

Erstelle das o.g. Gebäude als Objekt in einer C# Konsolenanwendung. 

Danach soll im gesamten Gebäude „das Licht eingeschaltet“ werden. 

 

Erstelle nun ein zweites Gebäude - das Nebengebäude des „Hotels“. Dieses hat 5 Stockwerke mit je 10 Doppelzimmern, 5 Einzelzimmern und einen Technikraum. 

Schalte auch dort das Licht in allen Zimmern ein. 

 

## Erwartung 

Die Anwendung ist kompilierfähig und im guten Stil implementiert. 
Nach Ausführung der Anwendung erscheinen die Konsolenausgaben für die Lichtschaltvorgänge. 
Erweiterbarkeit und Modellierung neuer Gebäudestrukturen soll später möglich sein. 
 

## Zeitrahmen 

Ca. 55 Minuten 
