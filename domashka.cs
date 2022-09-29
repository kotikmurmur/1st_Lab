#region task 1.4
double x=Convert.ToDouble(Console.ReadLine());
double s=Math.Cos(x);
if(x!=0){
for( int i=1;i<9;i++){
     s += Math.Cos((i + 1) * x) / Math.Pow(x, i);
}
}

Console.WriteLine(s);
#endregion


#region task 1.9
double a=1,s=0;
for(int i=1;i<=6;i++){
a*=i;
s+=(Math.Pow(-1,i)*Math.Pow(5,i))/a;
}
Console.WriteLine(s);

#endregion 
#region 1.15
int chisl=1;
int znament=1;
string [] nums = new string [10];
int i=0;
while (i<6){
string ab=chisl.ToString();
string bc=znament.ToString();
nums[i]=(ab +"/"+bc);

chisl=chisl+znament;
znament=chisl-znament;
i++;
}
Console.WriteLine(nums[4]);
#endregion 
#region 1.16
int a=1;
double x=1;
double s=0;
while(a<65){
    s+=x;
    x*=2;
    a++;
}
s/=15000000;
Console.WriteLine(s+" тонн");
#endregion 
#region 1.18
int s = 10;

 for (int i = 3; i <= 24; i += 3){
        s=s*2;
        Console.WriteLine($"Часы {i} количество клеток =  {s}");
}
#endregion 
#region 2.2
double p=1;
int n=1;
const double L=30000;
do{
n+=3;
p*=n;
} while(p<L);
Console.WriteLine($"{n-=3}");
#endregion 
#region 2.4
// -1<x<1
double s=0;
Console.WriteLine("Введите значение от -1 до 1");
var x = Convert.ToDouble(Console.ReadLine());
for(int i=0; ;i+=2){
    if(Math.Pow(x,i)>0.0001){
        s+=Math.Pow(x,i);
    }
    else{
        break;
    }

}
Console.WriteLine(s);

#endregion 
#region 2.7.1
double daily=10;
double sum=0;
for(int i=1;i<=7;i++){
    sum+=daily;
daily*=1.1;

Console.WriteLine($"День {i} - {sum} км");
}
#endregion 
#region 2.7.2
double daily=10;
double sum=0;
for(int i=1; ;i++){
    sum+=daily;
    daily*=1.1;
    if(sum>=100){
        Console.WriteLine($"День {i} - {sum} км");
        break;
    }
}
#endregion 
#region 2.7.3
double daily=10;
for(int i=1; ;i++){
    daily*=1.1;
    if(daily>=20){
        Console.WriteLine($"День {i} - {daily} км в день");
        break;
    }
}
#endregion 
#region 3.1
double e = 0.0001;  
double y;

for (double a = 0.1; a < 1; a += 0.1){
    int c = 1;
    double x;
    int i = 0;
    double s = 0;
    double fac = 1;
    do{
        x = c * Math.Pow(a, 2 * i) / fac;
        s += x;
        i ++;
        fac *= ((2 * i - 1) * 2 * i);
        c = -c;
        } 
    while (Math.Abs(x) > e);
    y = Math.Cos(a);
    Console.WriteLine($"x = {a}; s = {s};  y = {y}");
}
#endregion
#region 3.9
double s,x,y,c,n;
const double eps=0.0001;
for(x=0.1;x<=0.5;x+=0.5){
s=0;
c=0.1;
n=1;
while(Math.Abs(c)>=eps){
s+=c;
c*=(-1)*Math.Pow(x,2)*(2*n-1)/(2*n+1);
n+=1;
}
y=Math.Atan(x);
Console.WriteLine($"s={s:f4}, y={y:f4}");
}

#endregion
