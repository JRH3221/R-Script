using System.Linq.Expressions;

namespace Compiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string? path;
                SourceReader.Target target = SourceReader.Target.Invalid;
                if (args.Length == 0)
                {
                    Console.WriteLine("Enter path: ");
                    path = Console.ReadLine();

                    if(path is null)
                    {
                        throw new CustomException("Invalid Script Path", Code.PathError);
                    }

                    path = path.Replace("\"", "");

                    Console.WriteLine("Enter target (Python = 0, C++ = 1)");
                    target = (SourceReader.Target)int.Parse(Console.ReadLine() ?? "-1");
                }
                else
                {
                    path = args[0];
                }

                CheckPath(path); // will throw error if there are any faults

                SourceReader sourceReader = new SourceReader();
                sourceReader.Compile(path ?? "0x01", target); // this should never be null, but this is done to shut up visual studio
            }
            catch (CustomException e)
            {
                Logging.Log(e.Message, e.ErrorCode);
            }
            catch (Exception e)
            {
                Logging.Log(e.Message, Code.Null);
                
            }
        }

        private static void CheckPath(string? path)
        {
            if (path is null || path == string.Empty)
            {
                throw new CustomException("Invalid Script Path", Code.PathError);
            }
            if(!path.ToLower().EndsWith(".rscript"))
            {
                throw new CustomException("Invalid File Type. (Must be .rscript)", Code.PathError);
            }
        }
    }
}