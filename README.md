# VR-Project Nadine Rosenzopf
![Uebersicht](https://user-images.githubusercontent.com/72389468/164446175-9380c068-ebab-4cfd-a22a-30196b6a0213.JPG)


# Spielverlauf mit Rätsel
## Start: 
Eingang vor dem Labyrinth: Hohe Mauern, kein Ausgang möglich; Einziger Weg: In das Labyrinth.
Labyrinth besteht aus zwei Teilen, welches mithilfe eines Untergrundes verbunden wird.
## Im ersten Teil:
### Rätsel 1:
Labyrinth mit 4 Eier versteckt, welche eine bestimmte Farbe haben. Hebe ich das Ei auf, wird mithilfe des Audios eine Zahl gesagt (Beispiel Rot=5. Der Sprecher sagt „5“).
Nach jeden aufheben erscheint im Canvas ein 2D Ei in der aufgehobenen Farbe mit dem eben genannten Wert.
Das 3D Ei verschwindet nach dem Aufheben.
In Mitte des Spieles befindet sich ein kleines Rechenrätselspiel. Hierfür werden diese 4 Eier mit der jeweiligen Farbe benötigt. Auf den Wänden befinden sich 3 kleine Rechnungen wie Beispielsweiße „Rot-Blau=?“. Vor einem befinden sich unter jeden Rechnung 1 Button, wo die Zahl jeweils einzugeben ist. Die Zahl steigert sich bei jeden Mal betätigen des Buttons: 1 Klick und die Zahl steigert sich um 1 (Beispiel die aktuelle Zahl beträgt 4 und der Button wird betätigt, so springt diese auf 5). Zu jeder Rechnung gehört ein Button. Sind alle 3 Rechnungen richtig berechnet, so öffnet sich eine Falltüre und der Spiele fällt in den Untergrund. WICHTIG: Die Zahlen werden NICHT jede Runde neu generiert.

(![Spiel1 1](https://user-images.githubusercontent.com/72389468/164445084-e431bc2e-37f3-4384-a692-1c218f73879d.JPG)
![Spiel1 2](https://user-images.githubusercontent.com/72389468/164445135-5c37fb3a-cf6b-4b99-ab7f-3fc9880b31cc.JPG)
![Spiel1 3](https://user-images.githubusercontent.com/72389468/164445160-70c48221-05a8-4129-a57b-dcef425cf59f.JPG)


## Untergrund:
Ein erdiger Gang mit Wasser (Unity Standard Assets) liegt vor einem. Geht man den schmalen Gang entlang, so gelangt man zu einem leuchtenden Hammer, welcher für das nächste Rätsel mitgenommen werden muss. Geht man den Gang weiter entlang, gelangt man zu einem Lift, welcher mithilfe der Button Betätigung nach oben fährt.

## Zweiter Teil:

### Rätsel 2:
Hier findet man das Spiel „whack a mole“. Mit dem zuvor gefundenen Hammer müssen innerhalb eines bestimmten Zeitraumes eine bestimmte Anzahl dieser kleinen Tiere mit dem Hammer geschlagen werden (wie das Original). Man hat 3 Versuche. Ist eine Zeit abgelaufen und ich habe nicht die gewünschte Anzahl an Murmeltiere erschlagen, so verschwindet ein Lebenspunkt. Nach 3 Fehlversuchen erscheint der „Death-Screen“.

### Schluss:
Wurde diese Aufgabe erfüllt, so kann man in die Freiheit gelangen und es öffnet sich eine Türe und der „Sie haben es geschafft“-Screen erscheint.

### Timer:
Befindet sich rechts oben im Canvas und zählt die Zeit runter. Sobald die Zeit abgelaufen ist, erscheint ein „DeathScreen“ und der Spieler hat die Option zwischen „Neustart“ und „Spiel schließen“ zu entscheiden.


# Benötigte Sounds:
Ostereierzahl wie „Fünf “ (Sprecher)
Hintergrundmusik und Nebel/Wind Geräusche
Wassergeräusche für den Untergrund und Atmen des Spielers
Button Sound und Falltüre Sound
Hammer leichter Sound
Murmeltiere/Ratten/…
Wrack a mole – Spielmaschine und Hammer sound
Timer Leichter Sound, Türe öffnen in die Freiheit Geräusch
Death Screen / Winner Screen Sounds stoppen und Musik startet

# Arbeitsschritte: 
1. Spielfunktionen einbauen (VR Tauglich gestalten). Kann sich der Spieler bewegen?
Wie groß müssen meine Objekte sein? VR Testung.
2. Spiel 1: Ostereier Assets mit Farbe und Nummer zuweisen mit Sound. Rechnungen
aufstellen und Lösungen in Buttonfunktion einspeisen. Wenn Ei aufgehoben, dann erscheint
im Canvas diese Farbe des Eies mit dem angegebenen Wert.
3. Weiterarbeiten an Einspeisung in Canvas. Dann Werte vergleichen und bei True
Animation „Falltüre“ ausführen. Built Exe und Testen.
4. Probleme Spiel 1 beheben.
Death Screen: Neustart und Exit Button. Musik und Sounds off und neues Lied startet.
Spiel 2 Rechere wie im VR Bereich.
5. Spiel 2: Timer und Score. Murmeltiere welche Random auf und ab bewegen. Timer
läuft aus: 1 Leben von 3 reduziert. Ein Objekt ober Spiel entfernt. Wenn 3 mal verloren,
dann Death Screen.
6. Triggerfunktion die Score steigen lässt. Wenn bestimmte Anzahl an Murmeltieren:
Dann True und Türe in Freiheit mit Winner Screen. Winner Screen: “Du hast es geschafft.”
Neustart und Exit Button. Musik und Sounds off und neues Lied startet.
7. Untergrund einbauen. Bei Untergrund: Hammer einfügen, Wasser StandartAssets einbauen.
8. Weiter Arbeiten an Spiel 2. Dann in VR Modus Testen. Timer einbauen: 15min Zeit
für Spiel und falls abgelaufen: Death-Screen erscheint.
9. Probleme Spiel 2 beheben und Spiel 2 fertig stellen (falls benötigt). Erneut Testen
10. Design Start: Spiel 1: Ostereier, Button, Falltüre, Wände mit Blechtdach, Böden.
11. Sounds downloaden, richtig convertieren und in Scene einbinden
12. Untergrund designen und Wasser mit Nebel einbinden. Assets für Spielbeginn und
weitere Dekorationen hinzufügen. Design für Spiel 2.
13. Spiel testen und falls noch Zeit vorhanden, Objektanimationen für statische Positionen
14. Verbesserungen und fertigstellung Design und Sounds.
15. Spiel fertigstellen und erneut testen.

## Warum genau dieses Spiel?
Der Nutzer hat ein einmaliges Erleben von Grusel und Rätselspaß. In einer wunderbar grusligen Atmosphäre im Nebel muss der Spiele einfache Rätsel lösen, welche dennoch unter Zeitdruck auszuführen sind. Der Untergrund bietet ebenfalls ein individuelles Highlight, welches dem Spieler vor allem im VR Bereich viel breite im ganzen Spiel bietet. Hierbei spielen auch die Rätsel, welche sich durch das Spiel ziehen eine enorme Rolle: Anstatt nur auf einer Stelle das Rätsel zu spielen, müssen zuvor Eier gesammelt werden, um das MiniGame überhaupt lösen zu können. Auch der Hammer für das „Wrack a hole“ Game befindet sich im Untergrund und muss bis zum Spielende mitgenommen werden.


Copyright by Nadine :)
