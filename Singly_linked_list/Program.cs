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
            Node previous, currrent;
            previous = START;
            currrent = START;

            while((currrent != null) && (nim >= currrent.noMhs))
            {
                if(nim == currrent.noMhs)
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan");
                    return;
                }
                previous = currrent;
                currrent = currrent.next;
            }
            nodeBaru.next = currrent;
            previous.next = nodeBaru;
        }
        //Method untuk menghapus node tertentu didalam list
        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;
            //check apakah node yang dimaksud ada di dalam list atau tidak
            if (Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
            
                START = START.next;
                return true;
            
        }
        //Method untuk meng-check apakah node yang dimaksud ada didalam list atau tidak
        public bool Search (int nim, ref Node previous, ref Node current)
        {
            previous = current;
            while((current != null) && (nim >= current.noMhs))
            {
                previous = current;
                current = current.next; 
            }
            if (current == null)
                return (false);
            else
                return (true);


        } 
        
    }
    //Method untuk treverse /mengunjungi dan membaca isi list

    public void treverse()
    {
        if (listEmpety)
            Console.WriteLine("\nList kosong: ");
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
