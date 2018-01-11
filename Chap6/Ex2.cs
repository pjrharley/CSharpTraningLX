using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6 {
    class Book {
        private string Title, Author, Content, ISBN; 

        public Book(string title, string author, string content, string ISBN) {
            this.Title = title;
            this.Author = author;
            this.Content = content;
            this.ISBN = ISBN;
        }

        public string read() {
            return this.Content;
        }

        public void shelve() {
            // set state to shelved
        }
    }
}
