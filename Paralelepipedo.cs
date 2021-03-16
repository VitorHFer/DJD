using System;
using System.Collections.Generic;
using System.Text;

namespace ParalelepipedoFinal
{
    class Paralelepipedo
    {
		public int comprimento;
		public int largura;
		public int altura;
		public int Volume;
		public int Area;


		public Paralelepipedo()
		{
			this.comprimento = 3;
			this.largura = 3;
			this.altura = 3;

			Console.WriteLine("Comprimento: " + comprimento.ToString());
			Console.WriteLine("Largura: " + largura.ToString());
			Console.WriteLine("Altura: " + altura.ToString());
		}

		public Paralelepipedo(int tam)
		{
			this.comprimento = tam;
			this.largura = tam;
			this.altura = tam;

			if (tam < 0) tam = 0;

			Console.WriteLine("Comprimento: " + comprimento.ToString());
			Console.WriteLine("Largura: " + largura.ToString());
			Console.WriteLine("Altura: " + altura.ToString());

		}

		public Paralelepipedo(int comp, int larg, int alt)
		{
			if (comp < 0) comp = 0;
			if (larg < 0) larg = 0;
			if (alt < 0) alt = 0;

			this.comprimento = comp;
			this.largura = larg;
			this.altura = alt;


			Console.WriteLine("Comprimento: " + comp.ToString());
			Console.WriteLine("Largura: " + larg.ToString());
			Console.WriteLine("Altura: " + alt.ToString());

		}

		public void volume()
		{
			this.Volume = this.comprimento * this.largura * this.altura;
			Console.WriteLine("Volume: " + this.Volume);
		}

		public void areaTotal()
		{
			this.Area = 2 * altura * largura + 2 * altura * comprimento + 2 * largura * comprimento;
			Console.WriteLine("Área: " + this.Area);
		}

		public void IsCube()
		{
			if (comprimento == largura && largura == altura && altura  == comprimento)
			{
				Console.WriteLine("É um cubo");
			}
			else
			{
				Console.WriteLine("Não é cubo");
			}
		}

		public void Is3D()
		{
			if (comprimento == 0 || largura == 0 || altura == 0) Console.WriteLine("É 2D");
			else Console.WriteLine("É 3D");
		}
	}
}
