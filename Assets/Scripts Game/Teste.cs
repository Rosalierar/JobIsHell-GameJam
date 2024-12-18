using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    private int perguntas = 1;
    
    private TabeladeAfinidades tabelaAfinidades;
    private ControleDialogos controleDialogos;
    private AtivarDesativarTexto ativarDesativarTexto;
    [SerializeField]
    private GameObject objetoDosTextos;

    public Sprite maya;
    public Sprite Ran;
    public Sprite Hanna;
    public Sprite Akira;
    public Sprite Fenwick;
    public Sprite Macula;
    public Sprite Cooper;
    public Sprite Disha;
    public Sprite Chefe;

    private string nomeDoPersonagemPrincipal;

    private void Start()
    {
        nomeDoPersonagemPrincipal = PlayerPrefs.GetString("nomeDoJogador");

        tabelaAfinidades = FindObjectOfType<TabeladeAfinidades>();
        controleDialogos = FindObjectOfType<ControleDialogos>();
        ativarDesativarTexto = objetoDosTextos.GetComponent<AtivarDesativarTexto>();

        Debug.Log($"Ran sprite: {Ran}");
    }
    public void CliqueOpcao1()
    {
        Resposta(perguntas, 1);
        perguntas++;
    }
    public void CliqueOpcao2()
    {
        Resposta(perguntas, 2);
        perguntas++;
    }
    public void CliqueOpcao3()
    {
        Resposta(perguntas, 3);
        perguntas++;
    }
    public void CliqueOpcao4()
    {
        Resposta(perguntas, 4);
        perguntas++;
    }
    public void CliqueOpcao5()
    {
        Resposta(perguntas, 5);
        perguntas++;
    }

    private void Resposta(int pergunta, int opcaoEscolhida)
    {
        switch (pergunta)
        {
            case 1:
                {
                    switch (opcaoEscolhida)
                    {
                        case 4: //Verdade
                            {
                                ativarDesativarTexto.AtivarAnima��o1(-5, "Maya");
                                ativarDesativarTexto.AtivarAnima��o2(-5, "Hanna");
                                ativarDesativarTexto.AtivarAnima��o3(10, "Ren");

                                tabelaAfinidades.AtualizarAfinidadeMaya(-5);
                                tabelaAfinidades.AtualizarAfinidadeHanna(-5);
                                tabelaAfinidades.AtualizarAfinidadeRan(10);

                                controleDialogos.PularTexto();
                                controleDialogos.BotaoDePular.SetActive(true);

                                Sprite[] sprites = { Ran, Hanna, Akira, maya };
                                string[] stringsTextos = { "Surpresa seria se eles dormissem antes de voc�.",
                                    "Fala s�rio, seria melhor se voc� mentisse(revira os olhos), como que voc� consegue dormir, em um dia t�o crucial?! Voc� era para sair 2 horas atr�s, sabia? Est� atrasado.",
                                    $"{nomeDoPersonagemPrincipal} incr�vel que logo voc� acordou com a nossa liga��o, voc� dorme que nem uma pedra.",
                                    "Gente, podemos deixar essa discuss�o � caminho do local? N�o podemos perder mais tempo." };
                                string[] stringsNomes = { "Ran", "Hanna", "Akira", "Maya" };
                                int sequencia = stringsTextos.Length;

                                controleDialogos.PosPerguntas(sprites, stringsTextos, stringsNomes, sequencia, true);

                                break;
                            }
                        case 5: //Mentir
                            {
                                ativarDesativarTexto.AtivarAnima��o1(5, "Maya");
                                ativarDesativarTexto.AtivarAnima��o2(5, "Hanna");
                                ativarDesativarTexto.AtivarAnima��o3(-10, "Ren");

                                tabelaAfinidades.AtualizarAfinidadeMaya(5);
                                tabelaAfinidades.AtualizarAfinidadeHanna(5);
                                tabelaAfinidades.AtualizarAfinidadeRan(-10);

                                controleDialogos.PularTexto();
                                controleDialogos.BotaoDePular.SetActive(true);

                                Sprite[] sprites = { Ran, Hanna, Akira, maya };
                                string[] stringsTextos = { "Espero que sim, mesmo�", 
                                    "Pelo menos o atraso deve ter valido a pena para voc�, queridinho(a) da mam�e e do Papai.", 
                                    "� uma sensa��o muito boa, n�o �? Desobedecer, amo (ele d� um riso).", 
                                    "Podemos, por favor, ir?! �s horas est�o passando, n�o podemos perder muito tempo aqui." };
                                string[] stringsNomes = { "Ran", "Hanna", "Akira", "Maya" };
                                int sequencia = stringsTextos.Length;

                                controleDialogos.PosPerguntas(sprites, stringsTextos, stringsNomes, sequencia, true);
                                break;
                            }
                    }

                    break;
                }
            case 2:
                {
                    switch (opcaoEscolhida)
                    {
                        case 4:
                            {
                                tabelaAfinidades.AtualizarAfinidadeMaya(5);
                                tabelaAfinidades.AtualizarAfinidadeRan(5);
                                break;
                            }
                    }

                    break;
                }
        }

        controleDialogos.DuasOpcoes.SetActive(false);
    }
}
