


using System.Text.RegularExpressions;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;



Console.WriteLine(DigitoVerificador("123ab7"));
Console.WriteLine(DigitoVerificador("1234567"));
Console.WriteLine(DigitoVerificador("123abD7"));
Console.WriteLine(DigitoVerificador("12ab7"));
Console.WriteLine(DigitoVerificador("123ab"));
Console.WriteLine(DigitoVerificador("1233ab7"));
Console.WriteLine(DigitoVerificador("123afb7"));
Console.WriteLine(DigitoVerificador("123ab74"));



static int DigitoVerificador(string input)
{
    string pattern = @"^[0-9]{3}[a-zA-Z]{2}[0-9]{1}$";
    Regex regex = new Regex(pattern);
    MatchCollection matches = regex.Matches(input);

    if (matches.Count > 0)
    {
        return int.Parse(input.Substring(2, 1));
    }
    else
    {
        char lastNumericChar = '\0';
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(input[i]))
            {
                lastNumericChar = input[i];
                break;
            }
        }
        return int.Parse(lastNumericChar.ToString());
    }
}
//for (var a = 1; a <= 50; a++) {
//    var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
//    var b = Convert.ToInt64((DateTime.UtcNow - epoch).TotalMilliseconds);


//    Console.WriteLine(b);
//    Console.WriteLine(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
//}



//if ((DateTime.Today - new DateTime(DateTime.Today.Year, 1, 1)).Days == 255) Console.WriteLine("Felicidades NERDS, ya no vean tanto anime");


//string stringCodigo = "\"\":\"482150419585\"\"\":\"425.50\"";
////Regeex
////string detectaQR = @"[^0-9.:]";
////Regex regex = new Regex(detectaQR);
//string remplazados = Regex.Replace(stringCodigo, @"[^0-9.:]", "");
////Match match = Regex.Match(remplazados, detectaQR);
//string[] substrings = remplazados.Split(':');
//double monto=0;
////if (subStrings.Length == 3 && subStrings[1].Length == 12 && double.Parse(subStrings[2], monto)) {

////}
////else if (regex.Length == 12) {
////    throw new Exception("2 digitos del código.");
////}
////else {
////    throw new Exception("No se pudo leer el QR/Código de barras o capturaron los 12 digitos del código.");
////}

//if (substrings.Length==3 && substrings[1].Length == 12 && double.TryParse(substrings[2], out monto)) {
//    Console.WriteLine(substrings.Count() + " -------- ");
//    foreach (var s in substrings) {
//        Console.WriteLine($"{s}");
//    }
//    //Console.WriteLine("Found '{0}' at position {1}.", match.Value, match.Index);
//   // Console.WriteLine("La cadena contiene solo números, puntos y dos puntos.");
//}
//else {
//    //Console.WriteLine("La cadena contiene caracteres no permitidos.");
//}
//Console.WriteLine(remplazados);






//using System.Text.RegularExpressions;
//string salario = "12000";
//Console.WriteLine(Regex.Replace(salario, "^[0-9]2", "00"));





#region MongoDB
//using MongoDB.Bson;
//using MongoDB.Driver;

//var mongourl = "mongodb://localhost:27017/";

//var client = new MongoClient(mongourl);
//var dblist = client.ListDatabases().ToList();
//Console.WriteLine("bases:");
//foreach (var db in dblist) {
//    Console.WriteLine(db);
//}

//var document = new BsonDocument
//{
//   { "account_id", "MDB829001337" },
//   { "account_holder", "Linus Torvalds" },
//   { "account_type", "checking" },
//   { "balance", 50352434 }
//};
//var database = client.GetDatabase("pfizer");
//var lacollection = database.GetCollection<BsonDocument>("Nueva");
////lacollection.InsertOne(document);
//var cuenta = lacollection.Find(_ => true).ToList();
//foreach (var a in cuenta) { Console.WriteLine(a); }
#endregion


