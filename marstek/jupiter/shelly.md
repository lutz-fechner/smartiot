# Shelly Integration

Der beim Jupiter meist im Lieferumfang befindliche CT001 Smartmeter weist leider einige Mängel auf, so dass der Speicher im Modus Selbstanpassung nicht genau regeln kann. Als Lösung für das Problem bietet Marstek mittlerweile andere Smartmeter an. Zusätlich lässt sich der Shelly Pro 3EM Smartmeter einbinden, nachdem der Speicher ein Update erfahren hat.

Folgende Schritte sind notwendig um den Speicher mit dem Shelly Smartmeter zu koppeln.

1. Update anfordern  
Das benötigte EMS Update auf Version V120 wird nicht automatisch angeboten. Es muss über den Kunden-Support von Marstek angefordert werden. Hierfür unter "Benutzer-Feedback" Marstek kontaktieren und das Vorhaben schildern. Das Firmwareupdate wird dann in kürzester Zeit in der App verfügbar.

2. Shelly Pro 3EM vorbereiten  
In den Einstellungen des Shelly Smartmeters unter "Netzwerke" (Weltkugel-Symbol) in der Rubrik "RPC über UDP" den Port 1010 eintragen. Das Feld Zieladresse leer lassen.

3. Update durchführen  

4. Unter Arbeitsmodus auf Selbstanpassung umstellen und den Shelly Smartmeter auswählen.