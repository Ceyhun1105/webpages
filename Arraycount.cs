using System;
class HelloWorld {
  static void Main() {
int[] Array = {1,3,2,4,1,0,2};
int[] NewArr = new int[Array.Length];
int count= 0;

for(int i=0 ; i<Array.Length ; i++){
    bool Have=false;
    for(int j=i ; j<Array.Length;j++){
        if(Array[i]==Array[j]){
            count++;
        }
    }
    for(int c=0; c<i;c++){
        if (Array[i]==NewArr[c]){
            Have=true;
            break;
        }
        }
    if (Have==false){
    Console.WriteLine("number = "+Array[i]+"  >>>  count = "+count);
    }
    NewArr[i]=Array[i];
    count=0;
    
}
}
}
