using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6 {
    class Book {
        private string title, author, content, ISBN; 

        public Book(string title, string author, string content, string ISBN) {
            this.title = title;
            this.author = author;
            this.content = content;
            this.ISBN = ISBN;
        }

        public string read() {
            return this.content;
        }

        public void shelve() {
            // set state to shelved
        }
    }
}
