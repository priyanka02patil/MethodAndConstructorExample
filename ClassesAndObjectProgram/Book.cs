using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectProgram
{
    public class Book
    {
        private int bid;
        private string bname,authorname;
        private double bprice;

        public Book(int id, string name, string authname, double price)
        {
            bid = id;
            bname = name;
            authorname = authname;
            bprice = price;
        }

        public string DisplayDetails()
        {
            return $" Book Details Are : ID = {bid} Book Name = {bname} Book Price = {bprice} Author Name = {authorname} ";
        }
    }
}
