using System;

class MainClass {  
  public static void Main (string[] args) {
    int[] arr = new int[] {20,6,88,1,0,2,66,2,7,66};
    foreach(var item in arr){
     Console.Write(item+" ,");
    }
    QuickSort(arr);
    Console.WriteLine("\nArray after sort:");
    foreach(var item in arr){
     Console.Write(item+" ,");
    }
  }
  public static void QuickSort(int[] arr){
    int start =0;
    int end=(arr.Length-1);
    Sort(arr,start,end);
  }
  public static void Sort(int[] arr,int start,int end){
    int index = Partition(arr,start,end);
    Sort(arr,start,index-1);
    Sort(arr,index+1,end);
  }
  public static int Partition(int[] arr,int start,int end){
    int pivot = arr[end];
    int Boundary=start-1;
    for(int i=start;i<=end;i++){
      if(arr[i]<=pivot)
        Swap(arr,++Boundary,i);
    }
    return Boundary;
  }
  public static void Swap(int[] arr,int i,int j){
    int temp;
    temp=arr[i];
    arr[i]=arr[j];
    arr[j]=temp;
  }
}