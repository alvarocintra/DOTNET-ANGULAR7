﻿using System;
using consoleTeste.Interface;

namespace consoleTeste.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return $"Teste Chuta";
        }

        public string Corre()
        {
            return $"Teste Corre";
        }

        public string Passe()
        {
            return $"Teste Passe";
        }
    }
}
