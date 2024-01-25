﻿namespace portalinvestimento.virtualtilab.com.Entity
{
    public enum TipoOperacao_Aplicacao { Resgate, Aplicar }
    public class CadastrarAplicacaoDTO
    {
        public int Id_Usuario { get; set; }
        public int Id_Investimento { get; set; }
        public decimal Valor_Aplicacao { get; set; }
        // public TipoOperacao_Aplicacao Tipo { get; set; }
    }

    public class ResgatarAplicacaoDTO
    {
        public int Id_Usuario { get; set; }
        public int Id_Investimento { get; set; }
        public decimal Valor_Resgate { get; set; }
        // public TipoOperacao_Aplicacao Tipo { get; set; }
    }

}
