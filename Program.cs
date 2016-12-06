using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome.");

            char menuIndex = 'x';
            switch (menuIndex)
            {
                case 'n':

                    Console.WriteLine("\nPlease enter your name:");
                    string customerName = Console.ReadLine();
                    CheckString(customerName);

                    Console.WriteLine("\nPlease type the name of the project you'd like to start: e.g. 'Living Room' or 'Kitchen'");
                    string projectTitle = Console.ReadLine();
                    CheckString(projectTitle);

                    string projectFitle = GetProjectTitle(customerName, projectTitle);
                    Console.WriteLine("Project has been saved to: {0}\n", projectFile);
                    Console.ReadKey(true);

                    

                    break;

                case 'd':
                    break;

                default:
                    break;

            }


        }

        public static string GetProjectTitle(string cN, string pT)
        {
            string txtfileName = string.Format("{0} {1}.text", cN, pT);
            return txtfileName;

        }

        public static void CheckString(string temp)
        {
            bool problemFound = false;
            int spaceCount = 0;

            foreach (char c in temp)
            {
                if (!char.IsLetter(c))
                {
                    if (c == ' ')
                    {
                        spaceCount++;
                    }
                    else
                    {
                        problemFound = true;
                    }
                    if (spaceCount > 1)
                    {
                        problemFound = true;
                    }
                }
            }
            //While statement checks that the name is not null or only spaces, also that the length of the name is valid.
            while (String.IsNullOrEmpty(temp) || problemFound == true || temp.Length > 35 || temp.Length < 5)
            {
                //If any errors are found the program stays in loop until the user input is valid.
                Console.Clear();
                Console.WriteLine("This field cannot be blank, contain numbers or symbols or be longer than 35 characters. \nPlease try again:");
                temp = Console.ReadLine();
                spaceCount = 0;
                problemFound = false;
                foreach (char c in temp)
                {
                    if (!char.IsLetter(c))
                    {
                        if (c == ' ')
                        {
                            spaceCount++;
                        }
                        else
                        {
                            problemFound = true;
                        }
                        if (spaceCount > 1)
                        {
                            problemFound = true;
                        }

                    }
                }
            }
        }

    }
}
