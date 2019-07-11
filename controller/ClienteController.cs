using ProjetoSebo.bean;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;

namespace ProjetoSebo.controller
{
    public class ClienteController : BaseParaController
    {
        public const int CAMPO_NOME = 1;
        public const int CAMPO_DATA_NASCIMENTO = 2;
        public const int CAMPO_CPF = 3;
        public const int CAMPO_SEXO = 4;
        public const int CAMPO_TELEFONE = 5;
        public const int CAMPO_EMAIL = 6;

        public ClienteValidator Validator { get; }

        public ClienteController()
        {
            this.Validator = new ClienteValidator();
        }

        public ResultadoOperacao Gravar(Cliente cliente)
        {
            ResultadoOperacao resultado = ConsistirDados(cliente);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            Context.Clientes.Add(new ClienteModel(cliente));
            Context.SaveChanges();

            return new ResultadoSucesso("Cliente cadastrado com sucesso.");
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaBean dados)
        {
            Cliente cliente = dados as Cliente;

            ResultadoOperacao resultado = this.Validator.ConsistirNome(cliente.Nome);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_NOME;
                return resultado;
            }

            resultado = this.Validator.ConsistirDataNascimento(cliente.DataNascimento);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_DATA_NASCIMENTO;
                return resultado;
            }

            resultado = this.Validator.ConsistirCpf(cliente.Cpf);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_CPF;
                return resultado;
            }

            resultado = this.Validator.ConsistirSexo(cliente.Sexo);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_SEXO;
                return resultado;
            }

            return new ResultadoSucesso();
        }
    }
}
