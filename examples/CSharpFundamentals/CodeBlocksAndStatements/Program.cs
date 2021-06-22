using System;

//namespace CodeBlocksAndStatements
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = "";

//            if (args.Length > 0)
//            {
//                Console.WriteLine($"Hello, {args[0]}!");
//            }
//            else
//            {
//                Console.WriteLine("Hello, World!");
//            }
//        }
//    }
//}

namespace CodeBlocksAndStatements
{ // begin code block

    class Program
    { // begin code block

        static void Main(string[] args)
        { // begin code block

            string name = ""; // variable declaration statement

            if (args.Length > 0) // if statement
            { // begin code block

                // statement
                Console.WriteLine($"Hello, {args[0]}!"); // end line with a semicolon

            } // end code block
            else // else statement
            { // begin code block

                // statement
                Console.WriteLine("Hello, World!"); // end line with a semicolon

            } // end code block
        } // end code block
    } // end code block
} // end code block
