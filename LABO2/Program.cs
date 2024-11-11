// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information

Book info = new Book("Python");
info.addChapter(1, "Variables");
info.addChapter(2, "If-else");
info.addChapter(3, "Loop");

Book elo = new Book("Silicon");
elo.addChapter(1, "Transistor");
elo.addChapter(2, "Resistance");
elo.addChapter(3, "Capacité");

Library lib = new Library("Biblio de l'ECAM");
lib.addBook(info);
lib.addBook(elo);

lib.addSubscriber(new Subscriber("M. Marchand", "Sur Terre"));

lib.displayBooks();
lib.displaySubscribers();
