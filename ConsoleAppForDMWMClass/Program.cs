// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Atelier 1 Conversion nombre décimal en son équivalent binaire
string result = "";
string numConv;
Console.WriteLine("Donnez le nombre à convertir");
numConv = Console.ReadLine();
int num = Convert.ToInt32(numConv);
while (num > 1)
{
    int reste = num % 2;
    result = Convert.ToString(reste) + result;
    num = num / 2;

}
result = Convert.ToString(num) + result;
Console.WriteLine("le nombre converti est" + result);

//Test ref et out keywords
int InVar = 0;
FunctTest(ref InVar);
Console.WriteLine("Test Ref effectué");
static void FunctTest(ref int inVar)
{
    inVar = 0;
    inVar = inVar + 20;
    Console.WriteLine(inVar);
}


//Test string length via conditional operator
string Teststring = "Hello Test Conditional operator";
Console.WriteLine(Teststring.Length > 0
    ? "la chaîne est positive"
    : "string est null");



//Faire la multiplication de 3 nombres
//introduis par l'utilisateur
Console.WriteLine("Donnez nombre 1");
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Donnez nombre 2");
int num2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Donnez nombre 3");
int num3 = Convert.ToInt16(Console.ReadLine());
int res=num1*num2*num3;
Console.WriteLine("The result "+res);
Console.ReadKey();




//Test Out keyword
int entierNonFct;
TestOutRef(out entierNonFct);
static void TestOutRef(out int entierFct)
{
    entierFct = 0;
    entierFct = entierFct + 10;
}

//Test switch avec enum
test t = test.a;
switch (t)
{
    case test.a: Console.WriteLine("a"); break;
    case test.b: Console.WriteLine("b"); break;
};
int valueOfa = (int)test.a;
enum test
{
    a,
    b,
    c,
};



