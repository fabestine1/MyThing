#include <stdio.h>

int cut_one(int x,int y,int w,int h,int print);

int main(){
  // input
  int x = -1,y = -1,w = -1,h = -1;
  do{
    printf("X: ");
    scanf("%d",&x);
  } while(x <= 0);

  do{
    printf("Y: ");
    scanf("%d",&y);
  } while(y <= 0);

  do{
    printf("W: ");
    scanf("%d",&w);
  } while(w <= 0);

  do{
    printf("H: ");
    scanf("%d",&h);
  } while(h <= 0);


  if (cut_one(x,y,w,h,0) > cut_one(y,x,w,h,0)){
    cut_one(x,y,w,h,1); // prints cordinates
    printf("\nNumber of tiles: %d\n",cut_one(x,y,w,h,0));
  }
else {
  cut_one(y,x,w,h,1);
    printf("\nNumber of tiles: %d\n",cut_one(y,x,w,h,0));

}

  return 0;
}


int cut_one(int x,int y,int w,int h,int print){
    // first way to cut them
  int number_of_tiles = (w*h)/(x*y);
  int cutting_cordinates_w_x[number_of_tiles];
  int cutting_cordinates_w_y[number_of_tiles];
  int cutting_point = 0,count = 0;

  for (int i = 0; cutting_point<w; ++i)
  {
      cutting_point += x;
      if (cutting_point > w)
      {
        break;
      }
      cutting_cordinates_w_x[i] = cutting_point;
      count++;
  }
  cutting_point = 0;
  int counter = 0;
  for (int i = 0; cutting_point<h; ++i)
  {
      cutting_point += y;
      if (cutting_point > h)
      {
        break;
      }
      cutting_cordinates_w_y[i] = cutting_point;
      counter++;
  }
  if(print){
        printf("\nX cutting points: \n");
        for (int i = 0; i < count; ++i)
        {
            printf("%d\n",cutting_cordinates_w_x[i]);
        }

        printf("\nY cutting points: \n");
        for (int i = 0; i < counter; ++i)
        {
            printf("%d\n",cutting_cordinates_w_y[i]);
        }
  }
  number_of_tiles = count*counter;
  return number_of_tiles;
}
