using _004._03_AccsessModifiersExercise.Entities;
using _004._03_AccsessModifiersExercise.Services;

Console.WriteLine();
var song1 = new Song("Give Me Tonight", null,"George Benson", "RHINO");
var song3 = new Song("Moonlight Sonata", "Ludwig van Beethoven", "Various Artists", "Classical Records");
var song4 = new Song("The Four Seasons", "Antonio Vivaldi", "Chamber Orchestra", "Baroque Productions");
var song5 = new Song("Symphony No. 9", "Ludwig van Beethoven", "Philharmonic Orchestra", "Classic Harmony Records");
var playlist1 = new Playlist(song1);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);
Console.WriteLine("Before Shuffle:");
Console.WriteLine(playlist1.GetSongs());
playlist1.ShuffleSongs();
Console.WriteLine("\n\nAfter Shuffle:");
Console.WriteLine(playlist1.GetSongs());
NotepadService notepadService = new();
notepadService.PlaylistToNotepad(playlist1);

Console.ReadLine();
