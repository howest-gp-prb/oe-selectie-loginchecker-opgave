# oe-selectie-loginchecker-opgave
**Dit is een console-applicatie die checkt of je de basisinhoud over het hoofdstuk 'Selectie' begrijpt. Gezien het een console-applicatie betreft, komt er dus géén WPF aan te pas!**

## Startsituatie:
We maken een applicatie waarmee we checken of een gebruiker mag inloggen. We checken een aantal situaties om toegang te geven en printen een boodschap op het scherm afhankelijk van de situatie.

Je krijgt een aantal variabelen cadeau; deze staan helemaal bovenaan in de code. De variabelen zijn:
* `static int questionNumber`
* `static string userName`
* `static string password`
* `static int age`
 
Bovendien werd reeds de methode ` static void MakeNewQuestionLine()` gemaakt. Deze wordt gebruikt om te noteren 
aan welke oefening je bezig bent. Bekijk ze eens: je merkt dat de methode `questionNumber` gebruikt; een variabele buiten de scope van de methode.
Zo kunnen we bijhouden wat het nummer van de volgende vraag moet zijn.

*:warning:Belangrijk: gezien we werken met een console-applicatie is het `static` keyword nodig. Doe dit nooit in een WPF-applicatie!*

## Opdrachten
Gebruik telkens `Console.WriteLine()` om je boodschap te noteren.

### Opdracht 1
We beginnen met het onderscheid te maken tussen een gebruiker en een administrator.
Indien de `userName` gelijk is aan "Admin", dan printen we "Hi admin!". Indien niet, dan printen we "Hi user!".

### Opdracht 2
We draaien de logica eens om.
Indien de `userName` niet gelijk is aan "Admin", dan printen we "Hi user!". Indien wel, dan printen we "Hi admin!".

### Opdracht 3
We voegen een een extra optie toe: een mystery user. Indien de `userName` gelijk is aan "Admin", dan tonen we nog steeds "Hi admin!" en in alle andere gevallen
"Hi user!". Echter, indien de `userName` gelijk is aan "SecretUser", dan printen we "Hello there, mystery man!". Gebruik else if.

### Opdracht 4
We checken nu ook of het `password` klopt met de `userName`. Enkel een administrator kan inloggen met de `userName` "Admin" en het wachtwoord "ilovec#".
Als dat lukt, tonen we de zin "Successfully logged in as admin.". In alle andere gevallen tonen we "Login as admin failed.".

### Opdracht 5
We willen graag onze eigen naam ook kunnen gebruiken als alternatief op "Admin". Indien `userName` gelijk is aan "jouw_naam" óf "Admin", dan 
schrijven we "Godlike!". In alle andere gevallen noteren we "Godlike powers still have to be obtained.". We check het wachtwoord nog eventjes niet.

### Opdracht 6
We checken nu ook het wachtwoord. Inloggen kan wanneer de `userName` gelijk is aan "Admin" óf "jouw_naam" én het wachtwoord "ilovec#" is.
Als dat lukt, schrijf je "Logged in as admin with correct password.", lukt het niet dan schrijf je "Login as admin failed.".

### Opdracht 7
Gebruik nogmaals een else if voor de mystery user. Indien iemand inlogt met `userName` "Admin" én het `password` is "ilovec#", 
dan noteren we "Logged in as admin with correct password", maar voor de `userName` "SecretUser" met het wachtwoord "ilovec#" noteren 
we "Login as mystery user.". In alle andere gevallen noteren we "Login failed.".

### Opdracht 8
Indien er ingelogd wordt "Admin" en "ilovec#", dan noteren we "Logged in as admin with correct password.".
In alle andere gevallen gaan we ervan uit dat er ingelogd wordt als een gewone gebruiker, maar doen we nog een extra check: namelijk 
of de gebruiker zijn `age` (leeftijd) wel groter of gelijk is aan 18 jaar oud. Is hij 18 of ouder, dan schrijven we "Logged in as a normal user. You can see all content.".
In alle andere gevallen noteren we "Logged in as a minor. You can not see everything.".

### Opdracht 9
We willen onze applicatie gebruiksvriendelijker maken door te checken top de top 5 meest gebruikte wachtwoorden uit 2019. Deze wachtwoorden
zullen we niet accepteren:
1. 123456
2. 123456789
3. qwerty
4. password
5. 1234567

Gebruik hiervoor een **switch**. Wordt één van de bovenstaande wachtwoorden gebruikt, dan noteer je "You cannot use this password.". Daarnaast
voeg je een extra lijn toe waarin je vermeld het hoeveelste meest gebruikte wachtwoord het betreft, bijvoorbeeld: "Password is the second most common password in 2019.".
In alle andere gevallen noteer je "Password accepted.".

### Opdracht 10
maak een `bool canLogin` en zorg ervoor dat deze enkel werkt met `userName` "jouw_naam" en `password` "ilovec#".
Gebruik vervolgens de bool in een if .. else-statement om "You successfully logged in!" te noteren wanneer het lukt. en "Access denied" noteert wanneer het niet lukt.
