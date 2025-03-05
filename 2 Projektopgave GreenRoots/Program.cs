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

static double BeregnOmsætning(double pris, int antalSolgt)
{
    return (double)pris * antalSolgt;
}

static string KategoriserOmsætning(double omsætning)
{
    if(omsætning<10000)
    {
        return "Lav omsætning";
    }
    else if(omsætning>=10000 && omsætning<50000)
    {
        return "Mellem omsætning";
    }
    return "Høj omsætning";

}

