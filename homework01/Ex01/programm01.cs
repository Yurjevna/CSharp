int a=26;
int b=36;

int max=a;
int min=b;

if(a>max) max=a;
if(a<min) min=a;
if(b>max) max=b;
if(b<min) min=b;

Console.Write("max=");
Console.WriteLine(max);

Console.Write("min=");
Console.WriteLine(min);