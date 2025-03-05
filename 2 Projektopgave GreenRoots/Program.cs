//Opgave 1
int produktid = 1;
string produkt1Navn = "Bambus tandbørste";
string produkt1Kategori = "Bad";
double produkt1Pris = 39.0;
string produkt1Miljømærke = "Svanemærket";
int produkt1AntalSolgt = 243;

int produkt2Id = 2;
string produkt2Navn = "Genanvendelig kaffefilter";
string produkt2Kategori = "Køkken";
double produkt2Pris = 129.0;
string produkt2Miljømærke = "Ingen";
int produkt2AntalSolgt = 214;

int produkt3id = 3;
string produkt3Navn = "Bioplast Affaldsposer";
string produkt3Kategori = "Rengøring";
double produkt3Pris = 37.44;
string produkt3Miljømærke = "Ok compost HOME";
int produkt3AntalSolgt = 403;

int produkt4id = 4;
string produkt4Navn = "Mulepose";
string produkt4Kategori = "Hobby";
double produkt4Pris = 30.0;
string produkt4Miljømærke = "Ingen";
int produkt4AntalSolgt = 137;

int produkt5id = 5;
string produkt5Navn = "T-shirt øko-bomuld";
string produkt5Kategori = "Fritid";
double produkt5Pris = 200.0;
string produkt5Miljømærke = "Ingen";
int produkt5AntalSolgt = 507;


//Opgave 2
//     output     programnavn(input  navn, input navn)
static double BeregnOmsætning(double pris, int antalSolgt) //input er en double (et kommatal) for prisen
                                                           //og en int (et heltal) for salgs mængden
{
    return (double)pris * antalSolgt; //den outputter (returner) et kommatal som er omsætningen på varen
}

//Opgave 3
static string KategoriserOmsætning(double omsætning) //input er en double (kommatal) for omsætningen af en vare
{
    if (omsætning < 10000) //hvis omsætningen er under 10.000:
    {
        return "Lav omsætning"; //Så bliver outputtet (return) til stringen (teksten) "Lav omsætning"
    }
    else if (omsætning < 50000) //hvis den ikke er under 10.000 men er under 50.000:
    {
        return "Mellem omsætning"; //så outputter vi "Mellem omsætning"
    }
    //"If all else fails" og den er hverken under 10.000 eller
    // er under/ligmed 50.000
    //så må den være over 50.000 som betyder at vi har en "Høj omsætning" 
    return "Høj omsætning";
}


//prøver lige at beregne produkt 4s omsætning
double omsætning = BeregnOmsætning(produkt4Pris, produkt4AntalSolgt);

//så prøver vi lige at kategorisere det
string omk = KategoriserOmsætning(omsætning);

Console.WriteLine(omk); //output: "Lav Omsætning"


//Opgave 4
int antal_dage = 7; //Laver et variable til mængden af dage vi vil simulere
double totalOmsætning = 0; //Starter omsætningen på 0kr da vi ikke har simuleret en dag endu
for (int dagNr = 1; dagNr <= antal_dage; dagNr++) //SåLænge(x;er lavere end eller ligmed y;gør det nedenfor og øg x med 1)  
{
    //Her tager vi antalet af produkter som blev solgt og devidere dem med antalet af dage
    //som giver os gennemsnittet of produkter solgt over de 7 dage (altså en dags salg)
    //fx: vis vi solgte 200 t-shirts så vil det være: 200/7=28.5714285714 som betyder at
    //vi fik 28 t-shirts solgt den dag da vi runder ned.
    //dagNr%3 giver os resten fx. hvis vi er på dag 2 så bliver det +1, dag 1 bliver +0, dag 5 bliver det +2 osv..
    //dette simulere lidt tilfældighed i mængden af daglige salg
    int produkt1DagligtSalg = produkt1AntalSolgt / antal_dage + (dagNr % 3); 
    int produkt2DagligtSalg = produkt2AntalSolgt / antal_dage + (dagNr % 3); 
    int produkt3DagligtSalg = produkt3AntalSolgt / antal_dage + (dagNr % 3); 
    int produkt4DagligtSalg = produkt4AntalSolgt / antal_dage + (dagNr % 3); 
    int produkt5DagligtSalg = produkt5AntalSolgt / antal_dage + (dagNr % 3);

    //Her bruger vi vores tidligere metode 'BeregnOmsætning' til at beregne vores omsætning
    //baseret på de daglige salg som vi har simuleret ovenfor
    double om1 = BeregnOmsætning(produkt1Pris, produkt1AntalSolgt);
    double om2 = BeregnOmsætning(produkt2Pris, produkt2AntalSolgt);
    double om3 = BeregnOmsætning(produkt3Pris, produkt3AntalSolgt);
    double om4 = BeregnOmsætning(produkt4Pris, produkt4AntalSolgt);
    double om5 = BeregnOmsætning(produkt5Pris, produkt5AntalSolgt);

    //så bruger vi += til at tilføje alle vores omsætninger til vores totale omsætning
    //da vi bruger += tilføjes hver iterations omsætninger til det totale
    //dette kunne også skrives som 'totalOmsætning = totalOmsætning+om1+om2+om3+om4+om5'
    totalOmsætning += om1+om2+om3+om4+om5;

    //Here bruger vi Console.WriteLine() til at udskrive vores string.
    //samt bruger vi også '$' operatøren som tillader os at formatere vores string 
    //ved hjælp '{}' tuborgklammer hvor vi skriver vores variabler ind i
    Console.WriteLine($"Dag {dagNr}; Omsætningen for {produkt1Navn} blev: {om1} ({KategoriserOmsætning(om1)})");
    Console.WriteLine($"Dag {dagNr}; Omsætningen for {produkt2Navn} blev: {om2} ({KategoriserOmsætning(om2)})");
    Console.WriteLine($"Dag {dagNr}; Omsætningen for {produkt3Navn} blev: {om3} ({KategoriserOmsætning(om3)})");
    Console.WriteLine($"Dag {dagNr}; Omsætningen for {produkt4Navn} blev: {om4} ({KategoriserOmsætning(om4)})");
    Console.WriteLine($"Dag {dagNr}; Omsætningen for {produkt5Navn} blev: {om5} ({KategoriserOmsætning(om5)})");
    Console.WriteLine($"Dag {dagNr}; Den totale omsætning blev: {totalOmsætning}");
    /*Output på dag 1: 
    Dag 1; Omsætningen for Bambus tandbørste blev: 9477 (Lav omsætning)
    Dag 1; Omsætningen for Genanvendelig kaffefilter blev: 27606 (Mellem omsætning)
    Dag 1; Omsætningen for Bioplast Affaldsposer blev: 15088,32 (Mellem omsætning)
    Dag 1; Omsætningen for Mulepose blev: 4110 (Lav omsætning)
    Dag 1; Omsætningen for T-shirt øko-bomuld blev: 101400 (Høj omsætning)
    Dag 1; Den totale omsætning blev: 157681,32
    */
}