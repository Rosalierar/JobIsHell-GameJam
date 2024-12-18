using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressaoHistoria : MonoBehaviour
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

    private void Start()
    {
        

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

                                Sprite[] sprites = { Ran, Hanna, Akira, maya};
                                string[] stringsTextos = { "Espero que sim, mesmo�", "Pelo menos o atraso deve ter valido a pena para voc�, queridinho(a) da mam�e e do Papai.", "� uma sensa��o muito boa, n�o �? Desobedecer, amo (ele d� um riso).", "Podemos, por favor, ir?! �s horas est�o passando, n�o podemos perder muito tempo aqui." };
                                string[] stringsNomes = { "Ran", "Hanna", "Akira", "Maya"};
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
