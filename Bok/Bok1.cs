using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace  Bok
{
    //Fredrik H Rafed
    class Bok
    {
        private string titel;
        private  string författare;
        private int antalSidor;

        //Kunstruktor
        
        public Bok()
        {
            Console.WriteLine("Ange författere: ");
            this.författare = Console.ReadLine();

            Console.WriteLine("Ange titeln på boken: ");
            this.titel = Console.ReadLine();

            Console.WriteLine("Ange antal sidor: ");
            this.antalSidor = Convert.ToInt32(Console.ReadLine());
        }

       public void skrivUt()
        {
            Console.WriteLine("Bokens titel : \t " + titel);
            Console.WriteLine("Bokens författare är : \t " +  författare);
            Console.WriteLine("Bokens antal sidor : \t " + antalSidor);
        }
        public void ÄndraTitel (string titel)
        {
            this.titel = titel;
        }

    }


  
    
}