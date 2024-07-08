using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    #region Indexer parctice
    internal class PhoneBook
    {
        #region attributes
        private string[] names;
        long[] numbers;
        int size;

        #endregion

        #region properties
        public int Size
        {
            get { return size; }
        }

        #endregion

        #region Constructors
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[_size];

        }
        #endregion

        #region Methods
        public void AddPerson(int posisiton, string name, long number)
        {
            if (name is not null && numbers is not null)
            {
                if (posisiton < size && posisiton >= 0)
                {
                    names[posisiton] = name;
                    numbers[posisiton] = number;

                }
            }
        }

        public long GetNumber(string name)
        {
            if (names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }

            }
            return -1;
        }
        public void SetNumber(string name, long newNumber)
        {
            if (names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = newNumber;
                        break;
                    }
                }

            }

        }

        //indexer property
        //1. always named with this keyword
        //2. can take parameters
        public long this[string name]
        {
            get
            {
                if (names is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                            return numbers[i];
                    }

                }
                return -1;
            }
            set
            {
                if (names is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            return;
                        }
                    }

                }
            }
        }
        public string this[int index]
        {
            get
            {
                return $"position: {index}\nName :{names[index]}\nNumber: {numbers[index]}";

            }
        }

        #endregion
    }


    #endregion
}
