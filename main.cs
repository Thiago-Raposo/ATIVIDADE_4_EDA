using System;
using System.Net;
using arvorebin;

namespace ArvoreAVL
{
	class ProgramaArvoreAVL
	{
		static void Main(string[] args)
		{
			Console.WriteLine("arvore avl!");

			ArvoreAVL arvoreAVL = new ArvoreAVL();
			ArvoreBinaria arvoreBinaria = new ArvoreBinaria();
			int opcao, x;
			
			while (true)
			{
				// exemplo
				// 70 40 20 60 80 55 85 10 15 5
	            Console.WriteLine("1 - exibir a arvore AVL");
				Console.WriteLine("2 - inserir um novo no");
				Console.WriteLine("3 - remover um no ");
				Console.WriteLine("4 - percorrer em ordem AVL");
				Console.WriteLine("5 - exibir a arvore bin");
				Console.WriteLine("6 - percorrer em ordem bin");
				Console.WriteLine("7 - sair");
				Console.Write("escolha uma opcao: ");
				opcao = Convert.ToInt32(Console.ReadLine());

				if (opcao == 7)
					break;

				switch (opcao)
				{
					case 1:
					    Console.Write("\n AVL\n");
						arvoreAVL.Exibir();
						break;

					case 2:
						Console.Write("entre com a chave que sera inserida: ");
						x = Convert.ToInt32(Console.ReadLine());
						arvoreBinaria.Inserir(x);
						arvoreAVL.Inserir(x);
						break;

					case 3:
						Console.Write("entre com a chave que sera removida: ");
						x = Convert.ToInt32(Console.ReadLine());
						arvoreBinaria.Remover(x);
						arvoreAVL.Removeravl(x);
						break;

					case 4:
						   Console.Write("\n AVL\n");
						arvoreAVL.PercorrerEmOrdem();
						break;
					
					case 5:
					    Console.Write("\n bin\n");
						arvoreBinaria.Exibir();
						break;


					case 8:
					    Console.Write("\n bin\n");
						arvoreBinaria.PercorrerEmOrdem();
						break;
						
				}
			}
		}
	}
}