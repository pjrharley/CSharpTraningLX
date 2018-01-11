using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7 {
    class Ex3 {
        public static void run() {
            Book b1 = new Book("Programming", "Jee", "16465456");
            Book b2 = new Book("Programmingdasd", "Jesdfsde", "1642131265456");
            Book b3 = new Book("Programminsdfg", "Jesdfsde", "1646541231256");
            b1.displayBook();
            b2.displayBook();
            b3.displayBook();
        }
    }

    class Book {
        String title, author, publisher = "OReilly", ISBN;

        public Book(String title, String author, String ISBN) {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }

        public void displayBook() {
            Console.WriteLine(this.toString());
        }

        private string toString() {
            return title + " " + author + " " + publisher + " " + ISBN;
        }
    }
}
