// See https://aka.ms/new-console-template for more information

using MyContact;
oparation ope = new oparation();
while (true)
{
    Console.Clear();
    Console.WriteLine("\n                                          welcome to your contact manager\n");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("                                              All of your contact: " + ope.allcontact() + "");
    Console.ResetColor();
    Console.WriteLine("\n\n                                           =============================\n");
    Console.WriteLine("                                                 1. add a contact");
    Console.WriteLine("                                                 2. Delete a contact");
    Console.WriteLine("                                                 3. update a contact");
    Console.WriteLine("                                                 4. search by number");
    Console.WriteLine("                                                 5. search by name");
    Console.WriteLine("                                                 6. exit\n");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("                                           please choose what do you want:  ");

    Console.ForegroundColor = ConsoleColor.Yellow;

    string work = Console.ReadLine();
    Console.WriteLine();    
    Console.WriteLine();    
    Console.WriteLine();    

    switch (work)
    {
        case "1":
            {
                Console.Write("Full Name: ");
                string name = Console.ReadLine();

                Console.Write("Phone Number: ");
                string Phone = Console.ReadLine();

                Console.Write("Email : ");
                string Email = Console.ReadLine();

                Console.Write("Address: ");
                string Address = Console.ReadLine();

                Contact cntact = new Contact();
                cntact.FullName = name;
                cntact.Number = Phone;
                cntact.Email = Email;
                cntact.Address = Address;
                oparation op = new oparation();
                op.add(cntact);

                break;
            }
        case "2":
            {
                Console.WriteLine("Enter your phone number to remove:  ");
                string number = Console.ReadLine();
                oparation op = new oparation();
                op.remove(number);
                break;
            }
        case "3":
            {
                Console.WriteLine("Enter your phone number to update:  ");
                string number = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("press <Enter> to Update");
                Console.ForegroundColor = ConsoleColor.Yellow;

                oparation op = new oparation();
               bool flag= op.searchNumber(number);
                if (flag)
                {
                    Console.Write("Full Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Phone Number: ");
                    string Phone = Console.ReadLine();

                    Console.Write("Email : ");
                    string Email = Console.ReadLine();

                    Console.Write("Address: ");
                    string Address = Console.ReadLine();

                    Contact cntact = new Contact();
                    cntact.FullName = name;
                    cntact.Number = Phone;
                    cntact.Email = Email;
                    cntact.Address = Address;
                    op.Update(number, cntact);
                }
                //Console.WriteLine("your number not found!");
                Console.ReadKey();
                break;

            }
        case "4":
            {
                Console.WriteLine("Enter your phone number to search:  ");
                string number = Console.ReadLine();
                oparation op = new oparation();
                op.searchNumber(number);
                break;

            }
        case "5":
            {
                Console.WriteLine("Enter your contact Name to search:  ");
                string name = Console.ReadLine();
                oparation op = new oparation();
                op.searchName(name);
                break;
            }
        case "6":
            {
                return;

            }
        default:
            {
                Console.WriteLine("please select a legal option!!");
                Console.ReadKey();
                break;
            }


    }
}

