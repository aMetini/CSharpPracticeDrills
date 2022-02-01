# CSharpPracticeDrills

Övningsuppgifter
Jag hittar på övningsuppgifter och fyller på denna listan allt eftersom, så ni har något att
jobba med. Övningsuppgifterna här och på Project Euler är inte obligatoriska, och behöver
alltså inte redovisas. Däremot går jag gärna igenom utvalda uppgifter och löser gemensamt
om ni vill det. Så säg till om ni kör fast med någon (eller bara vill att vi jämför olika lösningar).
1. Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på
konsolen. Om namnet är "David" ska det skriva ut "Hej David!"
2. Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt
lösenord och spara det i en variabel. När användaren har skrivit in ett lösenord ska
programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller
inte. Använd en if-sats.
3. Skriv ett program som frågar användaren efter ett tal. Det ska skriva ut om talet är
mindre än 100, lika med 100 eller större.
4. Uppdatera programmet i uppgift 1 så att det även frågar efter ett tal. Skriv hälsningen
så många gånger som användaren anger.
5. Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man
skriver något som inte är ett tal (t.ex bara trycker enter). Efter varje inmatning ska
summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas.
Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade
talen. Hint: TryParse()
6. Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande
tecken: +, -, * eller /. Därefter ska ytterligare ett tal efterfrågas. Programmet ska
fungera som en simpel miniräknare. Om man t.ex matat in först 3, sedan *, och sist
5, så ska programmet skriva ut “3 * 5 = 15”.
7. Skriv ett program som ber användaren skriva in en månad. Programmet ska göra om
månaden till månadens siffervärde. T.ex. ska januari bli 1 och december 12. Använd
switch.
Alternativ: Prova även att lösa uppgiften med array och/eller enum.
Extra utmaning: Be användaren om två månader och räkna sedan ut hur många
månader som skiljer mellan dem. Tänk på att ett månaderna upprepas till nästa år.
Skriver man mars och maj bör man få 2. Likaså om man skriver november och
januari.
8. Skapa ett program som skriver ut 1 på första raden, 2 på nästa, sedan 4, o.s.v
(dubbelt så hög siffra för varje rad). Fortsätt till du skrivit ut 16 rader.
9. Skriv ett program som frågar användaren efter ett tal mellan 1 och 100. Programmet
ska ha ett hemligt tal lagrat i en variabel. Det ska fortsätta fråga användaren till dess
att användaren gissar det hemliga talet. Om man gissade för högt eller för lågt så ska
det skrivas ut, så att användaren har en rimlig chans att klara det.
Exempel: programmet har det hemliga talet 27. Användaren gissar på 50.
Programmet skriver ut att användaren gissade för högt. Användaren gissar på 20.
Programmet skriver ut att det var för lågt. Användaren gissar på 27. Programmet
skriver ut att det var rätt och avslutas.
Extra utmaning: slumpa det hemliga talet med hjälp av Random (kolla upp på google
hur det fungerar). Spara antalet gissningar i en variabel och skriv ut det när
användaren gissat rätt.
Extra utmaning 2: skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax”
eller “påse”. Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och
vem som vann omgången. Lägg det hela i en loop så spelet fortsätter tills man matar
in en tom sträng (trycker enter utan att skriva något). Skriv även ut poäng.
10. Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad.
Ex: Hej =>
H
e
j
11. Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”,
“fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”. Be sedan användaren att mata in en siffra.
Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.
Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man
skriver in t.ex 432 så svarar programmet: “fyra-tre-två”.
12. Fråga användaren hur många tal den vill mata in. Fråga sedan efter talen i tur och
ordning (“Ange tal 1:” osv). När alla tal är inmatade skriv ut dem i omvänd ordning.
13. Be användaren mata in en text. Skriv sedan ut texten baklänges.
14. Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *
Extra utmaning: Skriv ut texten översatt till rövarspråket.
15. Ett palindrom är ett ord som blir samma framlänges som baklänges. Be användaren
skriva in ett ord och ange sedan om det är ett palindrom eller inte.
16. Gör om uppgift 6 så man kan mata in allt på en rad (första talet, operator, andra
talet). Ignorera inmatade mellanslag i strängen. Om man t.ex. matar in strängen
“34 - 14”, så ska programmet skriva ut “= 20”.
17. Gör ett program som ber användaren mata in en text. Be sedan användaren mata in
en sträng som är en del av den första texten. Skriv ut hela texten med den del man
angav markerad i en annan färg. Ex. Användare matar in
“abcdefghijklmnopqrstuvxyz”, och sedan “defg”. Programmet ska då skriva ut:
abcdefghijklmnopqrstuvxyz
18. Be användaren mata in en mening. Skriv ut det genomsnittliga antalet bokstäver i
orden.
19. Skriv en metod DrawBox(int width, int height)
När man anropar metoden ska den tömma konsolen och skriva ut en rektangel där
de yttre tecknen består av ‘#’ och de inre av ‘-’
Exempel: DrawBox(7, 4);
#######
#- - - - -#
#- - - - -#
#######
20. Använd DrawBox-metoden i föregående uppgift för att rita en box. Placera sedan ett
@ i mitten av boxen. Om man använder piltangenterna ska man kunna flytta runt @.
När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den
nya positionen. Spara bredd och höjd på boxen så du vet när den ska stanna.
21. Skriv om DrawBox så den istället returnerar en 2D-array av char med tecknen som
den tidigare skrev ut på displayen. Man ska också kunna mata in en tredje parameter
för antal slumpade ‘#’. Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på
random ställen inne i boxen.
Skriv sedan en annan metod som tar och ritar ut arrayen på skärmen. Fixa så man
kan flytta runt @ med piltangenterna. Jämför positionen mot arrayen och gör så man
inte kan gå på någon ‘#’.
Extra utmaning: Gör en “orm” av ‘@’. När man flyttar positionen på @ så följer (t.ex)
5 andra @ efter i samma spår som man förflyttat sig.
Extra utmaning 2: I det klassiska spelet “masken” (snake) förflyttar sig en mask i
jämna tidsintervall i den riktning spelaren senast angav med piltangenterna.
Någonstans på banan finns ett äpple masken ska äta. Det gäller för spelaren att ta
sig dit utan att krocka med något hinder, eller sin egen svans. När man tar äpplet blir
masken längre och ett nytt äpple dyker upp på slumpvis vald plats på banan.
Implementera din egen version av spelet.
Hint: Kolla upp Console.KeyAvailable och Thread.Sleep()
Förslag: När du fått en första version av spelet att fungera, lägg till flera banor genom
att hårdkoda in olika banlayout i olika 2D-arrayer. När man tagit ett visst antal äpplen
på en bana så kommer man vidare till nästa.
22. Skriv en funktion som kan ta ett godtyckligt antal strängar som parametrar och som
returnerar den längsta av dem.
23. Skapa en metoden int[] IndexOfAll(string text, char c) som söker igenom strängen
text och returnerar en int[] med index till alla förekomster av c i text.
24. Skriv ett program som skriver ut följande rektanglar på konsolen med hjälp av loopar:
a b c d e f
#------- #---#--- ##------ --#--#-- #---#--- #-#-
-#------ -#---#-- --##---- --#--#-- -#-#---- -#-#
--#----- --#---#- ----##-- ######## --#----- #-#-
---#---- ---#---# ------## --#--#-- -#-#---- -#-#
g h i j k
###--- --#--## --#-- #---# ##--##--##--##--
###--- ---#-## ----- -#-#- ##--##--##--##--
###--- ----#-- --#-- --o-- wwwwww~~~~~~~~~~
------ -----#- --#-- -#-#- ################
#---#
25. Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och
färg. Skapa publika properties för att hämta eller ändra värdet på varje field.
Skriv en konstruktor till bilklassen som inte tar några parametrar. Skriv en till
konstruktor som tar en parameter för varje property som klassen har. Hur kan man
styra vilken konstruktor som anropas när man skapar ett objekt av klassen?
Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset på
bilen sänkas till hälften.
26. Skapa en klass som kan användas som stegräknare. Den ska ha en property Steps
som bara går att läsa; en metod Step() som räknar upp Steps med 1 varje gång man
anropar den; och en metod Reset() som nollställer räknaren.
Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut
värdet på Steps.
27. Skapa en en klass som har en property “red” och en property “blue”. Båda ska vara
en float och kunna ha ett värde mellan 0.0 och 100.0 men de ska vara
“sammankopplade” på så vis att värdena tillsammans alltid är 100.0 d.v.s om man
t.ex. sätter “blue” till 8.5 och sedan läser av “red” så ska den returnera 91.5
28. Skapa klassen “Person”, med properties “FirstName”, “LastName” och “Name”. Om
man ändrar någon av dem, så ska man få ut rätt värden när man läser av de andra.
Använd en konstruktor som tar parametrar “firstName” och “lastName” när man
instansierar objekten. (I en första enklare version så kan Name vara read-only).
Ex1. Person p = new Person(“Anna”, “Berg”); // => p.Name == “Anna Berg”
Ex2. p.Name = “Per Lind”; // => p.FirstName == “Per”, p.LastName == “Lind”
29. Skriv en klass som representerar en bil. Varje bil ska kunna ha en färg som
representeras av en enum (det ska finna minst 5 olika färger på bilar), samt en längd.
När man instansierar en bil så ska den få en random färg, och en random längd
(mellan 3 och 5 meter). Instansiera 1000 bilar och spara i en array. Skriv sedan ut
den sammanlagda längden av alla gröna bilar.
30. Gör en ny version av sten-sax-påse. Varje spelare ska representeras av ett
“Player”-objekt. Man ska kunna anropa en metod på objekten som returnerar en
enum med ett (random) av tre värden (sten, sax, påse). Objekten (klassen) ska ha en
konstruktor som tar namn på spelaren, samt en x-, och y-koordinat som
representerar ett ställe på skärmen där spelarens namn och poäng skrivs ut. Det ska
finnas en property för poäng som automatisk uppdaterar spelarens poäng på den
(x/y) positionen på skärmen varje gång man ändrar värdet på propertyn.
Ex: På översta raden längst till vänster skrivs “Computer: 0”. Varje gång man
uppdaterar poängen (t.ex computer.Score++;) så uppdateras poängen automatiskt
på den positionen. Likadant för den andra spelaren.
Dessutom ska det finnas en statisk metod på klassen som tar två enum (sten, sax,
påse) och returnerar en ny enum (win, lose, draw) som säger om den första
parametern man skickar in vinner över den andra (eller om det blir lika).
Hint: Använd Console.CursorLeft och Console.CursorTop. Spara den tidigare
positionen innan du ändrar; gör uppdateringen, och hoppa tillbaks.
31. Skriv metod: void ConvertDegrees(float Celsius, out float Fahrenheit, out float Kelvin)
Metoden ska ta antal grader i Celsius in, och man ska få ut motsvarigheten i
Fahrenheit och Kelvin i out-parametrarna. Ta input från användaren i Celsius, använd
metoden och skriv ut resultat.
32. Lägg till en statisk metod på klassen i uppgift 29. Metoden ska ta en bil som
inparameter och returnera en array med 10 bilar i samma färg, men med olika längd.
33. Skriv en metod som använder en ref int som in-parameter och som multiplicerar
referensen med sig själv. Den ska även returnera parametern konverterad till en
sträng. Anropa metoden och skriv sedan ut både den inskickade (uppdaterade)
variabeln, och det returnerade värdet.
34. Uppdatera konstruktorn på klassen i uppgift 29 (och 32) så att bilen även får en
random hastighet (mellan 60 och 240 km/h). Skriv en metod DriveForOneHour() som
uppdaterar en property Distance med total körsträcka. Distance ska alltså initieras på
0, och sedan öka för varje gång man anropar DriveForOneHour(). Lägg sedan till en
metod GetGraph() som returnerar en string på 20 tecken som representerar en
körsträcka på 1000 mil och visar bilens position enligt exempel: “|------x-----------|”.
(‘x’ är alltså bilens position mellan start och mål (1000 mil).
Skriv sedan ett program som simulerar att 10 bilar åker 1000 mil i olika hastighet där
varje bils position, samt dess exakta körda distans (i text) uppdateras en gång i
sekunden. (En sekund i simuleringen motsvarar alltså en timma i verkligheten).
hint: Thread.Sleep(1000);
Ex: Bil A: |------x-----------| 3420 km
Bil B: |-------------x----| 8293 km
.. etc ..
Extra utmaning: Lägg till så varje ‘x’ ritas ut i respektive bils färg; och så man ser hur
lång tid som gått sedan start; samt eventuella andra förbättringar du kan komma på.
35. Skapa en klass som har en privat konstruktor, och en statisk metod som anropar
konstruktorn och returnerar en ny instans av objektet.
OM ni är klara; lägg till en public readonly int (field) i klassen som får ett random tal
0-100 för varje objekt som instansieras.
36. Skapa en ny klass, och sedan ytterligare 2 klasser som ärver av den första.
Basklassen ska ha minst en metod och en property som de andra klasserna ärver.
Gör en ny instans av varje typ och anropa metoden på dem.
Skapa en array av samma typ som basklassen, och lagra instanserna
(de du skapade ovan) i arrayen. Loopa igenom array med foreach och anropa metod
på varje objekt.
Använd 'is'-operatorn i loopen och skriv ut olika saker på console beroende
på typ.
37. Skapa en Stack<string>. Gör en loop där användaren matar in text. Pusha varje
inmatad sträng på stacken. När användaren trycker enter utan att skriva något,
avsluta loopen och skriv ut alla strängar i omvänd ordning genom att Pop:a dem från
stacken.
38. Skapa en klass “Person” som har minst 5 properties som lagrar data om en person
(t.ex. namn, telefonnr, etc). Skapa en Dictionary<string, Person> med minst 5
key-value-pairs. Nyckeln ska vara personnummer. Skriv ett program som ber
användaren skriva in ett personnummer, och lista all info om den personen.
39. Skriv en loop som upprepade gånger tar input från användaren. Varje gång
användaren skriver något som inte är en siffra så läggs input i en kö. Om användaren
matar in en siffra (t.ex 3) så skriv ut lika många (3) strängar från kön, i den ordning de
matats in. Om man skriver en högre siffra än vad det finns objekt i kön så skriv ut alla
som finns i kön.
Ex: man matar in först “boll”, sedan “anka”, “bil”, och “fjäril”. Om man sedan matar in
“2” så skrivs “boll” och “anka” ut, matar man sedan in “katt” och “1” så skrivs “bil” ut.
40. Utgå från uppgift 38, och skriv ett program med en meny:
1. Lägg till person i registret
2. Sök person i registret
3. Avsluta programmet
Om man väljer 1 ska man bli tillfrågad att mata in de olika uppgifterna för en ny
person. Om man väljer 2 ska man kunna skriva ett personnummer och få ut
informationen. Efter varje val kommer man tillbaks till menyn, tills man väljer avsluta.
41. Skriv en generisk klass med namnet Safe, som representerar ett kassaskåp. Klassen
ska ha metoderna Store och Retrieve. Store ska kunna lägga till ett objekt i
kassaskåpet. Retrieve ska ta bort och returnera ett objekt som tidigare lagrats i
kassaskåpet.
Om ni vill prova att använda er av rekursiva anrop så kan ni testa följande:
42. Fakultet är en funktion inom matematiken. För ett heltal större än noll är fakulteten
lika med produkten av alla heltal från 1 upp till och med talet självt. Börja med att
skriva en funktion Factorial(n) som räknar ut fakulteten för ett heltal med en loop.
Exempel: n = 4 => 24 (1 * 2 * 3 * 4).
Försök nu skriva en ny funktion som beräknar Fakultet med rekursiva anrop.
43. Fibonacci-tal är en talserie som börjar med 0, 1. Sedan får man nästa tal i talserien
genom att lägga ihop de två föregående. Exempel: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, …
Skriv en funktion Fibonacci(n) som beräknar det n:te Fibonacci-talet rekursivt.
Extrauppgift: gör en funktion som räknar ut det med en loop i stället.
44. Skriv en rekursiv funktion som tar en sträng som parameter och returnerar en ny
sträng, som är den gamla strängen baklänges.
45. a) Skriv ett generiskt delegat som tar två strängar in och returnerar en sträng.
Låt delegatet peka på en lambda expression (anonym metod) som konkatenerar de
två strängarna och returnerar resultatet.
b) Skriv ett generiskt delegat som tar två strängar in (utan att returnerar något)
Låt delegatet peka på en lambda expression (anonym metod) som konkatenerar de
två strängarna och skriver ut resultatet.
c) Skriv ett generiskt delegat som tar en int in och returnerar en int.
Låt delegatet peka på en lambda expression (anonym metod) som returnerar ett tal
dubbelt så stort som det man matar in.
d) Skriv ett generiskt delegat som tar en int in och returnerar en double
Låt delegatet peka på en namngiven metod som returnerar ett tal hälften så stort
som det man matar in.
46. Skapa en array/lista med personer med minst 5 olika egenskaper, och minst 8
personer. Den ska minst ha förnamn, efternamn, längd, och vikt.
a) Använd linq för att skriva ut vikt på alla personer som väger mer än 80 kg.
b) Använd linq för att skapa en ny lista där objekten har hela namnet och längd, vikt
och BMI för alla personer. BMI = vikt / (längd * längd) [vikt = kg, längd = m]
c) sortera listan i (b) efter efternamn, och sedan förnamn (om flera har samma
efternamn)
47. Gör uppgift a, b,c från föregående uppgift med query syntax
48. Gör en metod som tar en int n, och returnerar en lista med alla Factorials upp till n.
(Se uppgift 42 om fakultet).
Skriv därefter en ny metod som gör samma sak fast med yield return.
49. Gör en metod som tar en int n, och returnerar en lista med alla fibonacci-tal upp till n.
(Se uppgift 43 om fibonacci-tal ).
Skriv därefter en ny metod som gör samma sak fast med yield return.
Winforms övningar
50. Skapa en winforms app med en textbox och en knapp. När man klickar på knappen
ska en messagebox visas med texten man skrivit i textboxen.
51. En winforms app med två knappar där den ena är disabled. När man klickar på ena
knappen så ska den man klickar på disablas, och den andra enablas. Och vice
verse.
52. En app med två NumericUpDown och en Label. Labeln visar hela tiden det högsta
värdet av de två NumericUpDown kontrollerna.
53. En sten-sax-påse app med tre knappar där man väljer sten sax eller påse. När man
väljer en så kommer det upp en MessageBox där det står vad datorn valde och om
man vann eller förlorade, samt frågan om man vill spela igen. Visa poängställning
med en label i appen.
Extra utmaning: Gör om designen så att det istället är en ComboBox dropdown där
man väljer sten, sax, eller påse; och en knapp för att Spela.
54. En winforms app med multiline textbox och en knapp, När man klickar på knappen så
öppnas en “Open file”-dialog. Om man väljer en .txt fil så läser programmet in den
och visar i textboxen.
Hint: Se video 70 om StreamReader.
55. En winforms app med två NumericUpDown kontroller; mellan dem ska det finnas en
ComboBox dropdown där man kan välja plus, minus, gånger, eller delat med. Det
ska finnas en textbox där resultatet skrivs ut. t.ex om man väljer 15 plus 12 så skriver
den 27 i textboxen. Resultatet ska uppdateras om man ändrar värdet i någon av
NumericUpDown eller ComboBox.
56. Gör en egen version av notepad. En multiline textbox, och en meny “File” med
alternativen “Open”, “Save”, Save as …” och “Exit”. Om man väljer open får man upp
en OpenFileDialog, och om man väljer en fil läses den in till textboxen. “Save” sparar
filen med samma namn som den hade när man öppnade. Med “Save as …” får man
upp en SaveFileDialog och kan välja att spara filen med ett nytt namn. “Exit” avslutar
appen, men om man gjort ändringar i filen frågar den först om man vill spara.
Hint: Se video 70 om StreamReader och StreamWriter.
Extra utmaning: Lägg till i menyn så den visar, och man kan använda
tangentbordskommandon för de olika valen (t.ex Ctrl+O för “Open”). Lägg också till
så frågan om man vill spara även kommer upp när man stänger på “krysset”, eller
Alt+F4. Lägg till meny alternativet “New” som funkar på samma sätt som i notepad.
57. Gör en winform version av Lab1, med en TextBox där man skriver in en sträng, en
multiline TextBox där alla delsträngar visas, och en Label där summan av alla
delsträngar visas. Det går inte att skriva text med olika färg i en TextBox så istället för
att visa hela strängen med delsträngen markerad så som vi gjorde i Lab1 så visa
istället bara alla delsträngar, en på varje rad. Gör så att delsträngarna och summan
uppdateras i realtid när man ändrar input. (d.v.s varje gång innehållet i input
TextBoxen ändras).
58. Skapa två Task med Task.Run, där den ena skriver “Hello” 100 gånger, och den
andra skriver “World” 100 gånger.
59. Skapa en Task<int> som beräknar summan av alla tal upp till 1000. Använd
task.Wait() för att invänta resultatet i huvudtråden och skriv sedan ut det.
60. Uppdatera uppgift 59 så du istället använder .ContinueWith() för att skapa en ny Task
som skriver ut resultatet när den första kört färdigt.
