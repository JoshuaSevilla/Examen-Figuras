using System;

namespace Examen_Figuras
{
    public interface ILienzo : IConsole
    {
        new Func<string> Read { get; set; }
        new Action<string> Write { get; set; }
    }


}

