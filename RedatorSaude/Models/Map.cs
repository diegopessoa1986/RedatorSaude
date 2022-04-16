
namespace RedatorSaude.Models
{
    public class Map
    {
        public static string rootFilepath = "wwwroot/templates/";
        

        //Documentos
        //0 RESULTADO
        public static string document_resutaldo = rootFilepath +  "Dest.docx";
        //1-PAGAMENTO CONDENACAO
        public static string document_pagamento_condenacao = rootFilepath +  "pagamento_condenacao.docx";
        //2-ESPECIFICAO SEM PROVAS
        public static string document_especificao_sem_provas = rootFilepath + "especificacao_sem_provas.docx";
        //3-JUNTADA CUSTAS FINAIS
        public static string document_juntada_custas_finais = rootFilepath + "juntada_custas_finais.docx";
        //4-JUNTADA CARTAS SUBS
        public static string document_juntada_cartas_subs = rootFilepath + "juntada_cartas_subs.docx";
        //5-PROVA PERICIA MEDICA
        public static string document_especificacao_provas_pericia_medica = rootFilepath + "especificao_prova_pericia_medica.docx";

    }
}
