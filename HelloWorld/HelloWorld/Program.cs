namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");   //Used to write strings to console.
            Console.WriteLine("Hello World! V2");//Writeline will start a new line every time.
            Console.Write("Hello World! ");      //Write will not.
            Console.Write("I will print on the same line\n\n");

            /* This is a multi
            -line comment */

            // This is a single line comment

            const int iInt = 100000;   //Stores whole numbers from -2,147,483,648 to 2,147,483,647 4bytes
            const long iLong = 1500000000L;  //Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 8 bytes Ends in L
            const float iFloat = 5.75F;  //Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits 4bytes Ends in F
            const double iDouble = 19.99D; //Stores fractional numbers.Sufficient for storing 15 decimal digits 8 bytes Better for calculations
            const char iChar = 'B';    //stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            const string iString = "This is a string.";    //stores text, such as "Hello World". String values are surrounded by double quotes
            const bool iBool = true;   //stores values with two states: true or false

            Console.WriteLine("Here are all sorts of variables");
            Console.WriteLine(iInt);     //prints infoInt
            Console.WriteLine(iLong);    //Prints infoLong
            Console.WriteLine(iFloat);   //prints infoFloat
            Console.WriteLine(iDouble);  //prints infoDouble
            Console.WriteLine(iChar);    //Prints infoChar
            Console.WriteLine(iString);  //Prints infoString
            Console.WriteLine(iBool);    //Prints infoBool

            const string iPlusCombining = "This is part 1 ";
            Console.WriteLine(iPlusCombining + "This is part 2");    //the plus will add the two parts together



            int iValueLater;     //This int variable
            iValueLater = 18;    //gets it's value later. But cannot be a constant 
            Console.WriteLine(iValueLater);

            char iOverwrite = 'X'; //this declares infoOverwrite as X
            iOverwrite = 'Y';    //This overwrites the value of x into Y in the char type varable named infoOverwrite
            Console.WriteLine(iOverwrite);

            int iAdditionOne = 5;
            int iAdditionTwo = 6;
            Console.WriteLine(iAdditionOne + iAdditionTwo); //Addition!

            int iManyDeclaresOneLine1 = 5, iManyDeclaresOneline2 = 6, iManyDeclaresOneLine3 = 50;   //Declares many varables as the same type in one line
            Console.WriteLine(iManyDeclaresOneLine1 + iManyDeclaresOneline2 + iManyDeclaresOneLine3);

            int iSeperateManyDeclares1, iSeperateManyDeclares2, iSeperateManyDeclares3;
            iSeperateManyDeclares1 = iSeperateManyDeclares2 = iSeperateManyDeclares3 = 50;
            Console.WriteLine(iSeperateManyDeclares1 + iSeperateManyDeclares2 + iSeperateManyDeclares3 + "\n");



            //Operators are used to do diffrent mathematical calculations in variables
            Console.WriteLine("OPERATORS");
            int iSum1 = 100 + 50;        // 150 (100 + 50) 	Adds together two values
            int iSum2 = iSum1 + 250;      // 400 (150 + 250)
            int iSum3 = iSum2 + iSum2;     // 800 (400 + 400)
            int iSum4 = 10;
            iSum4 += 5; //adds 5 to iSum4 Can be done for all operators too
            int iSubtract = 10 - 5; //Subtracts one value from another
            int iMultiply = 10 * 5; //Multiplies two values
            int iDevision = 10 / 5; //Divides one value by another
            int iModulo = 10 % 3;   //Returns the division remainder
            int iIncrement = 10;    //Increases the value of a variable by 1	
            iIncrement++;
            int iDecrement = 10;    //Decreases the value of a variable by 1
            iDecrement--;
            
            Console.WriteLine(iSubtract);
            Console.WriteLine(iMultiply);
            Console.WriteLine(iDevision);
            Console.WriteLine(iModulo);
            Console.WriteLine(iIncrement);
            Console.WriteLine(iDecrement);

            Console.WriteLine(iSum1 == iSum2);  //This checks if iSum1 is equal to iSum2
            Console.WriteLine(iSum1 != iSum2);  //not equal to
            Console.WriteLine(iSum1 > iSum2);   //greater then
            Console.WriteLine(iSum1 < iSum2);   //less then
            Console.WriteLine(iSum1 >= iSum2);  //greater or equal to
            Console.WriteLine(iSum1 <= iSum2);  //less or equal to

            Console.WriteLine(iSum1 > 5 && iSum1 > 10); //Logical and. Returns true if both statements are true
            Console.WriteLine(iSum1 > 5 || iSum1 < 10); //Logical or. Returns true if one of the statements is true
            Console.WriteLine(!(iSum1 > 5 && iSum1 > 10) + "\n");  //Logical not. Reverse the result, returns false if the result is true



            //Boolean Expression
            Console.WriteLine("BOOLEANS");

            Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9
            Console.WriteLine((10 == 15) + "\n"); // returns False, because 10 is not equal to 15



            //The math class
            Console.WriteLine("MATH");
            Console.WriteLine(Math.Max(5, 10)); //finds the highest value of x and y
            Console.WriteLine(Math.Min(5, 10)); //finds the lowest value of x and y
            Console.WriteLine(Math.Sqrt(64)); //returns the square root of x
            Console.WriteLine(Math.Abs(-4.7)); //returns the absolute (positive) value of x
            Console.WriteLine(Math.Round(9.99) + "\n"); //rounds a number to the nearest whole number



            /* Implicit Casting (automatically) - converting a smaller type to a larger type size
                            char -> int -> long -> float -> double */
            Console.WriteLine("TYPE CASTING");
            int iAIntD = 9;
            double iADoubleI = iAIntD;       // Automatic casting: int to double

            Console.WriteLine(iAIntD);      // Outputs 9
            Console.WriteLine(iADoubleI);   // Outputs 9

            /* Explicit Casting (manually) - converting a larger type to a smaller size type
                            double -> float -> long -> int -> char */
            double iMDoubleI = 9.78;
            int iMintD = (int)iMDoubleI;    // Manual casting: double to int

            Console.WriteLine(iMDoubleI);   // Outputs 9.78
            Console.WriteLine(iMintD + "\n");      // Outputs 9



            //Type Conversion Methods: Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)
            Console.WriteLine("TYPE CONVERTING");
            int iIntS = 10;
            double iDoubleI = 5.25;
            bool iBoolS = true;
            Console.WriteLine(Convert.ToString(iIntS));    // convert int to string
            Console.WriteLine(Convert.ToDouble(iIntS));    // convert int to double
            Console.WriteLine(Convert.ToInt32(iDoubleI));  // convert double to int
            Console.WriteLine(Convert.ToString(iBoolS) + "\n");   // convert bool to string



            //String operators
            Console.WriteLine("STRING OPERATORS");
            string iLength = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Console.WriteLine("The length of the txt string is: " + iLength.Length); //finds the length of a string 

            string iCase = "Upper and lower case";
            Console.WriteLine(iCase.ToUpper());   //makes it uppercase and outputs "HELLO WORLD"
            Console.WriteLine(iCase.ToLower());   //makes it lowercase and outputs "hello world"

            string iStringConcatenation1 = "John ";
            string iStringConcatenation2 = "Doe";

            string iStringConcatenation3 = iStringConcatenation1 + iStringConcatenation2;   //combines String 1 and 2 into string 3
            Console.WriteLine(iStringConcatenation3);

            iStringConcatenation1 = "Mike ";
            iStringConcatenation2 = "Wazowski";
            iStringConcatenation3 = string.Concat(iStringConcatenation1, iStringConcatenation2);    //combines String 1 and 2 into string 3 with the string.Concat() Function
            Console.WriteLine(iStringConcatenation3);

            iStringConcatenation1 = "obi-wan";
            iStringConcatenation2 = "kenobi";
            iStringConcatenation3 = $"I have the high ground -{iStringConcatenation1 } {iStringConcatenation2}";    //combines String 1 and 2 into string 3 with the string.Concat() Function
            Console.WriteLine(iStringConcatenation3);

            string iPositionChar= "Hello";
            Console.WriteLine(iPositionChar[0]); //takes a character from a position from inside a string. First letter is always 0

            string iPositionCharCheck = "Hello";
            Console.WriteLine(iPositionCharCheck.IndexOf("e"));  // Outputs 1 because e is the second character in the string


            // Full name. Gets the second part of the string starting from the letter P
            string iCharSubstring = "Emperor Palpatine";
            // Location of the letter D
            int iCharPos = iCharSubstring.IndexOf("P");
            // Get last name
            string iLastname = iCharSubstring.Substring(iCharPos); 
            Console.WriteLine(iLastname + "\n");



            Console.WriteLine("SPECIAL CHARACTERS");

            string iBackslashEscapeCharacter = "We are the so-called \"Vikings\" from the north."; //the slash infront of the "" makes it so the interpreter doesn't read it as you trying to end the text field
            String iNewline = "This three new lines.\n\n\n";    // \n is used as a new line 
            String iTab = "This three tabs.\t\t\t";     // \t is used as a tab
            string iBackspace = "This is three backspaces. a\bb\bc\b "; // \b is used as a backspace

            Console.WriteLine(iBackslashEscapeCharacter);
            Console.WriteLine(iNewline);
            Console.WriteLine(iTab);
            Console.WriteLine("This is not three backspaces. abc");
            Console.WriteLine(iBackspace);

            //this add X into Y
            int iNumberCombineInt1 = 10;
            int iNumberCombineInt2 = 20;
            int iNumberCombineInt3 = iNumberCombineInt1 + iNumberCombineInt2;  // z will be 30 (an integer/number)
            Console.WriteLine(iNumberCombineInt3);

            //this add X next to Y
            string iNumberCombineString1 = "10";
            string iNumberCombineString2 = "20";
            string iNumberCombineString3 = iNumberCombineString1 + iNumberCombineString2;  // z will be 1020 (a string)
            Console.WriteLine(iNumberCombineString3 + "\n");

            //If ... Else
            Console.WriteLine("IF AND ELSE");

            const int iNumberIf1 = 15;
            const int iNumberIf2 = 5;

            if (iNumberIf1 > iNumberIf2) //checks if X is bigger then Y because of the > operator
            {
                Console.WriteLine("X is bigger then Y");
            };

            const float iTime = 14.30F;

            if (iTime < 12) //checks if the time is after 12:00
            {
                Console.WriteLine("Good morning"); //writes Good morning if the time is before 12:00
            }else
            {
                Console.WriteLine("Good afternoon"); //writes Good afternoon if the time is after 12:00
            }

            const float iTime2 = 10.30F;
            String iOutputTernary = (iTime2 >= 12) ? "Good Afternoon" : "Good morning"; // if ternary statement
            Console.WriteLine(iOutputTernary + "\n");



            //Switch
            Console.WriteLine("SWITCH STATEMENTS"); 

            const int iFingers = 3;

            switch (iFingers) //checks Wich case fits with the condition
            {
                case 1:
                    Console.WriteLine("thumb"); //case if iFingers equals to 1
                    break;
                case 2:
                    Console.WriteLine("index finger");
                    break;
                case 3:
                    Console.WriteLine("middle finger");
                    break;
                case 4:
                    Console.WriteLine("ring finger");
                    break;
                case 5:
                    Console.WriteLine("pinkie");
                    break;
                default:    //if none of the above, then do this
                    Console.WriteLine("extraordinary");
                    break;
            }
            Console.Write("\n");



            //while loops
            Console.WriteLine("WHILE LOOPS"); 
            int iCounter = 0;
            while (iCounter < 9) //Do the loop untill the condition is reached
            {
                Console.WriteLine("Your number is: " + iCounter);
                iCounter++;
            }

            iCounter = 5;

            do //same as a while loop but always runs atleast once
            {
                Console.WriteLine(iCounter + "");
                iCounter++;
            } while (iCounter < 10);
            Console.Write("\n");


            //For loops
            Console.WriteLine("FOR LOOPS");

            for (iCounter = 0; iCounter < 10; iCounter++) //Sets iCounter to 0, runs untill iCounter 10, ups iCounter by one every time
            {
                Console.WriteLine(iCounter);
            }
            Console.Write("\n");



            //loop jumping. break and continue
            Console.WriteLine("BREAK AND CONTINUE");

            for (iCounter = 0; iCounter < 10; iCounter++) //Sets iCounter to 0, runs untill iCounter 10, ups iCounter by one every time
            {
                if (iCounter == 4)
                {
                    break;  //stops both the for loop and the if statement
                }
                Console.WriteLine(iCounter);
            }
            Console.Write("\n");

            for (iCounter = 0; iCounter < 10; iCounter++) //Sets iCounter to 0, runs untill iCounter 10, ups iCounter by one every time
            {
                if (iCounter == 4)
                {
                    continue;  //Skips 4 (only jumps out of one iteration of loop) 
                }
                Console.WriteLine(iCounter);
            }
            Console.Write("\n");



            //Arrays and multiple value variables
            Console.WriteLine("ARRAYS");

            String[] iShoes = { "Jordans", "Sneakers", "Nikes", "Gucci" };  //stores multiple values into a single array
            Console.WriteLine(iShoes.Length);   //finds the length of the array
            Console.Write("\n");
            Console.WriteLine(iShoes[0]);   //takes the first value from the array and writes it in console

            Console.Write("\n");

            String[] iCandy = { "Snickers", "mars", "JawBreaker", "Lollypop" };
            iCandy[2] = "M&M's"; //changes the value of the third slot from jawbreaker to M&M's
            Console.WriteLine(iCandy[0]);

            Console.Write("\n");
            //Loop through the array with a for loop
            string[] iCars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int iLoop = 0; iLoop < iCars.Length; iLoop++)
            {
                Console.WriteLine(iCars[iLoop]);
            }

            Console.Write("\n");
            //Loop through the array with a foreach loop
            foreach (string iLoop2 in iCars)
            {
                Console.WriteLine(iLoop2);
            }

            Console.Write("\n");
            // Sort a string alphabetically
            string[] iCars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(iCars2);
            foreach (string i in iCars2)
            {
                Console.WriteLine(i);
            }

            Console.Write("\n");
            // Sort an int in an ascending order with array.sort()
            int[] iNumbers = { 5, 1, 8, 9 };
            Array.Sort(iNumbers);
            foreach (int i in iNumbers)
            {
                Console.WriteLine(i);
            }

            Console.Write("\n");
            int[] iNumbers2 = { 5, 1, 8, 9 };
            Console.WriteLine(iNumbers2.Max());  // returns the largest value
            Console.WriteLine(iNumbers2.Min());  // returns the smallest value
            Console.WriteLine(iNumbers2.Sum());  // returns the sum of elements

            Console.Write("\n");
            // Create an array of four elements, and add values later
            string[] icars3 = new string[4];

            // Create an array of four elements and add values right away 
            string[] icars4 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] icars5 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] icars6 = { "Volvo", "BMW", "Ford", "Mazda" };



            //User username input with Console.ReadLine
            Console.WriteLine("BASIC INPUTS");
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string iUserName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + iUserName + "\n");

            Console.WriteLine("Write Your age");
            int iAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + iAge);

        }
    }
}