using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dtos.Character
{
    public class AddCharacterDto
    {
        public string Nome { get; set; } = "Anonimo";
        public int PontosDeVida { get; set; } = 100;
        public int Defesa { get; set; } = 10;
        public int Forca { get; set; } = 10;
        public int Inteligencia { get; set; } = 10;

        public RPGClass Class { get; set; } = RPGClass.Knight;
    }
}