using semester3modul6.Models;

using (var db = new TaskContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");

    // Create
    Console.WriteLine("Create et board");
    Board newBoard = new Board();
    User test = new User("Mads");
    Todo todo1 = new Todo(test,"hahaxd");
    Todo todo2 = new Todo(test,"hehexd");
    
    newBoard.todos.Add(todo1);
    newBoard.todos.Add(todo2);

    db.Add(newBoard);
    db.SaveChanges();
}