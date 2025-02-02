﻿using System;

namespace OlioTehtävä_4_Opiskelija
{
    class Opiskelija
    {
        //Kentät
        string opiskelijanNimi;
        int ika;
        double arvoSana;
        public static int opiskelijaLaskuri;


        //Metodit
        public string OpiskelijanNimi //opiskelijanNini kentän getteri ja setteri
        {
            set
            {
                Console.WriteLine(" Systen: OpiskelijanNimi setteri käytetty");
                opiskelijanNimi = value;
            }
            get
            {
                Console.WriteLine(" Systen: OpiskelijanNimi getteri käytetty");
                return opiskelijanNimi;
            }
        }
        public int Ika //ika kentän getteri ja setteri
        {
            set
            {
                Console.WriteLine(" Systen: Ikä setteri käytetty");
                ika = value;
            }
            get
            {
                Console.WriteLine(" Systen: Ikä getteri käytetty");
                return ika;
            }
        }
        public double Arvosana //arvoSana kentän getteri ja setteri
        {
            set
            {
                Console.WriteLine(" Systen: Arvosana setteri käytetty");
                arvoSana = value;
            }
            get
            {
                Console.WriteLine(" Systen: Arvosana getteri käytetty");
                return arvoSana;
            }
        }
        public void MuutaNimi(string value) //MuutNimi metodi muuttaa opiskelijanNimi kentön arvon parametrin arvoksi.
        {
            Console.WriteLine(" System: MuutaNimi metodi käytetty");
            opiskelijanNimi = value;
        }
        public void MuutaArvosana(double value) //MuutaArvosana metodi muuttaa arvoSana kentän arvon parametrin arvoksi.
        {
            Console.WriteLine(" System: MuutaArvosana metodi käytetty");
            arvoSana = value;
        }
        public void Vanhene() //Vanhene metodi kasvattaa ika kentän arvoa yhdellä.
        {
            Console.WriteLine(" System: Vanhene metodi käytetty");
            ika++;
        }
        public void OpiskelijanTiedot() //OpiskelijanTiedot metodi tulostaa kenttien opiskelijaNimi, ika ja arvoSana arvot.
        {
            Console.WriteLine(" Systen: OpiskelijanTiedot metodi käytetty");
            Console.WriteLine();
            Console.WriteLine("Nimi: " + opiskelijanNimi);
            Console.WriteLine("Ikä: " + ika);
            Console.WriteLine("Arvosana: " + arvoSana);
            Console.WriteLine();
        }
        public static void OpiskelijaLaskuri()//OpiskelijaLaskuri metodi tulostaa opiskelijaLaskuri kentän arvon konsoliin.
        {
            Console.WriteLine(" Systen: OpiskelijaLaskuri metodi käytetty");
            Console.WriteLine(opiskelijaLaskuri);
        }

        //Konstruktorit
        public Opiskelija() //Vakiokonstuktori
        {
            Console.WriteLine(" Systen: Olio luotu käyttämällä vakiokonstruktoria");
            opiskelijanNimi = "";
            ika = 17;
            arvoSana = 0;
            opiskelijaLaskuri++;
        }
        public Opiskelija(string u_nimi) //Ylikuormituskonstruktori
        {
            Console.WriteLine(" Systen: Olio luotu käyttämällä ylikuormituskonstruktoria");
            opiskelijanNimi = u_nimi;
            ika = 17;
            arvoSana = 0;
            opiskelijaLaskuri++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Oliotehtävä 4");
            Console.WriteLine("**************************");
            Console.WriteLine();

            //Luodaan 4 Opiskelija oliota ylikuormituskonstruktorilla.
            Opiskelija opis1 = new Opiskelija("Aapo");
            Opiskelija opis2 = new Opiskelija("Laura");
            Opiskelija opis3 = new Opiskelija("Tero");
            Opiskelija opis4 = new Opiskelija("Seppo");

            //Tulostetaan opiskelijoiden tiedot.
            opis1.OpiskelijanTiedot();
            opis2.OpiskelijanTiedot();
            opis3.OpiskelijanTiedot();
            opis4.OpiskelijanTiedot();

            //Kutsutaan MuutaArvosana metodi muuttaaksemme opiskelijoiden arvosanaa.
            opis1.MuutaArvosana(7.5);
            opis2.MuutaArvosana(8);
            opis3.MuutaArvosana(8.5);
            opis4.MuutaArvosana(8.75);

            //Kutsutaan Vanhene metodi lisääksemme opiskelijoiden ikää.
            opis1.Vanhene();
            opis2.Vanhene();
            opis3.Vanhene();
            opis4.Vanhene();

            //Tulostetaan opiskelijoiden tiedot uudestaan.
            opis1.OpiskelijanTiedot();
            opis2.OpiskelijanTiedot();
            opis3.OpiskelijanTiedot();
            opis4.OpiskelijanTiedot();

            //Kutsutaan OpiskelijaLaskuri metodi.
            Opiskelija.OpiskelijaLaskuri();
        }
    }
}
