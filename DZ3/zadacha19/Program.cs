int a = 12821;
int k1 = a % 10;
int k2 = (a % 100) / 10;
int k3 = (a % 10000) / 1000;
int k4 = a / 10000;
if (k1 == k4 && k2 == k3)
{
    Console.WriteLine("yes");
}
else {
    Console.WriteLine("no");
}
    
