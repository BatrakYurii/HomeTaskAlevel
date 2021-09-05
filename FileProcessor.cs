using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Master
{
    public class FileProcessor
    {
        private string _path;
        public FileProcessor(string path)
        {
            _path = path;
        }
        public async Task WriteTextAsync(string _text)
        {
            using (StreamWriter sw = new StreamWriter(_path, true))
            {
                await sw.WriteLineAsync(_text);
            }
        }

        public async Task<List<string>> ReadTextAsync()
        {
        List<string> result = new List<string>();
            using (StreamReader sr = new StreamReader(_path))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                   result.Add(line);
                }
            }
        return result;
        }
    }
}
