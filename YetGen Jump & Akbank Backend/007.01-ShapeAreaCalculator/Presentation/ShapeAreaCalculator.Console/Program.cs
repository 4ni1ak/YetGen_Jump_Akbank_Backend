using SAC_long_path.Infrastructure.Service;
using ShapeAreaCalculator.Domain.Entities;

Console.WriteLine("Hello, World!");

Square square1 = new(4);

NotepadService notepadService = new();
notepadService.SaveToNotepad(square1);