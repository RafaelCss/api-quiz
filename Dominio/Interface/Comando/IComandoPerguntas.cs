﻿using Dominio.Respostas;
using MongoDB.Bson;

namespace Dominio.Interface.Comando
{
	public interface IComandoPerguntas
	{
		Task<ApiResponse> CadastrarPergunta(string titulo,string assunto,string autor);
		Task<ApiResponse> BuscarPergunta(string campo,string valor);
		Task<ApiResponse> BuscarPerguntas(string campo,string valor);
		Task<ApiResponse> EditarPergunta(string id,string titulo,string assunto);
		Task<ApiResponse> DeletarPergunta(string guid);
	}
}
