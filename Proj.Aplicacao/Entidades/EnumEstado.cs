using System.Collections;
using System.Collections.Generic;

namespace Proj.Aplicacao.Entidades
{
    public class EstadosBrasil
    {
        public enum EnumEstadoBR
        {
            AC, // Acre
            AL, // Alagoas
            AP, // Amapá
            AM, // Amazonas
            BA, // Bahia
            CE, // Ceará
            DF, // Distrito Federal
            ES, // Espírito Santo
            GO, // Goiás
            MA, // Maranhão
            MT, // Mato Grosso
            MS, // Mato Grosso do Sul
            MG, // Minas Gerais
            PA, // Pará
            PB, // Paraíba
            PR, // Paraná
            PE, // Pernambuco
            PI, // Piauí
            RR, // Roraima
            RO, // Rondônia
            RJ, // Rio de Janeiro
            RN, // Rio Grande do Norte
            RS, // Rio Grande do Sul
            SC, // Santa Catarina
            SP, // São Paulo
            SE, // Sergipe
            TO // Tocantins
        }

        public static string GetEstadoExt(EnumEstadoBR estado)
        {
            string[] estados =
            {
                "Acre", "Alagoas", "Amapá", "Amazonas",
                "Bahia", "Ceará", "Distrito Federal", "Espírito Santo",
                "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná",
                "Pernambuco", "Piauí", "Roraima", "Rondônia",
                "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Santa Catarina",
                "São Paulo", "Sergipe", "Tocantins"
            };
            
            return estados[(int) estado];
        }
    }
}