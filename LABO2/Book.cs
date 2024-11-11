class Book {
    private string book_title;
    private List<Chapter> chapters;

    public Book(string book_title) {
        this.book_title = book_title;
        this.chapters = new List<Chapter>();
    }

    public string Title {
        get { return book_title; }
    }

    public void addChapter(int number, string title) {
        chapters.Add(new Chapter(title, number));
    }

    private string chapters_as_str() {
        string res = "";
        foreach (Chapter chapter in chapters) {
            res += chapter.ToString() + "\n";
        }
        return res;
    }

    public void displayChapters() {
        Console.WriteLine(chapters_as_str());
    }

    public override string ToString() {
        string res = Title + "\n";
        res += chapters_as_str();
        return res;
    }

}