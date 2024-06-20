using System.Globalization;

namespace WebApplication2.Models
{
    public class Figure
    {
        public string name {  get; set; }
        public string pic {  get; set; }
    }
    public class FigureGenerator : IFigureGenerator
    {
        private readonly string[] _name = { "circle", "triangle", "rectangle" };
        private readonly string[] _pic = { "⬤", "▲" , "█" };
        public Figure createNewFigure()
        {
            string name;
            string pic;
            var random = new Random();
            var Figureindex = random.Next(3);
            name = _name[Figureindex];
            pic = _pic[Figureindex];
            return new Figure { name = name, pic = pic };
        }
        public Figure addNewFigure()
        {
			string name;
			string pic;
			var random = new Random();
			var Figureindex = random.Next(3);
			name = _name[Figureindex];
			pic = _pic[Figureindex];
			File.WriteAllText(name, name + pic);
			File.WriteAllText(name + ".txt", name + pic);
			File.WriteAllText(name + ".pdf", name + pic);
			return new Figure { name = name, pic = pic };
		}
		public Figure openNewFigure()
		{
			if (File.Exists("circle.txt"))
			{
				string figur = File.ReadAllText("circle.txt");
				return new Figure { name = figur, pic = "" };
			}
			else if (File.Exists("circle.pdf"))
			{
				string figur = File.ReadAllText("circle.pdf");
				return new Figure { name = figur, pic = "" };
			}
			else if (File.Exists("circle"))
			{
				string figur = File.ReadAllText("circle");
				return new Figure { name = figur, pic = "" };
			}
			else
			{
				return new Figure { name = "*Empty*", pic = "*Empty" };
			}
		}
	}
    public interface IFigureGenerator
    {
        Figure createNewFigure();
		Figure addNewFigure();
		Figure openNewFigure();
    }
}
