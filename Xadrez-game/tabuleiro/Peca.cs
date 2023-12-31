﻿using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();
        
        public bool ExixteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i=0; i<Tab.Linhas; i++)
            {
                for(int j=0; j<Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public void IncrementarQuantidadeDeMovimento()
        {
            QteMovimentos++;
        }
        public void DecrementarQuantidadeDeMovimento()
        {
            QteMovimentos--;
        }
    }
}
