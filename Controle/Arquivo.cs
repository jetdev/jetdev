//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JetDev.Control
{
    using System;
    using System.Collections.Generic;
    
    public partial class Arquivo
    {
        public System.Guid Codigo { get; set; }
        public string NomeArquivo { get; set; }
        public string Extensao { get; set; }
        public string Tamanho { get; set; }
        public bool Excluido { get; set; }
    
        public virtual ItemVenda Itens { get; set; }
    }
}
