/*
 * Copyright (c) 2012 Adriano Quilião de Oliveira e Douglas Almeida.
 * Este programa é licenciado pelos termos da Licença Pública Geral Menor GNU
 * em sua versão 3 e esta disponivel www.gnu.org/copyleft/lesser.txt
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testeCardsLibrary
{
    class Program
    {

        static void Main(string[] args)
        {
            CardsLibrary.Deck baralho = new CardsLibrary.Deck();
            //baralho.shuffle(200);
            //baralho.cut(26);
            //baralho.getFistCard();
            //baralho.getLastCard();
            //baralho.moveFirstForTheLastPosition();
            //baralho.moveLastForTheFirstPosition();
            //baralho.discard(baralho.getFistCard());
            Console.WriteLine("-------------<BARALHO>---------------");
            foreach (CardsLibrary.Card card in baralho)
                Console.WriteLine("Naipe -> " + card.naipe + "  Carta -> " + card.index.ToString());
            Console.ReadLine();
        }

    }
}
