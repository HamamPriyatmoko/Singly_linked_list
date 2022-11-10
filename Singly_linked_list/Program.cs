using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        //Method untuk menambahkan sebuah node ke dalam list

        public void addnote()
        {
            int nim;
            string nm;
            Console.WriteLine("\nMasukan nomer Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMasukan nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;

            //Node ditambahkan sebagai node pertama 
            if(START == null || nim <= START.noMhs)
            {
                if((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan ");
                }
                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }
            //Menemukan lokasi node baru didalam list
            Node previus, currrent;
            previus = START;
            currrent = START;

            while((currrent != null) && (nim >= currrent.noMhs))
            {
                if(nim == currrent.noMhs)
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan");
                    return;
                }
                previus = currrent;
                currrent = currrent.next;
            }
            nodeBaru.next = currrent;
            previus.next = nodeBaru;
        }
        //Methodw
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
