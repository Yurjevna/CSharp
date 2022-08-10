int a=26;
int b=36;
int c=10;

int max=a;
int min=b;

if(a>max) max=a;
if(b>max) max=b;
if(c>max) max=c;
if(a<min) min=a;
if(b<min) min=b;
if(c<min) min=c;

Console.Write("max=");
Console.WriteLine(max);

Console.Write("min=");
Console.WriteLine(min);