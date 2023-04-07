using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS_MODUL_3
{

    /*-===== superclass Processor =====*/
    class Processor
    {
        public string merk, tipe;
    }

    /* ===== subclass dari Processor (Intel dan AMD) ===== */
    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    class amd : Processor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }
    /* ===== Subclass dari class Intel ===== */

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }

    /* ===== Subclass dari class AMD =====  */
    class Ryzen : amd
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    class Athlon : amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }
    /* ===== Superclass VGA ===== */
    class Vga
    {
        public string merk;
    }

    /* ===== Subclass dari VGA ===== */
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    /* ===== Superclass laptop ===== */
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dinyalakan");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }
    }

    /* ===== Subclass dari Laptop (ASUS, ACER, LENOVO) ===== */
    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    /* ===== Subclass dari class ASUS ===== */
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    /* ===== Subclass dari class ACER ===== */
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    /* ===== Subclass dari class LENOVO ===== */
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
    internal class program
    {
        private static Laptop laptop1;
        private static Laptop laptop2;
        private static Predator predator;
        private static ACER acer;

        static void Main(string[] args)
        {
            laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();

            laptop2 = new IdeaPad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();

            predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new CoreI7();

            // SOAL NO. 1
            Console.WriteLine("\nJAWABAN 1");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            // SOAL NO. 2
            Console.WriteLine("\nJAWABAN 2");
            //laptop1.Ngoding(); 
            // terjadi error pada program karena method Ngoding() hanya terdapat pada subclass Vivobook dan tidak terdapat pada superclass Laptop.
            // Saat kita membuat objek laptop1 dengan tipe data Laptop dan menginisialisasinya dengan objek Vivobook,
            // hanya method yang terdapat pada superclass Laptop yang dapat diakses dan dipanggil.
            // Oleh karena itu akan mengeluarkan pesan error karena tidak dapat menemukan method Ngoding() pada objek laptop1.

            // SOAL NO. 3
            Console.WriteLine("\nJAWABAN 3");
            Console.WriteLine(laptop1.vga.merk);
            Console.WriteLine(laptop1.processor.merk);
            Console.WriteLine(laptop1.processor.tipe);

            // SOAL NO. 4
            Console.WriteLine("\nJAWABAN 4");
            predator.BermainGame();

            // SOAL NO. 5
            ACER acer = new Predator();
            // acer.BermainGame();
            // JAWABAN 5
            // Terdapat error pada bagian acer = new Predator(); karena variabel acer dideklarasikan sebagai objek dari class ACER
            // dan tidak dapat diisi dengan objek dari subclass Predator

            // SOAL no. 6
            // Kesimpulan
            // jika mencoba untuk mengakses sebuah method yang tidak ada didalam objek nya maka tidak akan bisa di akses.
            // dan juga jika mendeklarasikan sebuah objek dari sebuah clas maka objek tersebuh objek dari calss tersebh dan
            // tidak dapat diisi dengan objek dari subclass lain.
        }
    }
}
