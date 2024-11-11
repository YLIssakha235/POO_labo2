class Chapter {
    private string title;
    private int number;

    public Chapter(string title, int number) {
        this.title = title;
        this.number = number;
    }

    public string Title {
        get { return title; }
    }

    public int Number {
        get { return number; }
    }

    public string get_title() {
        return title;
    }

    public override string ToString() {
        return String.Format("{1}: {0}", title, number);
    }
}