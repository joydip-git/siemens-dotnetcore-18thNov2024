using System.Collections.Generic;

Console.WriteLine();

Category laptop = new Category { Id = 1, Name = "Laptop" };
List<Category> categories = new List<Category> { laptop };

ProductReadDto p = new ProductReadDto
{
    Id = 1,
    Name = "dell xps",
    Price = 10000
};

class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public List<ProductReadDto>? Products { get; set; }
}

class ProductReadDto
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }

    //navigation property (association)
    public Category? Category { get; set; }
}

class Subscriber
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    //public List<Book>? Books { get; set; }
}

//Association Class
class Book
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    //public List<Subscriber>? Authors { get; set; }
}

class Catalog
{
    public int Id { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime ExpectedReturnDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public decimal Fine { get; set; } = 0;
    public Subscriber? Subscriber { get; set; }
    public Book? Book { get; set; }
}