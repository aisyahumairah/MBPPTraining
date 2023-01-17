using System;

namespace MBPPTraining
{
    class Book
    {
        public string title { get; set; }
        string color { get; set; }
        private bool writable;

        public Book()
        {
        }

        public Book(string title)
        {
            this.title = title;
        }

        public Book(string title, string color)
        {
        }

        public static void Flip()
        {
            Console.WriteLine("Next page");
        }

        public void Close()
        {
            Console.WriteLine("Book closed");
        }

        protected bool getWritable()
        {
            return writable;
        }

        protected void setWritable(bool writable)
        {
            this.writable = writable;
        }


        public virtual void Dispose()
        {
            Console.WriteLine("Throw book away");
        }

        public void Borrow(ShelfWithoutWheels shelf, string bookTitle)
        {
            shelf.RemoveBook(bookTitle);
        }

        //public string getTitle()
        //{
        //    return title;
        //}

        //public void setTitle(string newTitle)
        //{
        //    title = newTitle;
        //}
    }
}
