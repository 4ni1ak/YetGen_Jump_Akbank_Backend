using Enttites.Entities;
using Enttites.Entities.Persistance;


NoteMasterDbContext _context = new();
_context.Notes.Add(new("Note 1"));
_context.Notes.Add(new("Note 2"));
_context.Notes.Add(new("Note 3"));
_context.Notes.Add(new("Note 4"));

_context.SaveChanges();
List<Note> notes= _context.Notes.ToList();
foreach (var note in notes)
{
    Console.WriteLine(note.Text);
    
}
#region AddRange

List<Note> addNotes = new List<Note>
{
    new Note ( "Note 5" ),
    new Note ("Note 6"),
    new Note ("Note 7")
};

_context.Notes.AddRange(addNotes);
_context.SaveChanges();
#endregion

#region Remove

List<Note> notesToRemove = new List<Note>();

foreach (var note in addNotes)
{
    var existingNote = addNotes.FirstOrDefault(n => n.Text == note.Text);
    if (existingNote != null)
    {
        notesToRemove.Add(existingNote);
    }
}

foreach (var noteToRemove in notesToRemove)
{
    addNotes.Remove(noteToRemove);
}

_context.SaveChanges();
#endregion

foreach (var note in addNotes)
{
    Console.WriteLine(note.Text);

}

foreach (var note in notes)
{
    Console.WriteLine(note.Text);

}