using System;

namespace WindowsFormsApplication1{
  
public class Program { 

public static void Main () {
        int[,]tri = new int[100,100];
	    string[] m = new string[100];
	     int i,j,n;
	     Console.WriteLine("Enter the number of rows");
	     n = Convert.ToInt32(Console.ReadLine());
	    
	    for(i=0;i<n;i++)
		{
			
			m[i] = Console.ReadLine();
		
			for(j=0;j<=i-2;j++)
			{
				tri[i,j] =  Int32.Parse(m[i].Split(' ')[j]);
			}
		}
	        /*for(i=0;i<n;i++)
	     	{
	        for(j=0;j<=i;j++)
			{
				Console.WriteLine(tri[i,j] + " ");
			}
	         Console.WriteLine("");
	     	}*/
            
		

		
	
	//******************************************************//
     for ( i = n - 1; i >= 0; i--) 
        { 
            for ( j = 0; j <= i; j++) 
            { 
                // for each element,  
                // check both elements 
                // just below the number 
                // and below right to 
                // the number add the 
                // maximum of them to it 
                if (tri[i + 1,j] > tri[i + 1,j + 1]) 
                    tri[i,j] += tri[i + 1,j]; 
                else
                    tri[i,j] +=  tri[i + 1,j + 1]; 
				
            } 
        } Console.WriteLine("The output is ");
	      Console.WriteLine(tri[0,0]);
      
        // return the top element 
        // which stores the maximum sum 
    
    } 
}
}