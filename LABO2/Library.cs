class Library {
    private string library_name;

    private List<Book> books;
    private List<Subscriber> subscribers;

    public Library(string library_name) {
        this.library_name = library_name;
        books = new List<Book>();
        subscribers = new List<Subscriber>();
    }

    public void addSubscriber(Subscriber subscriber) {
        subscribers.Add(subscriber);
    }

    public void addBook(Book book) {
        books.Add(book);
    }

    public void displaySubscribers() {
        foreach (Subscriber subscriber in subscribers) {
            Console.WriteLine(subscriber);
        }
    }

    public void displayBooks() {
        foreach (Book book in books) {
            Console.WriteLine(book);
        }
    }
}