#region clase 7 polimorfismo


//Mexico mexico =  new Mexico();

//EEUU eeuu = new EEUU();



//List<Pais> paises = new List<Pais>();

//paises.Add(mexico);
//paises.Add(eeuu);


//foreach (Pais pais in paises)
//{
//    pais.CantarHimno();
//}

//public class EEUU : Pais
//{
//    public override void CantarHimno()
//    {
//        idioma = "ingles";
//        Console.WriteLine("En la tierra de la libertad... (cantan en " + idioma + ")");
//    }
//}

//public class Mexico : Pais
//{
//    public override void CantarHimno()
//    {
//        idioma = "Español";
//        Console.WriteLine("Mexicanos al grito de guerra... (cantan en "+ idioma + ")");
//    }
//}
//public  class Pais
//{
//    protected string idioma = "Idioma natal";
//    public virtual void CantarHimno()
//    {
//        Console.WriteLine("Viva nuestro pais");
//    }
//}

#endregion




#region clase 5 herencias


//ExtraRandom random= new ExtraRandom();
//Console.WriteLine(random.nextLetter());

//public class ExtraRandom : Random
//{
//    public String nextLetter()
//    {
//        int letraInicial = 97;
//        int randomInt = new Random().Next(0,26) + letraInicial;

//        return  "" + (char)randomInt;
//    }
//}


#endregion



#region clase 3

//Enfermedad polio = new Enfermedad("Polio", false);
//Enfermedad gripa = new Enfermedad("Gripa", true);
//Enfermedad vitiligio = new Enfermedad("Vitiligo", false);
//Enfermedad covid = new Enfermedad("Covid", true);
//Enfermedad cancer = new Enfermedad("Cancer", false);
//Enfermedad malaria = new Enfermedad("Malaria", false);

//new Enfermedad("po",true).esCurable();

//List<Enfermedad> enfermedades = new List<Enfermedad>();

//enfermedades.Add(polio);
//enfermedades.Add(gripa);
//enfermedades.Add(vitiligio);
//enfermedades.Add(covid);
//enfermedades.Add(cancer);
//enfermedades.Add(malaria);

//Console.WriteLine("Enfermedades curables:");
//foreach (Enfermedad enfermedad in enfermedades)
//{
//    if (enfermedad.esCurable()) Console.WriteLine(enfermedad.getNombre());
//}

//Console.WriteLine(polio.getIntentosDeCura());

//public class Enfermedad
//{
//    private String _nombre;
//    private bool _curable;
//    static int _intentosDeCura;
//    public int getIntentosDeCura() { return _intentosDeCura; }

//    public Enfermedad (String nombre, bool esCurable)
//    {
//        _nombre = nombre;
//        _curable = esCurable;
//    }
//    public bool esCurable() {
//        _intentosDeCura++;
//        return _curable; }
//    public string  getNombre() { return _nombre; }
//}



#endregion






#region clase 2

//Descomentar para correr ejemplo de esa clase

/*
Duck moby = new Duck("Moby", 0, "Burgers");
Duck wolfgang = new Duck("wolfgang", 0, "Chilly");
moby.Cuack();
wolfgang.Waddle();
Console.WriteLine(moby);
moby.Waddle(); moby.Waddle(); moby.Waddle();
Console.WriteLine(moby);



public class Duck
{
    private String _name;
    private int _life;
    private String _favoriteFood;
   
    public Duck(String name, int life, string favoriteFood)
    {
        _name = name;
        _life = life;
        _favoriteFood = favoriteFood;
    }
    public void Waddle()
    {
        _life++;
        Console.WriteLine(this._name+ " " + "se menea");
    }
    public void Cuack()
    {
        Console.WriteLine(this._name + " " + "hace cuack");
    }
    public override string ToString()
    {
        return ("Me llamo " + _name +  " y me gusta comer " + _favoriteFood + " y he dado " + _life + " pasos");
    }

}
*/

#endregion