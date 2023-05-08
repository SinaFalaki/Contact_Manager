using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact
{
    public class oparation : Icontactitem
    {
        private static List<Contact> database = new List<Contact>();



        public void add(Contact contact)
        {
            database.Add(contact);

        }



        public void remove(string number)
        { bool flag= false;
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].Number == number)
                {
                    database.Remove(database[i]);
                    flag = false;
                    break;
                }
                else
                {
                    flag= true;
                }
                
            }
            if (flag)
            {
                Console.WriteLine("your number is Not found!");
            }
            Console.ReadKey();
        }

        public bool searchNumber(string number)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].Number == number)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("=============================");
                    Console.WriteLine("full name is : " +database[i].FullName);
                    Console.WriteLine("phone number is : "+database[i].Number);
                    Console.WriteLine("Email is : "+database[i].Email);
                    Console.WriteLine("Address is : "+database[i].Address);
                    Console.ResetColor();
                    Console.ReadKey();
                    return true;
                }


            }
            Console.WriteLine("your number " + number + " not found!");

            return false;
        }




        public bool searchName(string name)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].FullName == name)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("=============================");
                    Console.WriteLine("full name is : " + database[i].FullName);
                    Console.WriteLine("phone number is : " + database[i].Number);
                    Console.WriteLine("Email is : " + database[i].Email);
                    Console.WriteLine("Address is : " + database[i].Address);
                    Console.ResetColor();
                    Console.ReadKey();
                    return true;

                }

            }
            Console.WriteLine("your name" + name + " not found!");

            return false;

        }
        public void Update(string number, Contact contact)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].Number == number)
                {
                    database[i].FullName = contact.FullName;
                    database[i].Number = contact.Number;
                    database[i].Email = contact.Email;
                    database[i].Address = contact.Address;
                }
            }
            Console.WriteLine("your number not found!");
        }

        public int allcontact()
        {
            int sum = database.Count;

            return sum;
        }
    }
}
