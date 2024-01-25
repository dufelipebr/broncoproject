﻿using portalinvestimento.virtualtilab.com.Entity;
using portalinvestimento.virtualtilab.com.Interfaces;

namespace portalinvestimento.virtualtilab.com.Services
{
    public class InvestimentoService : IInvestimentoService
    {
        public string Create(Investimento obj)
        {
            if (obj.Codigo == null || obj.Codigo.Length > 50)
                return "O codigo precisa ser preenchido e deve ter no maximo 50 caracteres";

            if (obj.Nome == null || obj.Nome.Length > 100)
                return "O nome não pode ser maior que 100 caracteres";


            if (obj.Descricao == null || obj.Descricao.Length > 500)
                return "Descrição do Fundo não pode ser maior que 500 caracteres";

            if (obj.TaxaADM <= 0 && obj.TaxaADM > 10)
                return "A Taxa Administrativa deve ser maior que 0 e menor que 10";

            if (obj.TipoInvestimento == 0)
                return "A Tipo de Investimento não foi informado";

            if (obj.AporteMinimo == 0)
                return "Aporte minimo deve ser informado";

            return "Investimento ok!";
        }


        public Aplicacao CriarAplicacao(Usuario usuario, Investimento inv, CadastrarAplicacaoDTO dto)
        {
            decimal saldoCarteira = usuario.Saldo_Carteira;

            if (dto.Valor_Aplicacao > saldoCarteira || saldoCarteira ==0)
                throw new ArgumentException("valor da aplicação não poder ser maior que saldo da carteira.");

            Aplicacao apl = new Aplicacao();
            apl.Data_Aplicacao = DateTime.Now;
            apl.Valor_Aplicacao = dto.Valor_Aplicacao;
            apl.Usuario = usuario;
            apl.Investimento = inv;
            apl.Rentabilidade = 0;

            return apl;
        }
    }
}
