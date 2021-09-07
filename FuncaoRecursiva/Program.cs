using System;
using System.IO;

namespace FuncaoRecursiva
{
	class Program
	{
		public static void LerArquivo(string nomeArquivo)

		//função para ler um arquivo txt
		{
			using (StreamReader arquivo = File.OpenText(nomeArquivo))
			{
				string linha;
				while ((linha = arquivo.ReadLine()) != null)
				{
					Console.WriteLine(linha);
				}
			}
		}

		//função para ler vários arquivo txt
		public static void LerArquivos(int numeroArquivo)
		{
			string arquivoComCaminho = @"C:\arquivos\arq" + numeroArquivo + ".txt";
			if (File.Exists(arquivoComCaminho))
			{
				using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
				{
					string linha;
					while ((linha = arquivo.ReadLine()) != null)
					{
						Console.WriteLine(linha);
					}
				}
			}
			string arquivoComCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";
			if (File.Exists(arquivoComCaminho2))
			{
				LerArquivos(numeroArquivo + 1);
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Oie... estudando no feriado, que linda!!!");
			Console.WriteLine("****************************************");

			LerArquivo(@"C:\Users\MAON\Projetos\Lembretes Importantes\CriarAutoMapper.txt");

			LerArquivos(1);
		}
	}
}
