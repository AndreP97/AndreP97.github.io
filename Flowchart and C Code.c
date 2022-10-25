// program.c

#include<stdio.h>

int main(){
// declare the number to scan from user
int n;
printf("Enter number: ");
scanf("%d", &n);
// multiplying the same number
int result = n * n;
// printining the result
printf("multipication  of %d X %d = %d\n",n,n,result);
return 0;}
