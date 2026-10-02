using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz_sua_area_de_ti
{
    public enum AreaTI
    {
        Desenvolvimento,
        DadosIA,
        Ciberseguranca,
        UXUI,
        Infraestrutura,
        GestaoTI
    }

    internal class Quiz
    {
        public static char?[] Respostas = new char?[7];

        public static Dictionary<AreaTI, int> Pontos =
            new Dictionary<AreaTI, int>();

        public static Dictionary<AreaTI, int> RespostasFortes =
            new Dictionary<AreaTI, int>();

        static Quiz()
        {
            ResetarPontuacao();
        }

        private static void ResetarPontuacao()
        {
            Pontos.Clear();
            RespostasFortes.Clear();

            foreach (AreaTI area in Enum.GetValues(typeof(AreaTI)))
            {
                Pontos[area] = 0;
                RespostasFortes[area] = 0;
            }
        }

        public static void SalvarResposta(int pergunta, char alternativa)
        {
            Respostas[pergunta] = alternativa;

            Recalcular();
        }

        private static void Adicionar(AreaTI principal, AreaTI secundaria)
        {
            // área principal recebe 3
            Pontos[principal] += 3;

            // área secundária recebe 1
            Pontos[secundaria] += 1;

            // usado como critério de desempate
            RespostasFortes[principal]++;
        }

        private static void Recalcular()
        {
            ResetarPontuacao();

            for (int pergunta = 1; pergunta <= 6; pergunta++)
            {
                if (Respostas[pergunta].HasValue)
                {
                    AplicarPontuacao(
                        pergunta,
                        Respostas[pergunta].Value
                    );
                }
            }
        }

        private static void AplicarPontuacao(int pergunta, char resposta)
        {
            switch (pergunta)
            {
                // PERGUNTA 1
                case 1:

                    switch (resposta)
                    {
                        case 'A':
                            Adicionar(
                                AreaTI.GestaoTI,
                                AreaTI.Infraestrutura
                            );
                            break;

                        case 'B':
                            Adicionar(
                                AreaTI.Desenvolvimento,
                                AreaTI.UXUI
                            );
                            break;

                        case 'C':
                            Adicionar(
                                AreaTI.Ciberseguranca,
                                AreaTI.DadosIA
                            );
                            break;

                        case 'D':
                            Adicionar(
                                AreaTI.UXUI,
                                AreaTI.GestaoTI
                            );
                            break;
                    }

                    break;

                // PERGUNTA 2
                case 2:

                    switch (resposta)
                    {
                        case 'A':
                            Adicionar(
                                AreaTI.Infraestrutura,
                                AreaTI.GestaoTI
                            );
                            break;

                        case 'B':
                            Adicionar(
                                AreaTI.DadosIA,
                                AreaTI.UXUI
                            );
                            break;

                        case 'C':
                            Adicionar(
                                AreaTI.Desenvolvimento,
                                AreaTI.Ciberseguranca
                            );
                            break;

                        case 'D':
                            Adicionar(
                                AreaTI.Ciberseguranca,
                                AreaTI.Desenvolvimento
                            );
                            break;
                    }

                    break;

                // PERGUNTA 3
                case 3:

                    switch (resposta)
                    {
                        case 'A':
                            Adicionar(
                                AreaTI.Ciberseguranca,
                                AreaTI.Desenvolvimento
                            );
                            break;

                        case 'B':
                            Adicionar(
                                AreaTI.UXUI,
                                AreaTI.DadosIA
                            );
                            break;

                        case 'C':
                            Adicionar(
                                AreaTI.GestaoTI,
                                AreaTI.Infraestrutura
                            );
                            break;

                        case 'D':
                            Adicionar(
                                AreaTI.DadosIA,
                                AreaTI.UXUI
                            );
                            break;
                    }

                    break;

                // PERGUNTA 4
                case 4:

                    switch (resposta)
                    {
                        case 'A':
                            Adicionar(
                                AreaTI.UXUI,
                                AreaTI.GestaoTI
                            );
                            break;

                        case 'B':
                            Adicionar(
                                AreaTI.GestaoTI,
                                AreaTI.DadosIA
                            );
                            break;

                        case 'C':
                            Adicionar(
                                AreaTI.Desenvolvimento,
                                AreaTI.UXUI
                            );
                            break;

                        case 'D':
                            Adicionar(
                                AreaTI.Infraestrutura,
                                AreaTI.Ciberseguranca
                            );
                            break;
                    }

                    break;

                // PERGUNTA 5
                case 5:

                    switch (resposta)
                    {
                        case 'A':
                            Adicionar(
                                AreaTI.Desenvolvimento,
                                AreaTI.Infraestrutura
                            );
                            break;

                        case 'B':
                            Adicionar(
                                AreaTI.Infraestrutura,
                                AreaTI.Desenvolvimento
                            );
                            break;

                        case 'C':
                            Adicionar(
                                AreaTI.DadosIA,
                                AreaTI.Ciberseguranca
                            );
                            break;

                        case 'D':
                            Adicionar(
                                AreaTI.GestaoTI,
                                AreaTI.DadosIA
                            );
                            break;
                    }

                    break;

                // PERGUNTA 6
                case 6:

                    switch (resposta)
                    {
                        case 'A':
                            Adicionar(
                                AreaTI.Infraestrutura,
                                AreaTI.GestaoTI
                            );
                            break;

                        case 'B':
                            Adicionar(
                                AreaTI.UXUI,
                                AreaTI.Desenvolvimento
                            );
                            break;

                        case 'C':
                            Adicionar(
                                AreaTI.DadosIA,
                                AreaTI.Ciberseguranca
                            );
                            break;

                        case 'D':
                            Adicionar(
                                AreaTI.Ciberseguranca,
                                AreaTI.Infraestrutura
                            );
                            break;
                    }

                    break;
            }
        }

        public static List<KeyValuePair<AreaTI, int>> ObterRanking()
        {
            return Pontos
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => RespostasFortes[x.Key])
                .ToList();
        }

        public static string NomeArea(AreaTI area)
        {
            switch (area)
            {
                case AreaTI.Desenvolvimento:
                    return "Desenvolvimento de Software";

                case AreaTI.DadosIA:
                    return "Dados e Inteligência Artificial";

                case AreaTI.Ciberseguranca:
                    return "Cibersegurança";

                case AreaTI.UXUI:
                    return "UX/UI e Produto Digital";

                case AreaTI.Infraestrutura:
                    return "Infraestrutura e Cloud";

                case AreaTI.GestaoTI:
                    return "Gestão de TI e Negócios";

                default:
                    return "";
            }
        }

        public static void Reiniciar()
        {
            Respostas = new char?[7];
            ResetarPontuacao();
        }
    }
}
