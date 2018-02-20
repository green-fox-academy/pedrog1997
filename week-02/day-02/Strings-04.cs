using System;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            todoText = todoText.Insert(0, "My todo: \n");
            todoText += " - Download games \n";
            todoText += "\t - Diablo";

            Console.WriteLine(todoText);

            Console.Read();
        }
    }
}