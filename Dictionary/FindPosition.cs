int[] arr = new int[] {10,20,30,40,50,80};
    int num = 70;
    int[] result = resultDic(arr,num);
    for(int i=0; i< result.Length; i++)
    {
        Console.WriteLine(result[i]);
        }
        
    public static int[] resultDic(int[] a, int b){
      Dictionary<int,int> d = new Dictionary<int,int>();
      for (int i = 0; i < a.Length; i++)
      {
          //d.Add(a[i], i);
          int m = b - a[i];
          if( d.ContainsKey(m) == true)
          { 
              Console.WriteLine(i);
             return new int[] {i, d[m]};
            }
            else{
                d[a[i]] = i;
                }
          }
          throw new Exception("there is not answer!");
    }