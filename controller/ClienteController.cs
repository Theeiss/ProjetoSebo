using ProjetoSebo.model;
using System;

namespace ProjetoSebo.controller
{
    public class ClienteController : BaseParaController
    {
        public ResultadoOperacao Gravar(Cliente cliente)
        {
            ResultadoOperacao resultado = ConsistirDados(cliente);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            Context.Clientes.Add(cliente);
            Context.SaveChanges();

            return new ResultadoSucesso("Usuário cadastrado com sucesso.");
        }

        public ResultadoOperacao ConsistirDados(Cliente cliente)
        {
            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirDataNascimento(DateTime dataNascimento)
        {
            if(dataNascimento == DateTime.MinValue)
                return new ResultadoAviso("A data de nascimento deve ser informada.");

            if (dataNascimento > DateTime.Now)
                return new ResultadoAviso("A data de nascimento não pode ser uma data futura.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirNome(string nome)
        {
            if (nome.Length == 0)
            {
                return new ResultadoAviso("Nome do cliente deve ser informado.");
            }

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirSexo(Cliente.TipoSexo sexo)
        {
            if(sexo == Cliente.TipoSexo.Nenhum)
                return new ResultadoAviso("Sexo deve ser informado.");

            return new ResultadoSucesso();
        }

        public ResultadoOperacao ConsistirCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace(",", "").Replace("-", "").Trim();

            if (cpf.Length == 0)
                return new ResultadoAviso("CPF do cliente deve ser informado.");
 
            string msg = "O CPF informado é inválido.";
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;

            int soma;
            int resto;

            if (cpf.Length != 11)
                return new ResultadoAviso(msg);

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf += digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            if (!cpf.EndsWith(digito))
                return new ResultadoAviso(msg);

            return new ResultadoSucesso();
        }
    }
}
