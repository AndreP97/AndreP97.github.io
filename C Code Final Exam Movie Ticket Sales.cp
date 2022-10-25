#include <iostream>

using namespace std;


double sum(double arr[],double n)
{
double sum = 0; // initialize sum
  
// Iterate through all elements
// and add them to sum
for (int i = 0; i < n; i++)
sum += arr[i];
  
return sum;
}
int main()
{
double adultMovieTicketSales[6]; //array for adult movie sales with setting size 6 (as given in console output)
double childMovieTicketSales[4]; //array for child movie sales with setting size 4 (as given in console output)
double snackSales[4]; //array for snack sales with setting size 4 (as given in console output)
cout<<"Welcome to Best Friends Rescue Charit6y Night at the Movies!"<<endl<<endl;
  
cout<<"Ticket Sales for Adults"<<endl;
int lengthAdult = (sizeof(adultMovieTicketSales)/sizeof(*adultMovieTicketSales)); //lenght of adult movie Sales
for(int i = 0 ; i<lengthAdult;i++){
cout<<"Adult Ticket Price: $";
cin>>adultMovieTicketSales[i]; //taking input one by one
}
cout<<endl;
double adultMovies = sum(adultMovieTicketSales,lengthAdult); //Total cost of adult movie ticlets sold
cout<<"Total adult ticket sales are $"<<adultMovies<<endl;
cout<<endl;
  
  
  
int lengthChild = (sizeof(childMovieTicketSales)/sizeof(*childMovieTicketSales)); //lenght of child movie Sales
cout<<"Ticket sales for Children"<<endl;
for(int i = 0 ; i<lengthChild;i++){
cout<<"Child Ticket Price: $";
cin>>childMovieTicketSales[i]; //taking input one by one
}
cout<<endl;
double childMovies = sum(childMovieTicketSales,lengthChild); //Total cost of child movie tickets sold
cout<<"Total child ticket sales are $"<<childMovies<<endl;
cout<<endl;
  
  
  
  
int lengthSnack = (sizeof(snackSales)/sizeof(*snackSales)); //length of snack Sales
cout<<"Snack Sales"<<endl;
for(int i = 0 ; i<lengthSnack;i++){
cout<<"Snack Price: $";
cin>>snackSales[i]; //taking input one by one
}
cout<<endl;
double snacks = sum(snackSales,lengthSnack); //Total cost of snacks sold
cout<<"Total snack sales are $"<<snacks<<endl;
cout<<endl;
  
double Total = adultMovies+childMovies+snacks; //Total of all the sold items
cout<<"Total ticket sales are:"<<Total<<endl;
  
  
double charity = .45*Total; //calulating charity with 45%
cout<<"The total donation for the charity event is:"<<charity; //print charity value
  
  
return 0;
}
