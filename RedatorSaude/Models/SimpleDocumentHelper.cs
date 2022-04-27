using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedatorSaude.Models
{
    public class SimpleDocumentHelper
    {
        public static string GetFilePathByType(string tipo) 
        {
            switch (tipo) 
            {
                case "RESULTADO":
                    return Map.document_resutaldo;
                case "PAGAMENTO CONDENACAO":
                    return Map.document_pagamento_condenacao;
                case "ESPECIFICAO SEM PROVAS":
                    return Map.document_especificao_sem_provas;
                case "JUNTADA CUSTAS FINAIS":
                    return Map.document_juntada_custas_finais;
                case "JUNTADA CARTAS SUBS":
                    return Map.document_juntada_cartas_subs;
                case "PROVA PERICIA MEDICA":
                    return Map.document_especificacao_provas_pericia_medica;
                case "PETICAO 1018":
                    return Map.document_peticao_1018;
                case "JUNTADA HONORARIOS":
                    return Map.document_juntada_honorarios;
                case "EMBARGOS DECLARACAO":
                    return Map.document_embargos_declaracao;
            }
            return "";
        }

        public static string GetQuali(string tipo)
        {
            switch (tipo)
            {
                case "AMIL ASSISTÊNCIA MÉDICA INTERNACIONAL S.A.":
                    return "AMIL ASSISTÊNCIA MÉDICA INTERNACIONAL S.A., devidamente inscrita no CNPJ/MF sob o nº 29.309.127/0001-79, com sede situada na Rua Arquiteto Olavo Redig de Campos, nº 105, 6º ao 21º andares, Torre B, Empreendimento EZ Towers, Vila Francisco, Cidade e Estado de São Paulo, CEP nº 07711-904  TEL: 81 3128-6150";
                case "AMICO SAÚDE LTDA.":
                    return "AMICO SAÚDE LTDA., devidamente inscrita no CNPJ/MF sob o nº 51.722.957/0001-82, com sede situada na Rua Azevedo Macedo n° 132, parte, Vila Mariana, Cidade e Estado de São Paulo, CEP 040.13-060.";
                case "SANTA HELENA ASSISTÊNCIA MÉDICA S.A":
                    return "SANTA HELENA ASSISTÊNCIA MÉDICA S.A, devidamente inscrita no CNPJ sob o nº 43.293.604/0001-86, com sede situada na Rua Bering, 114, jardim do mar, São Bernardo do Campo/SP, CEP 09.750-510.";
                case "HOSPITAL ANA COSTA S.A.":
                    return "HOSPITAL ANA COSTA S.A., sociedade anônima, inscrita no CNPJ/MF sob o nº 68.253.731/0001-82, com sede em Rua Pedro Américo, nº 60, Campo Grande, Santos/SP, CEP 11075-400";
                case "PLANO DE SAÚDE ANA COSTA LTDA.":
                    return "PLANO DE SAÚDE ANA COSTA LTDA., devidamente inscrita no CNPJ/MF sob o nº 02.864.364/0001-45, com sede situada na Avenida Ana Costa, nº 468, Gonzaga, Santos/SP, CEP 11060-000";
                case "SEISA SERVIÇOS INTEGRADOS DE SAÚDE LTDA.":
                    return "SEISA SERVIÇOS INTEGRADOS DE SAÚDE LTDA., (NEXT SAÚDE)  devidamente inscrita no CNPJ/MF sob o nº 44.269.579/0001-68, com sede situada na Avenida Salgado Filho, nº 517, Pavimento Superior, Centro, Guarulhos/SP, CEP 07115-000";
                case "SOBAM CENTRO MÉDICO HOSPITALAR LTDA.":
                    return "SOBAM CENTRO MÉDICO HOSPITALAR LTDA., devidamente inscrita no CNPJ Nº 50.739.135/0001-41, sediada na Rua Vinte e Três de maio, nº 790, 1º andar, Bairro Vianelo, Jundiaí, CEP 13207-070";
                case "HOSPITAL SANTA HELENA S.A.":
                    return "HOSPITAL SANTA HELENA S.A., devidamente inscrita no CNPJ Nº 06.033.403/0001-13, sediada na Rua Manoel Vaz, 59, Vila Alzira, CEP 09015-410, Santo André/SP";
                case "AMIL SAÚDE LTDA (MEDIAL SAÚDE)":
                    return "AMIL SAÚDE LTDA (MEDIAL SAÚDE), com sede na Av. Paulista, n° 1.842, 18° andar (parte), Bela Vista, Cidade e Estado de São Paulo, CEP: 01.310-200, inscrita no CNPJ/MF sob o n° 43.358.647/0001-00.";
                case "HOSPITAL ALVORADA TAGUATINGA S/A":
                    return "HOSPITAL ALVORADA TAGUATINGA S/A, devidamente inscrita no CNPJ/MF sob o nº 08.100.676/0001-69, com sede situada na Rua Arquiteto Olavo Redig de Campos, nº 105, 8º andar, Torre B, Empreendimento EZ Towers, Vila Francisco, Cidade e Estado de São Paulo, CEP nº 04711-904";
                case "ESHO EMPRESAS DE SERVIÇOS HOSPITALARES S/A - HOSPITAL SAMARITANO":
                    return "ESHO EMPRESAS DE SERVIÇOS HOSPITALARES S/A - HOSPITAL SAMARITANO, pessoa jurídica de direito privado inscrita no CNPJ/MF 29.435.005/0061-60, com sede a Rua Bambina nº 98, Bairro Botafogo - Rio de Janeiro – RJ - CEP 22251-050";
                case "SUL AMERICA COMPANHIA DE SEGURO SAUDE":
                    return "SUL AMERICA COMPANHIA DE SEGURO SAUDE, devidamente inscrita no CNPJ/MF sob o nº 01.685.053/0001-56, com sede situada na Rua Beatriz Larragoiti Lucas, nº 121, Cidade Nova, Estado do Rio de Janeiro, CEP nº 20.211-903";
                case "PRODENT ASSISTÊNCIA ODONTOLÓGICA LTDA":
                    return "PRODENT ASSISTÊNCIA ODONTOLÓGICA LTDA, devidamente inscrita no Ministério da Fazenda sob o CNPJ/MF de n.º 61.590.816/0001-07, com sede na Rua da Consolação, nº 1681, 2º andar, São Paulo – SP";
                case "SUL AMERICA ODONTOLOGICO S.A.":
                    return "SUL AMERICA ODONTOLOGICO S.A., devidamente inscrita no CNPJ/MF sob o nº 11.973.134/0001-05, com sede situada na Rua Dos Pinheiros, n.º 1673, 7º ANDAR, ALA SUL e 11º ANDAR; São Paulo - SP, CEP: 05422-012";
                case "CAIXA DE ASSISTÊNCIA DOS FUNCIONÁRIOS DO BANCO DO BRASIL - CASSI":
                    return "CAIXA DE ASSISTÊNCIA DOS FUNCIONÁRIOS DO BANCO DO BRASIL - CASSI, associação civil de direito privado e de assistência social sem fins lucrativos, inscrita no CNPJ/MF sob o nº. 33.719.485/0001-27, com sede no SGAS, 613, conjunto E, bloco A, Asa Sul, CEP: 70.200-903, em Brasília/DF";
            }
            return "";
        }

        public static Advogado GetAdvogadoByClient(string tipo)
        {
            switch (tipo)
            {
                case "AMIL ASSISTÊNCIA MÉDICA INTERNACIONAL S.A.":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" } ;
                case "AMICO SAÚDE LTDA.":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "SANTA HELENA ASSISTÊNCIA MÉDICA S.A":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "HOSPITAL ANA COSTA S.A.":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "PLANO DE SAÚDE ANA COSTA LTDA.":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "SEISA SERVIÇOS INTEGRADOS DE SAÚDE LTDA.":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "SOBAM CENTRO MÉDICO HOSPITALAR LTDA.":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "HOSPITAL SANTA HELENA S.A.":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "AMIL SAÚDE LTDA (MEDIAL SAÚDE)":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "HOSPITAL ALVORADA TAGUATINGA S/A":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "ESHO EMPRESAS DE SERVIÇOS HOSPITALARES S/A - HOSPITAL SAMARITANO":
                    return new Advogado() { Nome = @"RODOLPHO MARINHO DE SOUZA FIGUEIREDO", OAB = @"OAB/PE nº 31.036 | OAB/SP nº 414.983" };
                case "SUL AMERICA COMPANHIA DE SEGURO SAUDE":
                    return new Advogado() { Nome = "ANTONIO EDUARDO GONÇALVES DE RUEDA", OAB = "OAB/PE 16.983" };
                case "PRODENT ASSISTÊNCIA ODONTOLÓGICA LTDA":
                    return new Advogado() { Nome = "ANTONIO EDUARDO GONÇALVES DE RUEDA", OAB = "OAB/PE 16.983" };
                case "SUL AMERICA ODONTOLOGICO S.A.":
                    return new Advogado() { Nome = "ANTONIO EDUARDO GONÇALVES DE RUEDA", OAB = "OAB/PE 16.983" };
                case "CAIXA DE ASSISTÊNCIA DOS FUNCIONÁRIOS DO BANCO DO BRASIL - CASSI":
                    return new Advogado() { Nome = "MARIA EMÍLIA GONÇALVES DE RUEDA", OAB = "OAB/PE nº 23.748" };
            }
            return new Advogado() { Nome = "ANTONIO EDUARDO GONÇALVES DE RUEDA", OAB = "OAB/PE 16.983" }; 
        }

        public static string GetTypeString(string tipo) 
        {
            switch (tipo)
            {
                case "RESULTADO":
                    return "RESULTADO";
                case "PAGAMENTO CONDENACAO":
                    return "PAGAMENTO_CONDENACAO";
                case "ESPECIFICAO SEM PROVAS":
                    return "ESPECIFICAO_SEM_PROVAS";
                case "JUNTADA CUSTAS FINAIS":
                    return "JUNTADA_CUSTAS_FINAIS";
                case "JUNTADA CARTAS SUBS":
                    return "JUNTADA_CARTAS_SUBS";
                case "PROVA PERICIA MEDICA":
                    return "PROVA_PERICIA_MEDICA";
                case "PETICAO 1018":
                    return "PETICAO_1018";
                case "JUNTADA HONORARIOS":
                    return "JUNTADA_HONORARIOS";
                case "EMBARGOS DECLARACAO":
                    return "EMBARGOS DECLARACAO";
            }
            return "";
        }

        public static string GetUF(string estado)
        {
            switch (estado)
            {
                case "PERNAMBUCO":
                    return "PE";
                case "ALAGOAS":
                    return "AL";
                case "SERGIPE":
                    return "SE";
                case "PIAUI":
                    return "PI";
                case "PARA":
                    return "PA";
                case "AMAZONAS":
                    return "AM";
                case "ACRE":
                    return "AC";
                case "MATO GROSSO":
                    return "MT";
                case "MATO GROSSO DO SUL":
                    return "MS";
                case "RIO GRANDE DO SUL":
                    return "RS";
                case "RIO GRANDE DO NORTE":
                    return "RN";
                case "PARAIBA":
                    return "PB";
                case "SANTA CATARINA":
                    return "SC";
                case "PARANA":
                    return "PR";
                case "SAO PAULO":
                    return "SP";
                case "RIO DE JANEIRO":
                    return "RJ";
                case "ESPIRITO SANTO":
                    return "ES";
                case "MINAS GERAIS":
                    return "MG";
                case "BAHIA":
                    return "BA";
                case "GOIAS":
                    return "GO";
                case "DISTRITO FEDERAL":
                    return "DF";
                case "CEARA":
                    return "CE";
                case "MARANHAO":
                    return "MA";
                case "RORAIMA":
                    return "RR";
                case "RONDONIA":
                    return "RO";
                case "TOCANTINS":
                    return "TO";
                case "AMAPA":
                    return "AP";
            }
            return "";
        }
    }
}
