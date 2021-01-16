using System;

namespace Week2Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi - array
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python", "C#" };
         

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                   
            }
            Console.WriteLine(kurslar.Length+" Kurs Listelendi\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }

        
	

	} 
        
}

