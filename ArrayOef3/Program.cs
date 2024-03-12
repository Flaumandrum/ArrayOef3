using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayOef3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens     
            // 17/01/2024
            // Oef3: Array

            // Velden 

            String[] _voornamen = new string[0];
            UInt32 _aantal = 0, _nummerLln = 0;
            String _naam = "";
            byte _keuze = 0;
            Boolean _gevonden= false;

            // Programma
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 1:  Toon menu (ingeven aantal Leerlingen,  namen ingeven, toon namen,
                //namen aanpassen, namen verwijderen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Ingeven aantal leerlingen \n   2) Alle namen ingeven \n   3) Toon allen namen " +
                    "\n   4) Namen aanpassen \n   5) Leerlingen verwijderen \n   6) Afsluiten");
                Console.Write("\n\n: uw keuze: ");


                try
                {
                    // Keuze opslaan
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm wissen
                    Console.Clear();

                    // Als 1: Vraag het aantal leerlingen + sla op 
                    if (_keuze == 1)
                    {
                        Console.Write($"Hoeveel leerlingen telt je klas : ");
                        _aantal = UInt32.Parse(Console.ReadLine());

                        _voornamen = new string[_aantal];

                        // Scherm wissen
                        Console.Clear();

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDe klas werd aangemaakt.");
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 2: Vraag alle namen + sla op 
                    else if (_keuze == 2)
                    {
                        // Vraag de namen 
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            Console.Write($"Geef leerling {(i + 1).ToString()} in : ");
                            _voornamen[i] = Console.ReadLine();
                        }

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    //Als 3: Toon de namen op het scherm.
                    else if (_keuze == 3)
                    {
                        // array overlopen en op het scherm tonen
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            Console.WriteLine($"{(i + 1).ToString()}) {_voornamen[i]}");
                        }

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 4: namen aanpassen 
                    else if (_keuze == 4)
                    {
                        // 1)	Toon de namen met nummer
                        // array overlopen en op het scherm tonen
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            Console.WriteLine($"{(i+1).ToString()}) {_voornamen[i]}");
                        }

                        // 2)	Vraag het nummer om te veranderen
                        Console.Write($"\nGeef het nummer van de leerling die je wilt veranderen : ");
                        _nummerLln = UInt32.Parse(Console.ReadLine());


                        // 3)	Vraag nieuwe naam + opslaan
                        Console.Write($"\n\nGeef de nieuwe naam in : ");
                        _voornamen[_nummerLln-1] = Console.ReadLine();

                        // Scherm wissen
                        Console.Clear();

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDe naam werd veranderd.");
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 5: leerlingen verwijderen
                    else if (_keuze == 5)
                    {
                        // 1)	Vraag de naam om te verwijderen
                        Console.Write($"Geef de naam van de leerling die je wilt verwijderen : ");
                        _naam = Console.ReadLine();

                        // 2)	Zoek de naam + verwijder of geef fout
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            if (_voornamen[i] == _naam)
                            {
                                //verwijder de naam
                                _voornamen[i] = null;
                                _gevonden = true;
                                break;
                            }
                            else
                            {
                                _gevonden = false;
                            }
                        }

                        // Gebruiker begeleiden
                        // Scherm wissen
                        Console.Clear();

                        if (_gevonden)
                        {
                            Console.WriteLine("Deze persoon werd uit de klas verwijderd.");
                        }
                        else
                        {
                            Console.WriteLine("Jammer maar helaas, wij konden deze naam niet vinden.");
                        }

                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                        
                    }

                    // Als 6: Sluit af.
                    else if (_keuze == 6)
                    {
                        // afsluiten
                        Console.WriteLine("Dag en tot een volgende keer.");
                        Console.WriteLine("Druk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                    else
                    {

                        // foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();

                }

            } while (_keuze != 6);


        }
    }
}
