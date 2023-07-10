using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    internal class CppParsing
    {
        private enum Type { None = -1, Bool=0, Int=1, Pure=2}
        private List<object> Variables = new List<object>();

        // c++ blocks
        string includes;
        string methodDefinitions;
        string topLevelVars;
        string implementation;

        private class CTypes
        {
            public struct Null
            {

            }
            public struct Cbool
            {

            }
            public struct Cint 
            {
                public int value;
                public string varName;
            }
        }

        public void Parse(ref string input)
        {
            string currentToken = string.Empty;
            string lastToken = string.Empty;
            Type currentType = Type.None;
            for(int index = 0; index < input.Length; index++)
            {
                if (input[index] == ' ')
                {
                    switch(EvalToken(currentToken, currentType))
                    {
                        case Type.Int: 
                            currentType = Type.Int; 
                            break;

                        case Type.Bool:
                            currentType = Type.Bool;
                            break;
                    }
                }
                else
                {
                    currentToken += input[index];
                }
            }
        }

        private Type EvalToken(string token, Type lastType)
        {
            // variable types
            if(token == "int")
            {
                return Type.Int;
            }
            else if(token == "bool")
            {
                return Type.Bool;
            }
            else if(lastType != Type.None)
            {
                switch(lastType)
                {
                    case Type.Int:
                        CTypes.Cint cint = new CTypes.Cint();
                        cint.varName = token;
                        break;
                }
            }

            return Type.Error;
        }
    }
}
