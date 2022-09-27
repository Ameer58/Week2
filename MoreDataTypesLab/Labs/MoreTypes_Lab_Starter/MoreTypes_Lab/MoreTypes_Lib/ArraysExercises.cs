using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] array = new string[contents.Count];
            for(int i = 0; i < contents.Count; i++)
            {
                array[i] = contents[i];
            }
            return array;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            string[,,] array = new string[length1, length2, length3];
            int index = 0;
            if (length1 * length2 * length3 > contents.Count) throw new ArgumentException("Number of elements in list must match array size");
            for(int i = 0; i < length1; i++)
            {
                for(int j = 0; j < length2; j++)
                {
                    for(int k = 0; k < length3; k++)
                    {
                        array[i, j, k] = contents[index++];
                    }
                }
            }
            return array;   
            
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            string[][] array = new string[countRow1][];
            
            int index = 0;
            if (countRow1 * countRow2 > contents.Count) throw new ArgumentException("Number of elements in list must match array size");
            for(int i=0; i<countRow1; i++)
            {
                for(int j=0; j<countRow2; j++)
                {
                    array[i][j] = contents[index++];
                }
            }


            return array;
        }
    }
}
