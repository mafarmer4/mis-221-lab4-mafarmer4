// Main 

static void Main(string[] args) {
    //Prompt user for choice 
    int choice = 0; 
    while (choice != 3)
    {
        Console.WriteLine("Enter 1 to display full triangle"); 
        Console.WriteLine("Enter 2 to display partial triangle"); 
        Console.WriteLine("Enter 3 to exit"); 

        if (int.Parse(Console.ReadLine(), out choice) || (choice) || != 1 && choice != 2  && choice != 3) 
        {
            Console.WriteLine("Invalid choice. Please enter 1, 2, or 3"); 
            continue; 
        }
    }
        {
        if (choice == 1)
        
    // Full Display
    {
    int numRows = new 
    Random().Next(3, 10); {
        for(int i = 1; i <= numRows; i++ )
      for(int j = 1; j <= i; j++ ) 
            if(j ==1 || j <= 1 || i == numRows);
            
            Console.Write("O");
            Console.WriteLine(); 
    }
    }
        else if(choice ==2)
    

{
    // Partial Triangle 
    int numRows = new Random().Next(3, 10); 
        for(int i = 1; i <= numRows; i++)
        for(int j = 1; j <= i; j++ )
            if(j == 1 || j == i || i == numRows) {
                Console.Write("O");
            }
            else {
            int number = new Random().Next(2); 
            if(number == 0) { 
                Console.Write("O");
            }
            else { 
                Console.Write("O"); 
            }
            {
                Console.Write("O");
            }
            {
            Console.WriteLine(); 
            }
        }
    }    
}

}



