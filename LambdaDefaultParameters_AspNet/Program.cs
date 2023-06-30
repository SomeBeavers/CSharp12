using LambdaDefaultParameters_AspNet;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();
app.MapGet("/", (TodoDb db) =>
{
    db.Todos.Add(new Todo
    {
        Id = 1,
        Name = "MyToDo",
        IsComplete = true
    });
    db.SaveChanges();
    return "Hello World!";
});
app.MapGet("/todoitems", async (TodoDb db, int id = 1) =>
{
    Console.WriteLine($"id: {id}");
    return await db.Todos.ToListAsync();
});

//app.MapGet("/todoitems/complete", async (TodoDb db) =>
//    await db.Todos.Where(t => t.IsComplete).ToListAsync());


app.MapGet("/todoitem/{id}", async (TodoDb db, int id = 1) =>
{
    Console.WriteLine($"id: {id}");
    var todo = await db.Todos.FindAsync(id);
    if (todo is not null)
    {
        return todo?.Name;
    }

    return $"TODO with id = {id} is not found.";
});

app.MapGet("/todoitem", async (TodoDb db, int id = 1) =>
{
    Console.WriteLine($"id: {id}");
    var todo = await db.Todos.FindAsync(id);
    if (todo is not null)
    {
        return todo?.Name;
    }

    return $"TODO with id = {id} is not found.";
});

//app.MapPost("/todoitems", async (Todo todo, TodoDb db) =>
//{
//    db.Todos.Add(todo);
//    await db.SaveChangesAsync();

//    return Results.Created($"/todoitems/{todo.Id}", todo);
//});

//app.MapPut("/todoitems/{id}", async (int id, Todo inputTodo, TodoDb db) =>
//{
//    var todo = await db.Todos.FindAsync(id);

//    if (todo is null) return Results.NotFound();

//    todo.Name = inputTodo.Name;
//    todo.IsComplete = inputTodo.IsComplete;

//    await db.SaveChangesAsync();

//    return Results.NoContent();
//});

//app.MapDelete("/todoitems/{id}", async (int id = 0, TodoDb db = null!) =>
//{
//    if (await db.Todos.FindAsync(id) is not { } todo) return Results.NotFound();
//    db.Todos.Remove(todo);
//    await db.SaveChangesAsync();
//    return Results.Ok(todo);

//});

app.Run();