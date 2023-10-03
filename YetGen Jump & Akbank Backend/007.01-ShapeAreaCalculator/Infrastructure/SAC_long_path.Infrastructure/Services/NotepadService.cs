using ShapeAreaCalculator.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAC_long_path.Infrastructure.Service
{
    public class NotepadService
    {
        public void SaveToNotepad(ISaveableShape saveableShape)
        {
            string path = DirectoryService.GetNotepadDirectory();

            DirectoryService.DirectoryCreateIfNotExist(path);

            File.AppendAllText($"{path}/{saveableShape.GetType()}.txt", saveableShape.GetInfos());
        }
    }
}
