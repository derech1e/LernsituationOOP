# LernsituationOOP
Ein Lernprojekt das den Aufbau und die Vererbung von Klassen darstellen soll.
Aufgabe ist es den Prototyp einer Autoreservierung-Software sinvoll umzusetzen. 

### Klicke [hier](https://github.com/derech1e/LernsituationOOP/releases/tag/1.0.0) um dir die Release Executable herunterzuladen.

## Json.NET (Newtonsoft.JSON)
Link zur Webseite: https://www.newtonsoft.com/json

Link zur Dokumentation: https://www.newtonsoft.com/json/help/html/Introduction.htm


## UML Diagramm

![umldiagramm](.screenshots/UML_Diagramm.png)

## Klassendiagramm

![klassendiagramm](.screenshots/Klassendiagramm.png)

## Speichern einer Liste im JSON Format
### Serilisieren eines Objektes
Folgende Methode wird zum Serilisieren des Listen-Objektes benutzt. Des weiteren wird der formatierte String in einer Datei gespeichert.
```
private static void SerializeObjectToFile(string filePath, object objectToJson)
{
    string jsonString = JsonConvert.SerializeObject(objectToJson);
    File.WriteAllText(filePath, jsonString);
}
```

### Lesen einer Datei
Die Methode überprüft zunächst, ob es die angegebene Datei gibt. Wenn ja, wird der Inhalt dieser Datei versucht zu lesen.
```
private static string ReadTextFromFile(string filePath) => !File.Exists(filePath) ? "" : File.ReadAllText(filePath);
```

### Speichern der Reservierungsliste
Diese Methode ruft ```SerializeObjectToFile``` auf, um die Liste als Json in einer Datei zu speichern.
```
public static bool SaveReservierungen()
{
    SerializeObjectToFile(Utils.FILE_PATH_RESERVIERUNGEN, Utils.Reservierungen);
    return true;
}
```

### Laden der Reservierungsliste
Es wird versucht, den erhaltenen Text von der Methode ```ReadTextFromFile``` als Objekt zu Deserilisieren. Dabei muss der Typ des Objektes festgelegt werden. In diesem Fall ```List<Reservierung>```. Wenn dies erfolgreich funktioniert hat, wird die Liste übergeben. Sollte es jedoch zu einem Fehler kommen, wird mit ```??``` überprüft ob die Liste ```null``` ist und dann ggf. mit einer leeren Liste ersetzt.

```
public static bool LoadReservierungen()
{
    List<Reservierung> reservierungen = JsonConvert.DeserializeObject<List<Reservierung>>(ReadTextFromFile(Utils.FILE_PATH_RESERVIERUNGEN));
    Utils.Reservierungen = reservierungen ?? new List<Reservierung>();
    return true;
}
```


