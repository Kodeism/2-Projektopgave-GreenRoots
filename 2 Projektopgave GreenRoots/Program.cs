//     output     programnavn(input  navn,  input navn)
static double BeregnOmsætning(double pris, int antalSolgt) //input er en double (et kommatal) for prisen
                                                           //og en int (et heltal) for salgs mængden
{
    return (double)pris * antalSolgt; //den outputter (returner) et kommatal som er omsætningen på varen
}


static string KategoriserOmsætning(double omsætning) //input er en double (kommatal) for omsætningen af en vare
{
    if (omsætning < 10000) //hvis omsætningen er under 10.000:
    {
        return "Lav omsætning"; //Så bliver outputtet (return) til stringen (teksten) "Lav omsætning"
    }
    else if (omsætning < 50000) //hvis den ikke er under 10.000 men er under 50.000 så outputter vi "Mellem omsætning"
    {
        return "Mellem omsætning";
    }
    return "Høj omsætning"; //hvis den er højere end 10.000 og 50.000 så outputter vi "Høj omsætning"   
}


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
string produkt5Navn = "T-shir øko-bomuld";
string produkt5Kategori = "Hobby";
double produkt5Pris = 200.0;
string produkt5Miljømærke = "Ingen";
int produkt5AntalSolgt = 507;

//prøver lige at beregne produkt 4s omsætning
double omsætning = BeregnOmsætning(produkt4Pris, produkt4AntalSolgt);
//så prøver vi lige at kategorisere det
string omk = KategoriserOmsætning(omsætning);
Console.WriteLine(omk); //output: "Lav Omsætning"