#include<stdio.h>
int main() {  
int n,i=0,a;
scanf("%d",&n);
int arr[n];
while(i<n)
{
scanf("%d",&a);
if(a%2!=0)
{
arr[i]=a;
i++;
}
}
for(i=0;i<n/2;i++){
printf("%d\n",arr[i]-arr[(n-i)-1]);
}
if(n%2!=0){printf("%d\n",arr[n/2]);}
}
