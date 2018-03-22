using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Figuras
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Type> figuras = new List<Type>()
            {
                typeof(Estrella),
                typeof(Corazon),
                typeof(Rayo)
            };
            List<string> colors = new List<string>
            {
                "Rojo",
                "Negro",
                "Verde",
                "Amarillo"
            };

        }

    }

    class Paint : IToolBar, IConsole
    {
        public Paint()
        {

        }

        public string Figuras { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Colores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Commands { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Func<string> Read { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Action<string> Write { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    interface IFigura : IToolBar
    {

        string ColorFondo { get; set; }
        string ColorBorde { get; set; }
    }
    class Figura : IFigura
    {
        string ColorFondo { get; set; }
        string IFigura.ColorFondo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ColorBorde { get; set; }
        string IFigura.ColorBorde { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IToolBar.Figuras { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IToolBar.Colores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IToolBar.Commands { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Estrella : Figura
    {
        public override string ToString()
        {
            return "soy una estrella";
        }
    }
    class Corazon : Figura
    {
        public override string ToString()
        {
            return "soy un corazon";
        }

    }
    class Rayo : Figura
    {
        public override string ToString()
        {
            return "soy un rayo";
        }

    }
    class ToolBar : IToolBar
    {
        string Commands { get; set; } 
        string IToolBar.Commands { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Figuras { get; set; }
        string IToolBar.Figuras { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Colores { get; set; }
        string IToolBar.Colores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }

    public interface IConsole
    {
        Func<string> Read { get; set; }
        Action<string> Write { get; set; }
    }
    public class Console : IConsole
    {
        public Console(Func<string> read, Action<string> write)
        {
            Read = read;
            Write = write;
        }
        public Func<string> Read { get; set; }
        public Action<string> Write { get; set; }
    }


}

