using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeLetreiros
{
    internal static class Atualizacoes
    {

        private static string EfetuarRequisicaoServidor()
        {

            try
            {
                WebClient wc = new WebClient();
                return wc.DownloadString("http://cristianoprogramador.com/Letreiros.txt");
            }
            catch
            {
                return "Erro";
            }
            
        }

        private static string obterVersao(string requisicao)
        {
            String[] linha = requisicao.Split(';');

            return linha[0];
        }

        public static string ObterLinkUltimaVersao()
        {
            string requisicao = EfetuarRequisicaoServidor();

            String[] linha = requisicao.Split(';');

            return linha[1];
        }

        internal static bool VerificarAtualizacao()
        {
            string informacoesVersao = EfetuarRequisicaoServidor();

            if ( informacoesVersao != "Erro")
            {
                string versaoServidor = obterVersao(informacoesVersao);

                if (versaoServidor != Application.ProductVersion)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
