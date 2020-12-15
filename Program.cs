using System;

namespace Övningar_i_Csharp_boken
{
    class Program
    {
        static void Main(string[] args)
        {
            bool avsluta = true;
            while (avsluta)
            {
                Console.WriteLine("Välj en uppgift där uppgiftens namn = 7.4.2 eller 7.5.3 osv" + Environment.NewLine + "[A]vsluta");
                string val = Console.ReadLine();
                switch (val)
                {
                    case "7.11":
                        Console.WriteLine("När du ska namnge variablar tänk på att de ska vara: Beskrivande, ha lättutskrivna (inga stora bokstäver), inga konstiga tecken");
                        break;

                    case "test":

                    break;


                    case "7.4.2":
                        Console.Clear();
                        bool avsluta1 = false;
                        double a = 10;
                        //skapar ett värde som ska behålla saldot utanför, denna variabel uppdaterar sig och ska hålla värdet permanent, därför ligger det utanför loopen. Annars hade det blivit 0 efter varje gång man kör om applikationen
                        double mangdenPengar = 0;
                        //Skapar en loop som användaren ska befinna sig i, alltså sålänge han inte trycker på a kommer loopen som erbjuder alternativ att upprepa sig
                        while (!avsluta1)
                        {
                            Console.WriteLine("Alternativ:");
                            Console.WriteLine("[I]nsättning");
                            Console.WriteLine("[U]ttag");
                            Console.WriteLine("[S]aldo");
                            Console.WriteLine("[A]vsluta");
                            string menyVal = Console.ReadLine();
                            switch (menyVal)
                            {
                                case "I":

                                case "i":
                                    
                                    Console.Clear();
                                    Console.Write("Skriv in hur mycket pengar du vill sätta in ");
                                    string insattning = Console.ReadLine();
                                    bool arDetRattInmatning = double.TryParse(insattning, out a);
                                    if (arDetRattInmatning == true)
                                    {
                                        double insattning2 = Convert.ToDouble(insattning);
                                        mangdenPengar += insattning2;
                                        Console.WriteLine("Ditt saldo är " + mangdenPengar + "kr");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Felaktig inmatning");
                                    }                                    
                                    break;


                                case "U":
                                case "u":
                                    Console.Clear();
                                    Console.Write("Skriv hur mycket pengar du vill ta ut ");
                                    string uttag = Console.ReadLine();
                                    bool arDetRattInmatning2 = double.TryParse(uttag, out a);
                                    if(arDetRattInmatning2 == true)
                                    {
                                        
                                        if((mangdenPengar - Convert.ToDouble(uttag)) < 0) 
                                        {
                                            Console.WriteLine("Du har inte tillräckligt med pengar");
                                        }
                                        else
                                        {
                                            double uttag2 = Convert.ToDouble(uttag);                                         
                                            mangdenPengar -= uttag2;
                                            Console.WriteLine("Ditt nya saldo är " + mangdenPengar + "kr");
                                        }
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("Felaktig inmatning");
                                    }

                                   
                                    break;

                                case "S":
                                case "s":
                                    Console.Clear();
                                    Console.WriteLine("Ditt saldo är " + mangdenPengar + "Kr");
                                    break;

                                case "A":
                                case "a":
                                    Console.Clear();
                                    avsluta1 = true;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("Felaktig inmatning, försök igen");
                                    break;



                            }

                        }
                        break;


                    case "A":
                    case "a":
                        avsluta = false;
                        break;

                    case "7.5.1":
                        Console.Clear();
                        int talFoljd = 1;
                        while (talFoljd < 21)
                        {
                            Console.WriteLine(talFoljd++);
                        }
                        break;

                    case "7.5.2":
                        Console.Clear();
                        bool kontrolLoop = true;
                        do
                        {
                            try
                            {
                                
                            }
                            catch
                            {
                                
                                
                            }
                        } while (kontrolLoop);
                        Console.WriteLine("Skriv in ett tal mellan 1 och 100");
                        int ettTillHundra = int.Parse(Console.ReadLine());
                        if (ettTillHundra > 100 || ettTillHundra < 1)
                        {
                            Console.WriteLine("felaktig inmatning");
                        }
                        else
                        {
                            while (ettTillHundra < 102)
                            {
                                Console.Write(ettTillHundra++ + " ");
                            }
                        }
                        Console.Write(Environment.NewLine);

                        break;

                    case "7.5.3":
                        Console.Clear();
                        int antalKlave = 0;
                        int antalRundor = 0;
                        int antalKrona = 0;
                        Console.Write("Skriv in hur många gånger du vill singla slant");
                        int antalSinglingar = Convert.ToInt32(Console.ReadLine());
                        while (antalRundor <= antalSinglingar)
                        {
                            antalRundor++;
                            Random randomerare = new Random();
                            int tal = randomerare.Next(1, 3);
                            if (tal == 1)
                            {
                                Console.WriteLine("Klave");
                                antalKlave++;
                            }
                            else if (tal == 2)
                            {    
                                Console.WriteLine("Krona");
                                antalKrona++;
                            }
                        }
                        Console.Write("Du fick klave " + antalKlave + " gånger och krona " + antalKrona + " gånger" + Environment.NewLine);
                        break;

                    //7.5.4
                    // 

                    case "7.5.5":
                        bool korLoopen = true;
                        while(korLoopen == true)
                        {
                            Console.WriteLine("Vill du spela Yatzy?");
                            string svar = Console.ReadLine();
                            if (svar == "ja" || svar == "Ja")
                            {
                                
                                while(korLoopen == true)
                                {
                                    Random tarning1 = new Random();
                                    Random tarning2 = new Random();
                                    Random tarning3 = new Random();
                                    Random tarning4 = new Random();
                                    Random tarning5 = new Random();
                                    Random tarning6 = new Random();
                                    int slag1 = tarning1.Next(1, 7);
                                    int slag2 = tarning1.Next(1, 7);
                                    int slag3 = tarning1.Next(1, 7);
                                    int slag4 = tarning1.Next(1, 7);
                                    int slag5 = tarning1.Next(1, 7);
                                    int slag6 = tarning1.Next(1, 7);
                                    Console.WriteLine("Dina slag blev: " + slag1 + " " + slag2 + " " + slag3 + " " + slag4 + " " + slag5 + " " + slag6);
                                    Console.WriteLine("Vill du spela igen?");
                                    string enTillGang = Console.ReadLine();
                                    if (enTillGang == "ja" || enTillGang == "Ja")
                                    {
                                        korLoopen = true;
                                    }
                                    else
                                    {
                                        korLoopen = false;
                                    }
                                }
                                
                  
                            }
                            else if (svar == "nej" || svar == "Nej")
                            {
                                Console.WriteLine("Kom tillbaka när du har tid!");
                                korLoopen = false;            
                            }
                            else
                            {
                                Console.WriteLine("Felaktig inmatning, svara med ja eller nej");
                            }
                            

                            
                        }
                    break;

                    
                            

                }   
                    
            }
        }
    }
}
