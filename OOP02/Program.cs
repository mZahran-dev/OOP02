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


            //part02
            #region Q6.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

            HireDate hireDate1 = new HireDate(27, 5, 2003);
            HireDate hireDate2 = new HireDate(5, 7, 1979);
            HireDate hireDate3 = new HireDate(1, 7, 2025);
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "Mahmoud Ibrahim", SecurityPrivilege.DBA, 90000m, hireDate1, Gender.m);
            EmpArr[1] = new Employee(2, "Samir Hamed", SecurityPrivilege.Guest, 45000m, hireDate2, Gender.f);
            EmpArr[2] = new Employee(3, "Aya mahmoud", SecurityPrivilege.SecurityOfficer, 120000m, hireDate3, Gender.f);


            #endregion

            #region 7.Sort the employees based on their hire date then Print the sorted array.
            //While sorting(how many times Boxing and Unboxing process has occurred)

            int boxing = 0;
            int unboxing = 0;
            for (int i = 0; i < EmpArr.Length - 1; i++)
            {
                for (int j = 0; j < EmpArr.Length; j++)
                {
                    boxing++;
                    if (EmpArr[j].HireDate.CompareTo(EmpArr[j + 1].HireDate) > 0)
                    {
                        Employee temp = EmpArr[i];
                        EmpArr[j] = EmpArr[j + 1];
                        EmpArr[j + 1] = temp;

                        unboxing += 3;
                    }
                }

            }



            #endregion

        }
    }
}
