﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Bolao
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Campeonato br = montarCampeonato ();

			var pares = br.times.Select (time => new KeyValuePair<string,int> (time.Value.nome, br.pontos (time.Value)));
			Console.WriteLine ("Tabela desordenada");
			foreach(KeyValuePair<string,int> kv in pares){
				Console.WriteLine (kv.Key + "-->" + kv.Value);
			}

			var ordenados = pares.OrderByDescending (kv => kv.Value);

			Console.WriteLine ("Tabela Ordenada");
			foreach(KeyValuePair<string,int> kv in ordenados){
				Console.WriteLine (kv.Key + "-->" + kv.Value);
			}

//			Jogo j = br.turnos [1].rodadas [0].jogos [2];
//			Time mandante = j.mandante;
//			Time visitante = j.visitante;
//			Time naoJogou = br.turnos [1].rodadas [0].jogos [3].mandante;
//
//			Console.WriteLine (j);
//			Console.WriteLine (mandante.nome + " marcou " + j.pontos (mandante) + " ponto(s)");
//			Console.WriteLine (visitante.nome + " marcou " + j.pontos (visitante)  + " ponto(s)");
//			Console.WriteLine (naoJogou.nome + " marcou " + j.pontos (naoJogou)  + " ponto(s)");
//			Console.WriteLine (mandante.nome + " tem " + br.pontos (mandante)  + " ponto(s)");


		}
		public static Campeonato montarCampeonato(){
			Campeonato br16 = new Campeonato ();
			br16.registrar (1,	1,	"Palmeiras", "AtléticoPR",	4,	0);
			br16.registrar (1,	1,	"Flamengo", "Sport",	1,	0);
			br16.registrar (1,	1,	"AtléticoMG", "Santos",	1,	0);
			br16.registrar (1,	1,	"Coritiba", "Cruzeiro",	1,	0);
			br16.registrar (1,	1,	"Botafogo", "SãoPaulo",	0,	1);
			br16.registrar (1,	1,	"SantaCruz", "Vitória",	4,	1);
			br16.registrar (1,	1,	"Corinthians", "Grêmio",	0,	0);
			br16.registrar (1,	1,	"Figueirense", "PontePreta",	0,	0);
			br16.registrar (1,	1,	"AméricaMG", "Fluminense",	0,	1);
			br16.registrar (1,	1,	"Internacional", "Chapecoense",	0,	0);
			br16.registrar (1,	2,	"PontePreta", "Palmeiras",	2,	1);
			br16.registrar (1,	2,	"Fluminense", "SantaCruz",	2,	2);
			br16.registrar (1,	2,	"Cruzeiro", "Figueirense",	2,	2);
			br16.registrar (1,	2,	"AtléticoPR", "AtléticoMG",	1,	1);
			br16.registrar (1,	2,	"Santos", "Coritiba",	2,	1);
			br16.registrar (1,	2,	"Chapecoense", "AméricaMG",	3,	1);
			br16.registrar (1,	2,	"Grêmio", "Flamengo",	1,	0);
			br16.registrar (1,	2,	"SãoPaulo", "Internacional",	1,	2);
			br16.registrar (1,	2,	"Vitória", "Corinthians",	3,	2);
			br16.registrar (1,	2,	"Sport", "Botafogo",	1,	1);
			br16.registrar (1,	3,	"Botafogo", "AtléticoPR",	2,	1);
			br16.registrar (1,	3,	"Figueirense", "Santos",	2,	2);
			br16.registrar (1,	3,	"AméricaMG", "Vitória",	1,	1);
			br16.registrar (1,	3,	"Flamengo", "Chapecoense",	2,	2);
			br16.registrar (1,	3,	"Coritiba", "SãoPaulo",	1,	1);
			br16.registrar (1,	3,	"Palmeiras", "Fluminense",	2,	0);
			br16.registrar (1,	3,	"SantaCruz", "Cruzeiro",	4,	1);
			br16.registrar (1,	3,	"Corinthians", "PontePreta",	3,	0);
			br16.registrar (1,	3,	"Internacional", "Sport",	1,	0);
			br16.registrar (1,	3,	"AtléticoMG", "Grêmio",	0,	3);
			br16.registrar (1,	4,	"Cruzeiro", "AméricaMG",	1,	1);
			br16.registrar (1,	4,	"AtléticoPR", "Figueirense",	2,	1);
			br16.registrar (1,	4,	"Chapecoense", "SantaCruz",	1,	1);
			br16.registrar (1,	4,	"PontePreta", "Flamengo",	1,	2);
			br16.registrar (1,	4,	"Sport", "Corinthians",	0,	2);
			br16.registrar (1,	4,	"Vitória", "AtléticoMG",	1,	1);
			br16.registrar (1,	4,	"Fluminense", "Botafogo",	1,	0);
			br16.registrar (1,	4,	"SãoPaulo", "Palmeiras",	1,	0);
			br16.registrar (1,	4,	"Grêmio", "Coritiba",	2,	0);
			br16.registrar (1,	4,	"Santos", "Internacional",	0,	1);
			br16.registrar (1,	5,	"Internacional", "AtléticoPR",	1,	0);
			br16.registrar (1,	5,	"Corinthians", "Santos",	1,	0);
			br16.registrar (1,	5,	"Coritiba", "Chapecoense",	3,	4);
			br16.registrar (1,	5,	"SantaCruz", "Sport",	0,	1);
			br16.registrar (1,	5,	"AtléticoMG", "Fluminense",	1,	1);
			br16.registrar (1,	5,	"Botafogo", "Cruzeiro",	0,	1);
			br16.registrar (1,	5,	"Figueirense", "SãoPaulo",	1,	0);
			br16.registrar (1,	5,	"AméricaMG", "PontePreta",	1,	2);
			br16.registrar (1,	5,	"Flamengo", "Vitória",	1,	0);
			br16.registrar (1,	5,	"Palmeiras", "Grêmio",	4,	3);
			br16.registrar (1,	6,	"AtléticoPR", "SantaCruz",	1,	0);
			br16.registrar (1,	6,	"Chapecoense", "Fluminense",	0,	0);
			br16.registrar (1,	6,	"Corinthians", "Coritiba",	2,	1);
			br16.registrar (1,	6,	"AméricaMG", "Figueirense",	1,	0);
			br16.registrar (1,	6,	"Santos", "Botafogo",	3,	0);
			br16.registrar (1,	6,	"Flamengo", "Palmeiras",	1,	2);
			br16.registrar (1,	6,	"Grêmio", "PontePreta",	1,	0);
			br16.registrar (1,	6,	"Sport", "AtléticoMG",	4,	4);
			br16.registrar (1,	6,	"Vitória", "Internacional",	1,	0);
			br16.registrar (1,	6,	"Cruzeiro", "SãoPaulo",	0,	1);
			br16.registrar (1,	7,	"Internacional", "AméricaMG",	3,	1);
			br16.registrar (1,	7,	"PontePreta", "Chapecoense",	2,	1);
			br16.registrar (1,	7,	"Fluminense", "Grêmio",	1,	1);
			br16.registrar (1,	7,	"SãoPaulo", "AtléticoPR",	1,	2);
			br16.registrar (1,	7,	"Botafogo", "Vitória",	1,	1);
			br16.registrar (1,	7,	"Coritiba", "Sport",	3,	2);
			br16.registrar (1,	7,	"AtléticoMG", "Cruzeiro",	2,	3);
			br16.registrar (1,	7,	"Figueirense", "Flamengo",	1,	0);
			br16.registrar (1,	7,	"Palmeiras", "Corinthians",	1,	0);
			br16.registrar (1,	7,	"SantaCruz", "Santos",	0,	2);
			br16.registrar (1,	8,	"Chapecoense", "Grêmio",	3,	3);
			br16.registrar (1,	8,	"PontePreta", "AtléticoPR",	3,	2);
			br16.registrar (1,	8,	"SãoPaulo", "Vitória",	2,	0);
			br16.registrar (1,	8,	"Botafogo", "AméricaMG",	3,	1);
			br16.registrar (1,	8,	"SantaCruz", "Figueirense",	1,	0);
			br16.registrar (1,	8,	"Santos", "Sport",	2,	0);
			br16.registrar (1,	8,	"Coritiba", "Palmeiras",	2,	2);
			br16.registrar (1,	8,	"Cruzeiro", "Flamengo",	0,	1);
			br16.registrar (1,	8,	"Internacional", "AtléticoMG",	2,	0);
			br16.registrar (1,	8,	"Fluminense", "Corinthians",	1,	0);
			br16.registrar (1,	9,	"Palmeiras", "SantaCruz",	3,	1);
			br16.registrar (1,	9,	"AtléticoPR", "Santos",	1,	0);
			br16.registrar (1,	9,	"AméricaMG", "Coritiba",	2,	1);
			br16.registrar (1,	9,	"AtléticoMG", "PontePreta",	3,	0);
			br16.registrar (1,	9,	"Vitória", "Chapecoense",	1,	2);
			br16.registrar (1,	9,	"Corinthians", "Botafogo",	3,	1);
			br16.registrar (1,	9,	"Figueirense", "Internacional",	3,	2);
			br16.registrar (1,	9,	"Flamengo", "SãoPaulo",	2,	2);
			br16.registrar (1,	9,	"Sport", "Fluminense",	2,	1);
			br16.registrar (1,	9,	"Grêmio", "Cruzeiro",	2,	0);
			br16.registrar (1,	10,	"Palmeiras", "AméricaMG",	2,	0);
			br16.registrar (1,	10,	"Chapecoense", "AtléticoPR",	0,	0);
			br16.registrar (1,	10,	"PontePreta", "Cruzeiro",	0,	4);
			br16.registrar (1,	10,	"Botafogo", "Figueirense",	0,	0);
			br16.registrar (1,	10,	"SantaCruz", "Flamengo",	0,	1);
			br16.registrar (1,	10,	"AtléticoMG", "Corinthians",	2,	1);
			br16.registrar (1,	10,	"Fluminense", "Santos",	2,	4);
			br16.registrar (1,	10,	"Grêmio", "Vitória",	1,	2);
			br16.registrar (1,	10,	"SãoPaulo", "Sport",	0,	0);
			br16.registrar (1,	10,	"Coritiba", "Internacional",	1,	1);
			br16.registrar (1,	11,	"Cruzeiro", "Palmeiras",	2,	1);
			br16.registrar (1,	11,	"Corinthians", "SantaCruz",	2,	1);
			br16.registrar (1,	11,	"AméricaMG", "AtléticoMG",	0,	1);
			br16.registrar (1,	11,	"AtléticoPR", "Grêmio",	2,	0);
			br16.registrar (1,	11,	"Flamengo", "Fluminense",	1,	2);
			br16.registrar (1,	11,	"Internacional", "Botafogo",	2,	3);
			br16.registrar (1,	11,	"Santos", "SãoPaulo",	3,	0);
			br16.registrar (1,	11,	"Vitória", "PontePreta",	1,	1);
			br16.registrar (1,	11,	"Figueirense", "Coritiba",	0,	0);
			br16.registrar (1,	11,	"Sport", "Chapecoense",	5,	1);
			br16.registrar (1,	12,	"Flamengo", "Internacional",	1,	0);
			br16.registrar (1,	12,	"Grêmio", "Santos",	3,	2);
			br16.registrar (1,	12,	"Vitória", "Sport",	3,	2);
			br16.registrar (1,	12,	"Chapecoense", "Cruzeiro",	3,	2);
			br16.registrar (1,	12,	"Coritiba", "AtléticoPR",	1,	0);
			br16.registrar (1,	12,	"AméricaMG", "Corinthians",	0,	2);
			br16.registrar (1,	12,	"SãoPaulo", "Fluminense",	2,	1);
			br16.registrar (1,	12,	"Palmeiras", "Figueirense",	4,	0);
			br16.registrar (1,	12,	"SantaCruz", "PontePreta",	0,	3);
			br16.registrar (1,	12,	"AtléticoMG", "Botafogo",	5,	3);
			br16.registrar (1,	13,	"Fluminense", "Coritiba",	0,	0);
			br16.registrar (1,	13,	"AtléticoPR", "AméricaMG",	1,	0);
			br16.registrar (1,	13,	"Cruzeiro", "Vitória",	2,	2);
			br16.registrar (1,	13,	"Internacional", "Grêmio",	0,	1);
			br16.registrar (1,	13,	"Botafogo", "SantaCruz",	2,	1);
			br16.registrar (1,	13,	"Corinthians", "Flamengo",	4,	0);
			br16.registrar (1,	13,	"PontePreta", "SãoPaulo",	1,	0);
			br16.registrar (1,	13,	"Santos", "Chapecoense",	3,	0);
			br16.registrar (1,	13,	"Figueirense", "AtléticoMG",	1,	1);
			br16.registrar (1,	13,	"Sport", "Palmeiras",	1,	3);
			br16.registrar (1,	14,	"Chapecoense", "Corinthians",	0,	2);
			br16.registrar (1,	14,	"Coritiba", "Botafogo",	0,	0);
			br16.registrar (1,	14,	"PontePreta", "Sport",	2,	1);
			br16.registrar (1,	14,	"Flamengo", "AtléticoMG",	2,	0);
			br16.registrar (1,	14,	"Grêmio", "Figueirense",	2,	1);
			br16.registrar (1,	14,	"SantaCruz", "Internacional",	1,	0);
			br16.registrar (1,	14,	"SãoPaulo", "AméricaMG",	3,	0);
			br16.registrar (1,	14,	"Vitória", "Fluminense",	0,	0);
			br16.registrar (1,	14,	"Cruzeiro", "AtléticoPR",	0,	3);
			br16.registrar (1,	14,	"Palmeiras", "Santos",	1,	1);
			br16.registrar (1,	15,	"Botafogo", "Flamengo",	3,	3);
			br16.registrar (1,	15,	"Santos", "PontePreta",	3,	1);
			br16.registrar (1,	15,	"AméricaMG", "SantaCruz",	0,	3);
			br16.registrar (1,	15,	"AtléticoPR", "Vitória",	1,	1);
			br16.registrar (1,	15,	"Corinthians", "SãoPaulo",	1,	1);
			br16.registrar (1,	15,	"Figueirense", "Chapecoense",	1,	1);
			br16.registrar (1,	15,	"Fluminense", "Cruzeiro",	2,	0);
			br16.registrar (1,	15,	"Internacional", "Palmeiras",	0,	1);
			br16.registrar (1,	15,	"Sport", "Grêmio",	4,	2);
			br16.registrar (1,	15,	"AtléticoMG", "Coritiba",	2,	1);
			br16.registrar (1,	16,	"Corinthians", "Figueirense",	1,	1);
			br16.registrar (1,	16,	"SantaCruz", "Coritiba",	0,	1);
			br16.registrar (1,	16,	"Palmeiras", "AtléticoMG",	0,	1);
			br16.registrar (1,	16,	"PontePreta", "Internacional",	2,	2);
			br16.registrar (1,	16,	"AtléticoPR", "Fluminense",	1,	0);
			br16.registrar (1,	16,	"Chapecoense", "Botafogo",	2,	1);
			br16.registrar (1,	16,	"Cruzeiro", "Sport",	1,	2);
			br16.registrar (1,	16,	"Grêmio", "SãoPaulo",	1,	0);
			br16.registrar (1,	16,	"Vitória", "Santos",	2,	3);
			br16.registrar (1,	16,	"Flamengo", "AméricaMG",	2,	1);
			br16.registrar (1,	17,	"Figueirense", "Vitória",	1,	0);
			br16.registrar (1,	17,	"Sport", "AtléticoPR",	2,	0);
			br16.registrar (1,	17,	"AtléticoMG", "SantaCruz",	3,	0);
			br16.registrar (1,	17,	"Fluminense", "PontePreta",	3,	0);
			br16.registrar (1,	17,	"SãoPaulo", "Chapecoense",	2,	2);
			br16.registrar (1,	17,	"Coritiba", "Flamengo",	0,	2);
			br16.registrar (1,	17,	"Internacional", "Corinthians",	0,	1);
			br16.registrar (1,	17,	"Santos", "Cruzeiro",	2,	0);
			br16.registrar (1,	17,	"AméricaMG", "Grêmio",	0,	0);
			br16.registrar (1,	17,	"Botafogo", "Palmeiras",	3,	1);
			br16.registrar (1,	18,	"Sport", "AméricaMG",	1,	1);
			br16.registrar (1,	18,	"Vitória", "Coritiba",	3,	1);
			br16.registrar (1,	18,	"AtléticoPR", "Corinthians",	2,	0);
			br16.registrar (1,	18,	"Santos", "Flamengo",	0,	0);
			br16.registrar (1,	18,	"PontePreta", "Botafogo",	2,	0);
			br16.registrar (1,	18,	"Grêmio", "SantaCruz",	0,	0);
			br16.registrar (1,	18,	"SãoPaulo", "AtléticoMG",	1,	2);
			br16.registrar (1,	18,	"Cruzeiro", "Internacional",	4,	2);
			br16.registrar (1,	18,	"Chapecoense", "Palmeiras",	1,	1);
			br16.registrar (1,	18,	"Fluminense", "Figueirense",	0,	0);
			br16.registrar (1,	19,	"Flamengo", "AtléticoPR",	1,	0);
			br16.registrar (1,	19,	"AméricaMG", "Santos",	1,	0);
			br16.registrar (1,	19,	"Coritiba", "PontePreta",	3,	1);
			br16.registrar (1,	19,	"Palmeiras", "Vitória",	2,	1);
			br16.registrar (1,	19,	"Internacional", "Fluminense",	2,	2);
			br16.registrar (1,	19,	"SantaCruz", "SãoPaulo",	1,	2);
			br16.registrar (1,	19,	"Figueirense", "Sport",	1,	1);
			br16.registrar (1,	19,	"AtléticoMG", "Chapecoense",	3,	1);
			br16.registrar (1,	19,	"Corinthians", "Cruzeiro",	1,	1);
			br16.registrar (1,	19,	"Botafogo", "Grêmio",	0,	0);
			br16.registrar (2,	20,	"PontePreta", "Figueirense",	2,	0);
			br16.registrar (2,	20,	"Sport", "Flamengo",	1,	0);
			br16.registrar (2,	20,	"Fluminense", "AméricaMG",	1,	0);
			br16.registrar (2,	20,	"Grêmio", "Corinthians",	3,	0);
			br16.registrar (2,	20,	"Cruzeiro", "Coritiba",	2,	2);
			br16.registrar (2,	20,	"Santos", "AtléticoMG",	3,	0);
			br16.registrar (2,	20,	"Vitória", "SantaCruz",	2,	2);
			br16.registrar (2,	20,	"SãoPaulo", "Botafogo",	0,	1);
			br16.registrar (2,	20,	"AtléticoPR", "Palmeiras",	0,	1);
			br16.registrar (2,	20,	"Chapecoense", "Internacional",	1,	0);
			br16.registrar (2,	21,	"AméricaMG", "Chapecoense",	1,	2);
			br16.registrar (2,	21,	"Botafogo", "Sport",	3,	0);
			br16.registrar (2,	21,	"AtléticoMG", "AtléticoPR",	1,	0);
			br16.registrar (2,	21,	"Flamengo", "Grêmio",	2,	1);
			br16.registrar (2,	21,	"Internacional", "SãoPaulo",	1,	1);
			br16.registrar (2,	21,	"Palmeiras", "PontePreta",	2,	2);
			br16.registrar (2,	21,	"SantaCruz", "Fluminense",	0,	1);
			br16.registrar (2,	21,	"Coritiba", "Santos",	2,	1);
			br16.registrar (2,	21,	"Figueirense", "Cruzeiro",	1,	2);
			br16.registrar (2,	21,	"Corinthians", "Vitória",	2,	1);
//			br16.registrar (2,	22,	"PontePreta", "Corinthians",	0,	0);
//			br16.registrar (2,	22,	"Cruzeiro", "SantaCruz",	0,	0);
//			br16.registrar (2,	22,	"Santos", "Figueirense",	0,	0);
//			br16.registrar (2,	22,	"Chapecoense", "Flamengo",	0,	0);
//			br16.registrar (2,	22,	"Fluminense", "Palmeiras",	0,	0);
//			br16.registrar (2,	22,	"Grêmio", "AtléticoMG",	0,	0);
//			br16.registrar (2,	22,	"SãoPaulo", "Coritiba",	0,	0);
//			br16.registrar (2,	22,	"Sport", "Internacional",	0,	0);
//			br16.registrar (2,	22,	"Vitória", "AméricaMG",	0,	0);
//			br16.registrar (2,	22,	"AtléticoPR", "Botafogo",	0,	0);
//			br16.registrar (2,	23,	"AtléticoMG", "Vitória",	0,	0);
//			br16.registrar (2,	23,	"Botafogo", "Fluminense",	0,	0);
//			br16.registrar (2,	23,	"Palmeiras", "SãoPaulo",	0,	0);
//			br16.registrar (2,	23,	"Internacional", "Santos",	0,	0);
//			br16.registrar (2,	23,	"AméricaMG", "Cruzeiro",	0,	0);
//			br16.registrar (2,	23,	"Coritiba", "Grêmio",	0,	0);
//			br16.registrar (2,	23,	"Figueirense", "AtléticoPR",	0,	0);
//			br16.registrar (2,	23,	"SantaCruz", "Chapecoense",	0,	0);
//			br16.registrar (2,	23,	"Flamengo", "PontePreta",	0,	0);
//			br16.registrar (2,	23,	"Corinthians", "Sport",	0,	0);
//			br16.registrar (2,	24,	"Cruzeiro", "Botafogo",	0,	0);
//			br16.registrar (2,	24,	"Vitória", "Flamengo",	0,	0);
//			br16.registrar (2,	24,	"Santos", "Corinthians",	0,	0);
//			br16.registrar (2,	24,	"Grêmio", "Palmeiras",	0,	0);
//			br16.registrar (2,	24,	"Fluminense", "AtléticoMG",	0,	0);
//			br16.registrar (2,	24,	"AtléticoPR", "Internacional",	0,	0);
//			br16.registrar (2,	24,	"Chapecoense", "Coritiba",	0,	0);
//			br16.registrar (2,	24,	"SãoPaulo", "Figueirense",	0,	0);
//			br16.registrar (2,	24,	"PontePreta", "AméricaMG",	0,	0);
//			br16.registrar (2,	24,	"Sport", "SantaCruz",	0,	0);
//			br16.registrar (2,	25,	"Internacional", "Vitória",	0,	0);
//			br16.registrar (2,	25,	"Palmeiras", "Flamengo",	0,	0);
//			br16.registrar (2,	25,	"Coritiba", "Corinthians",	0,	0);
//			br16.registrar (2,	25,	"Botafogo", "Santos",	0,	0);
//			br16.registrar (2,	25,	"SãoPaulo", "Cruzeiro",	0,	0);
//			br16.registrar (2,	25,	"PontePreta", "Grêmio",	0,	0);
//			br16.registrar (2,	25,	"SantaCruz", "AtléticoPR",	0,	0);
//			br16.registrar (2,	25,	"Fluminense", "Chapecoense",	0,	0);
//			br16.registrar (2,	25,	"Figueirense", "AméricaMG",	0,	0);
//			br16.registrar (2,	25,	"AtléticoMG", "Sport",	0,	0);
//			br16.registrar (2,	26,	"Vitória", "Botafogo",	0,	0);
//			br16.registrar (2,	26,	"Grêmio", "Fluminense",	0,	0);
//			br16.registrar (2,	26,	"AtléticoPR", "SãoPaulo",	0,	0);
//			br16.registrar (2,	26,	"Corinthians", "Palmeiras",	0,	0);
//			br16.registrar (2,	26,	"Cruzeiro", "AtléticoMG",	0,	0);
//			br16.registrar (2,	26,	"AméricaMG", "Internacional",	0,	0);
//			br16.registrar (2,	26,	"Sport", "Coritiba",	0,	0);
//			br16.registrar (2,	26,	"Flamengo", "Figueirense",	0,	0);
//			br16.registrar (2,	26,	"Chapecoense", "PontePreta",	0,	0);
//			br16.registrar (2,	26,	"Santos", "SantaCruz",	0,	0);
//			br16.registrar (2,	27,	"AméricaMG", "Botafogo",	0,	0);
//			br16.registrar (2,	27,	"Corinthians", "Fluminense",	0,	0);
//			br16.registrar (2,	27,	"Vitória", "SãoPaulo",	0,	0);
//			br16.registrar (2,	27,	"Sport", "Santos",	0,	0);
//			br16.registrar (2,	27,	"Flamengo", "Cruzeiro",	0,	0);
//			br16.registrar (2,	27,	"AtléticoMG", "Internacional",	0,	0);
//			br16.registrar (2,	27,	"Palmeiras", "Coritiba",	0,	0);
//			br16.registrar (2,	27,	"Grêmio", "Chapecoense",	0,	0);
//			br16.registrar (2,	27,	"AtléticoPR", "PontePreta",	0,	0);
//			br16.registrar (2,	27,	"Figueirense", "SantaCruz",	0,	0);
//			br16.registrar (2,	28,	"Chapecoense", "Vitória",	0,	0);
//			br16.registrar (2,	28,	"SãoPaulo", "Flamengo",	0,	0);
//			br16.registrar (2,	28,	"Botafogo", "Corinthians",	0,	0);
//			br16.registrar (2,	28,	"SantaCruz", "Palmeiras",	0,	0);
//			br16.registrar (2,	28,	"PontePreta", "AtléticoMG",	0,	0);
//			br16.registrar (2,	28,	"Cruzeiro", "Grêmio",	0,	0);
//			br16.registrar (2,	28,	"Santos", "AtléticoPR",	0,	0);
//			br16.registrar (2,	28,	"Internacional", "Figueirense",	0,	0);
//			br16.registrar (2,	28,	"Coritiba", "AméricaMG",	0,	0);
//			br16.registrar (2,	28,	"Fluminense", "Sport",	0,	0);
//			br16.registrar (2,	29,	"Figueirense", "Botafogo",	0,	0);
//			br16.registrar (2,	29,	"Santos", "Fluminense",	0,	0);
//			br16.registrar (2,	29,	"Sport", "SãoPaulo",	0,	0);
//			br16.registrar (2,	29,	"AméricaMG", "Palmeiras",	0,	0);
//			br16.registrar (2,	29,	"Corinthians", "AtléticoMG",	0,	0);
//			br16.registrar (2,	29,	"Vitória", "Grêmio",	0,	0);
//			br16.registrar (2,	29,	"Internacional", "Coritiba",	0,	0);
//			br16.registrar (2,	29,	"AtléticoPR", "Chapecoense",	0,	0);
//			br16.registrar (2,	29,	"Cruzeiro", "PontePreta",	0,	0);
//			br16.registrar (2,	29,	"Flamengo", "SantaCruz",	0,	0);
//			br16.registrar (2,	30,	"PontePreta", "Vitória",	0,	0);
//			br16.registrar (2,	30,	"Fluminense", "Flamengo",	0,	0);
//			br16.registrar (2,	30,	"SantaCruz", "Corinthians",	0,	0);
//			br16.registrar (2,	30,	"SãoPaulo", "Santos",	0,	0);
//			br16.registrar (2,	30,	"Palmeiras", "Cruzeiro",	0,	0);
//			br16.registrar (2,	30,	"Botafogo", "Internacional",	0,	0);
//			br16.registrar (2,	30,	"Grêmio", "AtléticoPR",	0,	0);
//			br16.registrar (2,	30,	"Coritiba", "Figueirense",	0,	0);
//			br16.registrar (2,	30,	"AtléticoMG", "AméricaMG",	0,	0);
//			br16.registrar (2,	30,	"Chapecoense", "Sport",	0,	0);
//			br16.registrar (2,	31,	"Sport", "Vitória",	0,	0);
//			br16.registrar (2,	31,	"Internacional", "Flamengo",	0,	0);
//			br16.registrar (2,	31,	"Fluminense", "SãoPaulo",	0,	0);
//			br16.registrar (2,	31,	"Figueirense", "Palmeiras",	0,	0);
//			br16.registrar (2,	31,	"Botafogo", "AtléticoMG",	0,	0);
//			br16.registrar (2,	31,	"Santos", "Grêmio",	0,	0);
//			br16.registrar (2,	31,	"AtléticoPR", "Coritiba",	0,	0);
//			br16.registrar (2,	31,	"Cruzeiro", "Chapecoense",	0,	0);
//			br16.registrar (2,	31,	"Corinthians", "AméricaMG",	0,	0);
//			br16.registrar (2,	31,	"PontePreta", "SantaCruz",	0,	0);
//			br16.registrar (2,	32,	"SantaCruz", "Botafogo",	0,	0);
//			br16.registrar (2,	32,	"Coritiba", "Fluminense",	0,	0);
//			br16.registrar (2,	32,	"Flamengo", "Corinthians",	0,	0);
//			br16.registrar (2,	32,	"Chapecoense", "Santos",	0,	0);
//			br16.registrar (2,	32,	"Vitória", "Cruzeiro",	0,	0);
//			br16.registrar (2,	32,	"Grêmio", "Internacional",	0,	0);
//			br16.registrar (2,	32,	"AméricaMG", "AtléticoPR",	0,	0);
//			br16.registrar (2,	32,	"AtléticoMG", "Figueirense",	0,	0);
//			br16.registrar (2,	32,	"SãoPaulo", "PontePreta",	0,	0);
//			br16.registrar (2,	32,	"Palmeiras", "Sport",	0,	0);
//			br16.registrar (2,	33,	"Fluminense", "Vitória",	0,	0);
//			br16.registrar (2,	33,	"AtléticoMG", "Flamengo",	0,	0);
//			br16.registrar (2,	33,	"AméricaMG", "SãoPaulo",	0,	0);
//			br16.registrar (2,	33,	"Santos", "Palmeiras",	0,	0);
//			br16.registrar (2,	33,	"AtléticoPR", "Cruzeiro",	0,	0);
//			br16.registrar (2,	33,	"Figueirense", "Grêmio",	0,	0);
//			br16.registrar (2,	33,	"Botafogo", "Coritiba",	0,	0);
//			br16.registrar (2,	33,	"Corinthians", "Chapecoense",	0,	0);
//			br16.registrar (2,	33,	"Sport", "PontePreta",	0,	0);
//			br16.registrar (2,	33,	"Internacional", "SantaCruz",	0,	0);
//			br16.registrar (2,	34,	"Flamengo", "Botafogo",	0,	0);
//			br16.registrar (2,	34,	"Cruzeiro", "Fluminense",	0,	0);
//			br16.registrar (2,	34,	"SãoPaulo", "Corinthians",	0,	0);
//			br16.registrar (2,	34,	"PontePreta", "Santos",	0,	0);
//			br16.registrar (2,	34,	"Coritiba", "AtléticoMG",	0,	0);
//			br16.registrar (2,	34,	"Palmeiras", "Internacional",	0,	0);
//			br16.registrar (2,	34,	"Vitória", "AtléticoPR",	0,	0);
//			br16.registrar (2,	34,	"Chapecoense", "Figueirense",	0,	0);
//			br16.registrar (2,	34,	"SantaCruz", "AméricaMG",	0,	0);
//			br16.registrar (2,	34,	"Grêmio", "Sport",	0,	0);
//			br16.registrar (2,	35,	"Santos", "Vitória",	0,	0);
//			br16.registrar (2,	35,	"AméricaMG", "Flamengo",	0,	0);
//			br16.registrar (2,	35,	"Figueirense", "Corinthians",	0,	0);
//			br16.registrar (2,	35,	"AtléticoMG", "Palmeiras",	0,	0);
//			br16.registrar (2,	35,	"Sport", "Cruzeiro",	0,	0);
//			br16.registrar (2,	35,	"SãoPaulo", "Grêmio",	0,	0);
//			br16.registrar (2,	35,	"Fluminense", "AtléticoPR",	0,	0);
//			br16.registrar (2,	35,	"Botafogo", "Chapecoense",	0,	0);
//			br16.registrar (2,	35,	"Internacional", "PontePreta",	0,	0);
//			br16.registrar (2,	35,	"Coritiba", "SantaCruz",	0,	0);
//			br16.registrar (2,	36,	"Palmeiras", "Botafogo",	0,	0);
//			br16.registrar (2,	36,	"PontePreta", "Fluminense",	0,	0);
//			br16.registrar (2,	36,	"Chapecoense", "SãoPaulo",	0,	0);
//			br16.registrar (2,	36,	"Cruzeiro", "Santos",	0,	0);
//			br16.registrar (2,	36,	"SantaCruz", "AtléticoMG",	0,	0);
//			br16.registrar (2,	36,	"Corinthians", "Internacional",	0,	0);
//			br16.registrar (2,	36,	"Flamengo", "Coritiba",	0,	0);
//			br16.registrar (2,	36,	"Vitória", "Figueirense",	0,	0);
//			br16.registrar (2,	36,	"Grêmio", "AméricaMG",	0,	0);
//			br16.registrar (2,	36,	"AtléticoPR", "Sport",	0,	0);
//			br16.registrar (2,	37,	"Coritiba", "Vitória",	0,	0);
//			br16.registrar (2,	37,	"Figueirense", "Fluminense",	0,	0);
//			br16.registrar (2,	37,	"AtléticoMG", "SãoPaulo",	0,	0);
//			br16.registrar (2,	37,	"Flamengo", "Santos",	0,	0);
//			br16.registrar (2,	37,	"Internacional", "Cruzeiro",	0,	0);
//			br16.registrar (2,	37,	"SantaCruz", "Grêmio",	0,	0);
//			br16.registrar (2,	37,	"Corinthians", "AtléticoPR",	0,	0);
//			br16.registrar (2,	37,	"Palmeiras", "Chapecoense",	0,	0);
//			br16.registrar (2,	37,	"Botafogo", "PontePreta",	0,	0);
//			br16.registrar (2,	37,	"AméricaMG", "Sport",	0,	0);
//			br16.registrar (2,	38,	"Grêmio", "Botafogo",	0,	0);
//			br16.registrar (2,	38,	"AtléticoPR", "Flamengo",	0,	0);
//			br16.registrar (2,	38,	"Cruzeiro", "Corinthians",	0,	0);
//			br16.registrar (2,	38,	"Vitória", "Palmeiras",	0,	0);
//			br16.registrar (2,	38,	"Chapecoense", "AtléticoMG",	0,	0);
//			br16.registrar (2,	38,	"Fluminense", "Internacional",	0,	0);
//			br16.registrar (2,	38,	"PontePreta", "Coritiba",	0,	0);
//			br16.registrar (2,	38,	"Sport", "Figueirense",	0,	0);
//			br16.registrar (2,	38,	"Santos", "AméricaMG",	0,	0);
//			br16.registrar (2,	38,	"SãoPaulo", "SantaCruz",	0,	0);
			return br16;
		}
	}
}
