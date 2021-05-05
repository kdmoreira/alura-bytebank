using ByteBank.Modelos.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
