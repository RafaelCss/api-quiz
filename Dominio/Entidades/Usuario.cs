﻿using Flunt.Validations;


namespace Dominio.Entidades
{
	public class Usuario :Entidade
	{
		public Usuario() { }

		public Usuario(string nome,string email,string senha) 
		{
			ValidarNome(nome);
			ValidarEmail(email);
			ValidarSenha(senha);
		}

		public string Nome { get; private set; } = string.Empty;
		public string Email { get; private set; } = string.Empty;
		public string Senha { get; private set; } = string.Empty;

		public Usuario ValidarNome(string nome)
		{
			Nome = nome;
			AddNotifications(new Contract<Usuario>()
				.Requires()
				.IsNotNullOrWhiteSpace(Nome,"Nome","Este campo não pode ser vazio")
				);

			return this;
		}

		public Usuario ValidarEmail(string email)
		{
			Email = email;
			AddNotifications(new Contract<Usuario>()
				.Requires()
				.IsNotNullOrWhiteSpace(Email,"Email","Este campo não pode ser vazio")
				.IsEmailOrEmpty(Email,"Email","Este não éum email valido")
				);

			return this;
		}

		public Usuario ValidarSenha(string senha)
		{
			Senha = senha;
			AddNotifications(new Contract<Usuario>()
				.Requires()
				.IsNotNullOrWhiteSpace(Senha,"Senha","Este campo não pode ser vazio")
			);
			return this;
		}

	}
}
