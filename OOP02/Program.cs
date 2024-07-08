namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////part 01
            #region Q1.Trying indexer
            PhoneBook note = new PhoneBook(3);
            //note.AddPerson(0, "mahmoud", 123);
            //note.AddPerson(1, "ali", 456);
            //note.AddPerson(2, "omar", 789);
            //Console.WriteLine(note.GetNumber("omar"));

            //note["omar"] = 345;
            //Console.WriteLine(note["omar"]);

            //why string is an array of char?
            // string has an indexer that only return char and cannot be modified

            //for (int i = 0;i < note.Size; i++ )
            //{
            //    Console.WriteLine(note[i]);
            //}
            #endregion


        }
    }
}
