using System.ComponentModel;

namespace labb2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int familjMembercount;
            Console.WriteLine("Hur många familjmedlemmar");
            familjMembercount = int.Parse(Console.ReadLine());
            string[] names = new string[familjMembercount];
            double[] age = new double[familjMembercount];
            double totalage = 0;
            double mediaage = 0;
            int menuSelector = 0;
            int userinput = 0;


            while (menuSelector != 5)
            {
                Console.WriteLine(
                    "\n------------------------------------------------" +
                    "\nVälj ett av alternativen:" +
                    "\n1.) Lägg till namn på familjemedlemmar" +
                    "\n2.) Visa familjemedlemmar" +
                    "\n3.) Skriva ut summan av familjemedlemmarnas ålder" +
                    "\n4.) Skriva ut medelåldern för familjemedlemmarna" +
                    "\n5.) avsluta" +
                    "\n----------------------------------------------------"
                    );
                menuSelector = int.Parse(Console.ReadLine());
                switch (menuSelector)

                {
                    case 1:

                        if (userinput < familjMembercount)
                        {
                            Console.WriteLine("Namn på familjemedlemmar");
                            names[userinput] = Console.ReadLine();

                            Console.WriteLine("Ålder på familjemedlemmar");
                            age[userinput] = Double.Parse(Console.ReadLine());
                            userinput++;
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("tyvärr det fullt");
                        }

                        break;


                    case 2:

                        for (int i = 0; i < userinput; i++)
                        {
                            Console.WriteLine(names[i] + " är " + age[i]);

                        }

                        break;

                    case 3:

                        for (int i = 0; i < userinput; i++)
                            
                        {
                            totalage += age[i];

                        }
                        Console.WriteLine(" Summan är " + totalage.ToString("0.00"));

                        break;

                    case 4:
                        for (int i = 0; i < userinput; i++)
                        {
                            mediaage += age[i];

                        }
                        mediaage = mediaage / userinput;
                            Console.WriteLine(" Medelåldern är " + mediaage.ToString("0.00"));
                       
                        break;

                    case 5:
                        Console.WriteLine("Avsluta");
                        break;


                    default: 
                        Console.WriteLine("Felaktig indata, du behöver ange ett nummer mellan 1 - 5\n");
                        break;
                }   }
            }
        }
    }



