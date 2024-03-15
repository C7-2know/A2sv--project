public class Library
{
    public string name;
    public string address;
    public List<Book> Books;
    public List<MediaItem> MediaItems;

    public Library(string name, string address){
        this.name=name;
        this.address=address;
        this.Books = new List<Book>();
        this.MediaItems = new List<MediaItem>(); 
    }

    public void AddBook(Book book){
        this.Books.Add(book);
    }

    public  void RemoveBook(Book book){
        this.Books.Remove(book);
    }

    public  void AddMediaItem(MediaItem item){
        this.MediaItems.Add(item);
    }

    public  void RemoveMediaItem(MediaItem item){
        this.MediaItems.Remove(item);
    }

    public void PrintCatalog(){
        Console.WriteLine("Here are the list of books in the Book");
        foreach (Book book in this.Books){
            Console.WriteLine($"# {book.title} - {book.author} - {book.ISBN} - {book.PublicationYear}");
        }

        Console.WriteLine("Here are the list of MediaItems in the Book");
        foreach (MediaItem media in this.MediaItems){
            Console.WriteLine($"# {media.title} - {media.MediaType} - {media.Duration}");
        }
    } 

}

public class Book{
    public string title;
    public string author;
    public string ISBN;
    public int PublicationYear;

    public Book(string title, string author, string Isbn, int date){
        this.title=title;
        this.author=author;
        this.ISBN=Isbn;
        this.PublicationYear=date;
    }
}
public class MediaItem{
    public string title;
    public string MediaType;
    public int Duration;
    public MediaItem(string title,string type, int time){
        this.title=title;
        this.MediaType=type;
        this.Duration=time;
    }

}

public class MainC{
    public static void Main(){
        Library library =new Library("Abrehot","4 kilo");
        Book book1 =new Book("Long life","Elizebn alice",".....", 2024);
        Book book2 =new Book("Live like a Monk","Elizebn alice",".....", 2024);
        Book book3 =new Book("Rich dad poor dad","Elizebn alice",".....", 2024);
        Book book4 =new Book("the light","Elizebn alice",".....", 2024);

        MediaItem mediaItem1 =new MediaItem("Long life","CD", 2024);
        MediaItem mediaItem2 =new MediaItem("Monk life","DVD", 2024);
        MediaItem mediaItem3 =new MediaItem("The Unknown","DVD", 2024);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        library.AddMediaItem(mediaItem1);
        library.AddMediaItem(mediaItem2);
        library.AddMediaItem(mediaItem3);

        library.PrintCatalog();
    }
}
