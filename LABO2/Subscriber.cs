class Subscriber {
    private string name;
    private string address;

    public Subscriber(string name, string address) {
        this.name = name;
        this.address = address;
    }

    public string Name {
        get { return name; }
    }

    public string Address {
        get { return address; }
    }

    public override string ToString() {
        return String.Format("{0} (address={1})", name, address);
    }
}