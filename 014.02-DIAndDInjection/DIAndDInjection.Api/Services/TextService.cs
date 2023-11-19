using DIAndDInjection.Shared;
using DIAndDInjection.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAndDInjection.Api.Services
{
    public class TextService:ITextService
    {
        private readonly string _path;
        public TextService(string path="ß")
        {
           // _path = path;
           _path= "C:\\Users\\Bhs\\Desktop\\passwords.txtk";
        }
        public void Save(string text)
        {
            int number = 2;
            var even=number.IsEven();

            if (text.IsEmpty())
            {
                throw new ArgumentNullException("text can not not be null");
            }
            File.WriteAllText(_path, text);
        }
    }
}
