using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    internal class SourceReader
    {
        public enum Target { Invalid = -1, Python = 0, Cpp = 1}

        /// <summary>
        /// Take a .rscript file and compile it to a specified language
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="CustomException"></exception>
        public void Compile(string path, Target target)
        {
            path = path.Replace("\"", "");
            if (!File.Exists(path)) throw new CustomException("Could not find source file", Code.PathError);

            using(StreamReader streamReader = new StreamReader(path))
            {
                // read entire file into a string, then run the parser over the string
                string sourceCode = streamReader.ReadToEnd();

                if (sourceCode.Length < 1) throw new CustomException("No text in source file", Code.EmptyFile);

                switch(target)
                {
                    case Target.Invalid:
                        throw new CustomException("Invalid target type, (Must be '0' or '1')", Code.InvalidTarget);

                    case Target.Python:
                        break;

                    case Target.Cpp:
                        CppParsing parsing = new CppParsing();
                        parsing.Parse(ref sourceCode);
                        break;
                }
            }
        }
    }
}
